using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויירקט_משחק_לוטו
{
    class UserCard
    {
        int[] arUserCard;

        public UserCard() //בנאי
        {
            arUserCard = new int[6];
            for (int i = 0; i < arUserCard.Length; i++)
            {
                arUserCard[i] = 0;
            }

        }
        public int GetUserNum(int num) // הוצאת מספר מהכרטיס משתמש
        {
            return arUserCard[num];
        }

        private string nameplayer;

        public string NamePlayer   // הכנסה והוצאה של שם שחקן 
        {
            get { return nameplayer; }
            set { nameplayer = value; }

        }

        public bool ExistsNun(int num) // בדיקה של כפילות מספר
        {
            bool a = false;

            for (int i = 0; i < arUserCard.Length; i++)
            {
                if (arUserCard[i] == num)
                {
                    a = true;
                    Console.WriteLine("The number already exists");
                    break;
                }
            }
            return a;
        }

        int NumbersAlreadyInserted = 0;

        public bool AddNum(int newNum)  //הוספת מספר בתנאי שהוא לא נמצא 
        {
            if (NumbersAlreadyInserted < 6)
            {
                if (ExistsNun(newNum) == false)
                {
                    arUserCard[NumbersAlreadyInserted] = newNum;
                    NumbersAlreadyInserted++;
                    return true;
                }
                return false;
            }
            return false;
        }

        public int GetNumbersAlreadyInserted() // הוצאה של מספר המספרים שהכנסנו
        {
            return NumbersAlreadyInserted;
        }




    }
}
