using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.DataAccess.Implementation
{
    public class Payzee : IPayzee
    {
        public async Task<ApiResponse.ApiResponseModel> GetAuthPayzee(ApiRequestModel apiRequest)
        {
            ApiResponse.ApiResponseModel reservationList =new ApiResponse.ApiResponseModel();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(apiRequest), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://ppgsecurity-test.birlesikodeme.com:55002/api/ppg/Securities/authenticationMerchant", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<ApiResponse.ApiResponseModel>(apiResponse);
                }
            }

            return reservationList;
        }

        public async Task<PaymenResModel.PaymentResponse> PaymentPayzee(PayzeeRequest apiRequest,string token)
        {
           
            PaymenResModel.PaymentResponse payment = new ();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(apiRequest), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Authorization =
                              new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                using (var response = await httpClient.PostAsync("https://ppgpayment-test.birlesikodeme.com:20000/api/ppg/Payment/NoneSecurePayment", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    payment = JsonConvert.DeserializeObject<PaymenResModel.PaymentResponse>(apiResponse);
                }
            }

            return payment;

        }

        
    }
}
