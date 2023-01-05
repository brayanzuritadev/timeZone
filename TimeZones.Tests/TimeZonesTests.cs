namespace Console1;

[TestClass]
public class TimeZonesTests
{
    [TestMethod]
    public void ConvertDateTime()
    {
        //preparacion
        var timeZones = new TimeZones();
        //ejecucion
        var result = TimeZones.ConvertDateAndTime(new DateTime(2023, 01, 04, 22, 56, 00), "Argentina Standard Time", "America/Asuncion");
        //verificacion
        Assert.AreEqual("1/4/2023 10:56:00 PM Hora de verano de Paraguay",result);
    }

    [TestMethod]
    public void DifferenceBetweenTimeZone()
    {
        var timeZones = new TimeZones();
        //ejecucion
        var result = TimeZones.DifferenceBetweenTimeZone("Argentina Standard Time", "America/Asuncion");
        //verificacion
        Assert.AreEqual("01:00:00", result);
    }

    [TestMethod]
    public void DateTimeformat()
    {
        var timeZones = new TimeZones();
        //ejecucion
        var result = TimeZones.DateTimeformat(new DateTime(2023, 01, 04, 22, 56, 00));
        //verificacion
        Assert.AreEqual("20230104225600", result);
    }
}