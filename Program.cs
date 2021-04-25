using System;

namespace waterbill_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Water Supply Corporation");
            Console.WriteLine("Calculate your water bill with ease.");
            decimal unitConsumed = 0M;
            double perUnitCharge =0;
            decimal billCharge = 0M, surCharge = 0M, netAmountPaid = 0M;
            Console.WriteLine("Enter ID: ");
            string userId = Console.ReadLine();
            while (String.IsNullOrEmpty(userId)) //checks if id is null
            {
                Console.WriteLine("Please Enter ID: ");
                userId = Console.ReadLine(); 
            }

            Console.WriteLine("Enter Name: ");
            string userName = Console.ReadLine();
            while (String.IsNullOrEmpty(userName)) //Checks if username is null
            {
                Console.WriteLine("Please Enter Name: ");
                userName = Console.ReadLine(); 
            }
            Console.WriteLine("Enter Unit Consumed: ");
            string unitInputted = Console.ReadLine();
            bool checkUnitInputted = decimal.TryParse(unitInputted, out unitConsumed);
            // CHECK FOR CORRECT UNIT
            while (!checkUnitInputted)
            {
                Console.Write("Please Input the correct Unit format: ");
                unitInputted = Console.ReadLine();
                checkUnitInputted = decimal.TryParse(unitInputted, out unitConsumed);
                Console.WriteLine();
            }
            if (unitConsumed > 0 && unitConsumed < 200)
            {
                perUnitCharge = 1.2;
                billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
             }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                perUnitCharge = 1.50;
                billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                perUnitCharge = 1.80;
                billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
            }
            else 
            {
                perUnitCharge = 2.00;
                billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
            } 


            if  (billCharge > 300)
            {
                billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
                surCharge = billCharge * Convert.ToDecimal(15) / Convert.ToDecimal(100);
                netAmountPaid = billCharge + surCharge;
                Console.WriteLine(" Customer IDNO: {0} \nCustomer Name: {1} \nUnit Consumed: {2} \nBill Charge: {3} \nSurcharge: {4} \nNet Amount Paid: {5}", userId, userName, unitConsumed,billCharge,surCharge,netAmountPaid);
            }
            else if (billCharge >= 100 && billCharge <300 )
            {
              billCharge = Convert.ToDecimal(unitConsumed) * Convert.ToDecimal(perUnitCharge);
              netAmountPaid = billCharge + surCharge;
              Console.WriteLine(" Customer IDNO: {0} \nCustomer Name: {1} \nUnit Consumed: {2} \nBill Charge: {3} \nSurcharge: {4} \nNet Amount Paid: {5}", userId, userName, unitConsumed,billCharge,surCharge,netAmountPaid);
            }
            else 
            {
              netAmountPaid = billCharge + surCharge;
              Console.WriteLine("Sorry your Net amount is less than minimum bill(100), kindly consume more units for payment access.");
            }
        }
    }
}
