using System;
using System.IO;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
       static List<string> records = new List<string>();

        static void addPatient()
        {
            Console.WriteLine("######## Add ID  ########");

            Console.WriteLine("######## Add Name  ########");

            Console.WriteLine("######## Add Check In  ########");

            Console.WriteLine("######## Add Assigned Personal ########");
        }

        static void getPatient()
        {
            Console.WriteLine("######## Please enter ID ########");

            string id = Console.ReadLine();

            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assign1/Question1/listOfPatients.txt");
            
                line = sr.ReadLine();

                while (line != null)
                {
                    records.Add(line);
                 
                    line = sr.ReadLine();
                }

                 foreach(string el in records)
                {
                        Console.WriteLine("Arr " + el);
                }
                
                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        static void displayPatients()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assign1/Question1/listOfPatients.txt");
            
                line = sr.ReadLine();
                
                while (line != null)
                {
                    Console.WriteLine(line);
                 
                    line = sr.ReadLine();
                }
                
                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }

        static void setOptions()
        {
            string option;
            Console.WriteLine("###### Press S for search, Press C for create Record, Press D for Display all records #######");

            option = Console.ReadLine();

            switch(option.ToUpper()) 
            {
            case "S":
                getPatient();
                break;
            case "C":
                addPatient();
                break;
            case "D":
                displayPatients();
                break;    
            default:
                // code block
                break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("######## Welcome Patient App Record ########");

            string answer = "";

            while(answer != "no")
            {
                setOptions();

                Console.WriteLine("######## Would you to continue ? (yes / no) ########");
                answer = Console.ReadLine();
            }
        }

    }
}
