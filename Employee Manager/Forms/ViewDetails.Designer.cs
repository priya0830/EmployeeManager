
using Employee_Manager.Classes;

namespace Employee_Manager.Forms
{
    partial class ViewDetails
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
        private void InitializeComponent(UsersData result)
        {
            this.datagvViewDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagvViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // datagvViewDetails
            // 
            this.datagvViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvViewDetails.Location = new System.Drawing.Point(91, 57);
            this.datagvViewDetails.Name = "datagvViewDetails";
            this.datagvViewDetails.RowHeadersWidth = 62;
            this.datagvViewDetails.RowTemplate.Height = 28;
            this.datagvViewDetails.Size = new System.Drawing.Size(1023, 445);
            this.datagvViewDetails.TabIndex = 0;
            this.datagvViewDetails.DataSource = result;
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 671);
            this.Controls.Add(this.datagvViewDetails);
            this.Name = "ViewDetails";
            this.Text = "ViewDetails";
            ((System.ComponentModel.ISupportInitialize)(this.datagvViewDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvViewDetails;
    }
}