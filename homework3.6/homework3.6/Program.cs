namespace homework3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string files1 = "C:\\Project\\lesson.txt";
            string files2 = "C:\\Project\\New folder\\new";
            File.Copy(files1, files2, true);
        }
    }
}