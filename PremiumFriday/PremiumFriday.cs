using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedMember.Global

[assembly: InternalsVisibleTo("PremiumFriday.Tests")]

namespace PremiumFriday
{
    [Cmdlet(VerbsDiagnostic.Test, "PremiumFriday")]
    [OutputType(typeof(bool))]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class TestPremiumFriday : Cmdlet
    {
        [ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            HelpMessage = "Date to test to see if the date is a Premium Friday.")]
        public DateTime Date { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(PremiumFridayUtils.CheckPremiumFriday(Date));
        }
    }

    internal static class PremiumFridayUtils
    {
        public static bool CheckPremiumFriday(DateTime date)
        {
            var firstPremiumFriday = new DateTime(2017,2,24);
            
            if (date < firstPremiumFriday)
            {
                return false;
            }
                        
            if (date.DayOfWeek != DayOfWeek.Friday) return false;

            var currentMonth = date.Month;
            var nextFriday = date.AddDays(7);
            return nextFriday.Month != currentMonth;
        }
    }

    [Cmdlet(VerbsCommon.Get, "NextPremiumFriday")]
    [OutputType(typeof(DateTime))]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class GetNextPremiumFriday : Cmdlet
    {
        [ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, HelpMessage = "Date to start checking.")]
        public DateTime Date { get; set; }

        protected override void ProcessRecord()
        {
            var testDate = Date;

            while (!PremiumFridayUtils.CheckPremiumFriday(testDate))
                if (testDate.Year < 2017)
                    testDate = new DateTime(2017, 2, 24);
                else if (testDate.DayOfWeek != DayOfWeek.Friday) testDate = testDate.AddDays(1);
                else testDate = testDate.AddDays(7);

            WriteObject(testDate);
        }
    }
}