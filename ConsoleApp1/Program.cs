// See https://aka.ms/new-console-template for more information
using Console1;

/*DateTime dateNow = DateTime.Now;
Console.WriteLine("The date and time are {0} UTC.",
                   TimeZoneInfo.ConvertTimeToUtc(dateNow));

var horaU = TimeZoneInfo.ConvertTimeToUtc(dateNow);

var resultado = horaU - dateNow;

Console.WriteLine("resultado {0}", resultado);


DateTime easternTime = new DateTime(2007, 01, 02, 12, 16, 00);
string easternZoneId = "Morocco Standard Time";
try
{
    TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(easternZoneId);
    Console.WriteLine("The date and time are {0} UTC.",
                      TimeZoneInfo.ConvertTimeToUtc(easternTime, easternZone));
}
catch (TimeZoneNotFoundException)
{
    Console.WriteLine("Unable to find the {0} zone in the registry.",
                      easternZoneId);
}
catch (InvalidTimeZoneException)
{
    Console.WriteLine("Registry data on the {0} zone has been corrupted.",
                      easternZoneId);
}

DateTime unclearDate = new DateTime(2007, 11, 4, 1, 30, 0);
// Test if time is ambiguous.
Console.WriteLine("In the {0}, {1} is {2}ambiguous.",
                  TimeZoneInfo.Local.DisplayName,
                  unclearDate,
                  TimeZoneInfo.Local.IsAmbiguousTime(unclearDate) ? "" : "not ");
// Test if time is DST.
Console.WriteLine("In the {0}, {1} is {2}daylight saving time.",
                  TimeZoneInfo.Local.DisplayName,
                  unclearDate,
                  TimeZoneInfo.Local.IsDaylightSavingTime(unclearDate) ? "" : "not ");
Console.WriteLine();
// Report time as DST if it is either ambiguous or DST.
if (TimeZoneInfo.Local.IsAmbiguousTime(unclearDate) ||
    TimeZoneInfo.Local.IsDaylightSavingTime(unclearDate))
    Console.WriteLine("{0} may be daylight saving time in {1}.",
                      unclearDate, TimeZoneInfo.Local.DisplayName);

Console.WriteLine(TimeZoneInfo.GetSystemTimeZones().ToList());*/




var timezone = new TimeZones();

Console.WriteLine(timezone.ConvertDateAndTime(new DateTime(2023, 01, 04, 22, 56, 00), "Argentina Standard Time", "America/Asuncion"));


timezone.DifferenceBetweenTimeZone("Argentina Standard Time", "America/Asuncion");

Console.WriteLine(timezone.DateTimeformat(new DateTime(2023, 01, 04, 22, 56, 00)));
