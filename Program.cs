﻿using System;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    internal class Program
    {
        public static int EnemyHealth = 20, Health = 100, Damage, filament = 49;
        public static double armour = 10;
        public static double weapon = 0;
        public static double xp = 0;
        public static int pen = 0; //Using this for now, I'm sure we can change it later on^Josh

        static void Main(string[] args)
        {
            Start();
        }

        static void will()// method for will
        {
            enemy will;//calls enemy struct
            will.name = "Will";//sets enemy name
            will.enemyHealth = 25;//sets enemy health
            EnemyHealth = will.enemyHealth;//changes the global int for enemy health to the enemy you have made
        }

        static void Equiptment()
        {

            if (weapon == 0.5)
            {
                Console.WriteLine("You have no weapon");
            }

            else if (weapon == 1)
            {
                Console.WriteLine("You have weapon 1");
            }

            else if (weapon == 1.5)
            {
                Console.WriteLine("You have weapon 2");
            }

            else if (weapon == 2)
            {
                Console.WriteLine("You have weapon 3 (Highest Level)");
            }


            if (armour == 0.1)
            {
                Console.WriteLine("You have no Armour");
            }

            else if (armour == 0.5)
            {
                Console.WriteLine("You have Vaughn boots, maybe you should go tramping");
            }

            else if (armour == 1)
            {
                Console.WriteLine("You have Ginmail");
            }

            else if (armour == 1.5)
            {
                Console.WriteLine("You have weapon ResinRanger Rain Coat ");
            }

            else if (armour == 2)
            {
                Console.WriteLine("You have PLA Power Vest (Highest Level)");
            }



        }


        static void Start()
        {
            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin!\nSo you can go home and have a great weekend!");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            office();
        }

        //admin/office - item room
        static void office()
        {
            Console.Clear();
            Console.WriteLine("You are in the Office");
            Thread.Sleep(1000);
            Console.WriteLine("Your environmental impact of printing off rain forests of paper for your math exams, has enraged the office lady who appears to be a blob of glue and staplers for hands ");
            
            will();
            fight();

            Console.WriteLine("You feel light headed, you a door which leads out into the hallway.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "office":
                    Console.WriteLine("Your are already here\n");
                    office();
                    break;
                case "hallway":
                    hallway();
                    break;
                case "door":
                    hallway();
                    break;
            }
        }

<<<<<<< HEAD
=======
        static void hallway()
        {   
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Hallway");
            Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? ");
            Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground as there are better things to find (0)");
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);

            if (input == 1)
            {
                Console.WriteLine("You have picked up the pen");
                pen = 1;
            }

            else
            {
                pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                Console.WriteLine("You choice not to pick up the pen it probably wasn't important");
            }


            Console.WriteLine("You stand in the hallway, there is an closet, ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    hallway();
                    break;
                case "office":
                    office();
                    break;
                case "broom1":
                    broom1();
                    break;
                case "broom2":
                    broom2();
                    break;
                case "closet":
                    closet();
                    break;
            }
        }
>>>>>>> 32db03fdb06b4756626c7902d1bf36aa1b8177a8

        //Janitor Closet 
        static void closet()
        {
            Console.Clear();
            Console.WriteLine("You are in Janitor Closet");

            Console.WriteLine("You enter a dark gloomy room, Krissi appears from the shadows.");
            Console.WriteLine("Vaughn... Have you brought me a pen?? If you would like you see your boots again, I would a pen in return. \n I trust you would have grabbed one from the hallway");

            if (pen == 1)
            {
                Console.WriteLine("Thank you for grabbing my pen, you know I am a true pen thief, thank you");
                Console.WriteLine("Here are your special boots");
                armour = 0.5;
                Console.WriteLine("[YOU EQUPIED YOUR BOOTS]");
            }

            else
            {
                Console.WriteLine("Disappointing you didn't bing me a pen how about you go else where");
            }

            //Add function in here
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "closet":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    closet();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        //Boss Room
        static void broom1()
        {
            Console.Clear();
            Console.WriteLine("You are in BOSS ROOM 1 TEMPORARY NAME");
            Console.WriteLine("broom1 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom1":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom1();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        //Boss Room
        static void broom2()
        {
            Console.Clear();
            Console.WriteLine("You are in BOSS ROOM 2 TEMPORARY NAME");
            Console.WriteLine("broom2 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom2();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        static void hallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Hallway");
            Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? ");
            Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground as there are better things to find (0)");
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);

            if (input == 1)
            {
                Console.WriteLine("You have picked up the pen");
                pen = 1;
            }

            else
            {
                pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                Console.WriteLine("You choice not to pick up the pen it probaly wasn't important");
            }



            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    hallway();
                    break;
                case "office":
                    office();
                    break;
                case "broom1":
                    broom1();
                    break;
                case "broom2":
                    broom2();
                    break;
                case "closet":
                    closet();
                    break;
            }
        }
        static void printerRoom(){
            //welcome to the room ect
            Console.WriteLine("1. to make a Wepeon\n2. to make Armor");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("1. Plastic Saber - Low damage (25 Filliment)\n 2. Filament Fencer - medium damage (50 Filliment)\n3. Resin Rapier - highest Damage (100 filliment)");
                choice = Convert.ToInt32(Console.ReadLine());
                if ((choice == 1)||(filament <= 25)) 
                { 

                }
            }
            else if (choice == 2)
            {
                //what 
            }

        }
     

        static void fight()
        {
            
            int energy = 100, enemyEnergy = 100;
            do
            {
                Console.Clear();
                Console.WriteLine($"Your Health: {Health} | Your Energy: {energy} | Enemy Health: {EnemyHealth} | ");
                Console.WriteLine("Choose your move!:");
                attack();
                Thread.Sleep(2000);
                enemyAttack();
              
            } while ((Health > 0) && (EnemyHealth > 0));


            static void attack()    
            {
                int damage, hit, attack, hitChance;
                Random random = new Random();
                hit = random.Next(101);/// generate a random number between 1-100 this will be used to get the success or faliure of the hit
                Console.WriteLine("1: Strong hit\n2: Medium hit\n3: Low hit\n4: Rest");//this gives the user the option to select what type of attack they want to do
                attack = Convert.ToInt32(Console.ReadLine());
                switch (attack)
                {
                    case 1://this is the hardest attack to hit so it has the highest damage
                        damage = new Random().Next(15, 26); // Random damage between 15 and 25
                        hitChance = new Random().Next(1, 101); // Random hit chance between 1 and 100
                        if (hitChance <= 70) // 70% hit chance for strong attack
                        {
                            EnemyHealth -= damage;
                            Console.WriteLine($"You execute a strong attack and deal {damage} damage to the enemy!");
                        }
                        else
                        {
                            Console.WriteLine("Your strong attack missed!");
                        }
                        break;

                    case 2://this is the 2nd hardest attack to hit so it does the 2nd most damage the rest follow this pattern
                        damage = random.Next(10, 21); // Random damage between 10 and 20
                        hitChance = random.Next(1, 101); // Random hit chance between 1 and 100
                        if (hitChance <= 80) // 80% hit chance for medium attack
                        {
                            EnemyHealth -= damage;
                            Console.WriteLine($"You execute a medium attack and deal {damage} damage to the enemy!");
                        }
                        else
                        {
                            Console.WriteLine("Your medium attack missed!");
                        }
                        break;
                    case 3:
                        damage = random.Next(5, 16); 
                        hitChance = random.Next(1, 101);
                        if (hitChance <= 90) 
                        {
                            EnemyHealth -= damage;
                            Console.WriteLine($"You execute a low attack and deal {damage} damage to the enemy!");
                        }
                        else
                        {
                            Console.WriteLine("Your low attack missed!");
                        }
                        break;
                    case 4:
                        
                        break;
                }
            }
            static void enemyAttack() 
            { 
                
                int damage = new Random().Next(10, 21); // Random damage between 10 and 20
                
                Health -= damage;
                Console.WriteLine($"The enemy attacks and deals {damage} damage to you!");
               
            }
            
            
        }
    }
}
