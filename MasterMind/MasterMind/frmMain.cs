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
    public partial class frmMain : Form
    {
        private static frmMain form = null;
        private static frmInstructions instruct = null;
        private static frmSolver solver = null;
        Game cur_game { get; set; }

        public frmMain()
        {
            InitializeComponent();
            form = this;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ctrlGuess control = new ctrlGuess();
                control.Name = "guess" + Convert.ToString(i);
                control.Location = new System.Drawing.Point(330, 30 + (i * 60));
                this.Controls.Add(control);
                Program.guess_ctrls[i] = control;
            };
            
            
            cur_game = new Game(form);
        }

        private void picRed_Click(object sender, EventArgs e)
        {
            // Pick red for current guess
            cur_game.PickColor("red");
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            // Pick orange for current guess
            cur_game.PickColor("orange");
        }

        private void picYellow_Click(object sender, EventArgs e)
        {
            // Pick yellow for current guess
            cur_game.PickColor("yellow");
        }

        private void picGreen_Click(object sender, EventArgs e)
        {
            // Pick green for current guess
            cur_game.PickColor("green");
        }

        private void picBlue_Click(object sender, EventArgs e)
        {
            // Pick blue for current guess
            cur_game.PickColor("blue");
        }

        private void picPurple_Click(object sender, EventArgs e)
        {
            // Pick purple for current guess
            cur_game.PickColor("purple");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Undo last color picked
            cur_game.UndoPickColor();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            cur_game.VerifyGuess();
        }

        public void SetSolutionColor(string clr, int solution)
        {
            /*
            Set color for solution. Selects the correct picturebox then calls UpdateColor to change to the correct color.
            
            Inputs:
            clr - color to be set to
            solution - number 0-3 corresponding to the picturebox to update

            Outputs:
            None
            */

            switch (solution)
            {
                case 0:
                    UpdateColor(solution1, clr);
                    break;
                case 1:
                    UpdateColor(solution2, clr);
                    break;
                case 2:
                    UpdateColor(solution3, clr);
                    break;
                case 3:
                    UpdateColor(solution4, clr);
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
            }
        }

        private void tsmNewGame_Click(object sender, EventArgs e)
        {
            cur_game = new Game(form);
        }

        private void tsmInstructions_Click(object sender, EventArgs e)
        {
            // Display instructions if not already open
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "frmInstructions")
                {
                    return;
                }
            }

            // Closing frmInstructions removes form so a new one needs to be created each time it is opened
            instruct = new frmInstructions();
            instruct.Show();
        }

        private void tsmSolver_Click(object sender, EventArgs e)
        {
            // Display instructions if not already open

            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "frmSolver")
                {
                    return;
                }
            }

            // Closing frmInstructions removes form so a new one needs to be created each time it is opened
            solver = new frmSolver();
            solver.Show();
        }
    }
}
