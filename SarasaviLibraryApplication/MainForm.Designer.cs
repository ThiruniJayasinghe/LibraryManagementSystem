using System.Windows.Forms;

namespace SarasaviLibraryApplication
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
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnBookRegistration = new System.Windows.Forms.Button();
            this.btnUserRegistration = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoan.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.Black;
            this.btnLoan.Location = new System.Drawing.Point(134, 90);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(294, 48);
            this.btnLoan.TabIndex = 0;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(134, 220);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(294, 48);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.Black;
            this.btnReservation.Location = new System.Drawing.Point(134, 290);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(294, 45);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.ForeColor = System.Drawing.Color.Black;
            this.btnInquiry.Location = new System.Drawing.Point(134, 158);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(294, 48);
            this.btnInquiry.TabIndex = 3;
            this.btnInquiry.Text = "Inquiry";
            this.btnInquiry.UseVisualStyleBackColor = false;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnBookRegistration
            // 
            this.btnBookRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookRegistration.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnBookRegistration.Location = new System.Drawing.Point(134, 435);
            this.btnBookRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookRegistration.Name = "btnBookRegistration";
            this.btnBookRegistration.Size = new System.Drawing.Size(294, 52);
            this.btnBookRegistration.TabIndex = 4;
            this.btnBookRegistration.Text = "Book Registration";
            this.btnBookRegistration.UseVisualStyleBackColor = false;
            this.btnBookRegistration.Click += new System.EventHandler(this.btnBookRegistration_Click);
            // 
            // btnUserRegistration
            // 
            this.btnUserRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegistration.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnUserRegistration.Location = new System.Drawing.Point(134, 358);
            this.btnUserRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserRegistration.Name = "btnUserRegistration";
            this.btnUserRegistration.Size = new System.Drawing.Size(294, 54);
            this.btnUserRegistration.TabIndex = 5;
            this.btnUserRegistration.Text = "User Registration";
            this.btnUserRegistration.UseVisualStyleBackColor = false;
            this.btnUserRegistration.Click += new System.EventHandler(this.btnUserRegistration_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SarasaviLibraryApplication.Properties.Resources.oop;
            this.pictureBox4.Location = new System.Drawing.Point(637, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(503, 197);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SarasaviLibraryApplication.Properties.Resources.sarasavi__1_;
            this.pictureBox3.Location = new System.Drawing.Point(543, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(735, 482);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(50, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1228, 482);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1306, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 583);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBookRegistration);
            this.Controls.Add(this.btnUserRegistration);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoan;
        private Button btnReturn;
        private Button btnReservation;
        private Button btnInquiry;
        private Button btnBookRegistration;
        private Button btnUserRegistration;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
