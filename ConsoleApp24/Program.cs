using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 400; i < 599; i++)
            {

                int tal1 = i % 10;
                int tal2 = (i / 10) % 10;
                int tal3 = i / 100;



                if (tal1 != tal2 && tal1 != tal3 && tal2 != tal3 && tal1 != 0 && tal2 != 0 && tal3 != 0)
                {
                    StreamWriter Stream = null;
                    String UdFil = @"C: \Users\Jespe\Desktop\talmellem.txt";

                    try
                    {
                        Stream = new StreamWriter(UdFil, true); // open file output - da der står true vil den ikke overskrive tal men tilføje tal.
                        // stod der ikke true vil den overskrive hele tiden og kun det sidste tal ville komme frem altså 598

                        Stream.Write($@"{i}, ");    // laver comma seperatet value på samme linje

                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.ToString());
                        Console.ReadLine();
                    }

                    finally
                    {
                        if (Stream != null)
                            Stream.Close();// close file

                    }

                }
            }

        }   
    }
}