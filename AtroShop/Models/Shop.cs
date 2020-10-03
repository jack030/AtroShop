using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtroShop.Models
{
    public class Shop 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid  Id{ get; set; }
        public String  Name { get; set; }
        public String  PhoneNo { get; set; }
        public Guid ProfilePicture { get; set; }
        public String  CardNo { get; set; }
        public String  InstaLink { get; set; }
        public String  TelegramLink { get; set; }
        public Boolean Active { get; set;}
        public DateTime ExpireTime { get; set; }




    }
}
