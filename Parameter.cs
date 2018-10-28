namespace CodeBuilder
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{Type} {Name}";
        }
    }
}