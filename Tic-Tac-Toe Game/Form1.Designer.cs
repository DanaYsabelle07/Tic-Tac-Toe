namespace Tic_Tac_Toe_Game
{
    partial class board
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
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box1.Location = new System.Drawing.Point(83, 47);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(80, 80);
            this.box1.TabIndex = 1;
            this.box1.UseVisualStyleBackColor = true;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box2.Location = new System.Drawing.Point(189, 47);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(80, 80);
            this.box2.TabIndex = 2;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box3
            // 
            this.box3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box3.Location = new System.Drawing.Point(297, 47);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(80, 80);
            this.box3.TabIndex = 3;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box4
            // 
            this.box4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box4.Location = new System.Drawing.Point(83, 143);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(80, 80);
            this.box4.TabIndex = 4;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box5
            // 
            this.box5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box5.Location = new System.Drawing.Point(189, 143);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(80, 80);
            this.box5.TabIndex = 5;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box6
            // 
            this.box6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box6.Location = new System.Drawing.Point(297, 143);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(80, 80);
            this.box6.TabIndex = 6;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box7
            // 
            this.box7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box7.Location = new System.Drawing.Point(83, 246);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(80, 80);
            this.box7.TabIndex = 7;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // box8
            // 
            this.box8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box8.Location = new System.Drawing.Point(189, 246);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(80, 80);
            this.box8.TabIndex = 8;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box9
            // 
            this.box9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box9.Location = new System.Drawing.Point(297, 246);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(80, 80);
            this.box9.TabIndex = 9;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 368);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "board";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private Button box1;
        private Button box2;
        private Button box3;
        private Button box4;
        private Button box5;
        private Button box6;
        private Button box7;
        private Button box8;
        private Button box9;
    }
}