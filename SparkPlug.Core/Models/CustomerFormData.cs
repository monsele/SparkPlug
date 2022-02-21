using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Core.Models
{
    public class CustomerFormData:BaseModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMessage { get; set; }
        public string _formDomainName { get; set; }
    }
}
