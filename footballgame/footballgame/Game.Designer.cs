namespace footballgame
{
    partial class Game
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
            this.btnGameExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameExit
            // 
            this.btnGameExit.Location = new System.Drawing.Point(641, 488);
            this.btnGameExit.Name = "btnGameExit";
            this.btnGameExit.Size = new System.Drawing.Size(75, 23);
            this.btnGameExit.TabIndex = 0;
            this.btnGameExit.Text = "Exit";
            this.btnGameExit.UseVisualStyleBackColor = true;
            this.btnGameExit.Click += new System.EventHandler(this.btnGameExit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 523);
            this.Controls.Add(this.btnGameExit);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameExit;
    }
}