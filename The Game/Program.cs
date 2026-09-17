namespace The_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Show(IReportable r)
        {
                       Console.WriteLine(r.ReportLine());
        }
    }
}