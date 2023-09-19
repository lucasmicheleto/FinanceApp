using System;
using AppFinance.Models;
using LiteDB;

namespace AppFinance.Repositories
{
    public class TransactionRepo : ITransactionRepo
    {
        public List<Transaction> GetAll()
        {
            new LiteDatabase()
        }

        public bool Add(Transaction transaction)
        {

        }

        public bool Update(Transaction transaction)
        {

        }

        public bool Delete(Transaction transaction)
        {

        }
    }
}

