using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Product
    {
        [Key]
        [Column("ProductID")]
        public int ProductID { get; set; }

        [Column("Code")]
        [DisplayName("ID")]
        [Required]
        public string ProductCode { get; set; }

        [Column("Name")]
        [Required]
        [DisplayName("Name")]
        public string ProductName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public int Price { get; set; }
    }
}
