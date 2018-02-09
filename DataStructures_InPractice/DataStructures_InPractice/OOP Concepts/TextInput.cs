using System.Text;

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
