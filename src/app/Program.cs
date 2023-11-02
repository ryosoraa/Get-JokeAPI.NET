using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;

namespace Get_JokeAPi
{
    class API
    {
        public static String path = @"D:\playground\C#\Get-JokeAPi.NET\src\json\Raw.json";
        public static StreamWriter writer = File.CreateText(path);

        static void Main(string[] args)
        {

            string sURL;
            sURL = "https://candaan-api.vercel.app/api/text";

            WebRequest request;
            request = WebRequest.Create(sURL);

            Stream objStream;
            objStream = request.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            API.writer.WriteLine(objReader.ReadToEnd());
            Thread.Sleep(5000);
            Console.WriteLine(objReader.ReadLine());
            objStream.Close();

            while(objReader != null)
            {
                Console.WriteLine(objReader.ReadLine());
            }


        }
    }
}

