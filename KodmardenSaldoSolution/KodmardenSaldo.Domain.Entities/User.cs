using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodmardenSaldo.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int MemberId { get; set; }
        public double Balance { get; set; }

        public virtual Member Member { get; set; }
    }
}
