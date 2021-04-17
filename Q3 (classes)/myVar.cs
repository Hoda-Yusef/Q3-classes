using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hoda Khier + Yusef Aborokon 44/5
namespace targil3
{
    public class MyVar
    {
        private newCounter number1;
        private newCounter number2;
        private int low_range;
        private int high_range;

        //בנאי מגדיר טווח ערכים שווה לטווח ערכים 
        public MyVar(int min, int max)
        {
           
            // במקרה אופטימלי
            if (min < max )
            {
                number1 = new newCounter(min,max);
                number2 = new newCounter(min,max);
            }
            else
            {
                // אם שני ערכים שנקלטו שווים
                if (min == max)
                {
                    number1 = new newCounter(min,max+10);
                    number2 = new newCounter(min,max+10);
                }
                // אם ראשון שנקלט קטן מהשני שנקלט
                else
                {
                    number1 = new newCounter(max,min);
                    number2 = new newCounter(max,min);
                }
            }
        }
        // שיטה מחזירה ערך מונה באובייקט number1
        public int get_counter1()
        {
            return this.number1.get_counter();
        }

        // שיטה מחזירה ערך מונה באובייקט number2
        public int get_counter2()
        {
            return this.number2.get_counter();
        }

        //  שיטה מקבלת מספר שלם , בודקת אם נמצא בטווח ערכים שהוגדר לאובייקטים מסיג
        public Boolean set_counter1(int value)
        {
            // בודקים אם ערך שנקלט נמצא בטווח הערכים שמוגדר לאובייקט number1
            if (value >= number1.get_minRange() && value <= number1.get_maxRange())
            {
                number1.set_counter(value);
                return true;
            }
            else
            {
                // נציב ערך deafult
                number1.set_counter(0);
                return false;
            }
        }

        //  שיטה מקבלת מספר שלם , בודקת אם נמצא בטווח ערכים שהוגדר לאובייקטים מסיג newCounter
        public Boolean set_counter2(int value)
        {
            // בודקים אם ערך שנקלט נמצא בטווח הערכים שמוגדר לאובייקט number1
            if (value >= number2.get_minRange() && value <= number2.get_maxRange())
            {
                number2.set_counter(value);
                return true;
            }
            else
            {
                // נציב ערך deafult
                number2.set_counter(0);
                return false;
            }
        }

        // שיטה מחזירה סכום מונים בשני אובייקטים מסוג newCounter
        public int sum_counters()
        {
            int sum = 0;
            sum = number1.get_counter() + number2.get_counter();
            return sum;
        }

        // שיטה מחזירה מקסימום 
        public int maxOf()
        {
            int tmp1, tmp2;
            tmp1 = number1.get_counter();
            tmp2 = number2.get_counter();
            if (tmp1 > tmp2)
                return tmp1;
            else
                return tmp2;
        }
    }
}
