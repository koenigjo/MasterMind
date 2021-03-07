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
    public partial class frmSolver : Form
    {
        private static frmSolver form = null;
        Solver cur_solve { get; set; }

        public frmSolver()
        {
            InitializeComponent();
            form = this;
        }

        private void frmSolver_Load(object sender, EventArgs e)
        {
            cur_solve = new Solver(form);
        }

        public void ResetResults()
        {
            // Reset results to all grey
            res1.Image = MasterMind.Properties.Resources.grey_large;
            res2.Image = MasterMind.Properties.Resources.grey_large;
            res3.Image = MasterMind.Properties.Resources.grey_large;
            res4.Image = MasterMind.Properties.Resources.grey_large;
        }

        public void SetGuessColor(string clr, int guess)
        {
            /*
            Set color for solution. Selects the correct picturebox then calls UpdateColor to change to the correct color.
            
            Inputs:
            clr - color to be set to
            guess - number 0-3 corresponding to the picturebox to update

            Outputs:
            None
            */

            switch (guess)
            {
                case 0:
                    UpdateColor(guess1, clr);
                    break;
                case 1:
                    UpdateColor(guess2, clr);
                    break;
                case 2:
                    UpdateColor(guess3, clr);
                    break;
                case 3:
                    UpdateColor(guess4, clr);
                    break;
            }
        }

        public void SetResultColor(string clr, int res)
        {
            /*
           Set color for result. Selects the correct picturebox then calls UpdateColor to change to the correct color.

           Inputs:
           clr - color to be set to
           res - number 0-3 corresponding to the picturebox to update

           Outputs:
           None
           */

            switch (res)
            {
                case 0:
                    UpdateColor(res1, clr);
                    break;
                case 1:
                    UpdateColor(res2, clr);
                    break;
                case 2:
                    UpdateColor(res3, clr);
                    break;
                case 3:
                    UpdateColor(res4, clr);
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
                    pic.Image = MasterMind.Properties.Resources.black_large;
                    break;
                case "white":
                    pic.Image = MasterMind.Properties.Resources.white_large;
                    break;
                case "grey":
                    pic.Image = MasterMind.Properties.Resources.grey_large;
                    break;
            }
        }

        private void picBlack_Click(object sender, EventArgs e)
        {
            // Pick red for current guess
            cur_solve.PickColor("black", 1);
        }

        private void picWhite_Click(object sender, EventArgs e)
        {
            // Pick red for current guess
            cur_solve.PickColor("white", 0);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Undo last color picked
            cur_solve.UndoPickColor();
        }

        private void btnNewSolve_Click(object sender, EventArgs e)
        {
            cur_solve = new Solver(form);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get next guess based on results
            cur_solve.GetNextGuess();
        }

        public void InputError()
        {
            MessageBox.Show("No solution found. Start a new solve and verify the results were entered correctly.", "Error", MessageBoxButtons.OK);
        }
    }
}
