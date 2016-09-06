using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
	class MainClass
	{
        public static void Main(string[] args)
        {
            var phone = new Nokia3310();

            var context = new ValidationContext( phone, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            bool balanceIsOk = false;
            double balance;
            do
            {
                Console.WriteLine("Enter current balance");
                if(Double.TryParse(Console.ReadLine(), out balance))
                {
                    phone.Balance = balance;
                    balanceIsOk = Validator.TryValidateObject(phone, context, results, true);
                }

                if(!balanceIsOk && results.Any())
                {
                    results.ForEach(r => Console.WriteLine(r.ErrorMessage));
                }
            } while (!balanceIsOk);

            phone.Call("0118 999 881 99 9119 7253");
            Console.Read();
		}
	}
}
