using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdmin.Entities
{
    internal class Phone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [MaxLength(20, ErrorMessage = "Phone number must be 20 characters or less")]
        public string PhoneNumber { get; set; }
    }
}
