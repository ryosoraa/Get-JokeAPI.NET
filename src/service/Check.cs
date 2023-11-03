using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_JokeAPi.NET.src.service
{
    internal class Check
    {
        public bool IsValidJson(string json)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject(json);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}
