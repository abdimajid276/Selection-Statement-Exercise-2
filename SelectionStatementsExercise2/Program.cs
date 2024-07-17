namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I dont prefer math");
                    break;
                case "science":
                    Console.WriteLine("Science rocks");
                    break;
                case "P.E":
                    Console.WriteLine("P.E is fun");
                    break;
                case "History":
                    Console.WriteLine("History sucks");
                    break;
                case "Geometry":
                    Console.WriteLine("Geometry is fun");
                    break;
                default:
                    Console.WriteLine("i love that too");
                    break;
            }

        }
    }
}