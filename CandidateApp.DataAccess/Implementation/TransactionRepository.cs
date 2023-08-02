using CandidateApp.DataAccess.Context;
using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.DataAccess.Implementation
{
    public class TransactionRepository : GenericRepository<Transaction>,ITransactionRepository
    {
        public TransactionRepository(CandidateDbContext context) : base(context)
        {
        }
    }
}
