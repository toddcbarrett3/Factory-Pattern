namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Todd's Taco Shack! \nTo order please select from our menu: \n");
            Console.WriteLine("Press 1 for Tacos \nPress 2 for Enchiladas \nPress 3 for a Burrito \n");
            bool validInput;
            int result;
            do
            {
                var userInput = Console.ReadLine();
                validInput = int.TryParse(userInput, out result);

                if (!validInput) { Console.WriteLine("Invalid choice please make another selection"); }
            } while (!validInput);

                IOrderable instance = FoodFactory.OrderFood(result);
                instance.GetDescription();
        }
    }
}
