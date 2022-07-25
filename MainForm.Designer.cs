
namespace RockScissorsPaper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.butRock = new System.Windows.Forms.Button();
            this.butScissors = new System.Windows.Forms.Button();
            this.butPaper = new System.Windows.Forms.Button();
            this.cntUser = new System.Windows.Forms.TextBox();
            this.cntPC = new System.Windows.Forms.TextBox();
            this.UChoice = new System.Windows.Forms.TextBox();
            this.PChoice = new System.Windows.Forms.TextBox();
            this.AllResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butRock
            // 
            this.butRock.BackColor = System.Drawing.Color.White;
            this.butRock.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Камень;
            this.butRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRock.Location = new System.Drawing.Point(14, 120);
            this.butRock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.butRock.Name = "butRock";
            this.butRock.Size = new System.Drawing.Size(100, 100);
            this.butRock.TabIndex = 0;
            this.butRock.TabStop = false;
            this.butRock.UseVisualStyleBackColor = false;
            this.butRock.Click += new System.EventHandler(this.butRock_Click);
            // 
            // butScissors
            // 
            this.butScissors.BackColor = System.Drawing.Color.White;
            this.butScissors.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Ножницы;
            this.butScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butScissors.Location = new System.Drawing.Point(122, 120);
            this.butScissors.Name = "butScissors";
            this.butScissors.Size = new System.Drawing.Size(100, 100);
            this.butScissors.TabIndex = 1;
            this.butScissors.TabStop = false;
            this.butScissors.UseVisualStyleBackColor = false;
            this.butScissors.Click += new System.EventHandler(this.butScissors_Click);
            // 
            // butPaper
            // 
            this.butPaper.BackColor = System.Drawing.Color.White;
            this.butPaper.BackgroundImage = global::RockScissorsPaper.Properties.Resources.Бумага;
            this.butPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPaper.Location = new System.Drawing.Point(228, 120);
            this.butPaper.Name = "butPaper";
            this.butPaper.Size = new System.Drawing.Size(100, 100);
            this.butPaper.TabIndex = 2;
            this.butPaper.TabStop = false;
            this.butPaper.UseVisualStyleBackColor = false;
            this.butPaper.Click += new System.EventHandler(this.butPaper_Click);
            // 
            // cntUser
            // 
            this.cntUser.BackColor = System.Drawing.Color.White;
            this.cntUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cntUser.Location = new System.Drawing.Point(12, 12);
            this.cntUser.Name = "cntUser";
            this.cntUser.ReadOnly = true;
            this.cntUser.ShortcutsEnabled = false;
            this.cntUser.Size = new System.Drawing.Size(160, 30);
            this.cntUser.TabIndex = 3;
            this.cntUser.TabStop = false;
            this.cntUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cntPC
            // 
            this.cntPC.BackColor = System.Drawing.Color.White;
            this.cntPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cntPC.Location = new System.Drawing.Point(171, 12);
            this.cntPC.Name = "cntPC";
            this.cntPC.ReadOnly = true;
            this.cntPC.ShortcutsEnabled = false;
            this.cntPC.Size = new System.Drawing.Size(160, 30);
            this.cntPC.TabIndex = 4;
            this.cntPC.TabStop = false;
            this.cntPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UChoice
            // 
            this.UChoice.BackColor = System.Drawing.Color.White;
            this.UChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UChoice.Location = new System.Drawing.Point(12, 48);
            this.UChoice.Name = "UChoice";
            this.UChoice.ReadOnly = true;
            this.UChoice.ShortcutsEnabled = false;
            this.UChoice.Size = new System.Drawing.Size(160, 30);
            this.UChoice.TabIndex = 5;
            this.UChoice.TabStop = false;
            this.UChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PChoice
            // 
            this.PChoice.BackColor = System.Drawing.Color.White;
            this.PChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PChoice.Location = new System.Drawing.Point(171, 48);
            this.PChoice.Name = "PChoice";
            this.PChoice.ReadOnly = true;
            this.PChoice.ShortcutsEnabled = false;
            this.PChoice.Size = new System.Drawing.Size(160, 30);
            this.PChoice.TabIndex = 6;
            this.PChoice.TabStop = false;
            this.PChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllResult
            // 
            this.AllResult.BackColor = System.Drawing.Color.White;
            this.AllResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllResult.Location = new System.Drawing.Point(12, 84);
            this.AllResult.Name = "AllResult";
            this.AllResult.ReadOnly = true;
            this.AllResult.ShortcutsEnabled = false;
            this.AllResult.Size = new System.Drawing.Size(319, 30);
            this.AllResult.TabIndex = 7;
            this.AllResult.TabStop = false;
            this.AllResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 234);
            this.Controls.Add(this.AllResult);
            this.Controls.Add(this.PChoice);
            this.Controls.Add(this.UChoice);
            this.Controls.Add(this.cntPC);
            this.Controls.Add(this.cntUser);
            this.Controls.Add(this.butPaper);
            this.Controls.Add(this.butScissors);
            this.Controls.Add(this.butRock);
            this.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Rock-Scissors-Paper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRock;
        private System.Windows.Forms.Button butScissors;
        private System.Windows.Forms.Button butPaper;
        private System.Windows.Forms.TextBox cntUser;
        private System.Windows.Forms.TextBox cntPC;
        private System.Windows.Forms.TextBox UChoice;
        private System.Windows.Forms.TextBox PChoice;
        private System.Windows.Forms.TextBox AllResult;
    }
}

