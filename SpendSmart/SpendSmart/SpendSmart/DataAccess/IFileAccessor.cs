using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendSmart.DataAccess
{
    public interface IFileAccessor
    {
        Task<Stream> ReadFileAsync(string path);

        Task<Stream> GetWritableStreamAsync(string path);

    }
}
