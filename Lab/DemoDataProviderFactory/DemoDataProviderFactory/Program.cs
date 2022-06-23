using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.Common;

namespace DemoDataProviderFactory
{
    class Program
    {
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            var strConnection = config["ConnectionString : MyStoreDB"];
            return strConnection;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
