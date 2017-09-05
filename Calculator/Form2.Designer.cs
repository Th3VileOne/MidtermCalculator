namespace Calculator
{
    partial class Form2
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
            this.buttonresult = new System.Windows.Forms.Button();
            this.buttondivi = new System.Windows.Forms.Button();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maintextbox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonresult
            // 
            this.buttonresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonresult.Location = new System.Drawing.Point(35, 307);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(315, 52);
            this.buttonresult.TabIndex = 31;
            this.buttonresult.Text = "=";
            this.buttonresult.UseVisualStyleBackColor = true;
            this.buttonresult.Click += new System.EventHandler(this.Calculate);
            // 
            // buttondivi
            // 
            this.buttondivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttondivi.Location = new System.Drawing.Point(229, 249);
            this.buttondivi.Name = "buttondivi";
            this.buttondivi.Size = new System.Drawing.Size(121, 52);
            this.buttondivi.TabIndex = 30;
            this.buttondivi.Text = "/";
            this.buttondivi.UseVisualStyleBackColor = true;
            this.buttondivi.Click += new System.EventHandler(this.num_click);
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonmultiply.Location = new System.Drawing.Point(229, 195);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(121, 48);
            this.buttonmultiply.TabIndex = 29;
            this.buttonmultiply.Text = "x";
            this.buttonmultiply.UseVisualStyleBackColor = true;
            this.buttonmultiply.Click += new System.EventHandler(this.num_click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonminus.Location = new System.Drawing.Point(229, 139);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(121, 50);
            this.buttonminus.TabIndex = 28;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.num_click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonadd.Location = new System.Drawing.Point(229, 82);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(121, 51);
            this.buttonadd.TabIndex = 27;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.num_click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button0.Location = new System.Drawing.Point(35, 249);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(183, 52);
            this.button0.TabIndex = 26;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.num_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(162, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 48);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(96, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 48);
            this.button8.TabIndex = 24;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.num_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.Location = new System.Drawing.Point(35, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 48);
            this.button7.TabIndex = 23;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button6.Location = new System.Drawing.Point(162, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 50);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(96, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 21;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.Location = new System.Drawing.Point(35, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 50);
            this.button4.TabIndex = 20;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.num_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(162, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 51);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(96, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 51);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(35, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_click);
            // 
            // maintextbox
            // 
            this.maintextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.maintextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.maintextbox.Location = new System.Drawing.Point(25, 15);
            this.maintextbox.Name = "maintextbox";
            this.maintextbox.ReadOnly = true;
            this.maintextbox.Size = new System.Drawing.Size(325, 53);
            this.maintextbox.TabIndex = 16;
            this.maintextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maintextbox_KeyPress);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button10.Location = new System.Drawing.Point(356, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 51);
            this.button10.TabIndex = 32;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 380);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonresult);
            this.Controls.Add(this.buttondivi);
            this.Controls.Add(this.buttonmultiply);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maintextbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonresult;
        private System.Windows.Forms.Button buttondivi;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox maintextbox;
        private System.Windows.Forms.Button button10;
    }
}