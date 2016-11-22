using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumazingListView
{
    class Operation
    {
        public const string externalTurning = "/Image/externalTurning.png";
        public const string internalTurning = "/Image/internalTurning.png";

        public string Type { get; set; }
        public string Index { get; set; }
        public operations OperationType { get; set; }
        public string Parameters { get; set; }


    }
    public enum operations
    {
        External_Turning,
        Internal_Turning,
    }
}
