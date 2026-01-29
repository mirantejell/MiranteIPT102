using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MiranteRepository.Interface;

public interface IReposository
{
    public Task<IEnumerable<T>> GetDataAsync<T>(string connectionString,
        string storedProcName,
        DynamicParameters parameters = null);
    public Task<bool> SaveDataAsync(string connectionString,
        string storedProcName,
        DynamicParameters parameters = null);
}
