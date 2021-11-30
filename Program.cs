using System;

namespace Personalregister
{

    class Program
    {
        public static void Main(string[] args)
        {

            var meny = new Meny();
            meny.Run();
            Console.Write("Tryck i så fall på valfri tangent");
            Console.ReadKey(true);
        }
    }
    class Meny
    {
        public object[] namnObj = new object[5]; 

        public void Run()
        {
            Console.WriteLine("Personallista\n");

            int menyval = 0; 
            do
            {
                Console.WriteLine("MENYVAL: tryck på respektive tangent för att gå vidare\n");
                Console.WriteLine("[1] Lägg till namn och lön");
                Console.WriteLine("[2] Skriv ut namn med respektive lönebelopp");
                Console.WriteLine("[3] Avsluta programmet");


                menyval = int.Parse(Console.ReadLine()); 

                switch (menyval)
                {
                    case 1:
                        add_namn();
                        break;
                    case 2:
                        print_namn();
                        break;
                    case 3:
                        Console.WriteLine("Vill du verkligen avsluta programmet?");
                        break;
                    default:
                        Console.WriteLine("Var vänlig välj ett menyval från listan");
                        break;
                }
            } while (menyval != 3);



        }



        public void add_namn() 
        {


            for (int i = 0; i < namnObj.Length; i++) 
            {
                Console.WriteLine("Lägg till ett namn med respektive lönebelopp " + i + " av fem platser är ifyllda");

                try
                {

                    string namn = Console.ReadLine();
                    namnObj[i] = namn; 
                }
                catch (Exception)
                {
                   
                }

                if (i == namnObj.Length - 1) 
                {
                    Console.WriteLine("Personallistan är full, du kan inte lägga till fler namn");

                    
                }
            }

        }

        public void print_namn()
        {

            for (int i = 0; i < namnObj.Length; i++) 
            {
                Console.WriteLine(namnObj[i]);
            }
            
        }





    }

}