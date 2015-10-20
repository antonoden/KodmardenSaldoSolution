using KodmardenSaldo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace KodmardenSaldo.Domain.DataAccessLayer
{
    class Initializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var members = new List<Member>
            {
                new Member {FirstName="Alexander", LastName="Bennetoft", PersonalIdentityNumber="19940116-9074", MobileNumber="0768187151", Email="alexander.bennetoft@gmail.com" },
                new Member {FirstName="Johan", LastName="Uttermalm", PersonalIdentityNumber="19921026-2730", MobileNumber="0730383567", Email="johan.uttermalm@gmail.com" },
                new Member {FirstName="Ramin", LastName="Golrang", PersonalIdentityNumber="19911202-4477", MobileNumber="0707535519", Email="dj_gogel@hotmail.com" },
                new Member {FirstName="Mohammed", LastName="Aljumaili", PersonalIdentityNumber="19930513-0297", MobileNumber="0762090434", Email="mohammedaljumaili93@gmail.com" },
                new Member {FirstName="Anton", LastName="Odén", PersonalIdentityNumber="19930922-8436", MobileNumber="0768119444", Email="anton.oden.kau@hotmail.com" },
                new Member {FirstName="André", LastName="Winberg", PersonalIdentityNumber="19940928-0717", MobileNumber="0730244016", Email="andre.winberg@krukan6.net" },
                new Member {FirstName="Andreas", LastName="Ahlin", PersonalIdentityNumber="19930102-4957", MobileNumber="0739043898", Email="andreas.ahlin@gmail.com" },
                new Member {FirstName="Filip", LastName="Skogum", PersonalIdentityNumber="19930203-4179", MobileNumber="0730831308", Email="filip.skogum@gmail.com" },
                new Member {FirstName="Magnus", LastName="Pedersen", MobileNumber="0705521832", Email="magnus192@hotmail.com" }
            };

            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
            var users = new List<User>
            {
                new User {MemberId=5, UserName="antode", Balance=0, Password="1234" },
                new User {MemberId=1, UserName="aleben", Balance=50, Password="4321" }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
            var transactions = new List<Transaction>
            {
                new Transaction {UserId=1, Timestamp=DateTime.Now, Value=-50 },
                new Transaction {UserId=2, Timestamp=DateTime.Now.AddDays(-1), Value=25 }
            };

            transactions.ForEach(t => context.Transactions.Add(t));
            context.SaveChanges();
        }
    }
}
