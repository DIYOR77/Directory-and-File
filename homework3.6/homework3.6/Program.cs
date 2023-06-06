namespace homework3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Project\\Lesson.txt";
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    count++;
                }
            }
            Console.WriteLine($" Qatorlar soni: {count}");

        }
    }
}
    
