using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtroShop.Models
{
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Guid ProductId { get; set; }
        public Guid StoreId { get; set; }
        public int Amount { get; set; }
        public String FinalPrice { get; set; }
        public int Discount { get; set; }
        
        public Guid OrderId { get; set; }



    }
}
