using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace classes_sharp
{

    public class MyExceptionAverage : ApplicationException
    {

        private string message;
        public MyExceptionAverage()
        {
            message = "Incorrect average";
        }
        public override string Message
        {
            get { return message; }

        }

    }

    public class MyExceptionAge : ApplicationException
    {

        private string messageav;
        public MyExceptionAge()
        {
            messageav = "Incorrect age";
        }
        public override string Message
        {
            get { return messageav; }

        }
    }
    class Student
    {

        string fname;
        string lname;
        int age;
        uint avg;
        

        public Student() { }
        public Student(string fn, string ln, int a, uint av)
        {
            fname = fn;
            lname = ln;
            age = a;
            avg = av;

        }

        public void show()
        {
            WriteLine($"{lname} {fname} {age} {avg} ");
        }

        public void setFname()
        {
            WriteLine($"enter the name: ");
            fname = ReadLine();
        }

        public void setAge()
        {
            WriteLine("Enter age: ");
            int num = int.Parse(ReadLine());
            while (num < 18)
            {
                
                try
                {
                    if (num < 18)
                    {
                        throw new MyExceptionAge();
                    }
                }
                catch (MyExceptionAge ex)
                {

                    WriteLine(ex.Message);
                    WriteLine("Enter age: ");
                    num = int.Parse(ReadLine());
                }
            }
            age = num;
        }

        public void createStudent()
        {
            WriteLine("Enter last name: ");
            string ln;
            ln = ReadLine();
            lname = ln;

            WriteLine("Enter name: ");
            string n;
            n = ReadLine();
            fname = n;

            setAge();

            WriteLine("Enter average: ");
            uint anum = uint.Parse(ReadLine());
            while (anum > 12)
            {
                
                try
                {
                  
                    if (anum > 12)
                        throw new MyExceptionAverage();

                }
                catch (MyExceptionAverage e)
                {
                    WriteLine(e.Message);
                    WriteLine("Enter average: ");
                    anum = uint.Parse(ReadLine());
                }
            }
            avg = anum;


        }

        public string getFname()
        {
            return fname;
        }

        public override string ToString()
        {
            return $"{lname} {fname} {age} {avg} ";
        }

    }



    internal class Program
        {

            static void Main(string[] args)
            {
            Student st1 = new Student();
            try
            {
                st1.createStudent();
                WriteLine(st1);
            }
            catch (Exception exc)
            {
                WriteLine(exc);
            }
            finally
            {
                WriteLine("End of programm");
            }
            





            }
        }
    

}