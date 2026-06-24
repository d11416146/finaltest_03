namespace finaltest_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IName n1;
            string input = Console.ReadLine();
            if (input == "t")
            {
                n1 = new Teacher();
            }
            else
            {
                n1 = new Student();
            }
            Console.WriteLine(n1.GetName());
        }
    }
}
