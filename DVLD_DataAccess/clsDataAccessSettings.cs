using Microsoft.Extensions.Configuration;
using System;

namespace DVLD_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build()
                        .GetSection("constr").Value;


    }
}
