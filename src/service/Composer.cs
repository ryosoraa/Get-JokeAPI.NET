using Get_JokeAPi.NET.src.API;
using Get_JokeAPi.NET.src.model.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_JokeAPi.NET.src.service
{

    internal class Composer
    {
        
        public static Officer officer = new Officer();
        public static Creative creative = new Creative();
        public static Request request = new Request();
        public static Check check = new Check();

        public void mix(String path,String url)
        {
            String json = request.req(url);
            
            if (check.IsValidJson(json))
            {
                JokesDTO raw = officer.chief(json);
                string result = JsonConvert.SerializeObject(raw.data, Formatting.Indented);
                creative.literature(path, result);

            }

            


        }



    }
}
