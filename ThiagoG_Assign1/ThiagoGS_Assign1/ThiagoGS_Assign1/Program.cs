using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ThiagoGS_Assign1
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

            UpdateNumCans(meGusta);

            WriteLine(meGusta);
            //WriteLine(fatHappyDog);
            //WriteLine(fancyPuppy);

        }
        /*
         * The idea of this method is to call instance the objected using the class DogFood. It has two
         * parameters that will be assigned to the class properties
         */
    
        static DogFood CreateDogFood(string brandName,double unitPrice) { 
            DogFood dogFoodObj = new DogFood(brandName, unitPrice);
            return dogFoodObj;
        }
        /*Method will print the Brand Name and Unit Price, and ask for the users input to be stored in
         * the variable. I added a Try Catch block to prevent run time errors, and used a recursive method 
         * to force user to enter a valid amount of cans*/
        static void UpdateNumCans(DogFood anyDogFood) {
            WriteLine($"Brand Name: {anyDogFood.BrandName}");
            WriteLine($"Can Unit Price: {anyDogFood.CanUnitPrice:C}");
            Write($"Please enter the number of {anyDogFood.BrandName}cans needed: ");
            try {
                anyDogFood.NumCans = int.Parse(ReadLine());
            } catch {
                Clear();
                WriteLine("Please enter a valid number of Cans!");
                UpdateNumCans(anyDogFood);
            }
        } 
        /*
         * I have decided to use switch case instead of using if for a better code redability.
         * Since the Case is parsed as String, there is no need to convert the Readline to another
         * tipe of variable.
         * A default option was added with the PerformAction as a recursive method to ask the user 
         * to enter an option a valid option in case one of them is not selected
         */
        static void PerformAction(DogFood DogFood1, DogFood DogFood2, DogFood DogFood3) {
            WriteLine("Press 1 for View Order");
            WriteLine("Press 2 for Update Order");
            WriteLine("Press 3 for quitting the application");
            string selectedOption = ReadLine();
            

            switch(selectedOption) {
                case "1":
                    ViewOrder(DogFood1, DogFood2, DogFood3);
                    break;
                case "2":
                    UpdateOrder(DogFood1, DogFood2, DogFood3);
                    break;
                case "3":
                    WriteLine("Thank you for ordering dog foods. Good Bye!");
                    break;
                default:
                    Clear();
                    WriteLine("Please enter a valid option!");
                    PerformAction(DogFood1, DogFood2, DogFood3);
                    break;
            }
        }
        static string ViewOrder(DogFood DogFood1, DogFood DogFood2, DogFood DogFood3) {
            ComputedOrderSummary(DogFood1, DogFood2, DogFood3,out double totalBeforeDiscount ,out double discountAmount);
            return "A";
        }
        static string UpdateOrder(DogFood DogFood1, DogFood DogFood2, DogFood DogFood3) {
            return "b";
        }
        /* 
         * ComputedOrderSummary Method uses  simple if/else was used to check if the total amount is greater than o 75
         * if result as true a discount of 15% is applied. Since the discount Amount is already set to 0 at the begining
         * of the method, an else is not needed.
         */

        static double ComputedOrderSummary(DogFood DogFood1, DogFood DogFood2, DogFood DogFood3, out double totalBeforeDiscount, out double discountAmount) {
            
            discountAmount = 0;
            totalBeforeDiscount = DogFood1.BrandTotal + DogFood2.BrandTotal + DogFood3.BrandTotal;
           
            if (totalBeforeDiscount > 75) {
                discountAmount = totalBeforeDiscount * 0.15;
            } 

            double totalAfterDiscount = totalBeforeDiscount - discountAmount;

            return totalAfterDiscount;
        }
    }
}
