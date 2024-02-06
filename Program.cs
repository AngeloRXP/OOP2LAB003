namespace OOP2LAB003
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!\n" +
                "Please enter the dog name: ");
            string dogName = Console.ReadLine();

            Dog inputDog = new Dog
            {
                Name = dogName
            };

            Console.WriteLine($"Please enter the height of {dogName}: ");
            inputDog.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Please now, enter the color of {dogName}: ");
            inputDog.Color = Console.ReadLine();

            Console.WriteLine($"Enter the age of {dogName}: ");
            inputDog.Age = int.Parse(Console.ReadLine());


            Console.WriteLine(inputDog.ToString());
            inputDog.Eat();
            Console.WriteLine($"Cry: {inputDog.Cry()}\n");

            Console.WriteLine("Hello!!!\n" +
                "Please enter the cat name: ");
            string catName = Console.ReadLine();

            Cat inputCat = new Cat
            {
                Name = catName
            };

            Console.WriteLine($"Please enter the height of {catName}: ");
            inputCat.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Please now, enter the color of {catName}: ");
            inputCat.Color = Console.ReadLine();

            Console.WriteLine($"Enter the age of {catName}: ");
            inputCat.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(inputDog.ToString());
            inputCat.Eat();
            Console.WriteLine($"Cry: {inputCat.Cry()}\n");

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(inputDog);
            animals.Add(inputCat);

            Console.WriteLine("List of animals:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
