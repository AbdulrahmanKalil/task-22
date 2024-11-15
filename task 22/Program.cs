
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char selection = '\n';

            do
            {

                Console.WriteLine("\nP - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                selection = Char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();
                switch (selection)
                {
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i]);
                                if (i < numbers.Count - 1)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine("]");
                        }
                        break;

                    case 'A':
                        Console.Write("Enter an integer to add to the list: ");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(number2);
                        Console.WriteLine($"{number2} added.");
                        break;

                    case 'M':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }
                            Console.WriteLine($"The mean is {sum / numbers.Count}");
                        }
                        break;

                    case 'S':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }

                        }
                        break;

                    case 'L':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;
                    case 'F':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("The list is empty");

                        }
                        else
                        {

                            Console.Write("Enter the number you want to search for: ");
                            int numberToFind = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == numberToFind)
                                {

                                    Console.WriteLine($"The number {numberToFind} was found in the list at index {i}.");

                                }

                            }


                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again.");
                        break;

                }
            } while (selection != 'Q');
        }
    }
}

