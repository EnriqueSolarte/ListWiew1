using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOperation1
{
    class Operation
    {

        public types Type { get; set; }
        public string Index { get; set; }
        public operations OperationType { get; set; }
        public string Parameters { get; set; }

      
    }

    public enum types
    {
        
        RGH,
        ZTH,
    }

    public enum operations
    {
        External_Turning,
        Internal_Turning,
    }
}
