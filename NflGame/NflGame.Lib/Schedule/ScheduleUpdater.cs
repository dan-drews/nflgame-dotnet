using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NflGame.Lib.Helpers;
using Newtonsoft.Json;

namespace NflGame.Lib.Schedule
{
    public class ScheduleUpdater
    {

        String filePath = "schedule.json";

        public class YPW
        {
            public int Year { get; set; }
            public string Phase { get; set; }
            public int Week { get; set; }
        }
        
       public IEnumerable<YPW> BuildWeekList(int year = 0, string phase = "", int week = -1)
        {
            var season_types = new List<Tuple<string, IEnumerable<int>>>();
            var result = new List<YPW>();
            season_types.Add(Tuple.Create("PRE", Enumerable.Range(0, 4)));
            season_types.Add(Tuple.Create("REG", Enumerable.Range(1, 17)));
            season_types.Add(Tuple.Create("POST", Enumerable.Range(1, 5)));
            for (int y = 2009; y <= DateTime.Now.Year; y++)
            {
                if (year == 0 || y == year)
                {
                    foreach (var s in season_types)
                    {
                        if(phase == "" || phase == s.Item1)
                        {
                            foreach (int w in s.Item2)
                            {
                                if(week == -1 || week == w)
                                {
                                    result.Add(new YPW() { Year = y, Phase = s.Item1, Week = w });
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public IEnumerable<Schedule> GetScheduleList(int year = 0)
        {
            var result = new List<Schedule>();
            foreach (YPW ypw in BuildWeekList(year))
            {
                var url = GetScheduleUrl(ypw);
                var xml = getHtml(url);
                ScheduleXML.ss ss = xml.ParseXML<ScheduleXML.ss>();

                if (ss?.gms?.g != null) {
                    foreach (var g in ss?.gms?.g)
                    {
                        Schedule s = GetScheduleFromXml(ypw, g);
                        result.Add(s);
                    }
                }
            }
            return result;
        }

        private static Schedule GetScheduleFromXml(YPW ypw, ScheduleXML.ssGmsG g)
        {
            Schedule s = new Schedule();
            s.Away = g.v;
            s.year = ypw.Year;
            s.WDay = g.d;
            s.GameId = g.eid;
            s.Month = int.Parse(g.eid.ToString().Substring(4, 2));
            s.Day = int.Parse(g.eid.ToString().Substring(6, 2));
            s.Time = g.t;
            s.Season_Type = ypw.Phase;
            s.week = ypw.Week;
            s.Home = g.h;
            s.GameKey = g.gsis;
            return s;
        }

        public string GetScheduleUrl(YPW ypw)
        {
            if(ypw.Phase == "POST")
            {
                ypw.Week += 17;
                if (ypw.Week == 21)
                {
                    ypw.Week += 1;
                }
            }
            return $"http://www.nfl.com/ajax/scorestrip?season={ypw.Year}&seasonType={ypw.Phase}&week={ypw.Week}";
        }

        public string getHtml(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myWebRequest.Method = "GET";
            HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            StreamReader myWebSource = new StreamReader(myWebResponse.GetResponseStream());
            string myPageSource = string.Empty;
            myPageSource = myWebSource.ReadToEnd();
            myWebResponse.Close();
            return myPageSource;
        }

        public void Run(int year = 0)
        {
            if (!File.Exists(filePath))
            {
                var fs = File.Create(filePath);
                fs.Dispose();
            }
            FileAttributes fa = File.GetAttributes(filePath);
            if((fa & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            {
                // File can be written
                var sched = GetScheduleList(year);
                string json = JsonConvert.SerializeObject(sched);
                File.WriteAllText(filePath, json);
            }
        }

    }
}
