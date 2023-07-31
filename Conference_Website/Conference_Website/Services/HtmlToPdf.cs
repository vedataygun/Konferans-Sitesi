using iText.Html2pdf;
using System.IO;

namespace Conference_Website.Services
{
    public class HtmlToPdf
    {
        public bool ConvertPDF(string baseURI, string html, string destination)
        {
            try
            {
                ConverterProperties prop = new ConverterProperties();
                using(var stream = new FileStream(destination, FileMode.Create))
                {
                    HtmlConverter.ConvertToPdf(html, stream, prop);
                }
               
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
