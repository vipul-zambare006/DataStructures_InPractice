using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice
{
    public class NumericInput : TextInput
    {
        public override string value { get; set; }

        public override void Add(char c)
        {
            if (Char.IsNumber(c))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(c);
                value += sb;
            }
        }
    }
}
