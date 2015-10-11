using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpendSmart.DataAccess
{
    public class JsonParser
    {
        public List<T> Parse<T>(string data)
        {
            return JsonConvert.DeserializeObject<List<T>>(data);
        }


    }
}
