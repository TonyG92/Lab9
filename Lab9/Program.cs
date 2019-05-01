using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> people = new List<string> { "Tony", "Goku", "Piccolo", "Vegeta", "Beerus" };
            List<string> food = new List<string> { "Pasta", "Steak", "Cheeseburgers", "Salad", "Sushi" };
            List<string> hometown = new List<string> { "Saint Clair Shores", "Planet Vegeta", "Planet Namek", "Planet Vegeta", "Universe 7" };
            List<string> color = new List<string> { "Green", "Red", "Blue", "Black", "Gold" };
            string response = "y";

            Console.WriteLine("Welcome to our C# class. ");

            while (response == "y")
            {
                int count = people.Count;




                Console.WriteLine("Would you like to learn about a student or add a student? (add or learn) ");
                string addLearn = ValidateAddStudent();
                if(addLearn == "learn")
                {
                    Console.WriteLine($"Which student would you like to learn more about? (enter a number 1-{count}): ");
                    int number = GetValidNumber(count);

                    for (int i = 0; i < people.Count; i++)
                    {


                        if (i == number - 1)
                        {
                            Console.WriteLine($"Student {number} is {people[i]} ");
                            Console.WriteLine($"What Would you like to know about {people[i]}? (Enter hometown or favorite food or favorite color)");

                            string choice = Console.ReadLine();

                            try
                            {
                                if (choice == "hometown")
                                {
                                    Console.WriteLine($"{people[i]} is from {hometown[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes: ");

                                    string selection = Console.ReadLine();
                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{people[i]}'s favorite food is {food[i]} ");

                                        Console.WriteLine("Would you like to know more? Enter yes: ");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{people[i]}'s favorite color is {color[i]} ");
                                        }
                                    }

                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }


                                }
                                else if (choice == "favorite food")
                                {
                                    Console.WriteLine($"{people[i]}'s favorite food is {food[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes or no: ");
                                    string selection = Console.ReadLine();

                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{people[i]} is from {hometown[i]} ");

                                        Console.WriteLine("Would you like to know more? Enter yes: ");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{people[i]}'s favorite color is {color[i]} ");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }

                                }
                                else if (choice == "favorite color")
                                {
                                    Console.WriteLine($"{people[i]}'s favorite color is {color[i]}");
                                    Console.WriteLine("Would you like to know more? Enter yes or no: ");
                                    string selection = Console.ReadLine();

                                    if (selection == "yes")
                                    {
                                        Console.WriteLine($"{people[i]} is from {hometown[i]} ");

                                        Console.WriteLine("Would you like to know more? Enter yes: ");
                                        selection = Console.ReadLine();
                                        if (selection == "yes")
                                        {
                                            Console.WriteLine($"{people[i]}'s favorite food is {food[i]} ");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanks");
                                        break;
                                    }
                                }

                                else
                                {
                                    throw new Exception("INVALID INPUT, please input hometown or favorite food!!!");
                                }


                            }
                            catch (Exception e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            Console.WriteLine("Do you want to start again? (y or no) ");
                            response = Console.ReadLine();
                        }








                    }
                }
                else
                {
                    string input;

                    Console.WriteLine("Please enter person's name: ");
                    people.Add(input = ValidateNewStudent("Please enter a proper name: "));

                    Console.WriteLine("Please enter person's hometown: ");
                    hometown.Add(input = ValidateNewStudent("Please enter a proper hometown: "));

                    Console.WriteLine("Please enter person's favorite food: ");
                    food.Add(input = ValidateNewStudent("Please enter a type of food: "));

                    Console.WriteLine("Please enter person's favorite color: ");
                    color.Add(input = ValidateNewStudent("Please enter an actual color: "));

                    Console.WriteLine("Person has been added! Thank you!");









                }
                









               

            }
        }

        public static int UserNumber(int number, int count)
        {
            if (number > count || number < 1)
            {
                throw new Exception($"Number must be between 1 and {count}");
            }
            else
            {
                return number;
            }

        


        }

        public static int GetValidNumber(int count)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());
                UserNumber(number,count);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number 1-5");
                return GetValidNumber(count);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return GetValidNumber(count);
            }
        }

        public static string ValidateAddStudent()
        {
            string word = Console.ReadLine();
            if(word == "add")
            {
                return word;
            }
            else if(word == "learn")
            {
                return word;
            }
            else if(string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Type add or learn: ");
                return ValidateAddStudent();
            }
            else
            {
                Console.WriteLine("Type add or learn: ");
                return ValidateAddStudent();

            }
        }

        public static string ValidateNewStudent(string message)
        {
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine(message);
                return ValidateNewStudent(message);
            }
            else
            {
            // good job u did it right
                return word;
            }
        }





















    }





}
