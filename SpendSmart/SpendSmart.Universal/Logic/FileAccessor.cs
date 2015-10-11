using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpendSmart.DataAccess;
using Windows.Storage;

namespace SpendSmart.Universal.Logic
{
    public class FileAccessor : IFileAccessor
    {
        public async Task<Stream> GetWritableStreamAsync(string path)
        {
            var local = ApplicationData.Current.LocalFolder;
            var dataFolder=await local.CreateFolderAsync("spendsmartdata", CreationCollisionOption.OpenIfExists);
                        
            var file = await dataFolder.CreateFileAsync(path, CreationCollisionOption.ReplaceExisting);
            
            var randomAccessStream = await file.OpenAsync(FileAccessMode.ReadWrite);
            return randomAccessStream.AsStreamForWrite();
            
        }

        public async Task<Stream> ReadFileAsync(string path)
        {
            var local = ApplicationData.Current.LocalFolder;
            var dataFolder = await local.GetFolderAsync("spendsmartdata");
            var file = await dataFolder.GetFileAsync(path);
            return (await file.OpenReadAsync()).AsStreamForRead();
        }
    }
}
