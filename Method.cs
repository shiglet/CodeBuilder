using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    public class Method
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public List<Parameter> Parameters { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"public {ReturnType} {Name}(");
            foreach (var p in Parameters)
            {
                sb.Append(p.ToString() + ", ");
            }

            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine(")");
            sb.AppendLine("  {");
            sb.AppendLine("    throw new NotImplementedException();");
            sb.AppendLine("  }");

            return sb.ToString();
        }

    }
}