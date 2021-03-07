using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Solver
    {
        private frmSolver solve_form { get; set; }  // form containg solver
        string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };  // colors that can be picked
        List<int[]> solution_set { get; set; }  // list containing all possible solutions
        int[] cur_guess { get; set; } // array of current guess
        int cur_pick { get; set; }  // current pick for result 0 to 3
        int[] result { get; set; }

        public Solver(frmSolver solve_frm)
        {
            solve_form = solve_frm;
            solution_set = new List<int[]>();
            CreateSolutionSet();
            cur_guess = new int[] { 0, 0, 1, 1 };
            DisplayGuess();
            cur_pick = 0;
            result = new int[] { -1, -1, -1, -1 };
        }

        private void CreateSolutionSet()
        {
            // Fill out solution set with all possible guesses
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        for (int l = 0; l < 6; l++)
                        {
                            solution_set.Add(new int[] { i, j, k, l });
                        }
                    }
                }
            }
        }

        private void DisplayGuess()
        {
            // Display colors of cur_guess on board
            for (int i = 0; i < 4; i++)
            {
                solve_form.SetGuessColor(colors[cur_guess[i]], i);
            }
            solve_form.ResetResults();
        }

        public void PickColor(string clr, int res_val)
        {
            // Verify not all results have been selected
            if (cur_pick > 3) { return; }

            // Change result color and update results
            solve_form.SetResultColor(clr, cur_pick);
            result[cur_pick] = res_val;

            cur_pick++;

            // Enable Undo button
            var btnUndo = this.solve_form.Controls.Find("btnUndo", true)[0];
            btnUndo.Enabled = true;
        }

        public void UndoPickColor()
        {
            // Verify not first pick for guess
            if (cur_pick == 0) { return; }

            // Change result color and update result
            cur_pick--;
            solve_form.SetResultColor("grey", cur_pick);
            result[cur_pick] = -1;


            // Disable Undo button if back to first pick
            if (cur_pick == 0)
            {
                var btnUndo = this.solve_form.Controls.Find("btnUndo", true)[0];
                btnUndo.Enabled = false;
            }
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

        public void GetNextGuess()
        {
            /*
            Determine the next guess to try based on the results of the current guess based on algoritm by Donald Knuth.
            The current guess is compared against all remaining possible solutions in solution_set.
            If the the result of the compare doesn't match the result entered then the soultion is removed from the set.
            Once all remaining possible solutions are deteremined, each solution is compared against the remaining solutions.
            The soultion that would eliminate the most possible soultions if wrong is chosen as the next guess.
            If there is a tie for next guess then the first guess checked will be used.
            */

            // Get ammount of exact and wrong place picks
            int[] cur_res = GetResults(result);

            // Solution found
            if (cur_res[0] == 4) { return; }

            // Get compare value for current guess
            int cur_compare = MakeCompareValue(cur_guess);

            // Eliminate solutions that don't match result. Start at the end so removing solutions doesn't mess up the for loop.
            for (int i = solution_set.Count - 1; i >=0; i--)
            {
                int[] res = EvaluateGuess(cur_guess, solution_set[i]);
                if(cur_res[0] != res[0] || cur_res[1] != res[1])
                {
                    solution_set.RemoveAt(i);
                }
            }

            // If no solutions left alert user that they made an error and need to restart
            if (solution_set.Count == 0)
            {
                solve_form.InputError();
                return;
            }

            // Determine next guess by finding guess that will eliminate the most solutions if wrong
            int[] next_guess = solution_set[0];  // Default to first option in solution set
            int next_guess_elim = -1;  // Default to eliminating -1 solutions

            for (int i=0; i<solution_set.Count; i++)
            {
                int elim_count = 0;
                for (int j = 0; j < solution_set.Count; j++)
                {
                    int[] next_res = EvaluateGuess(solution_set[i], solution_set[j]);
                    // See if soultion would be eliminated based on guess
                    if (next_res[0] == 0 && next_res[1] == 0)
                    {
                        elim_count++;
                    }
                }
                // Update next guess if this would eliminate more solutions
                if (elim_count > next_guess_elim)
                {
                    next_guess = solution_set[i];
                    next_guess_elim = elim_count;
                }
            }

            // Update board for next guess
            cur_guess = next_guess;
            DisplayGuess();
            result = new int[] { -1, -1, -1, -1 };
            cur_pick = 0;
        }

        private int[] GetResults(int[] res)
        {
            /*
            Gets the number of exact and wrong place picks from a results array.
            -1 is wrong
            0 is wrong place
            1 is exact match

            Inputs:
            res - integer array containg 4 results

            Outputs:
            integer array containg the number of exact matches as the first value and wrong places as the second value
            */

            int exact = 0;
            int wrong_place = 0;

            // Get ammount of exact and wrong place picks
            for (int i = 0; i < 4; i++)
            {
                if (res[i] == 1)
                {
                    exact++;
                }
                else if (res[i] == 0)
                {
                    wrong_place++;
                }
            }
            return new int[] { exact, wrong_place };
        }

        private int[] EvaluateGuess(int[] guess, int[] solution)
        {
            /*
            Check the result of the guess. Finds if any picks are an exact match and removes them from
            the compare values of the guess and solution.The solution and guess compare values are then
            compared for anyt picks that are in the wrong place. Each digit in the compare values correspond
            to a color.The ones digit of each compare value is compared and the lower value of the 2
            corresponds to the the number of picks for that color is in the wrong place.That color digit
            is removed from the compare values and this repeats until one of the compare values is 0.
            
            Inputs:
            guess - integer array containg 4 color values of a guess
            solution - integer array containg 4 color values of a solution

            Outputs:
            integer array containg the number of exact matches as the first value and wrong places as the second value             
             */

            int exact = 0;
            int wrong_place = 0;
            int guess_check = 0;
            int solution_check = 0;

            // Get compare values
            int guess_comp = MakeCompareValue(guess);
            int solution_comp = MakeCompareValue(solution);

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
                }
                else
                {
                    wrong_place += guess_check;
                }

                // Remove checked color from compare values
                guess_comp = Convert.ToInt32(Math.Floor(guess_comp / 10.0));
                solution_comp = Convert.ToInt32(Math.Floor(solution_comp / 10.0));
            }

            return new int[] { exact, wrong_place };
        }
    }
}
