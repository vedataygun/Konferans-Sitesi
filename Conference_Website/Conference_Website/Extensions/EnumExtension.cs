using Conference_Website.Models;
using System.ComponentModel;

namespace Conference_Website.Extensions
{
    public static class EnumExtension
    {
        public static string ToDescriptionString(this AlertType value){
            DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().
                GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
