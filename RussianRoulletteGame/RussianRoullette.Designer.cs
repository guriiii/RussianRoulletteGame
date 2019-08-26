namespace RussianRoulletteGame
{
    partial class RussianRoullette
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoading = new System.Windows.Forms.Button();
            this.btnSpinning = new System.Windows.Forms.Button();
            this.btnShootAhead = new System.Windows.Forms.Button();
            this.btnShootAway = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.borderForWar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderForWar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.borderForWar);
            this.panel1.Location = new System.Drawing.Point(91, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 229);
            this.panel1.TabIndex = 0;
            // 
            // btnLoading
            // 
            this.btnLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoading.Location = new System.Drawing.Point(91, 42);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(75, 56);
            this.btnLoading.TabIndex = 1;
            this.btnLoading.Text = "Loading";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // btnSpinning
            // 
            this.btnSpinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinning.Location = new System.Drawing.Point(205, 42);
            this.btnSpinning.Name = "btnSpinning";
            this.btnSpinning.Size = new System.Drawing.Size(75, 56);
            this.btnSpinning.TabIndex = 2;
            this.btnSpinning.Text = "Spinning";
            this.btnSpinning.UseVisualStyleBackColor = true;
            this.btnSpinning.Click += new System.EventHandler(this.btnSpinning_Click);
            // 
            // btnShootAhead
            // 
            this.btnShootAhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootAhead.Location = new System.Drawing.Point(307, 42);
            this.btnShootAhead.Name = "btnShootAhead";
            this.btnShootAhead.Size = new System.Drawing.Size(82, 56);
            this.btnShootAhead.TabIndex = 3;
            this.btnShootAhead.Text = "Shoot Ahead";
            this.btnShootAhead.UseVisualStyleBackColor = true;
            this.btnShootAhead.Click += new System.EventHandler(this.btnShootAhead_Click);
            // 
            // btnShootAway
            // 
            this.btnShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootAway.Location = new System.Drawing.Point(415, 42);
            this.btnShootAway.Name = "btnShootAway";
            this.btnShootAway.Size = new System.Drawing.Size(75, 56);
            this.btnShootAway.TabIndex = 4;
            this.btnShootAway.Text = "Shoot Away";
            this.btnShootAway.UseVisualStyleBackColor = true;
            this.btnShootAway.Click += new System.EventHandler(this.btnShootAway_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(522, 42);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 56);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // borderForWar
            // 
            this.borderForWar.Image = global::RussianRoulletteGame.Properties.Resources.war33;
            this.borderForWar.Location = new System.Drawing.Point(-2, -2);
            this.borderForWar.Name = "borderForWar";
            this.borderForWar.Size = new System.Drawing.Size(507, 229);
            this.borderForWar.TabIndex = 6;
            this.borderForWar.TabStop = false;
            // 
            // RussianRoullette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(690, 387);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnShootAway);
            this.Controls.Add(this.btnShootAhead);
            this.Controls.Add(this.btnSpinning);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.panel1);
            this.Name = "RussianRoullette";
            this.Text = "RussianRoullette";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borderForWar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Button btnSpinning;
        private System.Windows.Forms.Button btnShootAhead;
        private System.Windows.Forms.Button btnShootAway;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox borderForWar;
    }
}