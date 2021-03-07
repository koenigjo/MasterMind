using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Game
    {
        private frmMain main_frm { get; set; }  // form containg game board
        string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };  // colors that can be picked
        private int[,] guesses { get; set; }  // 2d array to store guesses
        int[,] guess_results { get; set; }  // 2d array to store results of guesses
        int[] solution { get; set; }  // array containing solution
        int solution_compare { get; set; }  // solution value to compare guesses against
        int cur_guess { get; set; } // current guess 0 to 9
        bool game_over { get; set; } // track if game is still active
        int cur_pick { get; set; }  // current pick forguess 0 to 3

        public Game(frmMain main_form )
        {
            main_frm = main_form;
            guesses = new int[10, 4];
            guess_results = new int[10, 4];
            ResetGame();
            solution = MakeSolution();
            solution_compare = MakeCompareValue(solution);
            AddSolutionToBoard();
            DisplaySolution(false);
            cur_guess = 0;
            game_over = false;
            cur_pick = 0;
        }

        private int[] MakeSolution()
        {
            /*
            Randomly selects 4 colors for the solution. Each integer corresponds to the color value.

            Inputs:
            None

            Outputs:
            solution - array of 4 integers            
             */
            int[] solution = new int[4];

            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                solution[i] = rnd.Next(6);
            }

            return solution;
        }

        private int MakeCompareValue(int[] guess)
        {
            /*
            Convert an array of 4 color values into an integer for comparison between guess and solution.
            Each color value is used as a power of 10 and summed together

            Inputs:
            guess - integer array of 4 color values

            Outputs:
            comp_val - integer value of inputed color array         
            */

            int comp_val = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                comp_val += Convert.ToInt32(Math.Pow(10, guess[i]));
            }

            return comp_val;
        }

        private void ResetGame()
        {
            /*
            Resets the board for a new game. All guesses and anseres are cleared and 
            the guess panel is moved back to first guess.
            */

            foreach (ctrlGuess control in Program.guess_ctrls)
            {
                control.ResetControl();                    
            }

            MoveMakeGuess(0);

            // Hide solution
            DisplaySolution(false);

            // Reset guesses
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    guesses[i, j] = -1;
                }
            }

            // Reset results
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    guess_results[i, j] = -1;
                }
            }

            // Reset result text
            var lbl = this.main_frm.Controls.Find("lblResult", true)[0];
            lbl.Text = "";
        }

        private void MoveMakeGuess(int pos)
        {
            /*
            Moves pnlMakeGuess to be aligned with the desired ctrlGuess

            Inputs:
            pos - integer value of ctrlGuess from 0 to 9

            Outpus:
            None
            */

            var pnl = this.main_frm.Controls.Find("pnlMakeGuess", true)[0];
            pnl.Location = new System.Drawing.Point(10, 30 + (pos * 60));
        }

        public void PickColor(string clr)
        {
            // Verify game is still active and not all colors have been picked for the current guess
            if (game_over || cur_pick > 3) {return;}

            // Change color on board
            Program.guess_ctrls[cur_guess].SetGuessColor(clr, cur_pick);

            // Update guess array 
            guesses[cur_guess, cur_pick] = Array.FindIndex(colors, x=>x.Contains(clr));
            cur_pick++;

            // Enable Undo button
            var btnUndo = this.main_frm.Controls.Find("btnUndo", true)[0];
            btnUndo.Enabled = true;

            // Enable Guess button if all picks selected
            if (cur_pick > 3)
            {
            var btnGuess = this.main_frm.Controls.Find("btnGuess", true)[0];
            btnGuess.Enabled = true;
            }
        }

        public void UndoPickColor()
        {
            // Verify game is still active and not first pick for guess
            if (game_over || cur_pick == 0) { return; }

            // Change color on board
            Program.guess_ctrls[cur_guess].SetGuessColor("grey_large", cur_pick - 1);

            // Update guess array 
            cur_pick--;
            guesses[cur_guess, cur_pick] = -1;

            // Disable Undo button if back to first pick
            if (cur_pick == 0)
            {
                var btnUndo = this.main_frm.Controls.Find("btnUndo", true)[0];
                btnUndo.Enabled = false;
            }

            // Enable Guess button if all picks selected
            var btnGuess = this.main_frm.Controls.Find("btnGuess", true)[0];
            btnGuess.Enabled = false;
        }

        public void VerifyGuess()
        {
            /*
            Check the result of the guess. Finds if any picks are an exact match and removes them from
            the compare values of the guess and solution. The solution and guess compare values are then
            compared for anyt picks that are in the wrong place. Each digit in the compare values correspond
            to a color. The ones digit of each compare value is compared and the lower value of the 2
            corresponds to the the number of picks for that color is in the wrong place. That color digit
            is removed from the compare values and this repeats until one of the compare values is 0.

            The results are then displayed on the board and the game state is checked for a correct solution
            or if the player is out of guesses.
            */
            
            int[] guess = new int[4];
            int exact = 0;
            int wrong_place = 0;
            int solution_comp = solution_compare;
            int guess_check = 0;
            int solution_check = 0;
            

            //Get compare value for current guess
            for (int i = 0; i < 4; i++)
            {
                guess[i] = guesses[cur_guess, i];
            }

            int guess_comp = MakeCompareValue(guess);

            // Find exact matches and remove them from compares
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == solution[i])
                {
                    exact++;
                    guess_comp -= Convert.ToInt32(Math.Pow(10, guess[i]));
                    solution_comp -= Convert.ToInt32(Math.Pow(10, solution[i]));
                }
            }

            // Determine colors that match but are in wrong position
            while (solution_comp > 0 && guess_comp > 0)
            {
                // Get ones digit from solution and guess comps to compare
                guess_check = guess_comp % 10;
                solution_check = solution_comp % 10;

                // Add lowest value to wrong_place because that is the max of that color that can match
                if (solution_check < guess_check)
                {
                    wrong_place += solution_check;
                } else
                {
                    wrong_place += guess_check;
                }

                // Remove checked color from compare values
                guess_comp = Convert.ToInt32(Math.Floor(guess_comp / 10.0));
                solution_comp = Convert.ToInt32(Math.Floor(solution_comp / 10.0));
            }

            // Display answers on board and update guess results;
            this.UpdateAnswers(exact, wrong_place);

            //Check Game State
            CheckGameState();

            // Go to next guess if game isnt over
            if (!game_over)
            {
                cur_guess++;
                cur_pick = 0;
                this.MoveMakeGuess(cur_guess);
            }
            else
            {
                // Disable Undo and Guess buttons if game over
                var btnUndo = this.main_frm.Controls.Find("btnUndo", true)[0];
                btnUndo.Enabled = false;

                var btnGuess = this.main_frm.Controls.Find("btnGuess", true)[0];
                btnGuess.Enabled = false;
            }
        }

        private void UpdateAnswers(int exact, int wrong_place)
        {
            // Display results of guess and add to guess_results
            int ans = 0;

            for(int i = 0; i < exact; i++)
            {
                Program.guess_ctrls[cur_guess].SetAnswerColor("black", ans);
                guess_results[cur_guess, ans] = 1;
                ans++;
            }

            for (int i = 0; i < wrong_place; i++)
            {
                Program.guess_ctrls[cur_guess].SetAnswerColor("white", ans);
                guess_results[cur_guess, ans] = 0;
                ans++;
            }
        }
        
        private void CheckGameState()
        {
            /*
            Check if the game is over by seeing if the guess is correct or out of guesses. 
            */

            // Check if guess is correct, guess result will sum to 4
            int ans_sum = 0;
            for (int i=0; i<4; i++)
            {
                ans_sum += guess_results[cur_guess, i];
            }

            // Correct solution - winner
            if (ans_sum == 4)
            {
                game_over = true;
                DisplaySolution(true);
                var lbl = this.main_frm.Controls.Find("lblResult", true)[0];
                lbl.Text = "Winner!!!";
            }

            // Out of guesses - loser
            if (cur_guess == 9)
            {
                game_over = true;
                DisplaySolution(true);
                var lbl = this.main_frm.Controls.Find("lblResult", true)[0];
                lbl.Text = "Loser :(";
            }
        }

        private void DisplaySolution(bool disp)
        {
            // Show or hide solution
            for(int i = 1; i < 5; i++)
            {
            var img = this.main_frm.Controls.Find("solution" + Convert.ToString(i), true)[0];
            img.Visible = disp;
            }
        }

        private void AddSolutionToBoard()
        {
            // Add colors to solution on board
            for (int i = 0; i < 4; i++)
            {
                main_frm.SetSolutionColor(colors[solution[i]], i);
            }
        }
    }
}
