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
        private MyVar(int min, int max)
        {
            /*
                number1=new newCounter();
                number2=new newCounter();
             */
            // במקרה אופטימלי
            if (min < max && min >= number1.get_minRange())
            {
                low_range = min;
                high_range = max;
            }
            else
            {
                // אם שני ערכים שנקלטו שווים
                if (min == max)
                {
                    low_range = min;
                    high_range = min + 10;
                }
                // אם ראשון שנקלט קטן מהשני שנקלט
                else
                {
                    // גבול MIN
                    low_range = number1.get_minRange();
                    // גבול MAX
                    high_range = number1.get_maxRange();
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
        public void set_counter1(int value)
        {
            // בודקים אם ערך שנקלט נמצא בטווח הערכים שמוגדר לאובייקט number1
            if (value >= number1.get_minRange() && value <= number1.get_maxRange())
                number1.counter_input(value);
            else
                // נציב ערך deafult
                number1.counter_input(0);
        }

        //  שיטה מקבלת מספר שלם , בודקת אם נמצא בטווח ערכים שהוגדר לאובייקטים מסיג newCounter
        public void set_counter2(int value)
        {
            // בודקים אם ערך שנקלט נמצא בטווח הערכים שמוגדר לאובייקט number1
            if (value >= number2.get_minRange() && value <= number2.get_maxRange())
                number2.counter_input(value);
            else
                // נציב ערך deafult
                number2.counter_input(0);
        }

        // שיטה מחזירה סכום מונים בשני אובייקטים מסוג newCounter
        public int sum_counters(newCounter one, newCounter other)
        {
            int sum = 0;
            sum = one.get_counter() + other.get_counter();
            return sum;
        }

        // שיטה מחזירה מקסימום 
        public int maxOf(newCounter one, newCounter other)
        {
            int tmp1, tmp2;
            tmp1 = one.get_counter();
            tmp2 = other.get_counter();
            if (tmp1 > tmp2)
                return tmp1;
            else
                return tmp2;
        }
    }
}
