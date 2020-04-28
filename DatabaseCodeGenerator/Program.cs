using System;

namespace DatabaseCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: " + AppDomain.CurrentDomain.FriendlyName + " <schema dir> <output dir>");
                return;
            }

            Console.WriteLine(args[0]);

            try
            {
                var schema = Schema.DatabaseSchema.Load(args[0]);

                var gameCodeBuilder = new GameCode.Builder(schema, new Utils.CodeWriter(System.IO.Path.Combine(args[1], "GeneratedGameCode")));
                gameCodeBuilder.Build();

                var editorCodeBuilder = new EditorCode.Builder(schema, new Utils.CodeWriter(System.IO.Path.Combine(args[1], "GeneratedEditorCode")));
                editorCodeBuilder.Build();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
