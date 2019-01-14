using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsProofServer.Models {

    public class Product {

        [Key]
        public int Id { get; set; }
        public int VendorId { get; set; }
        [Required]
        [StringLength(30)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
