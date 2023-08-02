using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Entities
{
    public class ApiRequestModel
    {

        public string ApiKey { get; set; } = string.Empty;  
        public string Email { get; set; } = string.Empty;   
        public string Lang { get; set; } = string.Empty;    
    }
}
