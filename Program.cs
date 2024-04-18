﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace cli_parking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            List<Vehicle> slots = new List<Vehicle>();
            slots.Capacity = 0;

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
                            vehicle.serialNumber = commands[1].ToUpper();
                            vehicle.colour = char.ToUpper(commands[2][0]) + commands[2].Substring(1);
                            vehicle.type = char.ToUpper(commands[3][0]) + commands[3].Substring(1);

                            if (slots.Capacity == 0)
                            {
                                Console.WriteLine("Sorry, there is no parking lot. Please create at least one first!");
                            }
                            else if (slots.Count == 0)
                            {
                                slots.Add(vehicle);
                                Console.WriteLine($"Allocated slot number: {slots.IndexOf(vehicle)+1}");
                            } 
                            else if (slots.Count <= slots.Capacity) {
                                var slotIndex = slots.Count;
                                var isNullExist = false;
                                foreach (var item in slots)
                                {
                                    if (item == null)
                                    {
                                        slotIndex = slots.IndexOf(item);
                                        isNullExist = true;
                                        break;
                                    }
                                }
                                if (isNullExist)
                                {
                                    slots[slotIndex] = vehicle;
                                } else {
                                    if (slotIndex >= slots.Capacity)
                                    {
                                        Console.WriteLine("Sorry, parking lot is full");
                                    } else {
                                        slots.Insert(slotIndex, vehicle);
                                    }
                                }
                                Console.WriteLine($"Allocated slot number: {slots.IndexOf(vehicle)+1}");
                            } else {
                                Console.WriteLine("Sorry, parking lot is full");
                            }

                            Console.WriteLine("==park command SUCCESS==");
                            break;
                        case "leave":
                            Console.WriteLine("==leave command is running==");
                            DateTime now = DateTime.Now;
                            var index = Int32.Parse(commands[1]) - 1;

                            var rentalTime = now - slots[index].getEntryTime();
                            var rentalTimeHour = rentalTime.Hours;
                            if (rentalTime.Seconds < 3600)
                            {
                                rentalTimeHour = 1;
                            }
                            Console.WriteLine($"Waktu sewa adalah {rentalTimeHour} jam");
                            slots[index] = null;
                            Console.WriteLine($"Slot number {commands[1]} is free");
                            break;
                        case "status":
                            Console.WriteLine("==status command is running==");
                            foreach (var item in slots.Select((data, index) => (data, index)))
                            {
                                if (item.data == null)
                                {
                                    Console.WriteLine((item.index+1) + "=>" + "NULL");
                                } else {
                                    Console.WriteLine((item.index+1) + "=>" + item.data.serialNumber + " " + item.data.colour + " " + item.data.type + " " + item.data.getEntryTime());
                                }
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
        protected DateTime entryTime = DateTime.Now;

        public DateTime getEntryTime()
        {
            return entryTime;
        }
    }

}
