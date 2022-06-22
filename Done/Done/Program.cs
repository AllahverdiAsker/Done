using System;
using System.Collections.Generic;

namespace Done
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Exam> exams = new List<Exam>();

            string ac = "";


            for (; ; )
            {
                Console.WriteLine("Exam Sayi");
                ac = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ac))
                {
                    break;
                }
            }


            bool search = int.TryParse(ac, out int inputac);



            if (search)

            {
                for (int i = 0; i < inputac; i++)
                {

                    string aass = "";
                    for (; ; )
                    {
                        Console.Write("Enter Student");
                        aass = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(aass))
                        {
                            break;
                        }
                        Console.WriteLine("Wrong - Try Again");
                    }

                    string asss = "";
                    for (; ; )
                    {
                        Console.Write("Subject");
                        asss = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(asss))
                        {
                            break;
                        }
                        Console.WriteLine("Try Again");
                    }

                    Console.Write("Point");
                    string a = "";
                    double aa;
                    for (; ; )
                    {

                        a = Console.ReadLine();

                        if (double.TryParse(a, out aa))
                        {
                            break;
                        }
                        Console.WriteLine("Try Again");
                    }

                    string b = "";
                    DateTime bb;
                    for (; ; )
                    {
                        Console.Write("Exam Begin");
                        b = Console.ReadLine();

                        if (DateTime.TryParse(b, out bb))
                        {
                            break;
                        }
                        Console.WriteLine("Try Again");
                    }

                    string c = "";
                    DateTime cc;
                    for (; ; )
                    {
                        Console.Write("Exam end");

                        if (DateTime.TryParse(c, out cc) && bb > cc)
                        {
                            break;
                        }
                        Console.WriteLine("Try Again");
                    }

                    Exam exam = new Exam(bb, cc)
                    {
                        Point = aa,
                        Student = aass,
                        Subject = asss
                    };

                    exams.Add(exam);
                    Console.WriteLine(" Exam Added ");

                }


            }

        }

    }
    

}
