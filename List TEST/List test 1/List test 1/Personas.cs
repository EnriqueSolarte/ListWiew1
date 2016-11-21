using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_test_1
{
    class Personas
    {
        public string Name { get; set; }
        public int Edad { get; set; }
        public Paises Pais { get; set; }
    }

    public enum Paises
    {
        Ecuador, 
        Peru, 
        Brasil, 
        Mexico,
    }
}
