using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויירקט_משחק_לוטו
{
    class Input
    {
        public Input(UserCard _Usercard1) //בנאי
        {
            Usercard1 = _Usercard1;
        }
        private UserCard Usercard1;

        public UserCard Usercard // הכנסה והוצאה של כרטיס שחקן
        {
            get { return Usercard1; }
            set { Usercard1 = value; }
        }

        public void GetUserValues() // קליטה של 6 מספרים שלמים 
        {
            for (int i = 0; i < 6;)
            {

                int number;
                for (int h = 6; h > 0;)
                {
                    Console.WriteLine("Please Enter an {0} integers between 1 and 46", h);
                    string str = Console.ReadLine();
                    if (int.TryParse(str, out number))
                    {
                        if (number > 0 && number <= 46)
                        {
                            if (Usercard1.AddNum(number))
                            {
                                i++;
                                h--;

                            }
                        }
                        else { Console.WriteLine("Erorr"); }

                    }
                    else { Console.WriteLine("insert only an integers"); }
                   
                }
            }
        }







    }
}
