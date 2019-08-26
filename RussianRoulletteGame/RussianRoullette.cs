using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulletteGame
{
    public partial class RussianRoullette : Form
    {
        ClassForLoopSystem bulletClass = new ClassForLoopSystem();//Creating instance of the external class
        Random randNo = new Random();//Random class instance
        int totalChance = 6;//this variable for chances
        int tryingGun = 2;//this is for trying gun variable
        public RussianRoullette()
        {
            InitializeComponent();
        }

        private void btnLoading_Click(object sender, EventArgs e)
        {
            borderForWar.Image = RussianRoulletteGame.Properties.Resources.loading;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulletteGame.Properties.Resources.Loadings);//adding the sound
            soundPlayer.Play();//this sound playing function

            btnLoading.Enabled = false;
            bulletClass.Loading = 1;
        }

        private void btnSpinning_Click(object sender, EventArgs e)
        {
            borderForWar.Image = RussianRoulletteGame.Properties.Resources.spn;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulletteGame.Properties.Resources.Empty);//adding the sound
            soundPlayer.Play();//this sound playing function

            btnSpinning.Enabled = false;//button got false

            bulletClass.Spinning = randNo.Next(1, 6);//random numbers changing 1 to 6
        }

        private void btnShootAhead_Click(object sender, EventArgs e)
        {
            borderForWar.Image = RussianRoulletteGame.Properties.Resources.sht;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulletteGame.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (totalChance > 0 && bulletClass.Spinning == 1)
            {
                MessageBox.Show("Shoot You loose");
                btnShootAway.Enabled = false;
                btnShootAhead.Enabled = false;
            }
            else if (totalChance > 0 && bulletClass.Spinning != 1)
            {
                MessageBox.Show("Blank Fire");
                totalChance = totalChance - 1;//minus one from total
                bulletClass.Spinning = bulletClass.LoopShot(bulletClass.Spinning);

            }
        }

        private void btnShootAway_Click(object sender, EventArgs e)
        {
            borderForWar.Image = RussianRoulletteGame.Properties.Resources.shootaway;//shootaway image add
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulletteGame.Properties.Resources.Shot);//getting sound
            soundPlayer.Play();//sound paying

            if (totalChance > 0 && bulletClass.Spinning == 1 && tryingGun == 2)
            {
                MessageBox.Show("your score is 200");
                btnShootAway.Enabled = false;
                btnShootAhead.Enabled = false;
            }
            if (totalChance > 0 && bulletClass.Spinning == 1 && tryingGun == 1)
            {
                MessageBox.Show("you win you score is 100");
                btnShootAway.Enabled = false;
                btnShootAhead.Enabled = false;
            }
            else if (totalChance > 0 && bulletClass.Spinning != 1)
            {
                MessageBox.Show("Blank Fire");
                totalChance = totalChance - 1;//minus one from total
                bulletClass.Spinning = bulletClass.LoopShot(bulletClass.Spinning);

            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            (new RussianRoullette()).Show();
            this.Hide();
        }
    }
}
