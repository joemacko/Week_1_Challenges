using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenges
{
    [TestClass]
    public class ChallengeWork
    {
        [TestMethod]
        public void Variables()
        {
            //1. Declare and initialize variables that hold your first name, last name, and age.

            string firstName = "Joe";
            Console.WriteLine(firstName);
            string lastName = "Macko";
            Console.WriteLine(lastName);
            int age = 32;
            Console.WriteLine(age);
        }

        [TestMethod]
        public void Array()
        {
            //2. Declare and initialize an array that holds  a collection of at least four of your favorite book or movie titles.

            string movieOne = "1. Anchorman ";
            string movieTwo = "2. The Shawshank Redemption ";
            string movieThree = "3. Pearl Harbor";
            string movieFour = "4. Harry Potter and the Deathly Hallows: Part 2 ";
            string[] favoriteMovies = { movieOne, movieTwo, movieThree, movieFour };
            Console.WriteLine(favoriteMovies [0]);

            foreach (string movie in favoriteMovies)
            {
                Console.WriteLine(movie);
            }
        }

        [TestMethod]
        public void List()
        {
            //3. Make a list to hold dates. Include on that list the current date and time.

            DateTime dob = new DateTime(1988, 10, 30);
            DateTime fratFound = new DateTime(1856, 4, 10);
            DateTime anniversary = new DateTime(2018, 10, 7);
            DateTime indepDay = new DateTime(1776, 7, 4);
            DateTime nowDateTime = DateTime.Now;

            List<DateTime> listDates = new List<DateTime>();
            listDates.Add(dob);
            listDates.Add(fratFound);
            listDates.Add(anniversary);
            listDates.Add(indepDay);
            listDates.Add(nowDateTime);
            Console.WriteLine(listDates[2]);

            // Console.WriteLine($"{list[0]} {list[2]}");
            // Extrapolation to pull items from list
            // Foreach loop to pull all items from list. Works best because it will pull everything and is dynamic if list changes.

        }

        [TestMethod]
        public void Operators()
        {
            //4. Write out to the Console the values calculated by your age variable and the number 7. Use each operator we covered in Operators.
            int age = 32;
            int ageSum = age + 7;
            Console.WriteLine(ageSum);
            int ageDiff = age - 7;
            Console.WriteLine(ageDiff);
            int ageProd = age * 7;
            Console.WriteLine(ageProd);
            double ageQuot = age / 7;
            Console.WriteLine(ageQuot);
            int ageRemainder = age % 7;
            Console.WriteLine(ageRemainder);
        }

        [TestMethod]
        public void Conditionals()
        {
            //5. Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            //Tip: You can just initialize this variable for now, it does not have to be actually given by a user.
            //a. If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            //b. If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
            //c. If the hours is greater than 4 but less than 8, output "Bummer"
            //d. For any other condition output "Oh man, get some sleep!"

            double hoursSlept = 7.5;

            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursSlept > 8)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursSlept > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }

        [TestMethod]
        public void SwitchCase()
        {
            //6. Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //a. Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.

            int rateDay = 7;

            switch (rateDay)
            {
                case 10:
                case 9: 
                    Console.WriteLine("Great");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Good");
                    break;
                case 6:
                case 5:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                case 3:
                    Console.WriteLine("Bad");
                    break;
                case 2:
                case 1:
                case 0:
                    Console.WriteLine(":(");
                    break;
                default:
                    Console.WriteLine("Please enter a whole number between 0-10");
                    break;
            }

        }
        
    }
}
