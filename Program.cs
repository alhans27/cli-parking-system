using System;
using System.Collections.Generic;

namespace cli_parking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            List<Vehicle> slots = new List<Vehicle>();

            while (isTrue)
            {
                var command = Console.ReadLine();
                var commands = command.Split(" ");

                if (commands.Length > 0)
                {
                    switch (commands[0].ToLower())
                    {
                        case "create_parking_lot":
                            Console.WriteLine("==create command is running==");
                            slots.Capacity = Int32.Parse(commands[1]);
                            Console.WriteLine(slots.Capacity);
                            Console.WriteLine($"Created a parking lot with {slots.Capacity} slots");
                            break;
                        case "park":
                            Console.WriteLine("==park command is running==");
                            Vehicle vehicle = new Vehicle();
                            vehicle.serialNumber = commands[1];
                            vehicle.colour = commands[2];
                            vehicle.type = commands[3];

                            if (slots.Count < slots.Capacity)
                            {
                                slots.Add(vehicle);
                                Console.WriteLine($"Allocated slot number: {slots.IndexOf(vehicle)+1}");
                            } else {
                                Console.WriteLine("Sorry, parking lot is full");
                            }
                            Console.WriteLine("==park command SUCCESS==");
                            break;
                        case "leave":
                            Console.WriteLine("==leave command is running==");
                            break;
                        case "status":
                            Console.WriteLine("==status command is running==");
                            foreach (var item in slots)
                            {
                                Console.WriteLine(item.serialNumber + " " + item.colour + " " + item.type);
                            }
                            Console.WriteLine("==status command SUCCESS==");
                            break;
                        case "type":
                            Console.WriteLine("==type command is running==");
                            break;
                        case "registration_numbers":
                            Console.WriteLine("==registration_numbers command is running==");
                            break;
                        case "slot_number":
                            Console.WriteLine("==slot_number command is running==");
                            break;
                        case "exit":
                            Console.WriteLine("==exit command is running==");
                            isTrue = false;
                            break;
                    }
                }
            }
        }
    }

    class Vehicle
    {
        public string serialNumber;
        public string colour;
        public string type;
    }

}
