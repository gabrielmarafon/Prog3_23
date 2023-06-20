using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_Cap09
{
    public class Program.Helpers.cs
    {
        
    }
}

partial class Program
{
    static void SectionTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*");
        Console.WriteLine($"* {title}");
        Console.WriteLine("*");
        ForegroundColor = previousColor;
    }
}