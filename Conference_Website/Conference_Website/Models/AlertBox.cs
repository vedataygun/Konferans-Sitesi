using Conference_Website.Extensions;
using System.ComponentModel;

namespace Conference_Website.Models
{
    public class AlertBox
    {
        public AlertBox(AlertType alertType = AlertType.Success )
        {
            Type = alertType;
            TypeString = alertType.ToDescriptionString();
        }
        public string Header{ get; set; }
        public string Message { get; set; }
        public AlertType Type {
            get; set;
         }

        public string TypeString { get; set; }
    }

    public enum AlertType{

        [Description("Info")]
        Info,

        [Description("Warning")]
        Warning,

        [Description("Danger")]
        Danger,

        [Description("Success")]
        Success,

    }
}
