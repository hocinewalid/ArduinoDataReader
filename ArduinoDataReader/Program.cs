using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM6"; // choose your COM port 
            myport.Open();

            while (true)
            {

                String information = myport.ReadLine();
                Console.WriteLine(information);


            }

        }
    }
}