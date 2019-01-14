using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsProofServer.Models {

    public class Request {

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(70)]
        public string Description { get; set; }
        public string Justification { get; set; }
        public string RejectionReason { get; set; }
        [Required]
        [StringLength(30)]
        public string DeliveryMode { get; set; }
        public DateTime? SubmittedDate { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }

        public virtual User User { get; set; }
        public virtual IList<RequestLine> RequestLines { get; set; }

        public Request() { }
    }
}
