using MiranteDomain.Commands;
using MiranteDomain.Models;
using MiranteFramework.Extensions;
using MiranteRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiranteFramework.Commands;

public class CreateLibrary : ICreateLibrary
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName;
    private readonly IReposository _reposository;

    public CreateLibrary(IReposository reposository)
    {
        _storedProcedureName = "[dbo].[CreateCourse]";
        _reposository = reposository;
    }

    public async Task<bool> ExecuteAsync(LibraryModel model)
    {
        var p = model.ToLibraryDynamicParameters();
        return await _reposository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}
