namespace Tasks3
{

    internal class Program
    {
       static bool IsEmpty(List<int> list)
        {
            if (list.Count == 0)
                return true;

            return false;
        }
        static void PrintList(List<int> list)
        {
            if (!IsEmpty(list))
            {
                Console.Write("Elements of the list : ");
                Console.Write("[");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($" {list[i]}");
                }
                Console.WriteLine(" ]");
            }
            else 
            {
                Console.WriteLine("[] - the list is empty");
            }
        }

        static bool Exist(List<int> list, int num)
        {
            bool exist = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == num)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        static void AddNum(List<int> list, int num)
        {
            if (!Exist(list, num))
            {
                list.Add(num);
                Console.WriteLine($"Number {num} added to the list.");
            }
            else
            {
                Console.WriteLine($"Number {num} is already in the list.");
            }
        }
        static double GetMean(List<int> list)
        {
            

            int sum = 0;
            for (int i = 0;i < list.Count;i++)
                sum += list[i];
            return sum / list.Count;
        }

        static int GetMin (List<int> list)
        {
            int min = list[0];
            for (int i = 1;i < list.Count;i++)
                if (min > list[i])
                    min = list[i];
            return min;
        }
        static int GetMax (List<int> list)
        {
            int max = list[0];
            for(int i = 1; i < list.Count;i++)
                if (max < list[i])
                    max = list[i];
            return max;
        }

        static bool Search(List<int> list , int num)
        {
            bool found = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == num)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        static void GetEven(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
                if (list[i] % 2 == 0 && list[i] >= 0)
                    result.Add(list[i]);
            Console.WriteLine("Even List");
            PrintList(result);
        }
        static void GetOdd(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
                if (!(list[i] % 2 == 0) && list[i] > 0)
                    result.Add(list[i]);
            Console.WriteLine("Odd List");
            PrintList(result);

        }
        static void ClearList(List<int> list)
        {
            if (IsEmpty(list))
                Console.WriteLine("The list is already empty...");
            else
            {
                list.Clear();
                Console.WriteLine("List is cleared...");
            }
        }

        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            char choice = '\0';

            do
            {
                Console.WriteLine("\nP - Print numbers.");
                Console.WriteLine("A - Add a number.");
                Console.WriteLine("M - Display mean of the numbers.");
                Console.WriteLine("S - Display the smallest number.");
                Console.WriteLine("L - Display the largest number.");
                Console.WriteLine("F - Find a number.");
                Console.WriteLine("E - Even numbers of the list.");
                Console.WriteLine("O - Odd numbers of the list.");
                Console.WriteLine("C - Clear the list.");
                Console.WriteLine("Q - Quit.");
                Console.Write("Select an option from the menu: ");
                choice = char.Parse(Console.ReadLine());
                
                switch(choice)
                {
                    case 'p':
                    case 'P':
                        {
                            PrintList(list);
                            break;
                        }
                    case 'a':
                    case 'A':
                        {
                            Console.Write("Enter a number: ");
                            int num = int.Parse(Console.ReadLine());
                            AddNum(list, num);
                            break;
                        }
                    case 'm':
                    case 'M':
                        {
                            if(IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                double mean = GetMean(list);
                                Console.WriteLine($"The mean of the numbers = {mean}");
                            }
                            
                                
                            break;
                        }
                    case 's':
                    case 'S':
                        {
                            if (IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                int min = GetMin(list);
                                Console.WriteLine($"The smallest number is: {min}");
                            }
                            break;
                        }
                    case 'l':
                    case 'L':
                        {
                            if (IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                int max = GetMax(list);
                                Console.WriteLine($"The Largest number is:{max}");
                            }

                            break;
                        }
                    case 'f':
                    case 'F':
                        {
                            if (IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                Console.Write("Enter a number: ");
                                int num = int.Parse(Console.ReadLine());
                                if(Search(list,num))
                                    Console.WriteLine($"Number {num} is FOUND..");
                                else
                                    Console.WriteLine($"Number {num} is NOT found..");

                            }
                            break;
                        }
                    case 'e':
                    case 'E':
                        {
                            if (IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                                GetEven(list);
                            break;
                        }
                    case 'o':
                    case 'O':
                        {
                            if (IsEmpty(list))
                                Console.WriteLine("[] - the list is empty");
                            else
                                GetOdd(list);
                            break;
                        }
                    case 'c':
                    case 'C':
                        {
                            ClearList(list);
                            break;
                        }
                    case 'q':
                    case 'Q':
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Error... Invalid option...");
                        break;

                }

            } while (choice != 'Q' && choice != 'q');

        }
    }
}
