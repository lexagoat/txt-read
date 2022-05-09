using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string reader;
        StreamReader st = File.OpenText(@"D:\"); // ur .txt file
        while ((reader = st.ReadLine()) != null)
        {
            Console.WriteLine(reader);
        }
        Console.ReadLine();
    }
}
