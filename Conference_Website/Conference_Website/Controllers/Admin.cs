using Conference_Website.Context;
using Conference_Website.EmailService;
using Conference_Website.Extension;
using Conference_Website.Extensions;
using Conference_Website.Models;
using Conference_Website.ResultModels;
using Conference_Website.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Conference_Website.Controllers
{

    [Authorize]
    public class Admin : Controller
    {

        public readonly ValidateExtension _validate;
        public readonly DatabaseContext _context;
        public readonly HotmailEmailService _emailService;


        public Admin(ValidateExtension validate, DatabaseContext context , HotmailEmailService emailService)
        {
            _validate = validate;
            _context = context;
            _emailService = emailService;
        }


        public IActionResult PasswordReset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordReset(string oldPassword , string newPassword , string newPasswordAgain)
        {
            if(ModelState.IsValid)
            {
                if(oldPassword!=SiteSettings.AdminPassword)
                {

                    TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Warning)
                    {
                        Header = "Hatalı İşlem",
                        Message = "Eski şifre hatalı"
                    });
                    return View();


                }
                if(newPassword != newPasswordAgain)
                {

                    TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Warning)
                    {
                        Header = "Hatalı İşlem",
                        Message = "Yeni şifreler aynı değil"
                    });
                    return View();
                }

                SiteSettings.AdminPassword = newPassword;
                TempData.Put<AlertBox>("alert", new AlertBox()
                {
                    Header = "İşlem Başarıyla Tamamlandı",
                    Message = "Şifre değiştirme işlemi başarıyla tamamlandı."
                });
                return View();

            }
           
                TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
                {
                    Header = "Hatalı İşlem",
                    Message = "Lütfen tüm alanları doldurun."
                });
            
           
            return View();
        }



        public IActionResult GeneralInformation()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string username , string password)
        {
            if(!ModelState.IsValid)
            {

                TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
                {
                    Header = "Hatalı İşlem",
                    Message = "Lütfen tüm alanları doldurun."
                });

                return View();

            }


            if(username==SiteSettings.AdminUserName && password==SiteSettings.AdminPassword)
            {

                var claim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,username)

                };

                var claimIdentity = new ClaimsIdentity(claim,"a");
                var principal = new ClaimsPrincipal(claimIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("GeneralInformation");
               
            }

            TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
            {
                Header = "Hatalı İşlem",
                Message = "Kullanıcı adı veya Sifre hatalı."
            });


            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        public IActionResult Settings()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Settings(string LogoName, string Copyright , bool EmailChecked)
        {
            if (!ModelState.IsValid)
            {
                TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
                {
                    Header = "Hatalı İşlem",
                    Message = "Tüm alanları doldurun lütfen."
                }) ;
                return View();

            }


            SiteSettings.LogoName = LogoName.Trim();
            SiteSettings.Copyright = Copyright.Trim();
            SiteSettings.EmailChecked = EmailChecked;


            TempData.Put<AlertBox>("alert", new AlertBox()
            {
                Header = "İşlem Başarılı",
                Message = "Güncelleme işlemi başarıyla tamamlandı"
            });

            return View();
        }



        public IActionResult ParticipantList()
        {
            return View(_context.Participants.ToList());
        }


        public IActionResult Deneme()
        {
            return View();
        }


        [HttpPost]
        public async Task<Result> Send_Certification()
        {
            try
            {
                var participantList = _context.Participants.ToList();

                foreach (var participant in participantList)
                {
                    string html = @$"<!DOCTYPE html><head> <meta charset='utf-8'> <link href='http://localhost:56456/css/certifica.css' rel='stylesheet'></head><body><div class='container'> <div class='sec-1'></div><div class='sec-2'> <div class='col-1'> {SiteSettings.LogoName} </div><div class='col-2'> Katılım Sertifikası </div><div class='row'> <div class='col-3'> Vedat Aygün </div><div class='col-4'>{Detail.ConferenceName}</div></div><div class='date'> {DateTime.UtcNow} </div></div></div></body></html>";
                    string name = Guid.NewGuid().ToString() + ".pdf";
                    string fpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\PDF", name);
                    bool result = new HtmlToPdf().ConvertPDF("http://localhost:56456", html, fpath);
                    if (result)
                    {
                        await _emailService.SendCertification(participant.Email, fpath);

                    }

                }

         

                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Sertifika gönderme işlemi başarıyla tamamlandı."
                });
            }
            catch (Exception e)
            {


                return new Result(true, new AlertBox(AlertType.Danger)
                {
                    Header = "Hatalı İşlem",
                    Message = e.Message
                }) ;
            }
               
        }


            [HttpPost]
        public Result Update_Detail(string ConferenceName, DateTime StartDate)
        {
            if (!string.IsNullOrWhiteSpace(ConferenceName) && StartDate != default(DateTime))
            {

                Detail.ConferenceName = ConferenceName;
                Detail.StartDate = StartDate;

                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Güncelleme işlemi başarıyla tamamlandı."
                });
            }
            return new Result(false);
        }

        [HttpPost]

        public Result Delete_Image(string ImageName)
        {
            if (!string.IsNullOrWhiteSpace(ImageName))
            {

                try
                {
                    string exitingFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", ImageName);
                    System.IO.File.Delete(exitingFile);

                }
                finally
                {
                    Detail.ImageList.Remove(ImageName);

                }

                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Fotoğraf başarıyla kaldırıldı."
                });
            }

            return new Result(false);
        }


        [HttpPost]
        public async Task<Result> Add_Image(IFormFile Image, string ImageName)
        {
            if (Image != null)
            {

                var extent = _validate.ValidateImage(Image.FileName);

                if (extent != null)
                {
                    ImageName += extent;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", ImageName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Image.CopyToAsync(stream);
                        Detail.ImageList.Add(ImageName);
                    }

                    return new Result(true, new AlertBox()
                    {
                        Header = "İşlem Başarılı",
                        Message = "Fotoğraf başarıyla Eklendi."
                    });
                }
                else
                {
                    return new Result(false, new AlertBox(AlertType.Warning)
                    {
                        Header = "Hatalı İşlem",
                        Message = "Fotoğraf uzantınız (.jpg - .png - .jpeg) olmalıdır."
                    });

                }




            }
            return new Result(false, new AlertBox(AlertType.Danger));
        }



        [HttpPost]
        public Result Delete_Speaker(int id)
        {
            var speaker = Detail.Speakers.Where(x => x.Id.Equals(id)).First();

            bool result = Detail.Speakers.Remove(speaker);

            if (result)
            {
                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Konuşmacı başarıyla kaldırırdı.",

                });
            }

            return new Result(false, new AlertBox(AlertType.Danger));
        }


        [HttpPost]
        public async Task<Result> Add_Speaker(Speaker speaker, IFormFile newImage)
        {
            if (!string.IsNullOrEmpty(speaker.NameAndSurname) && !string.IsNullOrEmpty(speaker.Career) && !string.IsNullOrEmpty(speaker.Description))
            {
                int id = new Random().Next(50, 5200);
                speaker.Id = id;
                if (newImage == null)
                {
                    return new Result(true, new AlertBox(AlertType.Danger)
                    {
                        Header = "Hatalı İşlem",
                        Message = "Lütfen fotoğraf ekleyiniz.",

                    });
                }

                var extension = Path.GetExtension(newImage.FileName);
                var newName = $"{Guid.NewGuid()}{extension}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", newName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await newImage.CopyToAsync(stream);
                    speaker.Image = newName;
                    Detail.Speakers.Add(speaker);



                }
                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Konuşmacı ekleme işlemi başarıyla tamamlandı.",

                });
            }

            return new Result(true, new AlertBox(AlertType.Danger)
            {
                Header = "Hatalı İşlem",
                Message = "Tüm Alanları doldurunuz.",

            });
        }


        [HttpPost]
        public async Task<Result> Update_Speaker(Speaker speaker, IFormFile newImage)
        {
            if (!string.IsNullOrEmpty(speaker.NameAndSurname) && !string.IsNullOrEmpty(speaker.Career) && !string.IsNullOrEmpty(speaker.Description) && !string.IsNullOrEmpty(speaker.Image) && speaker.Id > 0)
            {

                if (newImage != null)
                {
                    var deleteFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", speaker.Image);
                    System.IO.File.Delete(deleteFile);

                    var extension = Path.GetExtension(newImage.FileName);
                    var newName = $"{Guid.NewGuid()}{extension}";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", newName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await newImage.CopyToAsync(stream);
                        speaker.Image = newName;

                    }

                }
                var oldSpeaker = Detail.Speakers.Where(x => x.Id.Equals(speaker.Id)).First();

                oldSpeaker.NameAndSurname = speaker.NameAndSurname;
                oldSpeaker.Career = speaker.Career;
                oldSpeaker.Description = speaker.Description;
                oldSpeaker.Image = speaker.Image;


                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Konuşmacı bilgileri güncellendi. ",


                });
            }

            return new Result(false, new AlertBox(AlertType.Danger));
        }



        [HttpPost]
        public DataResult<Speaker> Get_SpeakerDetail(int id)
        {

            if (id != 0)
            {

                var speaker = Detail.Speakers.Where(x => x.Id.Equals(id)).First();

                if (speaker != null)
                    return new DataResult<Speaker>(true, speaker);

            }

            return new DataResult<Speaker>(false);


        }

        public DataResult<Speaker> GetAll_Speaker(int id)
        {

            var speakerList = Detail.Speakers.ToList();

            return new DataResult<Speaker>(true, speakerList);


        }



        /*----------------     Agenda         ---------------*/


        [HttpPost]
        public DataResult<Agenda> Remove_Agenda(int id)
        {

            if (id != 0)
            {
                var item = Detail.Agenda.Where(x => x.Id.Equals(id)).First();

                if (item != null)
                {
                    Detail.Agenda.Remove(item);
                    return new DataResult<Agenda>(true, new AlertBox()
                    {
                        Header = "İşlem Başarılı",
                        Message = "Gündem başarıyla kaldırırdı.",


                    }, Detail.Agenda);
                }
            }

            return new DataResult<Agenda>(false);

        }


        [HttpPost]

        public DataResult<Agenda> Add_Agenda(Agenda agenda)
        {

            if (!string.IsNullOrEmpty(agenda.Description)  && !string.IsNullOrEmpty(agenda.StartTime))
            {
                agenda.Id = new Random().Next(50, 1000);

         
                    Detail.Agenda.Add(agenda);

                    return new DataResult<Agenda>(true, new AlertBox()
                    {
                        Header = "İşlem Başarılı",
                        Message = "Gündem başarıyla eklendi.",


                    },Detail.Agenda);
                
            }

            return new DataResult<Agenda>(false);
        }


        [HttpPost]

        public Result Update_Location(string lat , string @long , string address)
        {
            if(!string.IsNullOrEmpty(lat) && !string.IsNullOrEmpty(@long))
            {
                Detail.Latitude= lat;
                Detail.Longitude= @long;
                Detail.Location = address.Trim().CapitalFirstLetterInWord();

                return new Result(true, new AlertBox()
                {
                    Header = "İşlem Başarılı",
                    Message = "Konum başarıyla güncellendi",


                });
            }
            return new Result(false, new AlertBox(AlertType.Danger));

        }

    }

}






