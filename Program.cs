using System;

interface IMessage
{
    void End();
}

namespace CompanyA {
    class Message: IMessage {
      public virtual void End()
        {
            Console.WriteLine("Success !!!");
        }  
    }
    class Square : Message
    {
        public string name;
        private int width;
        private int height;

        public void SetDimension (int w, int h) {
            width = w;
            height = h;
        }
        public int CalculateArea () {
            return width * height;
        }

        public override void End()
        {
            base.End();
        }
    }
    class Location 
    {

        public string name;
        private double celsius = 0;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }

        public double Fahrenheit
        {
            get { return (celsius * 1.8) + 32; }
            set { celsius = (value - 32) * 5.0 / 9.0;}
        }

    }
}

namespace HelloProgram
{
    class Program {
        static void Test(int year, String name, String nationality) {
            Console.WriteLine ("His name is {0}", name);
            Console.WriteLine ("{0} {1}", getText(), year);
            Console.WriteLine ("He is {0}", nationality);
        }
        static String getText() {
            return "He was born in";
        }

        static void Main(){

            //class 1            
            Console.WriteLine("Hello World!");
            // Console.ReadKey();

            //class 2
            int year = 1990;
            string name = "Thomas";
            string nationality = "American";
            Test(year, name, nationality);

            //class 3
            CompanyA.Square a = new CompanyA.Square();
            a.name = "Paper";
            a.SetDimension(8, 11);

            CompanyA.Square b = new CompanyA.Square();
            b.name = "Computer Screen";
            b.SetDimension(16, 9);
            Console.WriteLine("Object " + a.name + " has area = " + a.CalculateArea() + " in^2");
            Console.WriteLine("Object " + b.name + " has area = " + b.CalculateArea() + " in^2");

            CompanyA.Message message = new CompanyA.Square();
            message.End();

            CompanyA.Location A = new CompanyA.Location();
            CompanyA.Location B = new CompanyA.Location();
            CompanyA.Location C = new CompanyA.Location();

            A.name = "New York";
            A.Fahrenheit = 56;

            C.name = "Bangkok";
            C.Celsius = 32;

            B.name = "Kiev";
            B.Fahrenheit = 32;

            double tempA = A.Fahrenheit;
            double tempB = B.Fahrenheit;

            Console.WriteLine(A.name + ": " + tempA);
            Console.WriteLine(B.name + ": " + tempB);
        }
    }
}