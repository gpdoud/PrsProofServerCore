using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrsProofServer.Models {

    public class RequestLine {

        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RequestId { get; set; }
        public int Quantity { get; set; } = 1;

        public RequestLine() { }
    }
}
