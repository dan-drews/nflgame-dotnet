using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NflGame.Lib.Schedule;

namespace NflGame.Tests.Schedule_Tests
{
    [TestClass]
    public class ScheduleUpdaterTests
    {
        [TestMethod]
        public void YPWGenerator_All_Test()
        {
            ScheduleUpdater upd = new ScheduleUpdater();
            var list = upd.BuildWeekList();

            String url = upd.GetScheduleUrl(new ScheduleUpdater.YPW() { Year = 2015, Week = 11, Phase = "REG" });
            var xml = upd.getHtml(url);
            upd.Run();
        }
    }
}
