using System;

namespace stu
{
    class epikGamer
    {
        public string name;
        public string gender;
        public float age;
        public string specIn;
        public float exp = 0f;

        public static void gamerMove()
        {
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Which game would you like to play?:");
            Console.WriteLine("1. Dying Light\n2. Far Cry New Dawn\n3. Ghostrunner");

            int games = Convert.ToInt32(Console.ReadLine());
            switch (games)
            {
                case 1:
                    {
                        Console.WriteLine("So you have chosen to play Dying Light");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("So you have chosen to play Far Cry New Dawn");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("So you have chosen to play Ghostrunner");
                        break;
                    }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            epikGamer character1 = new epikGamer();
            Console.WriteLine("Assign a name to your character: " );
            character1.name = Console.ReadLine();

            Console.WriteLine("Insert an age: ");
            character1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your gender?\n 1. Male\n 2. Heterosexual Female\n 3. Apache Attack Helicopter");
            character1.gender = Console.ReadLine();
            switch (Convert.ToInt32(character1.gender))
            {
                case 1:
                    {
                        Console.WriteLine("The gender you have chosen is Male");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The gender you have chosen is Female");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("The gender you have chosen is Apache Attack Helicopter");
                        break;
                    }
            }

            Console.WriteLine("The character you have built looks like this:\nName: " + character1.name + "\nAge: " + character1.age + "\nGender: " + character1.gender);
            
            Console.WriteLine("What type of game do you specialize in?:\n1. FPS\n2. RPG\n3. Adventure\n4. Action\n5. Racing\n6. Stealth\n7. Horror");
            character1.specIn = Console.ReadLine();
            switch (Convert.ToInt32(character1.specIn))
            {
                case 1:
                    {
                        Console.WriteLine("You specialize in FPS games so you perform better in the FPS category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You specialize in RPG games so you perform better in the RPG category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You specialize in Adventure games so you perform better in the Adventure category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("You specialize in Action games so you perform better in the Action category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("You specialize in Racing games so you perform better in the Racing category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("You specialize in Stealth games so you perform better in the Stealth category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("You specialize in Horror games so you perform better in the Horror category of games. Your starting EXP is " + character1.exp);
                        break;
                    }
            }

            Console.WriteLine("--------------------------------------------------------------------------");

            epikGamer.gamerMove();

            Console.ReadKey();
        }
    }
}
