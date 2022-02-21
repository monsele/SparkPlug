using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Core.Dto
{
    public class CustomerFormDataDto
    {
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string customerMessage { get; set; }
        public string _formDomainName { get; set; }
    }
}
