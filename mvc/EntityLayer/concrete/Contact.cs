using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
   public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(50)]
        public String UserName { get; set; }


        [StringLength(50)]
        public String UserMail { get; set; }

        [StringLength(50)]
        public String subject { get; set; }

        [StringLength(500)]
        public String Message { get; set; }
    }
}
