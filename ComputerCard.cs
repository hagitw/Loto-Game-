using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויירקט_משחק_לוטו
{
    class ComputerCard
    {
        int[] arComputerCard;

        public ComputerCard() // בנאי
        {
            arComputerCard = new int[6];
            for (int i = 0; i < arComputerCard.Length; i++)
            {
                arComputerCard[i] = 0;
            }
        }

        public int GetComputernum(int num) // הוצאת של מספר מהמחשב
        {
            return arComputerCard[num];
        }

        public bool ExistsNum(int num) // בדיקה של מספר במערך
        {
            bool a = false;

            for (int i = 0; i < arComputerCard.Length; i++)
            {
                if (arComputerCard[i] == num)
                {
                    a = true;
                    break;
                }
            }
            return a;
        }



        public void GenerateValue() // הגרלה של 6 מספרים שונים והכנסה למערך
        {
            Random r = new Random();
            int RandomNum;
            for (int i = 0; i < 6;)
            {
                RandomNum = r.Next(1,46);

                if (ExistsNum(RandomNum) == false)
                {
                    arComputerCard[i] = RandomNum;
                    i++;
                }

            }
        }


    }
}
