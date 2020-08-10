using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Application_TrafficTracker
{
    public static class ConfigurationBuild
    {

        public static void BuildConfiguration(string[] args, IConfiguration configuration)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .AddCommandLine(args)
           .Build();
        }

        public static  string GetConnectionString(this Microsoft.Extensions.Configuration.IConfiguration configuration, string name)
    {
            string conString = Microsoft.Extensions
                .Configuration
                .ConfigurationExtensions
                .GetConnectionString(configuration, name);

            return conString;

        }
    }
}

