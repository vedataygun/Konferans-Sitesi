using Conference_Website.Context;
using Conference_Website.EmailService;
using Conference_Website.Extension;
using Conference_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Conference_Website.Controllers
{



    public class Participation : Controller
    {

        private readonly DatabaseContext _context;
        private readonly HotmailEmailService _emailService;

        public Participation(DatabaseContext context, HotmailEmailService hotmailEmailService)
        
        {
            _context = context;
            _emailService= hotmailEmailService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Index(Participant participant)
        {
            if(ModelState.IsValid)
            {
                var participant1 = _context.Participants.Where(x => x.Email.Equals(participant.Email.ToLower())).FirstOrDefault();
                int ID = 0;
                if(participant1 == null)
                {
                    participant.Email = participant.Email.ToLower();
                    participant.RegisterDate = DateTime.UtcNow;
                    participant.VerficationCode = await _emailService.SendVerificationCode(participant.Email);
                    var response = _context.Participants.Add(participant);
                    ID = response.Entity.Id;
                 
                }
                else if(participant1.Verfication)
                {
                    TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
                    {
                        Header = "Kayıtlı E-Posta",
                        Message = "Bu E-Posta adresi ile daha önce kayıt yapılmış.",

                    });
                    return View();
                }
                else
                {
                    ID = participant1.Id;
                    int VerificationCode = await _emailService.SendVerificationCode(participant.Email);
                    participant1.VerficationCode = VerificationCode;

                }

                _context.SaveChanges();
                return RedirectToAction("Verification", new {ID});

            }

            TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
            {
                Header="Alanlar Boş Geçilemez",
                Message="Tüm alanları doldurun lütfen."
            });

            return View();
        }

        public IActionResult Verification(int Id)
        {
            var participant = _context.Participants.Find(Id);

            if(participant==null)
                return NotFound();

            ViewBag.Id = Id;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Verification(int Id ,int VerificationCode)
        {
            var participant = _context.Participants.Find(Id);

            if(participant.Verfication)
            {
                return NotFound();

            }else if(participant.VerficationCode == VerificationCode)
            {
                participant.Verfication = true;
                await _context.SaveChangesAsync();
                return RedirectToAction("VerificationSuccess");
            }

            TempData.Put<AlertBox>("alert", new AlertBox(AlertType.Danger)
            {
                Header="Hatalı Doğrulama Kodu",
                Message="Girdiğin kod hatalı, lütfen tekrar deneyin."
            });
            return Redirect("/email-dogrulama/" + Id);
        }

        public IActionResult VerificationSuccess()
        {
            return View();
        }
    }
}
