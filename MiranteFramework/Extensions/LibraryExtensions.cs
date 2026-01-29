using System.Data;
using Dapper;
using MiranteDomain.Models;

namespace MiranteFramework.Extensions
{
    public static class LibraryExtensions
    {
        public static DynamicParameters ToLibraryDynamicParameters(this LibraryModel model)
        {
            var p = new DynamicParameters();

            p.Add("@LibraryId", model.LibraryId, DbType.Int32, ParameterDirection.Input);
            p.Add("@LibraryName", model.LibraryName, DbType.String, ParameterDirection.Input);
            p.Add("@Address", model.Address, DbType.String, ParameterDirection.Input);
            p.Add("@Email", model.Email, DbType.String, ParameterDirection.Input);
            p.Add("@ContactNumber", model.ContactNumber, DbType.String, ParameterDirection.Input);

            return p;
        }
    }
}
