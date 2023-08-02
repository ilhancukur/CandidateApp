using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Repository;
using CandidateApp.KpsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TcknService;

namespace CandidateApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        { 
        
           var data =_unitOfWork.Customer.GetAll();

            return Ok(data);
        
        }

        [HttpPost]
        public async Task<ActionResult> SaveCustomerAsync(Customer customer)
        {

            bool deger =await KpsAsmxService.GetTcknDogrulama(customer);
            if (deger==false)
            {
                customer.Status = 0;
                customer.IdentityNoVerified = "Hatalı bilgi";
            }
            else
             {
                customer.Status = 1;
                customer.IdentityNoVerified = "Başarılı İşlem";
             }


            _unitOfWork.Customer.Add(customer);
            _unitOfWork.Save();
            return Ok();

        }
    }
}
