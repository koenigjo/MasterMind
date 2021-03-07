using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class ctrlGuess : UserControl
    {
        public ctrlGuess()
        {
            InitializeComponent();
        }

        private void guess_Load(object sender, EventArgs e)
        {

        }

        public void ResetControl()
        {
            /*
            Set control back to default color of grey             
            */
            color1.Image = MasterMind.Properties.Resources.grey_large;
            color2.Image = MasterMind.Properties.Resources.grey_large;
            color3.Image = MasterMind.Properties.Resources.grey_large;
            color4.Image = MasterMind.Properties.Resources.grey_large;
            ans1.Image = MasterMind.Properties.Resources.grey_small;
            ans2.Image = MasterMind.Properties.Resources.grey_small;
            ans3.Image = MasterMind.Properties.Resources.grey_small;
            ans4.Image = MasterMind.Properties.Resources.grey_small;
        }

        public void SetGuessColor(string clr, int pick)
        {
            /*
            Set color for guess. Selects the correct picturebox then calls UpdateColor to change to the correct color.
            
            Inputs:
            clr - color to be set to
            pick - number 0-3 corresponding to the picturebox to update

            Outputs:
            None
            */

            switch (pick)
            {
                case 0:
                    UpdateColor(color1, clr);
                    break;
                case 1:
                    UpdateColor(color2, clr);
                    break;
                case 2:
                    UpdateColor(color3, clr);
                    break;
                case 3:
                    UpdateColor(color4, clr);
                    break;
            }
        }

        public void SetAnswerColor(string clr, int ans)
        {
            /*
            Set color for answer. Selects the correct picturebox then calls UpdateColor to change to the correct color.
            
            Inputs:
            clr - color to be set to
            ans - number 1-4 corresponding to the picturebox to update

            Outputs:
            None
            */

            switch (ans)
            {
                case 0:
                    UpdateColor(ans1, clr);
                    break;
                case 1:
                    UpdateColor(ans2, clr);
                    break;
                case 2:
                    UpdateColor(ans3, clr);
                    break;
                case 3:
                    UpdateColor(ans4, clr);
                    break;
            }
        }

        private void UpdateColor(PictureBox pic, string clr)
        {
            /*
            Change the image color of the desired picture box.
            
            Inputs:
            pic - picturebox to be changed
            clr - color to be set to

            Outputs:
            None
            */
            switch (clr)
            {
                case "red":
                    pic.Image = MasterMind.Properties.Resources.red;
                    break;
                case "orange":
                    pic.Image = MasterMind.Properties.Resources.orange;
                    break;
                case "yellow":
                    pic.Image = MasterMind.Properties.Resources.yellow;
                    break;
                case "green":
                    pic.Image = MasterMind.Properties.Resources.green;
                    break;
                case "blue":
                    pic.Image = MasterMind.Properties.Resources.blue;
                    break;
                case "purple":
                    pic.Image = MasterMind.Properties.Resources.purple;
                    break;
                case "black":
                    pic.Image = MasterMind.Properties.Resources.black;
                    break;
                case "white":
                    pic.Image = MasterMind.Properties.Resources.white;
                    break;
                case "grey_large":
                    pic.Image = MasterMind.Properties.Resources.grey_large;
                    break;
                case "grey_small":
                    pic.Image = MasterMind.Properties.Resources.grey_small;
                    break;
            }
        }
    }
}
