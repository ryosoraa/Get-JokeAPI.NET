using System;
using System.IO;
using System.Net;

namespace Get_JokeAPi.NET.src.API
{
    public class Request
    {
        public string req(string url)
        {
            string result = string.Empty; // Deklarasikan json sebelum blok using

            try
            {
                WebRequest request = WebRequest.Create(url);

                using (WebResponse response = request.GetResponse())
                using (Stream objStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(objStream))
                {
                   String json = reader.ReadToEnd();
                   result = json;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

    }
}
