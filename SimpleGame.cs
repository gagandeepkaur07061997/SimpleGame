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

        public Simple_Game()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.loadimage.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object;

            //code to play the sound when click on the button 
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.loading_gun_sound);

            Sound_Object.Play();

            Class_obj.load();
            //code to enabled spin and load btn

            btn_Spin.Enabled = true;
            btn_load.Enabled = false;
        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.spin image.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object; 

            //code to play sound for spin btn on click 
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.spin_sound);

            Sound_Object.Play();
            //code to show message for spin btn on click 
            MessageBox.Show(Class_obj.spin().ToString());

            //code to enabled btn like spin, shoot and shoot away
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_Shoot_away.Enabled = true;
        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.shoot on head.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_box.Image = bmp_Object;

            // code to display different message on shoot button click
            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("best of luck for the next time");
            }
            else
            {
                MessageBox.Show("empty shoot");
            }

            // code to play sound on shoot button click 
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

            // code to disapear message on button click
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

            // code to play sound on button click
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot_sound);

            Sound_Object.Play();

        }
        //code to restart the game on button click

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //code to exit the game on button click 
        private void btn_Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
