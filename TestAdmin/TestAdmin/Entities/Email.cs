using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdmin.Entities
{
    internal class Email
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [MaxLength(100, ErrorMessage = "Email address must be 100 characters or less")]
        public string EmailAddress { get; set; }
    }
}
