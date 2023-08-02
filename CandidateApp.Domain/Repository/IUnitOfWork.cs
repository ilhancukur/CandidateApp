using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Repository
{
    public interface IUnitOfWork:IDisposable
    {

        ICustomerRepository Customer { get; }

        ITransactionRepository Transaction { get; }

        int Save();

    }
}
