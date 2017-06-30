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

            //Console.WriteLine("How many ones do you want to donate?");
            //int ones = int.Parse(Console.ReadLine());
            //int oneDollar = 1 * ones;
            //Console.WriteLine("How many fives do you want to donate?");
            //int fives = int.Parse(Console.ReadLine());
            //int fiveDollar = 5 * fives;
            //Console.WriteLine("How many tens do you want to donate?");
            //int tens = int.Parse(Console.ReadLine());
            //int tenDollar = 10 * tens;
            //Console.WriteLine("How many twenties do you want to donate?");
            //int twenties = int.Parse(Console.ReadLine());
            //int twentyDollar = 20 * twenties;
            //Console.WriteLine("How many fifties do you want to donate?");
            //int fifties = int.Parse(Console.ReadLine());
            //int fiftyDollar = 50 * fifties;
            //Console.WriteLine("How many hundreds do you want to donate?");
            //int hundreds = int.Parse(Console.ReadLine());
            //int hundredDollar = 100 * hundreds;
            //Console.WriteLine("How many quarters do you want to donate?");
            //double quarters = double.Parse(Console.ReadLine());
            //double quarterCoin = .25d * quarters;

            //double donationAmount = oneDollar + fiveDollar + tenDollar + twentyDollar + fiftyDollar + hundredDollar + quarterCoin;

            //Console.WriteLine("Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //string email = Console.ReadLine();
            //Console.WriteLine("Fiscal Year: ");
            //string fiscalYear = Console.ReadLine();
            //Console.WriteLine(name);
            //Console.WriteLine(address);
            //Console.WriteLine(email);
            //Console.WriteLine(fiscalYear);
            //Console.WriteLine("Donation Amount: " + donationAmount)

            //Console.WriteLine("How many A's did you receive?");
            //int As = int.Parse(Console.ReadLine());
            //int Apoints = 4 * As;

            //Console.WriteLine("How many B's did you receive?");
            //int Bs = int.Parse(Console.ReadLine());
            //int Bpoints = 3 * Bs;

            //Console.WriteLine("How many C's did you receive?");
            //int Cs = int.Parse(Console.ReadLine());
            //int Cpoints = 2 * Cs;

            //Console.WriteLine("How many D's did you receive?");
            //int Ds = int.Parse(Console.ReadLine());
            //int Dpoints = 1 * Ds;

            //int totalPoints = Apoints + Bpoints + Cpoints + Dpoints;

            //int totalGradesReceived = As + Bs + Cs + Ds;

            //double gpa = totalPoints / totalGradesReceived;

            //Console.WriteLine(gpa);

            //limit the number of decimal places to 2 (X.XX)

            //decimal a = 52.0m / 35.0m;
            //Console.WriteLine(Math.Round(a, 2));

            //Console.WriteLine(a); // this does not give me the answer I'm looking for but can't figure it out

        //    calculate the GPAs of 7 students and based on their GPAs, calculate the class average.
        //    int numberOfStudents = 7;
        //double totalGpas = gpaStudent1 + gpaStudent2 + gpaStudent3 + gpaStudent4 + gpaStudent5 + gpaStudent6 + gpaStudent7;
        //double gpasAverage = totalGpas / numberOfStudents
        //    Console.WriteLine(gpasAverage);

        //    //known variables
        //    double superSwim = 15d;
        //    double beTheShark = 17.50d;
        //    double babyBubbles = 4.75d;

        //    //ask the buyer how many of each tshirt they want
        //    //consider adding an intro statement
        //    Console.WriteLine("How many Super Swim tshirts ($15 each) would you like to purchase?");
        //    int numberOfSuperSwim = int.Parse(Console.ReadLine());

        //    Console.WriteLine("How many Be the Shark tshirts ($17.50 each) would you like to purchase?");
        //    int numberOfBeTheShark = int.Parse(Console.ReadLine());

        //    Console.WriteLine("How many Baby Bubbles tshirts ($4.75 each) would you like to purchase?");
        //    int numberOfBabyBubbles = int.Parse(Console.ReadLine());

        //    //calculate total number of shirts
        //    int totalShirts = numberOfSuperSwim + numberOfBeTheShark + numberOfBabyBubbles;

        //    //calculate the subtotal
        //    double superSwimTotalCost = superSwim * numberOfSuperSwim;
        //    double beTheSharkTotalCost = beTheShark * numberOfBeTheShark;
        //    double babyBubblesTotalCost = babyBubbles * numberOfBabyBubbles;

        //    double subTotal = superSwimTotalCost + beTheSharkTotalCost + babyBubblesTotalCost;

        //    //calculate the grand total
        //    double grandTotal = subTotal * .08 + subTotal;

        //    //print receipt
        //    Console.WriteLine("Total Shirts: " + totalShirts);
        //    Console.WriteLine("Subtotal: " + subTotal);
        //    Console.WriteLine("Grand Total (0.08% sales tax): " + grandTotal);








        }
    }
}
