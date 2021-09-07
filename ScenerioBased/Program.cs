using System;

namespace ScenerioBased
{
    class Program
    {
        static void Main(string[] args)
        {
            Zensar obj = new Zensar();
            obj.show();
            obj.nestedif();
        }
    }

    public class Zensar
    {
        int Empage=20;
        public void show()
        {

            Console.WriteLine("**********If else**********");

            if (Empage >= 20)
            {
                Console.WriteLine("He is eligible for Drive");
            }
            else
            {
                Console.WriteLine("He is not eligible for Drive");

            }
        

        }

        public void nestedif()
        {
            string expertis = ".NET";

            //Console.WriteLine("Enter your Expertis  Domain:");
            //string expertis = Console.ReadLine();


            //Console.WriteLine("Enter your Experience in years:");
            //int Experienceinyrs = Convert.ToInt32(Console.ReadLine());

             int Experienceinyrs = 5;

            Console.WriteLine("**********Nested If**********");

            if (expertis == ".NET")
            {

                if (Experienceinyrs >= 2)
                {
                    Console.WriteLine("He is eligible candidate for .NET Developer Profile");

                }
                else
                {
                    Console.WriteLine("He is not eligible candidate for .NET Developer Profile");
                }


            }
            
        }
    
    }


}
