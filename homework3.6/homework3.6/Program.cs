namespace homework3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Project\\";
            Aniqla(path);
        }
        static void Aniqla(string path)
        {
            string[] papka = Directory.GetDirectories(path);
            string[] fayl=Directory.GetFiles(path);
            
            if (papka.Length!=0 && fayl.Length!=0)
                Console.WriteLine(" Papka va Fayllar bor.");

            else if (papka.Length!=0)
                Console.WriteLine(" Papka bor.");

            else if (fayl.Length!=0)
                Console.WriteLine(" Fayl bor.");

            else
                Console.WriteLine(" Papka va Fayl bo'sh.");
        }
    }
}