using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and 
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _3.ExceptionTask
{
    public class ExceptionsTest
    {
        public static void Main()
        {
            InvalidRangeException<int> intException = new InvalidRangeException<int>("You have to enter number between 1 and 100", 1, 100);
            Console.WriteLine("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            if (number < intException.RangeStart || number > intException.RangeEnd)
            {
                throw intException;
            }


            string startDate = "1.1.1980";
            string endDate = "31.12.2013";

            InvalidRangeException<DateTime> dateException = new InvalidRangeException<DateTime>("You have to enter a date between 1.1.1920 and 31.12.2013", DateTime.Parse(startDate),
                DateTime.Parse(endDate));

            Console.WriteLine("Ënter a date in format dd.mm.yyyy: ");

            string date = Console.ReadLine();

            DateTime checkDate = DateTime.Parse(date);

            if (checkDate < dateException.RangeStart || checkDate > dateException.RangeEnd)
            {
                throw dateException;
            }

        }
    }
}
