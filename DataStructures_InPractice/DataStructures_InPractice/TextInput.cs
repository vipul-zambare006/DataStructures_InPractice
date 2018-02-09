using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice
{
    public class TextInput
    {
        public virtual string value { get; set; }

        public virtual void Add(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(c);
            value += sb;
        }

        public string GetValue()
        {
            return value;
        }

    }
}
