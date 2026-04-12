using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Crash_Couese
{
    internal class ListOfObjects
    {
        public void Show() 
        {
            List<Object> players = new List<Object>();

            //Player p1 = new Player("TkdAbrar");
            //Player p2 = new Player("Gojo");
            //Player p3 = new Player("Esagi");

            //players.Add(p1);
            //players.Add(p2);
            //players.Add(p3);

            /* These are called anonymous objects because
               we are not storing them in a variable,
               we are directly adding them to the list. */
            players.Add(new Player("TkdAbrar"));
            players.Add(new Player("Gojo"));
            players.Add(new Player("Esagi"));

            foreach (Player player in players)
            {
                //Console.WriteLine(player.username);
                Console.WriteLine(player);
            }

        }
    }
    class Player 
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
