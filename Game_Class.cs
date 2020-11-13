using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Game_Class
    {

        public int load_position;
        public int spin_position;
        public int shoot_position;
        public int chance = 0;

        public void load()
        {
            load_position = 1;
        }

         public int spin()
        {
            Random rnd_obj = new Random();
            spin_position = rnd_obj.Next(1, 7);
            return spin_position;
        }
        //code to clear the position of the bullet when click on button 
        public int shoot()
        {
            if (load_position == spin_position)
            {
                return 0;
            }
            else if (spin_position == 6)
            {
                spin_position = 1;
                return 1;
            }
            else
            {
                spin_position++;
                return 1;
            }

        }
    }
}
    

