
namespace MasterMind
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.solution4 = new System.Windows.Forms.PictureBox();
            this.solution3 = new System.Windows.Forms.PictureBox();
            this.solution2 = new System.Windows.Forms.PictureBox();
            this.solution1 = new System.Windows.Forms.PictureBox();
            this.pnlMakeGuess = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPurple = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picYellow = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.tsmNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolver = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solution4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution1)).BeginInit();
            this.pnlMakeGuess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSolution
            // 
            this.pnlSolution.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolution.Controls.Add(this.solution4);
            this.pnlSolution.Controls.Add(this.solution3);
            this.pnlSolution.Controls.Add(this.solution2);
            this.pnlSolution.Controls.Add(this.solution1);
            this.pnlSolution.Location = new System.Drawing.Point(330, 675);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(213, 58);
            this.pnlSolution.TabIndex = 0;
            // 
            // solution4
            // 
            this.solution4.Location = new System.Drawing.Point(159, 8);
            this.solution4.Name = "solution4";
            this.solution4.Size = new System.Drawing.Size(42, 42);
            this.solution4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.solution4.TabIndex = 7;
            this.solution4.TabStop = false;
            // 
            // solution3
            // 
            this.solution3.Location = new System.Drawing.Point(109, 8);
            this.solution3.Name = "solution3";
            this.solution3.Size = new System.Drawing.Size(42, 42);
            this.solution3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.solution3.TabIndex = 6;
            this.solution3.TabStop = false;
            // 
            // solution2
            // 
            this.solution2.Location = new System.Drawing.Point(59, 8);
            this.solution2.Name = "solution2";
            this.solution2.Size = new System.Drawing.Size(42, 42);
            this.solution2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.solution2.TabIndex = 5;
            this.solution2.TabStop = false;
            // 
            // solution1
            // 
            this.solution1.Location = new System.Drawing.Point(9, 8);
            this.solution1.Name = "solution1";
            this.solution1.Size = new System.Drawing.Size(42, 42);
            this.solution1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.solution1.TabIndex = 4;
            this.solution1.TabStop = false;
            // 
            // pnlMakeGuess
            // 
            this.pnlMakeGuess.BackColor = System.Drawing.Color.LightCyan;
            this.pnlMakeGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMakeGuess.Controls.Add(this.panel1);
            this.pnlMakeGuess.Controls.Add(this.btnGuess);
            this.pnlMakeGuess.Controls.Add(this.btnUndo);
            this.pnlMakeGuess.Location = new System.Drawing.Point(10, 570);
            this.pnlMakeGuess.Name = "pnlMakeGuess";
            this.pnlMakeGuess.Size = new System.Drawing.Size(310, 100);
            this.pnlMakeGuess.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picPurple);
            this.panel1.Controls.Add(this.picBlue);
            this.panel1.Controls.Add(this.picGreen);
            this.panel1.Controls.Add(this.picYellow);
            this.panel1.Controls.Add(this.picOrange);
            this.panel1.Controls.Add(this.picRed);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 60);
            this.panel1.TabIndex = 12;
            // 
            // picPurple
            // 
            this.picPurple.Image = global::MasterMind.Properties.Resources.purple;
            this.picPurple.Location = new System.Drawing.Point(259, 9);
            this.picPurple.Name = "picPurple";
            this.picPurple.Size = new System.Drawing.Size(42, 42);
            this.picPurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPurple.TabIndex = 15;
            this.picPurple.TabStop = false;
            this.picPurple.Click += new System.EventHandler(this.picPurple_Click);
            // 
            // picBlue
            // 
            this.picBlue.Image = global::MasterMind.Properties.Resources.blue;
            this.picBlue.Location = new System.Drawing.Point(209, 9);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(42, 42);
            this.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlue.TabIndex = 14;
            this.picBlue.TabStop = false;
            this.picBlue.Click += new System.EventHandler(this.picBlue_Click);
            // 
            // picGreen
            // 
            this.picGreen.Image = global::MasterMind.Properties.Resources.green;
            this.picGreen.Location = new System.Drawing.Point(159, 9);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(42, 42);
            this.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGreen.TabIndex = 13;
            this.picGreen.TabStop = false;
            this.picGreen.Click += new System.EventHandler(this.picGreen_Click);
            // 
            // picYellow
            // 
            this.picYellow.Image = global::MasterMind.Properties.Resources.yellow;
            this.picYellow.Location = new System.Drawing.Point(109, 9);
            this.picYellow.Name = "picYellow";
            this.picYellow.Size = new System.Drawing.Size(42, 42);
            this.picYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picYellow.TabIndex = 12;
            this.picYellow.TabStop = false;
            this.picYellow.Click += new System.EventHandler(this.picYellow_Click);
            // 
            // picOrange
            // 
            this.picOrange.Image = global::MasterMind.Properties.Resources.orange;
            this.picOrange.Location = new System.Drawing.Point(59, 9);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(42, 42);
            this.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOrange.TabIndex = 11;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.picOrange_Click);
            // 
            // picRed
            // 
            this.picRed.Image = global::MasterMind.Properties.Resources.red;
            this.picRed.Location = new System.Drawing.Point(9, 9);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(42, 42);
            this.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRed.TabIndex = 10;
            this.picRed.TabStop = false;
            this.picRed.Click += new System.EventHandler(this.picRed_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuess.Enabled = false;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuess.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuess.Location = new System.Drawing.Point(170, 64);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(90, 30);
            this.btnGuess.TabIndex = 11;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUndo.Location = new System.Drawing.Point(50, 64);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(90, 30);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewGame,
            this.tsmInstructions,
            this.tsmSolver});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(611, 24);
            this.main_menu.TabIndex = 13;
            this.main_menu.Text = "menuStrip1";
            // 
            // tsmNewGame
            // 
            this.tsmNewGame.Name = "tsmNewGame";
            this.tsmNewGame.Size = new System.Drawing.Size(77, 20);
            this.tsmNewGame.Text = "New Game";
            this.tsmNewGame.Click += new System.EventHandler(this.tsmNewGame_Click);
            // 
            // tsmInstructions
            // 
            this.tsmInstructions.Name = "tsmInstructions";
            this.tsmInstructions.Size = new System.Drawing.Size(81, 20);
            this.tsmInstructions.Text = "Instructions";
            this.tsmInstructions.Click += new System.EventHandler(this.tsmInstructions_Click);
            // 
            // tsmSolver
            // 
            this.tsmSolver.Name = "tsmSolver";
            this.tsmSolver.Size = new System.Drawing.Size(51, 20);
            this.tsmSolver.Text = "Solver";
            this.tsmSolver.Click += new System.EventHandler(this.tsmSolver_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(10, 675);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(310, 58);
            this.lblResult.TabIndex = 14;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(611, 741);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pnlMakeGuess);
            this.Controls.Add(this.pnlSolution);
            this.Controls.Add(this.main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.main_menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSolution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solution4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solution1)).EndInit();
            this.pnlMakeGuess.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.PictureBox solution4;
        private System.Windows.Forms.PictureBox solution3;
        private System.Windows.Forms.PictureBox solution2;
        private System.Windows.Forms.PictureBox solution1;
        private System.Windows.Forms.Panel pnlMakeGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPurple;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picYellow;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem tsmNewGame;
        private System.Windows.Forms.ToolStripMenuItem tsmInstructions;
        private System.Windows.Forms.ToolStripMenuItem tsmSolver;
        private System.Windows.Forms.Label lblResult;
    }
}

