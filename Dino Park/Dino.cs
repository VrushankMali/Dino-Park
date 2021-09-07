using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_Park
{
    abstract class Dino
    {
        private
            string Name;    //For dino name
            int Age;        //For dino age
            int Noise;      //For dino noise/vocal
            double Weight;  //For dino weight

        public
            void printInfo()    //Function to print info about specific dino
            {

            }
            void makeNoise()    //Function to make dino's noise
            {

            }
            int ageUp()         //Function to increase dino's age
            {

                return 0;
            }
    }
}
