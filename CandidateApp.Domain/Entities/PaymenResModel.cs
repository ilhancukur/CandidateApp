using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class PaymenResModel
    {
        public class Result
        {
       
            public string responseCode { get; set; } = string.Empty;    

            public string responseMessage { get; set; } = string.Empty;

            public string orderId { get; set; } = string.Empty;

        
            public object? txnType { get; set; } 

       
            public string txnStatus { get; set; } = string.Empty;

      
            public int vposId { get; set; }

       
            public string vposName { get; set; } = string.Empty;

            public string authCode { get; set; } = string.Empty;

            public object hostReference { get; set; } = string.Empty;

            public string totalAmount { get; set; } = string.Empty;
        }

        public class PaymentResponse
        {

            public bool fail { get; set; }

            public int statusCode { get; set; }

   
            public Result? result { get; set; }
        }
    }
}
