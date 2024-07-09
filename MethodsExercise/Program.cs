namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            string story = $"In a vibrant land where the skies were always {favoriteColor} and the trees sang melodies of {favoriteBand}, lived a remarkable adventurer named {name}. " +
                           $"{name} was known far and wide for their bravery and love for {favoriteAnimal}s. " +
                           $"One sunny morning, while exploring the mystical Whispering Woods, {name} stumbled upon an ancient, enchanted map. " +
                           $"The map promised to lead the way to a hidden treasure guarded by a legendary {favoriteAnimal}. " +
                           $"With excitement bubbling in their heart, {name} set off on a thrilling quest. " +
                           $"After days of traversing through enchanted forests and crossing sparkling rivers, {name} finally reached the hidden cave. " +
                           $"There, standing majestically, was a giant {favoriteAnimal}, whose eyes twinkled with ancient wisdom. " +
                           $"The {favoriteAnimal} challenged {name} to a game of riddles, which {name} cleverly won. " +
                           $"As a reward, the {favoriteAnimal} gifted {name} the treasure – a chest filled with everlasting happiness and a magical amulet that ensured all their dreams would come true. " +
                           $"From that day on, {name} and the {favoriteAnimal} became best friends, embarking on countless adventures and filling the land with joy and music from {favoriteBand}. " +
                           $"And so, the legend of {name} and the enchanted {favoriteAnimal} lived on forever.";

            Console.WriteLine(story);
            Console.WriteLine("Adding 2,4: " + Sum(2,4));
            Console.WriteLine("Adding 2,4,6: " + Sum(2,4,6));
            Console.WriteLine("Multiplying 8, 12: " + Multiply(8,12));
            Console.WriteLine("Multiplying 2,3,6,12: " + Multiply(2,3,6,12));
            Console.WriteLine("Subtracting 13,3,6: " + Subtract(13,3,6));
            Console.WriteLine("Dividing 12,6: " + Divide(12,6));
            Console.WriteLine("Dividing 12,6,2: " + Divide(12,6,2));
        }

        static int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }

        static int Multiply(params int[] numbers)
        {
            return numbers.Aggregate(1, (acc, val) => acc * val);
        }

        static int Subtract(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return numbers.Skip(1).Aggregate(numbers[0], (acc, val) => acc - val);
        }

        static double Divide(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return numbers.Skip(1).Aggregate((double)numbers[0], (acc, val) => acc / val);
        }
    }
}
