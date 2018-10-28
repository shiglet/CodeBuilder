using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBuilder
{
    class Program
    {
        public static void Main()
        {
            CodeBuilder cb = new CodeBuilder("Test")
                .AddField("Name", "string")
                .AddField("Age", "int")
                .AddMethod("Calculate", "void",
                    new List<Parameter>()
                    {
                        new Parameter() {Name = "a", Type = "int"},
                        new Parameter() {Name = "b", Type = "int"},
                        new Parameter() {Name = "c", Type = "int"}
                    })
                .AddMethod("Format", "override string",
                    new List<Parameter>()
                    {
                        new Parameter() {Name = "toFormat", Type = "string"}
                    })
                .AddMethod("Pow", "int",
                    new List<Parameter>()
                    {
                        new Parameter() {Name = "a", Type = "int"},
                    });
            Console.WriteLine(cb);
            Console.ReadKey();
        }
    }
}
