using MiranteRepository.Interface;
using MiranteDomain.Queries;
using MiranteDomain.Models;
using MiranteFramework.Extensions;
namespace MiranteFramework.Queries;

public class GetLibraryById : IGetLibraryById
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storeProcedureName;
    private readonly IReposository _reposository;

    public GetLibraryById(IReposository reposository)
    {
        _storeProcedureName = "[dbo].[GetLibraryById]";
        _reposository = reposository;
    }

    public async Task<LibraryModel?> ExecuteAsync(int Id)
    {
        var parameters = Id.ToDynamicParameters("LibraryId");
        var data = await _reposository.GetDataAsync<LibraryModel>(_connectionName, _storeProcedureName, parameters);

        return data.FirstOrDefault();
    }
}
