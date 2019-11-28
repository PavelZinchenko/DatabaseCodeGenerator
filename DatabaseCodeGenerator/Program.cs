using System;

namespace DatabaseCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine(AppDomain.CurrentDomain.FriendlyName + " <path>");
                return;
            }

            Console.WriteLine(args[0]);

            try
            {
                var schema = Schema.DatabaseSchema.Load(args[0]);

                var builder = new GameCode.Builder(schema, new Utils.CodeWriter(System.IO.Path.Combine(args[1], "GeneratedGameCode")));
                builder.Build();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
