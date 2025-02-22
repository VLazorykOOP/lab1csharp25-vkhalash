namespace Lab1Charp
{
    public class Program
    {
        private static void Main()
        {
            Console.Write("Enter option 1-6: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 6;

            while (!isValid)
            {
                Console.Write("Please enter a valid option.\nEnter option 1-6: ");
                isValid = int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 6;
            }

            switch (option)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
            }
        }

        private static void Task1()
        {
            Console.Write("Enter side length: ");
            bool isValid = float.TryParse(Console.ReadLine(), out float side) && side > 0;

            while (!isValid)
            {
                Console.Write("Please enter a valid side length.\nEnter side length: ");
                isValid = float.TryParse(Console.ReadLine(), out side) && side > 0;
            }

            double radius = side * Math.Sqrt(3) / 6;
            Console.WriteLine("Radius = " + radius);
        }

        private static void Task2()
        {
            static float GetValidInput(string prompt)
            {
                Console.Write(prompt);
                bool isValid = float.TryParse(Console.ReadLine(), out float value) && value > 0;
                while (!isValid)
                {
                    Console.Write("Invalid input.\n" + prompt);
                    isValid = float.TryParse(Console.ReadLine(), out value) && value > 0;
                }
                return value;
            }

            float a = GetValidInput("Enter side A: ");
            float b = GetValidInput("Enter side B: ");
            float c = GetValidInput("Enter side C: ");

            if (a + b > c && a + b > c && a + b > c)
                Console.WriteLine("Triangle is a right triangle.");
            else
                Console.WriteLine("Triangle is not a right triangle.");
        }

        private static void Task3()
        {
            Console.Write("Enter X coordinate: ");
            bool isValid = float.TryParse(Console.ReadLine(), out float x);
            while (!isValid)
            {
                Console.Write("Invalid input.\nEnter X coordinate: ");
                isValid = float.TryParse(Console.ReadLine(), out x);
            }

            Console.Write("Enter Y coordinate: ");
            isValid = float.TryParse(Console.ReadLine(), out float y);
            while (!isValid)
            {
                Console.Write("Invalid input.\nEnter Y coordinate: ");
                isValid = float.TryParse(Console.ReadLine(), out y);
            }

            if (x >= -15 && x <= 0 && y >= -15 && y <= 0)
                Console.WriteLine("Point is inside.");
            else if (x == -15 || x == 0 || y == -15 || y == 0)
                Console.WriteLine("Point is on the edge.");
            else Console.WriteLine("Point is out");
        }

        private static void Task4()
        {
        begin:
            Console.Write(
            "Enter option from the list: \n" +
            "c - car\n" +
            "b - bike\n" +
            "m - motorbike\n" +
            "p - plane\n" +
            "t - train\n");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "c" or "C":
                    Console.WriteLine("Car - Speed: 120 km/h");
                    break;
                case "b" or "B":
                    Console.WriteLine("Bike - Speed: 25 km/h");
                    break;
                case "m" or "M":
                    Console.WriteLine("Motorbike - Speed: 100 km/h");
                    break;
                case "p" or "P":
                    Console.WriteLine("Plane - Speed: 900 km/h");
                    break;
                case "t" or "T":
                    Console.WriteLine("Train - Speed: 200 km/h");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    goto begin;
            }
        }

        private static void Task5()
        {
            static float CubeRoot(float number)
            {
                float result = 1;
                for (int i = 0; i < 3; i++)
                {
                    result *= number;
                }
                return result;
            }

            Console.Write("Input a number to find cube of: ");
            bool isValid = float.TryParse(Console.ReadLine(), out float number);

            while (!isValid)
            {
                Console.Write("Please enter a valid side length.\nInput a number to find cube of: ");
                isValid = float.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("Cube of " + number + " is " + CubeRoot(number));

        }

        private static void Task6()
        {
            Console.Write("Enter X: ");
            bool isValid = float.TryParse(Console.ReadLine(), out float x);
            while (!isValid)
            {
                Console.Write("Invalid input.\nEnter X: ");
                isValid = float.TryParse(Console.ReadLine(), out x);
            }

            Console.Write("Enter Y: ");
            isValid = float.TryParse(Console.ReadLine(), out float y);
            while (!isValid)
            {
                Console.Write("Invalid input.\nEnter Y: ");
                isValid = float.TryParse(Console.ReadLine(), out y);
            }

            float equationResult = ((1 / x * y) + 1 / (x * x + 1)) * (x + y);
            Console.WriteLine("Result of the equation is: " + equationResult);
        }
    }
}
