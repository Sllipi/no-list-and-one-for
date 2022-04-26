using System;

namespace no_list_and_one_for
{
    using System;
        class Program
        {
            static void Main(string[] args)
            {
                byte numberOfColumns = 0;
                byte[] myArray = new byte[numberOfColumns];
                bool arrayStart = true;
                while (arrayStart == true)
                {
                    Console.WriteLine($"Введите число, exit или sum: ");
                    string Message = Console.ReadLine();
                    if (Message == "sum")
                    {
                        double arraySum = 0;
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            arraySum += myArray[i];
                        }
                        Console.WriteLine("Сумма: " + arraySum);
                    }
                    else if (Message != "sum" && Message != "exit")
                    {
                        byte[] myArrayCopi = new byte[myArray.Length + 1];
                        myArrayCopi[myArrayCopi.Length - 1] = byte.Parse(Message);
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            myArrayCopi[i] = myArray[i];
                        }
                        myArray = myArrayCopi;
                    }
                    else if (Message == "exit")
                    {
                        arrayStart = false;
                        break;
                    }
                    else Console.WriteLine($"Нет такой команды ");
                }
            }
        }
    }
