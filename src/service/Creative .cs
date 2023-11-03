using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_JokeAPi.NET.src.service
{
    public class Creative
    {
        private static Check check = new Check();
        public void literature(String path, String json)
        {
        StreamWriter writer = File.AppendText(path);
            writer.WriteLine(json);
            writer.Close();
        }
    }
}
