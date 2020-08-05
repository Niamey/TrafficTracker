using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Application_TrafficTracker
{
    public static class ConfigurationBuild
    {
        public static string BuildConfiguration(string[] args)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .AddCommandLine(args)
           .Build();
            var section = Configuration.GetSection("Sectionofsettings").ToString();
            return section;
        }
    }
}

