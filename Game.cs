using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויירקט_משחק_לוטו
{
    class Game
    {
        public Game()
        {

            UserCard UserCard = new UserCard();

            Console.WriteLine("please write your name");
            String str = Console.ReadLine();
            UserCard.NamePlayer = str;


            Input a = new Input(UserCard);
            a.GetUserValues();

            ComputerCard computer = new ComputerCard();


            computer.GenerateValue();

            CheckPlay check = new CheckPlay(computer, UserCard);
            check.Compare();

            Console.WriteLine(str);

            Output.Write(check.GetnCorrectScores());

            if (check.GetnCorrectScores() > 0)
            {
                Console.WriteLine("You Winner");
            }
            else
            {
                Console.WriteLine("You loser");
            }

        }

    }
}
