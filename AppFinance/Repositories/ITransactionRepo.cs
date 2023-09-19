using AppFinance.Models;

namespace AppFinance.Repositories
{
    public interface ITransactionRepo
    {
        bool Add(Transaction transaction);
        bool Delete(Transaction transaction);
        List<Transaction> GetAll();
        bool Update(Transaction transaction);
    }
}