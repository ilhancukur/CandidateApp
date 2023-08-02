using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class PayzeeRequest
    {
      

        
            public int memberId { get; set; }

   
            public int merchantId { get; set; }

 
            public string customerId { get; set; } = string.Empty;

       
            public string cardNumber { get; set; } = string.Empty;

       
            public string expiryDateMonth { get; set; } = string.Empty;

      
            public string expiryDateYear { get; set; } = string.Empty;

            public string cvv { get; set; } = string.Empty;

     
            public int secureDataId { get; set; }

            public string cardAlias { get; set; } = string.Empty;


            public string userCode { get; set; } = string.Empty;

            public string txnType { get; set; } = string.Empty;


            public string installmentCount { get; set; } = string.Empty;


            public string currency { get; set; } = string.Empty;


            public string orderId { get; set; } = string.Empty;


            public string totalAmount { get; set; } = string.Empty;

            public string pointAmount { get; set; } = string.Empty;

            public string rnd { get; set; } = string.Empty;

       
            public string hash { get; set; } = string.Empty;

       
            public string description { get; set; } = string.Empty;

  
            public string cardHolderName { get; set; } = string.Empty;

       
            public string requestIp { get; set; } = string.Empty;

            
        
    }
}
