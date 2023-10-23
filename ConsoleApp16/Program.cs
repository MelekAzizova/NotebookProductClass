using ConsoleApp16.Models;
using System.Net.WebSockets;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            


            Notebook notebook = new Notebook();
            Console.WriteLine("Notebook adini daxil edin...");
            notebook.Brand = Console.ReadLine();
            Console.WriteLine(notebook.Brand);

            notebook.SetPrice(3500);
            notebook.Ram = 126;
            Console.WriteLine(notebook.Ram);

            notebook.Storage = 256;
            Console.WriteLine(notebook.Storage);












        }

    }
}