MasterMind.exe    C# windows desktop application
GitHub: https://github.com/koenigjo/MasterMind

Allows a user to play a game of MastMind against a randomly seected solution.
Instructions are in the game.
Has a solver using the algorithm by Donald Knuth that suggests a guess and determines 
  the next guess to make based on the results of the previous guess.
frmMain, frmInstructions, frmSolver are the 3 forms in the program.
Game.cs is the class for a game of MasterMind.
  - Contains methods for making and verifying guesses and determining the state of the game
Solver.cs is the class for solving a game of MasterMind.
  - Contains methods for determining the next guess to make based on the results of the previous guess.
