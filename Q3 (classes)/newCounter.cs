using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hoda Khier + Yusef Aborokon 44/5
namespace targil3
{
    public class newCounter
    {
        private int counter = 0;
        private int min_range;
        private int max_range;


        // constructor
        public newCounter(int min,int max)
        {
            if (min < max )
            {
                min_range = min;
                max_range = max;
            }
            else
            {
                // אם שני ערכים שהתקבלו שווים
                if (min == max)
                {
                    min_range = min;
                    max_range = min + 10;
                }
                // אם הראשון גדול מערך השני 
                else
                {
                    
                    min_range = max;
                    
                    max_range = min;
                }
            }
        }

        // שיטה מחזירה ערך של המונה
        public int get_counter()
        {
            return this.counter;
        }

        // שיטה מאפשרת שינוי ערך המונה
        public Boolean set_counter(int number)
        {
            if (number >= this.min_range && number <= this.max_range)
            {
                // מספר תקין
                this.counter = number;
                return true;
            }
            else
                // מספר שנקלט לא נמצא בטווח הערכים שהוגדר
                return false;

        }

        // שיטה מחזירה ערך גבול תחתון
        public int get_minRange()
        {
            return this.min_range;
        }

        // שיטה מחזירה ערך גבול עליון
        public int get_maxRange()
        {
            return this.max_range;
        }

     
        // שיטה בודקת אם ערך המונה החדש נמצא בטווח הערכים המוגדר לאובייקט
        private int check_input(int count)
        {
            if (count >= this.min_range && count <= this.max_range)
                return 1;
            else
                return 0;
        }

        // שיטה מקדמת counter  ב1
        public Boolean inc_counter()
        {
            int tmp = this.counter;
            tmp++;
            // בודקים אם הערך אחרי קידום עדיין נמצא בטווח המוגדר
            if (check_input(tmp) == 1)
            {
                this.counter++;
                return true;
            }
            else
                
                return false;
        }


        // שיטה מקטינה counter  ב1
        public Boolean dec_counter()
        {
            int tmp = this.counter;
            tmp--;
            // בודקים הערך המוקטן ב1 אם עדיין נמצא בטווח הערכים המוגדר
            if (check_input(tmp) == 1)
            {
                // אם כן אז מקטינים המונה ב1
                this.counter--;
                return true;
            }
            // אחרת מחזירים הערך הנוכחי של המונה בלי שינוי
            else
                return false;
        }


    }
}
