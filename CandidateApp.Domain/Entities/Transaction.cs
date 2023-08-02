using CandidateApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class Transaction
    {

        public int 	Id { get; set; }

        public int CustomerId { get; set; }
        public string OrderId { get; set; } = string.Empty;
        public string Types { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public string CardPan { get; set; } = string.Empty;

        public string ResponseCode { get; set; } = string.Empty;

        public string ResponseMesssage { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;  

    }
}
