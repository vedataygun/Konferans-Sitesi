#pragma checksum "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61da33d1443f44cf3e61873ae6f4290f6ae757f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GeneralInformation), @"mvc.1.0.view", @"/Views/Admin/GeneralInformation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
using Conference_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61da33d1443f44cf3e61873ae6f4290f6ae757f6", @"/Views/Admin/GeneralInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156e577ba099e7aa4c85abd1525c8d45f2e0c5c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GeneralInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/generalInformation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/slider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/slider.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/generalInformation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
  
    ViewData["Title"] = "Admin Genel Ayarlar Sayfası";
    ViewBag.Navigation = "Genel Ayarlar";
    Layout = "_Admin-Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61da33d1443f44cf3e61873ae6f4290f6ae757f65694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61da33d1443f44cf3e61873ae6f4290f6ae757f66872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<section class=\"sec-1\">\r\n    <h5>Detay</h5>\r\n    <form action=\"/admin/Update_Detail\" id=\"Detail\" method=\"post\" >\r\n        <div class=\"col-1\">\r\n            <input type=\"text\" name=\"ConferenceName\"");
            BeginWriteAttribute("value", " value=\"", 522, "\"", 552, 1);
#nullable restore
#line 19 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 530, Detail.ConferenceName, 530, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Konferans Adı\" />\r\n            <input type=\"datetime-local\" name=\"StartDate\"");
            BeginWriteAttribute("value", " value=\"", 643, "\"", 697, 1);
#nullable restore
#line 20 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 651, Detail.StartDate.ToString("yyyy-MM-ddThh:mm"), 651, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""DD/MM/YY HH:MM:SS"" />
            <button type=""submit"">
                Güncelle
                <i class=""fa-solid fa-arrow-right""></i>
            </button>
        </div>
    </form>

</section>


<section class=""sec-2"">
    <h5>Mekan Fotoğrafları</h5>
    <div");
            BeginWriteAttribute("class", " class=\"", 990, "\"", 1050, 2);
            WriteAttributeValue("", 998, "col-1", 998, 5, true);
#nullable restore
#line 33 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue(" ", 1003, Detail.ImageList.Count>4?"":"direction-row", 1004, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    \r\n        <div class=\"slider\">\r\n");
#nullable restore
#line 36 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
             if(Detail.ImageList.Count>0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                 for(int i=0; i<Detail.ImageList.Count; i++)
                {
                    string ImageName = @Detail.ImageList[i];
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\"", 1315, "\"", 1322, 1);
#nullable restore
#line 41 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 1320, i, 1320, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "  class=\"", 1323, "\"", 1370, 2);
            WriteAttributeValue("", 1332, "image-container", 1332, 15, true);
#nullable restore
#line 41 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("  ", 1347, i==0?"featured":"", 1349, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 1419, "\"", 1434, 1);
#nullable restore
#line 42 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 1424, ImageName, 1424, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa-regular fa-trash-can\"></i>\r\n                        </button>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61da33d1443f44cf3e61873ae6f4290f6ae757f612213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1576, "~/img/", 1576, 6, true);
#nullable restore
#line 45 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
AddHtmlAttributeValue("", 1582, ImageName, 1582, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
 
    <div class=""input-group "">
        <form id=""addImageForm"" enctype=""multipart/form-data"" action=""/admin/Add_Image"" method=""post"">
                <input type=""file"" name=""Image"" id=""file_image"" />
                <button type=""button"" id=""select-image"">
                    Fotoğraf Seç
                </button>
               
            </form>
        </div>
    </div>

</section>

<section class=""sec-3"">
   
    <div class=""col-1"">
        <h5>Konuşmacılar</h5>
        <button id=""addSpeaker"">
            <i class=""fa-solid fa-plus""></i>
            <span>Ekle</span>
        </button>
    </div>
    <div class=""col-2"" id=""speakerListDiv"">
");
#nullable restore
#line 75 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
         if (@Detail.Speakers.Count > 0)
        {
            foreach (var item in Detail.Speakers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"speaker-items\">\r\n                    <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61da33d1443f44cf3e61873ae6f4290f6ae757f615522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2607, "~/img/", 2607, 6, true);
#nullable restore
#line 81 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
AddHtmlAttributeValue("", 2613, item.Image, 2613, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span>");
#nullable restore
#line 82 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                         Write(item.NameAndSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <button  class=\"speaker-delete-btn\"");
            BeginWriteAttribute("id", "  id=\"", 2803, "\"", 2817, 1);
#nullable restore
#line 85 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 2809, item.Id, 2809, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                              <i class=\"fa-regular fa-trash-can\"></i>\r\n                         </button>\r\n                        <button class=\"speaker-edit-btn\"");
            BeginWriteAttribute("id", " id=\"", 2984, "\"", 2997, 1);
#nullable restore
#line 88 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 2989, item.Id, 2989, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">\r\n                            <i class=\"fa-regular fa-pen-to-square\"></i>\r\n                         </button>\r\n                     </div>\r\n                </div>\n");
#nullable restore
#line 93 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
            }
           
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n<section class=\"sec-4\">\r\n    <h5>Mekan Fotoğrafları</h5>\r\n    <div class=\"row-1\">\r\n            <div class=\"col-1\" id=\"agendaList\">\r\n");
#nullable restore
#line 103 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                 if (Detail.Agenda.Count > 0)
                {
                    var agendaList = Detail.Agenda.OrderBy(x => x.StartTime).ToList();

                    for (int i = 0; i < Detail.Agenda.Count; i++)
                    {
                        var item = agendaList[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 3701, "\"", 3732, 2);
            WriteAttributeValue("", 3709, "item", 3709, 4, true);
#nullable restore
#line 110 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue(" ", 3713, i==0?"first":"", 3714, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span>");
#nullable restore
#line 111 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                             Write(item.StartTime);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                                             Write(!string.IsNullOrEmpty(item.EndTime) && item.EndTime != item.StartTime ? $" - {@item.EndTime}" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <button");
            BeginWriteAttribute("id", " id=\"", 3926, "\"", 3939, 1);
#nullable restore
#line 112 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 3931, item.Id, 3931, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"buttonAgendaRemove\"><i  class=\"fa-solid fa-trash\"></i></button>\r\n                            <span>");
#nullable restore
#line 113 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n");
#nullable restore
#line 115 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <form id=""agendaAddForm"">
        <div class=""col-2"">
            <div class=""input-group"">
            <input type=""text"" name=""StartTime"" class=""agendaInput"" placeholder=""Başlangıç Saati"" />
                <input type=""text"" name=""EndTime"" class=""agendaInput"" placeholder=""Bitiş Saati"" />
            </div>
            <div class=""input-group"">
            <input type=""text"" name=""Description"" placeholder=""Açıklama"" />
            <button");
            BeginWriteAttribute("id", " id=\"", 4633, "\"", 4638, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\">\r\n                Ekle\r\n                <i class=\"fa-solid fa-plus\"></i>\r\n            </button>\r\n        </div>\r\n        </div>\r\n        </form>\r\n\r\n    </div>\r\n</section>\r\n\r\n<!-----       Speaker List Edit & Add Form       ----->\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<!-----      Finish       ----->\r\n\r\n\r\n\r\n<section class=\"sec-5\">\r\n    <h5>Adres</h5>\r\n    <div class=\"col-1\">\r\n        <div id=\"map\">\r\n        </div>\r\n\r\n        <form id=\"mapForm\">\r\n            <input type=\"hidden\" id=\"lat\"");
            BeginWriteAttribute("value", " value=\"", 6105, "\"", 6129, 1);
#nullable restore
#line 180 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 6113, Detail.Latitude, 6113, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" id=\"long\"");
            BeginWriteAttribute("value", " value=\"", 6176, "\"", 6201, 1);
#nullable restore
#line 181 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
WriteAttributeValue("", 6184, Detail.Longitude, 6184, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"textarea\" >\r\n                <div class=\"textarea-text\" data-placeholder=\"Address detay\" id=\"txtarea-adressDetail\" contentEditable=\"plaintext-only\">");
#nullable restore
#line 183 "C:\Users\casper\Desktop\Konferans sitesi\Conference_Website\Conference_Website\Views\Admin\GeneralInformation.cshtml"
                                                                                                                                  Write(Detail.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
            <div class=""searchAddress"">
            <input type=""text"" placeholder=""Adres ara"" id=""searchAddress"" name=""Location"" />
            <select id=""adressList"">
              
            </select>
            <button type=""submit"">
                Güncelle
                <i class=""fa-solid fa-arrow-right""></i>
            </button>
            </div>
        </form>

    </div>
   
    </section>



");
            DefineSection("javascript", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61da33d1443f44cf3e61873ae6f4290f6ae757f625185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61da33d1443f44cf3e61873ae6f4290f6ae757f626285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        Admin_initMap();\r\n    </script>\r\n   ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
