using Get_JokeAPi.NET.src.model.DTO;
using Get_JokeAPi.NET.src.service;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Reflection.PortableExecutable;

namespace Get_JokeAPi
{
    public class API
    {

        private static Composer composer = new Composer();

        static void Main(string[] args)
        {
            string url = "https://candaan-api.vercel.app/api/text";
            string path = @"D:\playground\C#\Get-JokeAPi.NET\src\json\Results.json";

            composer.mix(path, url);
        }

    }
}
