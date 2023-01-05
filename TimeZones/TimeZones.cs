using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console1
{
    public class TimeZones
    {

        public static string ConvertDateAndTime(DateTime dateTime, string timeZoneSource, string timeZoneDestination)
        {

            try
            {

                TimeZoneInfo dateTimeZoneSource = TimeZoneInfo.FindSystemTimeZoneById(timeZoneSource);

                TimeZoneInfo dateTimeZoneDestination = TimeZoneInfo.FindSystemTimeZoneById(timeZoneDestination);

                var timeUtc = TimeZoneInfo.ConvertTimeToUtc(dateTime, dateTimeZoneSource);

                //convertimos al tipo date time que necesitamos
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, dateTimeZoneDestination);

                if (dateTimeZoneDestination.IsDaylightSavingTime(cstTime))
                {
                    return cstTime.ToString() + " " + dateTimeZoneDestination.DaylightName;
                }
                else
                {
                    return cstTime.ToString() + " " + dateTimeZoneDestination.StandardName;
                }
            }
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("Unable to find the {0} or {1} zone in the registry.",
                                  timeZoneSource,timeZoneDestination);
            }
            catch (InvalidTimeZoneException)
            {
                Console.WriteLine("Registry data on the {0} or {1} zone has been corrupted.",
                                  timeZoneSource, timeZoneDestination);
            }

            return "";
        }

        public static string DifferenceBetweenTimeZone(string timeZoneSource, string timeZoneDestination)
        {
            TimeZoneInfo dateTimeZoneSource = TimeZoneInfo.FindSystemTimeZoneById(timeZoneSource);

            TimeZoneInfo dateTimeZoneDestination = TimeZoneInfo.FindSystemTimeZoneById(timeZoneDestination);

            var diference = dateTimeZoneSource.BaseUtcOffset - dateTimeZoneDestination.BaseUtcOffset;

            return diference.ToString();
        }

        public  static string DateTimeformat(DateTime dateTime)
        {
            string convertedDate = dateTime.ToString("yyyyMMddHHmmss");

            return convertedDate;
        }
    }
}
