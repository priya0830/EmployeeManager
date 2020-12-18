
using Employee_Manager.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Employee_Manager.Forms
{
    partial class ViewDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;

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
            this.dgUserDetailsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUserDetailsGrid
            // 
            this.dgUserDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserDetailsGrid.Location = new System.Drawing.Point(23, 22);
            this.dgUserDetailsGrid.Name = "dgUserDetailsGrid";
            this.dgUserDetailsGrid.RowHeadersWidth = 62;
            this.dgUserDetailsGrid.RowTemplate.Height = 28;
            this.dgUserDetailsGrid.Size = new System.Drawing.Size(1419, 565);
            this.dgUserDetailsGrid.TabIndex = 0;
            // 
            // ViewDetails
            // 

            var bindingList = new BindingList<User>((IList<User>)result.data);
            var source = new BindingSource(bindingList, null);
            this.dgUserDetailsGrid.DataSource = result.data;
            
            #region pagination info
            int totalPages = result.meta.pagination.pages;
            int limit = result.meta.pagination.limit;
            int totalRecords = result.meta.pagination.total;
            int currentPageNUmber = result.meta.pagination.page;
            #endregion


            this.ClientSize = new System.Drawing.Size(1703, 661);
            this.Controls.Add(this.dgUserDetailsGrid);
            this.Name = "ViewDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgUserDetailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        
        private DataGridView dgUserDetailsGrid;
    }



    #endregion
}