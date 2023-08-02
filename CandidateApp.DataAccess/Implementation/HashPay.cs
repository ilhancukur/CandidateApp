using Azure.Core;
using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.DataAccess.Implementation
{
    public class HashPay : IHash
    {
        public  string CreateHash(HasRequest request)
        {
            var apiKey = "SKI0NDHEUP60J7QVCFATP9TJFT2OQFSO";
            var hashString = $"{apiKey}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}{request.CustomerId}{request.OrderId}";
            System.Security.Cryptography.SHA512 s512 = System.Security.Cryptography.SHA512.Create();
            System.Text.UnicodeEncoding ByteConverter = new System.Text.UnicodeEncoding();
            byte[] bytes = s512.ComputeHash(ByteConverter.GetBytes(hashString));
            var hash = System.BitConverter.ToString(bytes).Replace("-", "");

            return hash;
        }

        public HasRequest SetParam(PayzeeRequest payzeeRequest)
        {
            HasRequest hasRequest = new HasRequest();
            hasRequest.Rnd = payzeeRequest.rnd;
            hasRequest.CustomerId = payzeeRequest.customerId;
            hasRequest.UserCode = payzeeRequest.userCode;
            hasRequest.OrderId = payzeeRequest.orderId;
            hasRequest.TotalAmount = payzeeRequest.totalAmount;
            hasRequest.TxnType = payzeeRequest.txnType;

            return hasRequest;  
        }
    }
}
