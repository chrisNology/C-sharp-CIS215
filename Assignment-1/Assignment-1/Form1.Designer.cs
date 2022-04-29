namespace Assignment_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnShowHours = new System.Windows.Forms.Button();
            this.btnHideHours = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_1.Properties.Resources.florist;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Freshest flowers in town!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(477, 113);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(287, 110);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "                   Hours\r\nMonday-Friday    6am to 8pm\r\nSaturday              6am " +
    "to 3pm\r\nSunday                Closed";
            // 
            // btnShowHours
            // 
            this.btnShowHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHours.Location = new System.Drawing.Point(452, 320);
            this.btnShowHours.Name = "btnShowHours";
            this.btnShowHours.Size = new System.Drawing.Size(94, 23);
            this.btnShowHours.TabIndex = 3;
            this.btnShowHours.Text = "&Show Hours";
            this.btnShowHours.UseVisualStyleBackColor = true;
            this.btnShowHours.Click += new System.EventHandler(this.btnShowHours_Click);
            // 
            // btnHideHours
            // 
            this.btnHideHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideHours.Location = new System.Drawing.Point(572, 320);
            this.btnHideHours.Name = "btnHideHours";
            this.btnHideHours.Size = new System.Drawing.Size(88, 23);
            this.btnHideHours.TabIndex = 4;
            this.btnHideHours.Text = "&Hide Hours";
            this.btnHideHours.UseVisualStyleBackColor = true;
            this.btnHideHours.Click += new System.EventHandler(this.btnHideHours_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(689, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHideHours);
            this.Controls.Add(this.btnShowHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Florist Haven";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnShowHours;
        private System.Windows.Forms.Button btnHideHours;
        private System.Windows.Forms.Button btnExit;
    }
}

