using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace bot2studio
{
    public partial class Form1 : Form
    {
        private object interaction;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frames_counted1 = Interaction.InputBox("Enter the frames taken into account","Frames","0",500,300);
            string framerate1 = Interaction.InputBox("Enter the framerate of the camera", "FPS", "0", 500, 300);
            string distance1 = Interaction.InputBox("Enter the distance travelled (cm)", "Distance", "0", 500, 300);

            int frames_counted = int.Parse(frames_counted1);
            int framerate = int.Parse(framerate1);
            double distance = double.Parse(distance1)/100;
            double speed = distance * framerate / frames_counted;
            string speed1 = speed.ToString();

            MessageBox.Show(speed1 + "m/s");
    


        }
    }
}
