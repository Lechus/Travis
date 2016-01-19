namespace FluentApp
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
            this.applicant = new System.Windows.Forms.Panel();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.applicant.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicant
            // 
            this.applicant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicant.Controls.Add(this.lastname);
            this.applicant.Controls.Add(this.firstname);
            this.applicant.Location = new System.Drawing.Point(37, 39);
            this.applicant.Name = "applicant";
            this.applicant.Size = new System.Drawing.Size(387, 592);
            this.applicant.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(23, 36);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(131, 22);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "FirstName";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(196, 36);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(131, 22);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "LastName";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(680, 221);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(191, 78);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 684);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.applicant);
            this.Name = "Form1";
            this.Text = "Affiliate";
            this.applicant.ResumeLayout(false);
            this.applicant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel applicant;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button submit;
    }
}

