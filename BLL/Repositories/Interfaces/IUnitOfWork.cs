using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
