using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendSmart.DataAccess
{
    public class JsonDataAccessor : IDataAccessor
    {
        private IFileAccessor _fileAccessor;

        public JsonDataAccessor(IFileAccessor fileAccessor)
        {
            _fileAccessor = fileAccessor;
        }

        public string GetFileNameFrom(Type type, object options=null)
        {
            return type.Name + ".json";
        }

        public async Task<List<T>> GetDataAsync<T>()
        {
            string json;
            using (var streamReader = new StreamReader(await _fileAccessor.ReadFileAsync(GetFileNameFrom(typeof(T)))))
            {
                json = await streamReader.ReadToEndAsync();
            }

            return await Task.Factory.StartNew(()=>JsonConvert.DeserializeObject<List<T>>(json));
        }

        public async Task SaveDataAsync<T>(List<T> data)
        {
            string json= await Task.Factory.StartNew(() => JsonConvert.SerializeObject(data));
            string fileName = GetFileNameFrom(typeof(T));
            Stream stream = await _fileAccessor.GetWritableStreamAsync(fileName);

            using (var streamWriter = new StreamWriter(stream))
            {
                await streamWriter.WriteAsync(json);
            }
        }
    }
}
