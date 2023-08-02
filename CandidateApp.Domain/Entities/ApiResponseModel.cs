using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class ApiResponse
    {
        public class Result
        {
            public int userId { get; set; }
            public string token { get; set; } = string.Empty;
        }

        public class ApiResponseModel
        {
            public bool fail { get; set; }
            public int statusCode { get; set; }
            public Result? result { get; set; }
            public int count { get; set; }
            public string responseCode { get; set; } = string.Empty;
            public string responseMessage { get; set; } = string.Empty;
        }
    }
}
