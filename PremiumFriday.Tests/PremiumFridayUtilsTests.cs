using System;
using Xunit;
using PremiumFriday;

namespace PremiumFriday
{
    public class PremiumFridayUtilsTests
    {
        [Theory]
        [InlineData("2017-02-17")]
        [InlineData("2016-12-30")]
        public void CheckPremiumFriday_BeforeFirstPremiumFriday_ReturnsFalse(string dateStr)
        {
            var date = DateTime.Parse(dateStr);
            Assert.False(PremiumFridayUtils.CheckPremiumFriday(date));
        }

        [Theory]
        [InlineData("2024-08-23")]
        [InlineData("2024-08-16")]
        [InlineData("2024-02-16")]
        public void CheckPremiumFriday_NotLastFriday_ReturnsFalse(string dateStr)
        {
            var date = DateTime.Parse(dateStr);
            Assert.False(PremiumFridayUtils.CheckPremiumFriday(date));
        }

        [Theory]
        [InlineData("2017-02-24")]
        [InlineData("2024-08-30")]
        [InlineData("2024-05-31")]
        [InlineData("2020-02-28")]
        public void CheckPremiumFriday_LastFriday_ReturnsTrue(string dateStr)
        {
            var date = DateTime.Parse(dateStr);
            Assert.True(PremiumFridayUtils.CheckPremiumFriday(date));
        }

        [Theory]
        [InlineData("2024-03-29")]
        [InlineData("2024-03-22")]
        public void CheckPremiumFriday_MonthWithFiveFridays(string dateStr)
        {
            var date = DateTime.Parse(dateStr);
            bool expected = date.Day == 29;
            Assert.Equal(expected, PremiumFridayUtils.CheckPremiumFriday(date));
        }

        [Theory]
        [InlineData("2021-12-31")]
        public void CheckPremiumFriday_LastDayFriday_ReturnsTrue(string dateStr)
        {
            var date = DateTime.Parse(dateStr);
            Assert.True(PremiumFridayUtils.CheckPremiumFriday(date));
        }
    }
}
