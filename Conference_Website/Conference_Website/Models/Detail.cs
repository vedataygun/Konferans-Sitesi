using System;
using System.Collections.Generic;

namespace Conference_Website.Models
{
    public  class Detail
    {
        public static string ConferenceName = "Teknoloji Yenilik Konferansı";

        public static DateTime StartDate = new DateTime(2023, 8, 15, 14, 25, 54);

        public static string Location = "Moymul, Balıkesir Kütahya Yolu No:82 TMYO Yerleşkesi, 43300 Tavşanlı/ Kütahya";

        public static List<Speaker> Speakers = null;

        public static String Latitude = "39.572632";
        public static String Longitude = "29.443159";

        public static String City = "Kütahya";

        public static List<String> ImageList = new List<String>()
        {
            "konferans1.jpg",
            "konferans2.jpg",
            "konferans3.jpg",
        };

        public static List<Agenda> Agenda = null;


    }
}
