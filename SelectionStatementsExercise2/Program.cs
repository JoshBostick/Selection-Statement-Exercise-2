namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower()) 
            {
                case "math":
                case "geometry":
                case "calculus":
                    Console.WriteLine("I love math!");
                    break;
                case "science":
                case "biology":
                case "chemistry":
                    Console.WriteLine("Science is Awesome!");
                    break;
                case "history":
                    Console.WriteLine("History is fun!");
                    break;
                case "english":
                    Console.WriteLine("English is hard");
                    break;
                case "spanish":
                    Console.WriteLine("That's cool!");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
        }
    }
}