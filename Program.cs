namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise1
            Console.WriteLine("Insert first number (a1):");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number (a2):");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");//br
            Console.WriteLine(" Value of a1: " + a1);
            Console.WriteLine(" Value of a2: " + a2);            
            Console.WriteLine(" ");//br
            Console.WriteLine("Enter a new value for a1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a new value for a2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");//br            
            Console.WriteLine(" New value of a1: " + a1);
            Console.WriteLine(" New value of a2: " + a2);

            Console.WriteLine(" ");//br

            //exercise2
            Console.WriteLine("Enter your year of birth:");
            int ageYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");//br
            Console.WriteLine(" your year of birth is " + ageYear);
            Console.WriteLine(" ");//br

            //exercise3
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");//br
            Console.WriteLine(" Welcome to the system " + firstName + " " + lastName);
            Console.WriteLine(" ");//br

            //exercise4
            Console.WriteLine("-HackerU Shop-");
            Console.WriteLine("Please enter your choice, which product would ytou like to buy?");
            Console.WriteLine("-Milk");
            Console.WriteLine("-Chocolate");
            Console.WriteLine("-Apple");
            string choise = Console.ReadLine();           
            Console.WriteLine("Thank you for buying " + "" + choise + "");
            Console.WriteLine(" ");//br

            //exercise5
            Console.WriteLine("Please enter year:");
            int newYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter month:");
            int newMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter day:");
            int newDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");//br

            Console.WriteLine(newDay + "." + newMonth + "." + newYear);
            Console.WriteLine(" ");//br
            Console.WriteLine(newDay + "-" + newMonth + "-" + newYear);
            Console.WriteLine(" ");//br
            Console.WriteLine(newDay + @"\" + newMonth + @"\" + newYear);
            Console.WriteLine(" ");//br
            
        }
    }
}