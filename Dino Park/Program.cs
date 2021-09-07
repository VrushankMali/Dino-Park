using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            //Park Menu to let the user know what a user can do
            System.Console.WriteLine("1: Add Dino");
            System.Console.WriteLine("2: Print Information");
            System.Console.WriteLine("3: Make Noise");
            System.Console.WriteLine("4: Age Up");
            System.Console.WriteLine("5: Remove Dino");
            System.Console.WriteLine("6: Exit");
            System.Console.WriteLine("Choose an option: ");     //Menu selection by taking user input
            int select = Convert.ToInt32(Console.ReadLine());

            while(select>=6)
            {
                if(select==1)
                {
                    addDino();  //Calling function to add more dino in the list
                }

                if (select==2)
                {
                    Dino.printInfo();   //Calling function to print info about specific dino
                }

                if (select==3)
                {
                    Dino.makeNoise();   //Calling function to make specific dino's noise
                }

                if (select==4)
                {
                    Dino.ageUp();   //Calling function to increase specific dino's age
                }

                if (select==5)
                {
                    removeDino();   //Calling function to remove a dino from the list
                }
            }
        }
    }
}
