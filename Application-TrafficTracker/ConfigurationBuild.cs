using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Application_TrafficTracker
{
    public class ConfigurationBuild
    {
        private readonly IConfiguration _configuration;
        public ConfigurationBuild(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public  void BuildConfiguration(string[] args, IConfiguration configuration)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .AddCommandLine(args)
           .Build();
        }

        public  static string GetConnectionString(_configuration, string name)
    {

        }
    }
}

