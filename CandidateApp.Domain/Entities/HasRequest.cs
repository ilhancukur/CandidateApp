using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class HasRequest
    {
        public string UserCode { get; set; }=string.Empty;
        public string Rnd { get; set; } = string.Empty;
        public string TxnType { get; set; } = string.Empty;
        public string TotalAmount { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        public string OrderId { get; set; } = string.Empty;


    }
}
