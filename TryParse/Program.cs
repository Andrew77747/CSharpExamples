namespace TryParse
{
    class Program
    {
        private static bool TryParse(string s, out bool res)
        {
            if (s == "false" || s == "true")
            {
                res = s == "true";
                return true;
            }

            res = false;
            return false;
        }

        static void Main(string[] args)
        {
            if (TryParse("false", out var v))
            {
                Console.WriteLine("Success " + v);
            }
        }
    }
}