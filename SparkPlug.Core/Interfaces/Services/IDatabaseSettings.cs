using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Core.Interfaces.Services
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
    }
}
