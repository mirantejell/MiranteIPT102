using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MiranteFramework.Extensions;

public static class StringExtension
{
    public static DynamicParameters ToDynamicParameters(this int value, string name)
    {
        var paremeters = new DynamicParameters();

        paremeters.Add($"@{name}", value, DbType.String, ParameterDirection.Input);

        return paremeters;
    }
}
