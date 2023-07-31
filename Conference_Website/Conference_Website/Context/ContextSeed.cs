using Conference_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference_Website.Context
{
    public class ContextSeed
    {
        public static async Task SeedAsync(DatabaseContext context)
        {
            context.Participants.AddRange(GetParticipant());
            context.Agendas.AddRange(GetAgendas());
            context.Speakers.AddRange(GetSpeakers());
            await context.SaveChangesAsync();
            Detail.Agenda = context.Agendas.ToList();
            Detail.Speakers = context.Speakers.ToList();
        }

        private static List<Agenda> GetAgendas()
        {
            return new List<Agenda>(){
                new Agenda()
                {
                    StartTime="09:00",
                    EndTime="10:00",
                    Description="Tanıtım & Selamlaşma"
                },
                 new Agenda()
                {
                    StartTime="10:00",
                    EndTime="12:00",
                    Description="Konu Tanıtımı"
                },
                  new Agenda()
                {
                    StartTime="12:00",
                    EndTime="13:00",
                    Description="Öğle Arası"
                },
                new Agenda()
                {
                    StartTime="13:00",
                    EndTime="16:00",
                    Description="Konu Anlatımı"
                },
                 new Agenda()
                {
                    StartTime="16:00",
                    EndTime=string.Empty,
                    Description="Kapanış"
                },
            };
        }

        private static List<Speaker> GetSpeakers()
        {
            return new List<Speaker>(){
               new Speaker()
               {
                   NameAndSurname="Vedat Aygün",
                   Career="Veri Analisti",
                   Image="speaker1.png",
                   Description="Ben bir paragrafım. Kendi metninizi eklemek ve beni düzenlemek için buraya tıklayın. Bu kolay. Kendi içeriğinizi eklemek ve yazı tipinde değişiklikler yapmak için \"Metni Düzenle\"ye tıklayın veya bana çift tıklayın. Bir hikaye anlatman ve kullanıcılarının senin hakkında biraz daha " +
                   "bilgi sahibi olmasını sağlaman için harika bir yerim. "
               },
         new Speaker()
        {
            NameAndSurname = "Muhammet Nuri Çalışkan",
                   Career = "Veri Analisti",
                   Image="speaker.png",
                   Description = "Ben bir paragrafım. Kendi metninizi eklemek ve beni düzenlemek için buraya tıklayın. Bu kolay. Kendi içeriğinizi eklemek ve yazı tipinde değişiklikler yapmak için \"Metni Düzenle\"ye tıklayın veya bana çift tıklayın. Bir hikaye anlatman ve kullanıcılarının senin hakkında biraz daha " +
                   "bilgi sahibi olmasını sağlaman için harika bir yerim. "
        }
    };
        }

        private static List<Participant> GetParticipant()
        {
            return new List<Participant>(){
               new Participant()
               {
                  Name="name1",
                  Surname="surname1",
                  Email="muhammetaygun96@gmail.com",
                  Verfication=true,
                  RegisterDate=DateTime.UtcNow
               },
                new Participant()
               {
                  Name="name2",
                  Surname="surname2",
                  Email="zenon0046@gmail.com",
                  Verfication=true,
                                   RegisterDate=DateTime.UtcNow

        },
                  new Participant()
               {
                  Name="name3",
                  Surname="surname3",
                  Email="zenon0046@gmail.com",
                  Verfication=true,
                  RegisterDate=DateTime.UtcNow

        },
               new Participant()
               {
                  Name="name4",
                  Surname="surname4",
                  Email="zenon0046@gmail.com",
                  Verfication=true,
                                  RegisterDate=DateTime.UtcNow

        },

    };
        }
    }
}
