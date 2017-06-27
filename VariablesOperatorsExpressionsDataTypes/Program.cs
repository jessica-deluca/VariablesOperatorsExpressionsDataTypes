using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressionsDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////initializing new name variable
            //string name = "Mike";
            ////printing the value of name to console
            //Console.WriteLine(name);
            ////entering new assignment for name
            //name = "Daniel";
            ////printing the new value of name to console
            //Console.WriteLine(name);
            ////initializing new birthMonth variable using camelcasing
            //string birthMonth = "August";
            //Console.WriteLine(birthMonth);

            //int age = 65;
            //string why = "because I said so";
            //char firstInitial = 'L';

            ////floating point types
            //float floatNumber = 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);

            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);

            ////asking a question... is jessica younger than sam? true
            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //Console.WriteLine("What is the name on the reservation?");
            //string reserveName = Console.ReadLine();

            ////start with (), then move out; turn string into int
            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            ////string+int will always equal a string
            //double amountEach = 13.53d;
            //double totalBill = numberOfPeople * amountEach;
            //Console.WriteLine("Reservation: " + reserveName);
            //Console.WriteLine("Total Due: $" + totalBill);

            //double recipeCups = 7d;
            //double cupsAdded = 2d;
            //double cupsNeeded = recipeCups - cupsAdded;
            //Console.WriteLine(cupsNeeded);

            //double amountOnHand = 29d;
            //double updatedAmount = 41d;
            //double amountReceived = updatedAmount - amountOnHand;
            ////Console.WriteLine(amountReceived);

            //double boxCost = 3d;
            //double amountHave = 12d;
            //double numberBoxes = amountHave / boxCost;
            //Console.WriteLine(numberBoxes);

            Console.WriteLine("How many ones do you want donate?");
            int ones = int.Parse(Console.ReadLine());
            int oneDollar = 1 * ones;
            Console.WriteLine("How many fives do you want donate?");
            int fives = int.Parse(Console.ReadLine());
            int fiveDollar = 5 * fives;
            Console.WriteLine("How many tens do you want donate?");
            int tens = int.Parse(Console.ReadLine());
            int tenDollar = 10 * tens;
            Console.WriteLine("How many twenties do you want donate?");
            int twenties = int.Parse(Console.ReadLine());
            int twentyDollar = 20 * twenties;
            Console.WriteLine("How many fifties do you want donate?");
            int fifties = int.Parse(Console.ReadLine());
            int fiftyDollar = 50 * fifties;
            Console.WriteLine("How many hundreds do you want donate?");
            int hundreds = int.Parse(Console.ReadLine());
            int hundredDollar = 100 * hundreds;
            Console.WriteLine("How many quarters do you want donate?");
            float quarters = float.Parse(Console.ReadLine());
            float quarterCoin = .25f * quarters;

            float donationAmount = oneDollar + fiveDollar + tenDollar + twentyDollar + fiftyDollar + hundredDollar + quarterCoin;

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Fiscal Year: ");
            string fiscalYear = Console.ReadLine();
            Console.WriteLine(name + "" + "" + address + "" + "" + email + "" + "" + fiscalYear + "" + "Donation Amount: " + donationAmount);





        }
    }
}
