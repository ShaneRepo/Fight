namespace Fight
{
    partial class Form1
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
            this.listBoxBattleResults = new System.Windows.Forms.ListBox();
            this.labelBattleResults = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBoxWins = new System.Windows.Forms.TextBox();
            this.textBoxLosses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fight Game";
            // 
            // listBoxBattleResults
            // 
            this.listBoxBattleResults.FormattingEnabled = true;
            this.listBoxBattleResults.Location = new System.Drawing.Point(343, 149);
            this.listBoxBattleResults.Name = "listBoxBattleResults";
            this.listBoxBattleResults.Size = new System.Drawing.Size(237, 186);
            this.listBoxBattleResults.TabIndex = 1;
            // 
            // labelBattleResults
            // 
            this.labelBattleResults.AutoSize = true;
            this.labelBattleResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattleResults.Location = new System.Drawing.Point(383, 112);
            this.labelBattleResults.Name = "labelBattleResults";
            this.labelBattleResults.Size = new System.Drawing.Size(123, 20);
            this.labelBattleResults.TabIndex = 2;
            this.labelBattleResults.Text = "Battle Results";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(101, 112);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(205, 112);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save Game";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(101, 167);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load Game";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(205, 167);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit Game";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // textBoxWins
            // 
            this.textBoxWins.Location = new System.Drawing.Point(65, 278);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.Size = new System.Drawing.Size(100, 20);
            this.textBoxWins.TabIndex = 7;
            // 
            // textBoxLosses
            // 
            this.textBoxLosses.Location = new System.Drawing.Point(190, 278);
            this.textBoxLosses.Name = "textBoxLosses";
            this.textBoxLosses.Size = new System.Drawing.Size(100, 20);
            this.textBoxLosses.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wins";
            // 
            // labelLoss
            // 
            this.labelLoss.AutoSize = true;
            this.labelLoss.Location = new System.Drawing.Point(202, 241);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(40, 13);
            this.labelLoss.TabIndex = 10;
            this.labelLoss.Text = "Losses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(857, 552);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLosses);
            this.Controls.Add(this.textBoxWins);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelBattleResults);
            this.Controls.Add(this.listBoxBattleResults);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBattleResults;
        private System.Windows.Forms.Label labelBattleResults;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxWins;
        private System.Windows.Forms.TextBox textBoxLosses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoss;
    }
}

