using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ThiagoG_Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* Since we had to create three objects, I have decided to create a method called CreateDogFood
             * to generate the dogFood. Therefore,I called the method 3 times passing different parameters. 
             * It is probably redundant , but I wanted to give it a try
             */

            DogFood meGusta = CreateDogFood("Me Gusta",5.3);
            DogFood fatHappyDog = CreateDogFood("Fat Happy Dog", 8.32);
            DogFood fancyPuppy = CreateDogFood("Fancy Puppy", 12.43);

            /// Still need to create banner///////
            PrintCompanyBanner(meGusta,fatHappyDog,fancyPuppy);
            UpdateNumCans(meGusta);
            UpdateNumCans(fatHappyDog);
            UpdateNumCans(fancyPuppy);

            PerformAction(meGusta,fatHappyDog, fancyPuppy);

        }
        /* -----------------------CreateDogFood Explanation----------------------------------------
         * The idea of this method is to  instance the objected using the class DogFood. It has two
         * parameters that will be assigned to the class properties
         */
    
        static DogFood CreateDogFood(string brandName,double unitPrice) { 
            DogFood dogFoodObj = new DogFood(brandName, unitPrice);
            return dogFoodObj;
        }
        /*-------------------PrintCompanyBanner Explanation-----------------------
         * The method assigns the strings variables that will be in the initial banner, including the banner horizontal border
         * Then, it calls the WriteLines to print the banner where the formating size of the empty space was calculated 
         * using the formula (81 -variable length)/2 to center the message
         * 
         * In the second banner, a forEach method is called to iterate over the dogFood array to print the 1 line per dogFood
         * and priting its BrandName and CanUnitPrice
         * 
         * I used some WriteLine(\n) and WriteLine() just to add some space between the console prompts 
         */
        static void PrintCompanyBanner(params DogFood[] dogFood)
        {
            string companyName = "Kika";
            string border = new string('*', 81);
            string headingMessage = "Please see below the Dog Food we have available and place your order!";
            
            WriteLine(border);
            WriteLine("*{0,25}Welcome to {1} Online Store!{0,25}*","",companyName);
            WriteLine("*{0,5}{1}{0,5}*", "",headingMessage);
            WriteLine(border);
            WriteLine();

            WriteLine(border);
            WriteLine("*{0,12}Please see below the dog food availables in our store!{0,13}*","");
            foreach (DogFood food in dogFood) {
                WriteLine("*{0,12}Can Unit Price for {1,-15}: {2,8:C}{0,23}*","",food.BrandName,food.CanUnitPrice);
            }
            WriteLine(border);
            WriteLine("\n\n\n");
            WriteLine("Lets start by entering the number of cans needed for each product.");
            WriteLine();


        }
        /* ---------------------UpdateNumCans Explanation---------------------------------------------
         * Method will print the Brand Name and Unit Price, and ask for the users input to be stored in
         * the variable. I added a Try Catch block to prevent run time errors if an invalid input is entered 
         * and used a recursive method to force user to enter a valid amount of cans*/
        static void UpdateNumCans(DogFood anyDogFood) {
            WriteLine();
            WriteLine($"Brand Name: {anyDogFood.BrandName}");
            WriteLine($"Can Unit Price: {anyDogFood.CanUnitPrice:C}");
            Write($"Please enter the number of {anyDogFood.BrandName} cans needed: ");
            try {
                anyDogFood.NumCans = int.Parse(ReadLine());
            } catch {
                Clear();
                WriteLine("Please enter a valid number of Cans!");
                UpdateNumCans(anyDogFood);
            }
        } 
        /* 
         * To take advantage of loops, instead of assigning each DoogFood as parameter, I though it would be better
         * to add the DogFood as an array of parameters in each of the methods below.
         */
        
        /* ------------------- PerformAction Explanation ---------------------------------------------
         * A use switch case was used instead of if/else statement for a better code redability.
         * Besides, since the Case is parsed as String, there is no need to convert the Readline to another
         * tipe of variable.
         * A default option was added with the PerformAction as a recursive method to ask the user 
         * to enter an option a valid option in case one of them is not selected
         */
        static void PerformAction(params DogFood[] dogFood) {
            WriteLine();
            WriteLine("Press 1 for View Order");
            WriteLine("Press 2 for Update Order");
            WriteLine("Press 3 for quitting the application");
            Write("Please enter the selected option: ");
            string selectedOption = ReadLine();
            

            switch(selectedOption) {
                case "1":
                    ViewOrder(dogFood);
                    break;
                case "2":
                    UpdateOrder(dogFood);
                    break;
                case "3":
                    WriteLine("Thank you for ordering dog foods. Good Bye!");
                    break;
                default:
                    Clear();
                    WriteLine("Please enter a valid option!");
                    PerformAction(dogFood);
                    break;
            }
        }
        /*-------------------------------ViewOrder Explanation--------------------------------------
         * The ComputedOrderSummary is assigned to the dueAmount variable, because it returns the totalAfterDiscount.
         * The other two variables (totalBeforeDiscount and discountAmount) do not need to be assigned as they are already
         * an output from the method
         * The method then performs a loop in the array to display each one of the DogFood objects and its properties.
         * an empty Writeline was added just to provide a space between each DogFood displayed
         * Then, outside the loop, the Writeline is called to display the 3 amounts variables, and call the Perform Action Again
         */
        static void ViewOrder(params DogFood[] dogFoods) {
            
            double dueAmount = ComputedOrderSummary(out double totalBeforeDiscount ,out double discountAmount,dogFoods);
            WriteLine();
            string border = new string('*', 50);
            WriteLine(border);
            foreach (DogFood food in dogFoods) {
                WriteLine(food);
                WriteLine("{0,0}{0,49}", "*");
            }
            WriteLine(border);
            WriteLine($"{"*",-10}Total Purchase Amount: {totalBeforeDiscount,-16:C}*\n{"*",-10}Total Discount: {discountAmount,-23:C}*\n{"*",-10}Total Amount Due: {dueAmount,-21:C}*");
            WriteLine(border);
            PerformAction(dogFoods);
        }
        /* -------------------UpdateOrder Explanation----------------------------
         *  A variable i is assigned as 1 so it is the first option button that the user might select once the method is called.
         *  A foreach loop iterates over the array of params to print the options the user can select based on the DoogFoods.
         *  The userSelection is assigned to the number that the user entered.
         *  I had to add an try/catch statement to make sure that user would only select from the range of options available. 
         *  If he don't a prompt will be sent to the console asking to enter a valid number and recall the method again.
         *  Since the array length start with the index 0, the UpdateNumCans will be called selecting the correct DogFood.
         *  Ex: Option 1 is meGusta but in array meGusta would be dogFoods[0]
         */
        static void UpdateOrder(params DogFood[] dogFoods) {
            int i = 1;
            WriteLine();
            foreach (DogFood food in dogFoods) { 
                WriteLine($"Press {i} for {food.BrandName}");
                i++;
            }
            try
            {
                Write($"Please select from option 1 to {i-1}: ");
                int userSelection = int.Parse(ReadLine());              
                UpdateNumCans(dogFoods[userSelection - 1]);
                WriteLine($"The number of {dogFoods[userSelection - 1].BrandName} cans was updated!");
                         
                
            } catch {
                WriteLine("Please enter a Valid Dog Food Option");
                UpdateOrder(dogFoods);
            }
            

            PerformAction(dogFoods);
        }
        /* --------------------------ComputedOrderSummary Explanation-------------------------------------------------
         *  Local variables are set to 0 before the logic begins.
         *  A foreach loop is used to increment the totalBeforeDiscount variable by adding each DogFood BrandTotal.
         *  Then, it uses  simple if/else was used to check if the total amount is greater than o 75
         *  if result as true a discount of 15% is applied. Since the discount Amount is already set to 0 at the begining
         * of the method, an else is not needed.
         */

        static double ComputedOrderSummary(out double totalBeforeDiscount, out double discountAmount,params DogFood[] dogFoods) {
            
            discountAmount = 0;
            totalBeforeDiscount = 0;

            foreach (DogFood food in dogFoods) {
                totalBeforeDiscount += food.BrandTotal;            
            }
           
            if (totalBeforeDiscount > 75) {
                discountAmount = totalBeforeDiscount * 0.15;
            } 

            double totalAfterDiscount = totalBeforeDiscount - discountAmount;

            return totalAfterDiscount;
        }
    }
}
