namespace hospitalmanagementsystem
{
    partial class loginas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.doctor = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 880);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(387, 314);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(190, 58);
            this.admin.TabIndex = 2;
            this.admin.Text = "LOGIN AS ADMIN";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // doctor
            // 
            this.doctor.Location = new System.Drawing.Point(387, 412);
            this.doctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(190, 58);
            this.doctor.TabIndex = 3;
            this.doctor.Text = "LOGIN AS DOCTOR";
            this.doctor.UseVisualStyleBackColor = true;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(387, 522);
            this.staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(190, 58);
            this.staff.TabIndex = 4;
            this.staff.Text = "LOGIN AS STAFF";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 875);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "loginas";
            this.Text = "loginas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button doctor;
        private System.Windows.Forms.Button staff;
    }
}

