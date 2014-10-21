using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    public static class RandomData
    {
        public static string randPesel()
        {
            Random rnd = new Random();
           
            int year = rnd.Next(45, 100);
            
            int month = rnd.Next(1, 13);
            string monthString = (month>9) ? month.ToString(): "0"+month.ToString();
            
            int day;
            
            if (month < 8)
               day = rnd.Next(1, 31 + (month % 2));          
            else 
                day = rnd.Next(1, 32 - (month % 2));
            

            string dayString = (day>9) ? day.ToString(): "0"+day.ToString();

            string fourDig = rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();

            return year.ToString() + monthString + dayString + fourDig;

        }

        public static DateTime randEnter()
        {
            Random rnd = new Random();
            return new DateTime(2014,rnd.Next(1,13),rnd.Next(1,31),rnd.Next(6,17),rnd.Next(60),rnd.Next(60));
        }

        public static DateTime randExit(DateTime start)
        {
            Random rnd = new Random();

            return new DateTime(start.Year, start.Month, start.Day, 
                rnd.Next(start.Hour+4, 23), rnd.Next(start.Minute, 60), rnd.Next(start.Second, 60));
        }

    }
}
