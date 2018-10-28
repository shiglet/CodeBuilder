using System;
using System.Collections.Generic;

namespace CodeBuilder
{
    public class CodeBuilder
    {
       public CodeBuilder(string nameClass)
        {
            currentClass.Name = nameClass;
            NameClass = nameClass;
        }

        public string NameClass;
        private readonly Class currentClass = new Class();
        public CodeBuilder AddField(string name, string type)
        {
            currentClass.Fields.Add(new Field { Name = name, Type = type });
            return this;
        }
        public CodeBuilder AddMethod(string name, string returnType, List<Parameter> parameters)
        {
            currentClass.Methods.Add(new Method()
            {
                Name = name,
                Parameters = parameters,
                ReturnType = returnType
            });
            return this;
        }

        public override string ToString()
        {
            return currentClass.ToString();
        }
    }
}
