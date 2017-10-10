using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZonesDemoForCampaigns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commit

            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (TimeZoneInfo timeZoneInfo in timeZones)
                Console.WriteLine("Timezone : " + timeZoneInfo.DisplayName + "\nDifference : " + timeZoneInfo.BaseUtcOffset + "\n\n");


            Console.ReadKey();
        }
    }
}
