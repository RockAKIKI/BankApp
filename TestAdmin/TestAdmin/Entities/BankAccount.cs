using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdmin.Entities
{
    internal class BankAccount
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [MaxLength(100, ErrorMessage = "Email address must be 100 characters or less")]
        public string AccountNumber { get; set; } = string.Empty;
    }
}
