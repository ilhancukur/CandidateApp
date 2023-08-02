using CandidateApp.DataAccess.Context;
using CandidateApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.DataAccess.Implementation
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly CandidateDbContext _context;

        public UnitOfWork(CandidateDbContext context)
        {
            _context = context;
            Customer = new CustomerRepository(_context);
            Transaction = new TransactionRepository(_context);  
        }
        public ICustomerRepository Customer  { get; private set; }

        public ITransactionRepository Transaction { get; private set; }

        public void Dispose()
        {
            _context.Dispose(); 
        }

        public int Save()
        {
           return _context.SaveChanges();
        }
    }
}
