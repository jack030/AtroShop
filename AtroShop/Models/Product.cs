using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtroShop.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Guid StoreId { get; set; }
        public Guid Picture { get; set; }
        public int Amount { get; set; }
        public String Price { get; set; }
        public String Description { get; set; }

        public bool Available { get; set; }
        public int Discount { get; set; }
        public Boolean DiscountActive { get; set; }
        public DateTime DiscountExpire { get; set; }

    }
}
