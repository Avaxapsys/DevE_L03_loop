using System;
using System.Linq;

namespace DevE_L03_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = 1;
            do
            {
                Console.WriteLine($"Task number: {task}");
                TaskExecutor(task);
                task++;
            }
            while (task < 13);
        }

        static int GetInput(string count)
        {
            string countNumber = count;
            Console.WriteLine($"Put {count} number:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void TaskExecutor(int task)
        {
            int taskNumber = task;

            switch (task)
            {
                case 1:
                    FirstTask();
                    break;

                case 2:
                    SecondTask();
                    break;

                case 3:
                    ThirdTask();
                    break;

                case 4:
                    FourthTask();
                    break;

                case 5:
                    FifthTask();
                    break;

                case 6:
                    SixthTask();
                    break;

                case 7:
                    SeventhTask();
                    break;

                case 8:
                    EighthTask();
                    break;

                case 9:
                    NinthTask();
                    break;

                case 10:
                    TenthTask();
                    break;

                case 11:
                    EleventhTask();
                    break;

                case 12:
                    TwelfthTask();
                    break;
            }
        }

        static void FirstTask()
        {
            int firstNumber = GetInput("first");
            int secondNumber = GetInput("second");
            int result = firstNumber;

            for (int i=1; i< secondNumber; i++)
            {
                result *= firstNumber;
            }

            Console.WriteLine($"Result of the first task: {result}");
        }

        static void SecondTask()
        {
            int firstNumber = GetInput("");
            Console.Write("Result of the second task:");
            for (int i=1; i<= 1000; i++)
            {
                if (i % firstNumber == 0)
                {
                    Console.Write($"{i},");
                }
            }
            Console.WriteLine("");
        }

        static void ThirdTask()
        {
            int firstNumber = GetInput("");
            Console.Write("Result of the third task:");
            for (int i = 1; i <= firstNumber; i++)
            {
                if (Math.Pow(i, 2) >= firstNumber)
                    break;
                Console.Write($"{i},");
            }
            Console.WriteLine("");
        }

        static void FourthTask()
        {
            int firstNumber = GetInput("");
            Console.Write("Result of the fourth task:");

            for (int i = firstNumber - 1; i > 0; i--)
            {
                if (firstNumber % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
          
            
        }

        static void FifthTask()
        {
            int firstNumber = GetInput("first");
            int secondNumber = GetInput("second");
            int tempNumber = 0;
            Console.Write("Result of the fifth task:");
            if (firstNumber > secondNumber)
            {
                for (int i = secondNumber + 1; i < firstNumber; i++)
                {
                    if (i % 7 == 0)
                    {
                        tempNumber += i;
                    }
                }
                Console.WriteLine(tempNumber);
            }
            else if (firstNumber < secondNumber)
            {
                for (int i = firstNumber + 1; i < secondNumber; i++)
                {
                    if (i % 7 == 0)
                    {
                        tempNumber += i;
                    }
                }
                Console.WriteLine(tempNumber);
            }
            else
            {
                Console.WriteLine("You've input the equal numbers");
            }
        }

        static void SixthTask()
        {
            int firstNumber = GetInput("");
            int tempFirst = 1;
            int tempSecond = 1;
            int fibonacci = 0;
            Console.Write($"Fibonacci for {firstNumber}: ");

            for (int i = 3; i <= firstNumber; i++)
            {
                fibonacci = tempFirst + tempSecond;
                tempFirst = tempSecond;
                tempSecond = fibonacci;
            }
            Console.WriteLine(fibonacci);
        }

        static void SeventhTask()
        {
            int firstNumber = GetInput("first");
            int secondNumber = GetInput("second");
            Console.Write($"NOD for {firstNumber} and {secondNumber}: ");

            while (firstNumber != secondNumber)
            {
                if(firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            int nod = secondNumber;
            Console.WriteLine(nod);
        }

        static void EighthTask()
        {
            Console.WriteLine("I'll try it later");
        }

        static void NinthTask()
        {
            int firstNumber = GetInput("");
            int odd = 0;
            int tempNumber;
            Console.Write("Result of the ninth task:");

            while (firstNumber > 0)
            {
                tempNumber = firstNumber % 10;
                if (tempNumber % 2 != 0)
                {
                    odd++;
                }
                firstNumber /= 10;
            }

            Console.WriteLine(odd);
        }

        static void TenthTask()
        {
            int firstNumber = GetInput("");
            int reversedNumber = 0;
            Console.Write("Result of the tenth task:");

            while (firstNumber != 0)
            {
                int remainNumber = firstNumber % 10;
                reversedNumber *= 10;
                reversedNumber += remainNumber;
                firstNumber /= 10;
            }
            Console.WriteLine(reversedNumber);

        }

        static void EleventhTask()
        {
            int firstNumber = GetInput("");
            int odd = 0;
            int even = 0;
            int tempNumber = 0;
            int operNumber = 0;
            Console.Write("Result of the eleventh task:");

            for(int i = 1; i <= firstNumber; i++)
            {
                operNumber = i;
                while (operNumber > 0)
                {
                    tempNumber = operNumber % 10;
                    if (tempNumber % 2 != 0)
                    {
                        odd += tempNumber;
                    }
                    else
                    {
                        even += tempNumber;
                    }
                    operNumber /= 10;
                }
                if(even > odd)
                {
                    Console.Write($"{i},");
                }
                odd = 0;
                even = 0;
            }
        }

        static void TwelfthTask()
        {
            int firstNumber = GetInput("first");
            int secondNumber = GetInput("second");
            int tempNumber_1 = 0;
            int tempNumber_2 = 0;
            int tempnumber_3 = 0;
            bool answear = false;
            Console.Write("Result of the twelfth task:");


            while (firstNumber / 10 > 0 || firstNumber % 10 > 0)
            {
                tempNumber_1 = firstNumber % 10;
                tempnumber_3 = secondNumber;
                while (tempnumber_3 / 10 > 0 || tempnumber_3 % 10 > 0)
                {
                    tempNumber_2 = tempnumber_3 % 10;
                    if (tempNumber_2 == tempNumber_1)
                    {
                        answear = true;
                        break;
                    }
                    tempnumber_3 /= 10;
                }
                if (answear == true)
                {
                    break;
                } 
                firstNumber /= 10;

            }
            Console.WriteLine(answear);
            }
    }

}
