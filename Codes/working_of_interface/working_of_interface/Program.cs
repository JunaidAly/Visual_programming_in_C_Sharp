using System;

namespace working_of_interface
{
    interface car
    {
        void bike_colour();
    }

    
    class bike : car
    {
        public void bike_colour()
        {
            
            Console.WriteLine("Bike colour is black");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bike bik = new bike();
            bik.bike_colour();
        }
    }
}
