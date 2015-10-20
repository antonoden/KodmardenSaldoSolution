using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodmardenSaldo.Domain.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
