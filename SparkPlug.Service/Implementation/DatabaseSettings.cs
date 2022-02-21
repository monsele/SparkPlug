using SparkPlug.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Service.Implementation
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get ; set ; }
    }
}
