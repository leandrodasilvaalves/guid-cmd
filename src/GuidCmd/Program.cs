namespace GuidCmd
{
    public static class Program
    {
        public const string NOT_DASH = "--no-dash";
        public static IList<string> Guids { get; } = new List<string>();

        public static void Main(string[] args)
        {
            ParseArgs(args, out var notDash, out var quantity);
            Generate(quantity, notDash);
            PrintGuid();
        }

        static void PrintGuid()
        {
            foreach (var guid in Guids)
                Console.WriteLine(guid);
        }

        public static void Generate(int quantity, bool notDash = false)
        {
            Guids.Clear();
            var index = 0;
            do
            {
                var guid = Guid.NewGuid().ToString();
                if (notDash) guid = guid.Replace("-", "");
                Guids.Add(guid);
                index++;
            } while (index < quantity);
        }

        public static void ParseArgs(string[] args, out bool notDash, out int quantity)
        {
            notDash = args.Contains(NOT_DASH);
            args = Array.FindAll(args, a => a != NOT_DASH);            
            quantity = !args.Any(a => a.Contains("-n")) ? 1
                : int.Parse(string.Join("", string.Join("", args).ToArray<char>().Where(a => char.IsDigit(a))));
        }
    }
}
