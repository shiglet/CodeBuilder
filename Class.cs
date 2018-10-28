using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    public class Class
    {
        public List<Field> Fields = new List<Field>();
        public List<Method> Methods = new List<Method>();
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");
            foreach (var f in Fields)
            {
                sb.AppendLine("  " + f.ToString());
            }
            foreach (var p in Methods)
            {
                sb.AppendLine("  " + p.ToString());
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}