
namespace Employee_Manager.Forms
{
    partial class AddEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.dateUpdated = new System.Windows.Forms.DateTimePicker();
            this.btnCreatedNow = new System.Windows.Forms.Button();
            this.btnUpdatedNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(237, 208);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(236, 26);
            this.txtGender.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(237, 341);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Updated";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(237, 570);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 49);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_ClickAsync);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboStatus.Location = new System.Drawing.Point(237, 280);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(236, 28);
            this.comboStatus.TabIndex = 14;
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(237, 428);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(236, 26);
            this.dateCreated.TabIndex = 15;
            // 
            // dateUpdated
            // 
            this.dateUpdated.Location = new System.Drawing.Point(237, 513);
            this.dateUpdated.Name = "dateUpdated";
            this.dateUpdated.Size = new System.Drawing.Size(236, 26);
            this.dateUpdated.TabIndex = 16;
            // 
            // btnCreatedNow
            // 
            this.btnCreatedNow.Location = new System.Drawing.Point(507, 425);
            this.btnCreatedNow.Name = "btnCreatedNow";
            this.btnCreatedNow.Size = new System.Drawing.Size(106, 26);
            this.btnCreatedNow.TabIndex = 17;
            this.btnCreatedNow.Text = "Now";
            this.btnCreatedNow.UseVisualStyleBackColor = true;
            this.btnCreatedNow.Click += new System.EventHandler(this.btnCreatedNow_Click);
            // 
            // btnUpdatedNow
            // 
            this.btnUpdatedNow.Location = new System.Drawing.Point(507, 515);
            this.btnUpdatedNow.Name = "btnUpdatedNow";
            this.btnUpdatedNow.Size = new System.Drawing.Size(106, 26);
            this.btnUpdatedNow.TabIndex = 18;
            this.btnUpdatedNow.Text = "Now";
            this.btnUpdatedNow.UseVisualStyleBackColor = true;
            this.btnUpdatedNow.Click += new System.EventHandler(this.btnUpdatedNow_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 655);
            this.Controls.Add(this.btnUpdatedNow);
            this.Controls.Add(this.btnCreatedNow);
            this.Controls.Add(this.dateUpdated);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.DateTimePicker dateUpdated;
        private System.Windows.Forms.Button btnCreatedNow;
        private System.Windows.Forms.Button btnUpdatedNow;
    }
}