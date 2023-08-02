using CandidateApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Repository
{
    public interface IPayzee
    {
        Task<ApiResponse.ApiResponseModel> GetAuthPayzee(ApiRequestModel apiRequest);

        Task<PaymenResModel.PaymentResponse> PaymentPayzee(PayzeeRequest apiRequest,string token);

    }
}
