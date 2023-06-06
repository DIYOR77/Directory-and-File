namespace homework3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Project";

            File.Create("C:\\Project\\.gitignore");

            string[] path2 = Directory.GetDirectories(path, "obj*");

            string[] path3 = Directory.GetDirectories(path, "bin*");

            foreach (string s in path2)
                Console.WriteLine(s);

            foreach (string s in path3)
                Console.WriteLine(s);

            string[] path4 = Directory.GetFiles(path, "*exe.txt");
            foreach (string s in path4)
                Console.WriteLine(s);

            Directory.Delete($"{path}\\bin", true);

            Directory.Delete($"{path}\\obj", true);
        }
    }
}