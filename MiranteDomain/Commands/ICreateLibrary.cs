using MiranteDomain.Models;

namespace MiranteDomain.Commands;

public interface ICreateLibrary
{
    Task<bool> ExecuteAsync(LibraryModel model);
}
