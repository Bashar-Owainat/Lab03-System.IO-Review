using System;
using System.IO;
using System.Text;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Chanllenge01();
            // Challenge02();
            //Challenge03();
            int[] arr1 = { 5,7,9};
            Challenge04(arr1);
            //int[] array = { 5, 5, 200, 21, 65, 30 };
            //Challenge05(array);
            //Challenge06();
            // Challenge07();
            //Challenge08();
           // Challenge09();
        }

        static int Chanllenge01()
        {
            Console.Write("Please 3 numbers: ");
            String userIput = Console.ReadLine();
            
            String[] arrOfStrings = userIput.Split(" ");

             if(arrOfStrings.Length < 3)
             {
                  Console.WriteLine("0");
                  return 0;
             }
             else
             {
                try
                {
                      int product = 1;
                      for(int i = 0; i < 3; i++)
                      {
                           int convertedString = Convert.ToInt32(arrOfStrings[i]);
                            product *= convertedString;
                      }
                       Console.WriteLine(product);
                       return product;
                }
                catch (FormatException)
                {
                    Console.WriteLine("1");
                    return 1;

                }
  
             }
           
        }



        static int Challenge02()
        {
            Console.Write("Please enter a number between 2-10: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while(userInput < 2 || userInput > 10)
            {
                 Console.Write("Your input is outside the range! Please enter a number between 2-10: ");
                 userInput = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < userInput; i++)
            {
                Console.Write(i + 1 + " of " + userInput + " - Enter a number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                sum += userNumber;

            }
            Console.WriteLine("The average of these " + userInput + " numbers is: " + sum / userInput);
            return sum / userInput;
        }        


        static void Challenge03()
        {
            
            for (int i = 1; i <= 5; i++)
            {
                int index = i * 2 - 1;
                
                for (int s = 1 ; s <= 6-i; s++)
                 Console.Write(" ");
        

                for (int j = 1; j <= index; j++)
                    {
                        Console.Write("*");
                    }
                
                Console.WriteLine("");
               
            }
            int counter = 2;
            for (int i = 1; i <= 4; i++)
            {
                int space = i  +1;
                for (int s = 1; s <= space; s++)
                    Console.Write(" ");
                
                for(int j = 1; j <= 9-counter; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                counter += 2;
            }

        }



        static void Challenge04(int[] arr)
        {
           
            int[] counting = new int[arr.Length];
   
            Array.Sort(arr);
            int count =1;
            int max = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                for(int j = i+1 ; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count += 1;
                        i++;
                    }
                }
                counting[i] = count;
                if(counting[i] > max)
                {
                    max = counting[i];
                }
                count = 1;
                

            }

            for(int i = 0; i < counting.Length; i++)
            {
                if(counting[i] != max)
                {
                    sum += counting[i];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(arr[sum] + " is the most duplicated");
        }

        static int Challenge05(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            return max;

        }

        static void Challenge06()
        {
            Console.WriteLine("Please enter a word: ");
            String userInput = Console.ReadLine();
            String path = @"C:\Users\LEGION\Documents\Challenge06.txt";
            File.AppendAllText(path, userInput);
        }

        static void Challenge07()
        {
            String path = @"C:\Users\LEGION\Documents\Challenge06.txt";
            String[] fileContent = File.ReadAllLines(path);
            for(int i = 0; i < fileContent.Length; i++)
            {
                Console.WriteLine(fileContent[i]);
            }
        }


        static void Challenge08()
        {
            String path = @"C:\Users\LEGION\Documents\Challenge06.txt";
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
            {
                Console.WriteLine(fileContent[i]);
            }
            Console.WriteLine("Enter the index of the line you want to delete(start form 0): ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            String holder =  fileContent[userInput];
            fileContent[userInput] = "";
            String str = String.Concat(fileContent);
            File.WriteAllText(path, str);

            File.AppendAllText(path, holder);


        }

        static void Challenge09()
        {
            Console.WriteLine("Enter a sentence: ");
            String userInput = Console.ReadLine();
            String[] arr1 = userInput.Split(" ");
            String[] result = new string[arr1.Length];
            Console.Write("[");
            for(int i = 0; i < arr1.Length; i++)
            {
                int length = arr1[i].Length;
                if(i == arr1.Length - 1)
                {
                result[i] = "\""+arr1[i] + ": " + length+"\"";
                    Console.Write(result[i]);
                }
                else
                {
                    result[i] = "\"" + arr1[i] + ": " + length + "\", ";
                    Console.Write(result[i]);
                }
                
            }
            Console.WriteLine("]");



        }

    }
}
