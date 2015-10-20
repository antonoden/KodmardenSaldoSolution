using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodmardenSaldo.Domain.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PersonalIdentityNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string UniversityPassCard { get; set; }
    }
}
