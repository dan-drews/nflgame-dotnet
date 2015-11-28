using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NflGame.Lib.Schedule
{
    public class Schedule
    {
        
        public long GameId { get; set; }

        public string Away { get; set; }

        public int Day { get; set; }
        
        public long GameKey { get; set; }
        public string Home { get; set; }
        public int Month { get; set; }
        public string Season_Type { get; set; }
        public string Time { get; set; }
        public string WDay { get; set; }
        public int week { get; set; }
        public int year { get; set; }
    }
}
