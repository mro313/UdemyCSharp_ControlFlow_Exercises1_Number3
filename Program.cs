using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

namespace UdemyCSharp_ControlFlow_Exercises1_Number3
{
    class Program
    {
        static void Main(string[] args)
        {

            int userHeight;
            int userWidth;

            Console.WriteLine("Please enter the width of an image");
            userWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of an image");
            userHeight = Convert.ToInt32(Console.ReadLine());

            if(userWidth > userHeight)
            {
                Console.WriteLine("Your image's dimensions are (w x h): " + userWidth + " x " + userHeight + ". So it's in landscape mode");
            }

            else if(userHeight > userWidth)
            {
                Console.WriteLine("Your image's dimensions are (w x h): " + userWidth + " x " + userHeight + ". So it's in portrait mode");
            }

            else
            {
                Console.WriteLine("Your image isn't in landscape OR portrait mode!");
            }


        }   
    }
}
