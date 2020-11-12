using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Simple_Game : Form
    {
        Game_Class Class_obj=new Game_Class();
        private object btn_shoot;

        public Simple_Game()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.load image 1.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.game_load_sound);

            Sound_Object.Play();

            
            btn_Spin.Enabled = false;
            btn_Shoot_away.Enabled = true;

            


        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.spin_images.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object; 

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.spin_sound);

            Sound_Object.Play();
        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.shoot on head.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object;

            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("best of luck for the next time");
            }
            else
            {
                MessageBox.Show("empty shoot");
            }

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot_sound);

            Sound_Object.Play();
        }

        private void btn_Shoot_away_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.shoot away images.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object;

            if (Class_obj.chance <= 2)
            {
                if (Class_obj.shoot() == 0)

                    MessageBox.Show("Congress, you won the game");
                btn_Shoot.Enabled = false;
                btn_Shoot_away.Enabled = false;
            }
            else
            {
                 Class_obj.chance++;
                if (Class_obj.chance == 2)
                {
                    MessageBox.Show("Try Again");
                    btn_Shoot.Enabled = false;
                    btn_Shoot_away.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Builts are finished");
                }
            }
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot_sound);

            Sound_Object.Play();

           
            
            }
    }
}
