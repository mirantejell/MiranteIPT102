
using MiranteDomain.Models;
namespace MiranteDomain.Queries
{
    public interface IGetLibraryById
    {
        Task<LibraryModel?> ExecuteAsync(int Id);
    }
}
