using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "Hello";
        str += ", world";

        StringBuilder b = new StringBuilder();
        Console.WriteLine($"Length :: {b.Length}");
        Console.WriteLine($"Capacity :: {b.Capacity}");
        b.Append( "bla" );
        b.Append( "bla" );
        Console.WriteLine($"Length :: {b.Length}");
        Console.WriteLine($"Capacity :: {b.Capacity}");
        b.Append( "bla" );
        b.Append( "bla" );
        b.AppendLine( "bla" );
        b.AppendLine( "bla" );
        Console.WriteLine($"Length :: {b.Length}");
        Console.WriteLine($"Capacity :: {b.Capacity}");
        Console.WriteLine(b);
    }
}