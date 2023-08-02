using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Enum;
using CandidateApp.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CandidateApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayzeeController : ControllerBase
    {
        private readonly IPayzee _payzee;
        private readonly IHash _hash;
        private readonly IUnitOfWork _unitOfWork;

        public PayzeeController(IPayzee payzee,IHash hash, IUnitOfWork unitOfWork)
        {
            _payzee = payzee;
            _hash = hash;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse.ApiResponseModel>> GetAuth()
        {
            ApiRequestModel apiRequestModel = new ApiRequestModel();
            apiRequestModel.ApiKey = "kU8@iP3@";
            apiRequestModel.Email = "murat.karayilan@dotto.com.tr";
            apiRequestModel.Lang = "TR";
            var data = await _payzee.GetAuthPayzee(apiRequestModel);

            return Ok(data);
        
        
        }

        [HttpPost]
        public async Task<ActionResult<string>> SendPayment(PayzeeRequest payzeeRequest,string token)
        {


            var hashreq = _hash.SetParam(payzeeRequest);// ilgli paramereler set edilir
            string hash = _hash.CreateHash(hashreq);// hash oluşturulur.
            payzeeRequest.hash = hash;  
            
            var data = await _payzee.PaymentPayzee(payzeeRequest,token);

            _unitOfWork.Transaction.Add(
                 new Transaction { 
                  Amount=(Convert.ToDecimal(payzeeRequest.totalAmount)/100),
                  CardPan=payzeeRequest.cardNumber,
                  CustomerId=Convert.ToInt32(payzeeRequest.customerId),
                  OrderId=payzeeRequest.orderId,
                  ResponseCode=data.result.responseCode,
                  ResponseMesssage=data.result.responseMessage,
                  Status=data.statusCode.ToString(),
                  Types = (data.result.txnType == null || data.result.txnType == string.Empty) ? "" : (string)data.result.txnType,
                  
                 }

                );

            _unitOfWork.Save();
            return Ok(data);


        }


    }
}
