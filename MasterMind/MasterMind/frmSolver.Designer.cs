
namespace MasterMind
{
    partial class frmSolver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.picWhite = new System.Windows.Forms.PictureBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.res4 = new System.Windows.Forms.PictureBox();
            this.res3 = new System.Windows.Forms.PictureBox();
            this.res2 = new System.Windows.Forms.PictureBox();
            this.res1 = new System.Windows.Forms.PictureBox();
            this.guess4 = new System.Windows.Forms.PictureBox();
            this.guess3 = new System.Windows.Forms.PictureBox();
            this.guess2 = new System.Windows.Forms.PictureBox();
            this.guess1 = new System.Windows.Forms.PictureBox();
            this.btnNewSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Guess";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(111, 322);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUndo.Location = new System.Drawing.Point(9, 322);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(90, 30);
            this.btnUndo.TabIndex = 28;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // picWhite
            // 
            this.picWhite.Image = global::MasterMind.Properties.Resources.white_large;
            this.picWhite.Location = new System.Drawing.Point(134, 264);
            this.picWhite.Name = "picWhite";
            this.picWhite.Size = new System.Drawing.Size(42, 42);
            this.picWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWhite.TabIndex = 27;
            this.picWhite.TabStop = false;
            this.picWhite.Click += new System.EventHandler(this.picWhite_Click);
            // 
            // picBlack
            // 
            this.picBlack.Image = global::MasterMind.Properties.Resources.black_large;
            this.picBlack.Location = new System.Drawing.Point(34, 264);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(42, 42);
            this.picBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlack.TabIndex = 26;
            this.picBlack.TabStop = false;
            this.picBlack.Click += new System.EventHandler(this.picBlack_Click);
            // 
            // res4
            // 
            this.res4.Image = global::MasterMind.Properties.Resources.grey_large;
            this.res4.Location = new System.Drawing.Point(159, 209);
            this.res4.Name = "res4";
            this.res4.Size = new System.Drawing.Size(42, 42);
            this.res4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.res4.TabIndex = 23;
            this.res4.TabStop = false;
            // 
            // res3
            // 
            this.res3.Image = global::MasterMind.Properties.Resources.grey_large;
            this.res3.Location = new System.Drawing.Point(109, 209);
            this.res3.Name = "res3";
            this.res3.Size = new System.Drawing.Size(42, 42);
            this.res3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.res3.TabIndex = 22;
            this.res3.TabStop = false;
            // 
            // res2
            // 
            this.res2.Image = global::MasterMind.Properties.Resources.grey_large;
            this.res2.Location = new System.Drawing.Point(59, 209);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(42, 42);
            this.res2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.res2.TabIndex = 21;
            this.res2.TabStop = false;
            // 
            // res1
            // 
            this.res1.Image = global::MasterMind.Properties.Resources.grey_large;
            this.res1.Location = new System.Drawing.Point(9, 209);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(42, 42);
            this.res1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.res1.TabIndex = 20;
            this.res1.TabStop = false;
            // 
            // guess4
            // 
            this.guess4.Image = global::MasterMind.Properties.Resources.grey_large;
            this.guess4.Location = new System.Drawing.Point(159, 107);
            this.guess4.Name = "guess4";
            this.guess4.Size = new System.Drawing.Size(42, 42);
            this.guess4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guess4.TabIndex = 19;
            this.guess4.TabStop = false;
            // 
            // guess3
            // 
            this.guess3.Image = global::MasterMind.Properties.Resources.grey_large;
            this.guess3.Location = new System.Drawing.Point(109, 107);
            this.guess3.Name = "guess3";
            this.guess3.Size = new System.Drawing.Size(42, 42);
            this.guess3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guess3.TabIndex = 18;
            this.guess3.TabStop = false;
            // 
            // guess2
            // 
            this.guess2.Image = global::MasterMind.Properties.Resources.grey_large;
            this.guess2.Location = new System.Drawing.Point(59, 107);
            this.guess2.Name = "guess2";
            this.guess2.Size = new System.Drawing.Size(42, 42);
            this.guess2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guess2.TabIndex = 17;
            this.guess2.TabStop = false;
            // 
            // guess1
            // 
            this.guess1.Image = global::MasterMind.Properties.Resources.grey_large;
            this.guess1.Location = new System.Drawing.Point(9, 107);
            this.guess1.Name = "guess1";
            this.guess1.Size = new System.Drawing.Size(42, 42);
            this.guess1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guess1.TabIndex = 16;
            this.guess1.TabStop = false;
            // 
            // btnNewSolve
            // 
            this.btnNewSolve.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewSolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSolve.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSolve.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewSolve.Location = new System.Drawing.Point(34, 12);
            this.btnNewSolve.Name = "btnNewSolve";
            this.btnNewSolve.Size = new System.Drawing.Size(142, 30);
            this.btnNewSolve.TabIndex = 30;
            this.btnNewSolve.Text = "New Solve";
            this.btnNewSolve.UseVisualStyleBackColor = false;
            this.btnNewSolve.Click += new System.EventHandler(this.btnNewSolve_Click);
            // 
            // frmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(210, 359);
            this.Controls.Add(this.btnNewSolve);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.picWhite);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res4);
            this.Controls.Add(this.res3);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.guess4);
            this.Controls.Add(this.guess3);
            this.Controls.Add(this.guess2);
            this.Controls.Add(this.guess1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solver";
            this.Load += new System.EventHandler(this.frmSolver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guess1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox guess1;
        private System.Windows.Forms.PictureBox guess2;
        private System.Windows.Forms.PictureBox guess3;
        private System.Windows.Forms.PictureBox guess4;
        private System.Windows.Forms.PictureBox res1;
        private System.Windows.Forms.PictureBox res2;
        private System.Windows.Forms.PictureBox res3;
        private System.Windows.Forms.PictureBox res4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picWhite;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnNewSolve;
    }
}