using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZone
{
  class Program
  {
    static void Main(string[] args)
    {

      // Create a string array with the lines of text
      ArrayList lineas = new ArrayList();

      // Creando lita de objetos time zone.
      List<TimeZone> timezones = new List<TimeZone> {
        new TimeZone("Morocco Standard Time", "(GMT) Casablanca", 0 ),
        new TimeZone("GMT Standard Time", "(GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London", 0 ),
        new TimeZone("Greenwich Standard Time", "(GMT) Monrovia, Reykjavik", 0 ),
        new TimeZone("W. Europe Standard Time", "(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", 0 ),
        new TimeZone("Central Europe Standard Time", "(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", 0 ),
        new TimeZone("Romance Standard Time", "(GMT+01:00) Brussels, Copenhagen, Madrid, Paris", 0 ),
        new TimeZone("Central European Standard Time", "(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb", 0 ),
        new TimeZone("W. Central Africa Standard Time", "(GMT+01:00) West Central Africa", 0 ),
        new TimeZone("Jordan Standard Time", "(GMT+02:00) Amman", 0 ),
        new TimeZone("GTB Standard Time", "(GMT+02:00) Athens, Bucharest, Istanbul", 0 ),
        new TimeZone("Middle East Standard Time", "(GMT+02:00) Beirut", 0 ),
        new TimeZone("Egypt Standard Time", "(GMT+02:00) Cairo", 0 ),
        new TimeZone("South Africa Standard Time", "(GMT+02:00) Harare, Pretoria", 0 ),
        new TimeZone("FLE Standard Time", "(GMT+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius", 0 ),
        new TimeZone("Israel Standard Time", "(GMT+02:00) Jerusalem", 0 ),
        new TimeZone("E. Europe Standard Time", "(GMT+02:00) Minsk", 0 ),
        new TimeZone("Namibia Standard Time", "(GMT+02:00) Windhoek", 0 ),
        new TimeZone("Arabic Standard Time", "(GMT+03:00) Baghdad", 0 ),
        new TimeZone("Arab Standard Time", "(GMT+03:00) Kuwait, Riyadh", 0 ),
        new TimeZone("Russian Standard Time", "(GMT+03:00) Moscow, St. Petersburg, Volgograd", 0 ),
        new TimeZone("E. Africa Standard Time", "(GMT+03:00) Nairobi", 0 ),
        new TimeZone("Georgian Standard Time", "(GMT+03:00) Tbilisi", 0 ),
        new TimeZone("Iran Standard Time", "(GMT+03:30) Tehran", 0 ),
        new TimeZone("Arabian Standard Time", "(GMT+04:00) Abu Dhabi, Muscat", 0 ),
        new TimeZone("Azerbaijan Standard Time", "(GMT+04:00) Baku", 0 ),
        new TimeZone("Mauritius Standard Time", "(GMT+04:00) Port Louis", 0 ),
        new TimeZone("Caucasus Standard Time", "(GMT+04:00) Yerevan", 0 ),
        new TimeZone("Afghanistan Standard Time", "(GMT+04:30) Kabul", 0 ),
        new TimeZone("Ekaterinburg Standard Time", "(GMT+05:00) Ekaterinburg", 0 ),
        new TimeZone("Pakistan Standard Time", "(GMT+05:00) Islamabad, Karachi", 0 ),
        new TimeZone("West Asia Standard Time", "(GMT+05:00) Tashkent", 0 ),
        new TimeZone("India Standard Time", "(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi", 0 ),
        new TimeZone("Sri Lanka Standard Time", "(GMT+05:30) Sri Jayawardenepura", 0 ),
        new TimeZone("Nepal Standard Time", "(GMT+05:45) Kathmandu", 0 ),
        new TimeZone("N. Central Asia Standard Time", "(GMT+06:00) Almaty, Novosibirsk", 0 ),
        new TimeZone("Central Asia Standard Time", "(GMT+06:00) Astana, Dhaka", 0 ),
        new TimeZone("Myanmar Standard Time", "(GMT+06:30) Yangon (Rangoon)", 0 ),
        new TimeZone("SE Asia Standard Time", "(GMT+07:00) Bangkok, Hanoi, Jakarta", 0 ),
        new TimeZone("North Asia Standard Time", "(GMT+07:00) Krasnoyarsk", 0 ),
        new TimeZone("China Standard Time", "(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi", 0 ),
        new TimeZone("North Asia East Standard Time", "(GMT+08:00) Irkutsk, Ulaan Bataar", 0 ),
        new TimeZone("Singapore Standard Time", "(GMT+08:00) Kuala Lumpur, Singapore", 0 ),
        new TimeZone("W. Australia Standard Time", "(GMT+08:00) Perth", 0 ),
        new TimeZone("Taipei Standard Time", "(GMT+08:00) Taipei", 0 ),
        new TimeZone("Tokyo Standard Time", "(GMT+09:00) Osaka, Sapporo, Tokyo", 0 ),
        new TimeZone("Korea Standard Time", "(GMT+09:00) Seoul", 0 ),
        new TimeZone("Yakutsk Standard Time", "(GMT+09:00) Yakutsk", 0 ),
        new TimeZone("Cen. Australia Standard Time", "(GMT+09:30) Adelaide", 0 ),
        new TimeZone("AUS Central Standard Time", "(GMT+09:30) Darwin", 0 ),
        new TimeZone("E. Australia Standard Time", "(GMT+10:00) Brisbane", 0 ),
        new TimeZone("AUS Eastern Standard Time", "(GMT+10:00) Canberra, Melbourne, Sydney", 0 ),
        new TimeZone("West Pacific Standard Time", "(GMT+10:00) Guam, Port Moresby", 0 ),
        new TimeZone("Tasmania Standard Time", "(GMT+10:00) Hobart", 0 ),
        new TimeZone("Vladivostok Standard Time", "(GMT+10:00) Vladivostok", 0 ),
        new TimeZone("Central Pacific Standard Time", "(GMT+11:00) Magadan, Solomon Is., New Caledonia", 0 ),
        new TimeZone("New Zealand Standard Time", "(GMT+12:00) Auckland, Wellington", 0 ),
        new TimeZone("Fiji Standard Time", "(GMT+12:00) Fiji, Kamchatka, Marshall Is.", 0 ),
        new TimeZone("Tonga Standard Time", "(GMT+13:00) Nuku'alofa", 0 ),
        new TimeZone("Azores Standard Time", "(GMT-01:00) Azores", 0 ),
        new TimeZone("Cape Verde Standard Time", "(GMT-01:00) Cape Verde Is.", 0 ),
        new TimeZone("Mid-Atlantic Standard Time", "(GMT-02:00) Mid-Atlantic", 0 ),
        new TimeZone("E. South America Standard Time", "(GMT-03:00) Brasilia", 0 ),
        new TimeZone("Argentina Standard Time", "(GMT-03:00) Buenos Aires", 0 ),
        new TimeZone("SA Eastern Standard Time", "(GMT-03:00) Georgetown", 0 ),
        new TimeZone("Greenland Standard Time", "(GMT-03:00) Greenland", 0 ),
        new TimeZone("Montevideo Standard Time", "(GMT-03:00) Montevideo", 0 ),
        new TimeZone("Newfoundland Standard Time", "(GMT-03:30) Newfoundland", 0 ),
        new TimeZone("Atlantic Standard Time", "(GMT-04:00) Atlantic Time (Canada)", 0 ),
        new TimeZone("SA Western Standard Time", "(GMT-04:00) La Paz", 0 ),
        new TimeZone("Central Brazilian Standard Time", "(GMT-04:00) Manaus", 0 ),
        new TimeZone("Pacific SA Standard Time", "(GMT-04:00) Santiago", 0 ),
        new TimeZone("Venezuela Standard Time", "(GMT-04:30) Caracas", 0 ),
        new TimeZone("SA Pacific Standard Time", "(GMT-05:00) Bogota, Lima, Quito, Rio Branco", 0 ),
        new TimeZone("Eastern Standard Time", "(GMT-05:00) Eastern Time (US & Canada)", 0 ),
        new TimeZone("US Eastern Standard Time", "(GMT-05:00) Indiana (East)", 0 ),
        new TimeZone("Central America Standard Time", "(GMT-06:00) Central America", 0 ),
        new TimeZone("Central Standard Time", "(GMT-06:00) Central Time (US & Canada)", 0 ),
        new TimeZone("Central Standard Time (Mexico)", "(GMT-06:00) Guadalajara, Ciudad de México, Monterrey", 0 ),
        new TimeZone("Canada Central Standard Time", "(GMT-06:00) Saskatchewan", 0 ),
        new TimeZone("US Mountain Standard Time", "(GMT-07:00) Arizona", 0 ),
        new TimeZone("Mountain Standard Time (Mexico)", "(GMT-07:00) Chihuahua, La Paz, Mazatlan", 0 ),
        new TimeZone("Mountain Standard Time", "(GMT-07:00) Mountain Time (US & Canada)", 0 ),
        new TimeZone("Pacific Standard Time", "(GMT-08:00) Pacific Time (US & Canada)", 0 ),
        new TimeZone("Pacific Standard Time (Mexico)", "(GMT-08:00) Tijuana, Baja California", 0 ),
        new TimeZone("Alaskan Standard Time", "(GMT-09:00) Alaska", 0 ),
        new TimeZone("Hawaiian Standard Time", "(GMT-10:00) Hawaii", 0 ),
        new TimeZone("Samoa Standard Time", "(GMT-11:00) Midway Island, Samoa", 0 ),
        new TimeZone("Dateline Standard Time", "(GMT-12:00) International Date Line West", 0 )

    };
      foreach (TimeZone z in timezones)
      {
        Console.WriteLine(z._text + " : " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, z._value));
        lineas.Add((z._text + " : " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, z._value)).ToString());
      }

      // Obteniendo los time zone del sistema.
      foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
      {
        Console.WriteLine(z.StandardName + " : " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, z.Id));
        lineas.Add((z.DisplayName + " : " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, z.Id)).ToString());
      }
      
      // Set a variable to the My Documents path.
      string mydocpath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

      // Write the string array to a new file named "TimeZoneList.txt".
      using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\TimeZoneList.txt"))
      {
        foreach (string linea in lineas)
          outputFile.WriteLine(linea);
      }
    }
  }
}

