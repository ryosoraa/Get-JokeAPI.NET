using Get_JokeAPi.NET.src.model.DTO;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_JokeAPi.NET.src.service
{
    public class Officer
    {
        public JokesDTO chief(String json)
        {
            ArrayList results = new ArrayList();
            JokesDTO JDTO = JsonConvert.DeserializeObject<JokesDTO>(json);
            Console.WriteLine(JDTO.data[0]);

            return JDTO;
        }
    }
}
