using Microsoft.CodeAnalysis;
using System.IO;

namespace Conference_Website.Models
{
    public class ValidateExtension
    {

       public string ValidateImage(string fileName)
        {
            var extensionList = new string[] { ".jpg", ".png" , ".JPEG"};

            var extension = Path.GetExtension(fileName);

            foreach ( var extent in extensionList)
            {
                if (extension.ToLower() == extent.ToLower())
                    return extent;
            }



            return null;
        }
    }

    
}
