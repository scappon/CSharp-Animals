using System.Collections;
using System;

public class GatherInput
{
    private ArrayList zoo {set; get;}

    public GatherInput(ArrayList zoo) => this.zoo = zoo;

    public void GetUserInput()
    {
         Console.WriteLine("Enter a number to select type to create:\n1. Dog\n2. Cat\n3. Teacher");
         int selection = 0;
         try
         {
            selection = Convert.ToInt32(Console.ReadLine());
         }
         catch (Exception)
         {
             Console.WriteLine("Bad input try again........");
             GetUserInput();
             return;
         }

            if (selection < 4 && selection > 0) {
                Console.WriteLine("Enter a name for your selection: ");
                var name = Console.ReadLine();

                if (selection == 1) 
                {
                    while (true)
                    {
                        Console.WriteLine("Is this Dog friendly? (y/n): ");
                        var friendly = Console.ReadLine();

                        if (friendly == "y")
                        {
                            zoo.Add(new Dog(true, name));
                            break;
                        }
                        else if (friendly == "n") 
                        {
                            zoo.Add(new Dog(false, name));
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Please enter y for yes or n for no");
                        }
                    }
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Enter how many mice this cat has killed: ");
                
                    while (true)
                    {
                        try
                        {
                            var miceKilled = Convert.ToInt32(Console.ReadLine());
                            zoo.Add(new Cat(miceKilled, name));
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Try again. Make sure to enter a number: ");
                        }
                    }
                }
                else if (selection == 3)
                {
                    Console.WriteLine($"Enter how old {name} is: ");
                
                    while (true)
                    {
                        try
                        {
                            var age = Convert.ToInt32(Console.ReadLine());
                            zoo.Add(new Teacher(age, name));
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Try again. Make sure to enter a number: ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Must enter number between 1 and 3");
                GetUserInput();
                return;
            }
    } 
}