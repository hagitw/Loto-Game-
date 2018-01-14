using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויירקט_משחק_לוטו
{
    class CheckPlay
    {
        public CheckPlay(ComputerCard _computercard, UserCard _usercard)
        {
            computercard = _computercard;
            usercard = _usercard;
        }
        private ComputerCard computercard;

        public ComputerCard computercard1
        {
            get { return computercard; }
            set { computercard = value; }
        }
        private UserCard usercard;

        public UserCard usercard1
        {
            get { return usercard; }
            set { usercard = value; }
        }

        int nCorrectScores = 0;
        public int Compare() // בדיקת תוצאות
        {
            for (int i = 0; i < 6; i++)
            {
                for (int h = 0; h < 6; h++)
                {
                    if (computercard.GetComputernum(i) == usercard.GetUserNum(h))
                    {
                        nCorrectScores++;
                    }
                }
            }
            return nCorrectScores;
        }
        public int GetnCorrectScores() // הוצאת מספר זכיות
        {
            return nCorrectScores;
        }

    }
}
