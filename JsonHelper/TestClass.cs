using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonHelper
{
    public class TestClass
    {

    }

    public class TypeOfTray
    {
        public int Index { get; set; }
        public string TrayType { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public TypeOfTray()
        {
            TrayType = "";
        }
    }
}
