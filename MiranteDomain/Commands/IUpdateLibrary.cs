using MiranteDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiranteDomain.Commands
{
    public interface IUpdateLibrary
    {
        Task<bool> ExecuteAsync(LibraryModel model);

    }
}
