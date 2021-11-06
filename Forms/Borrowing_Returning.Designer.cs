
namespace Library
{
    partial class Borrowing_Returning
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
            this.lbPurchaseDate = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBorrows = new System.Windows.Forms.DataGridView();
            this.checkBoxBorrow = new System.Windows.Forms.CheckBox();
            this.checkBoxReturn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member_id :";
            // 
            // lbPurchaseDate
            // 
            this.lbPurchaseDate.AutoSize = true;
            this.lbPurchaseDate.Location = new System.Drawing.Point(38, 135);
            this.lbPurchaseDate.Name = "lbPurchaseDate";
            this.lbPurchaseDate.Size = new System.Drawing.Size(81, 15);
            this.lbPurchaseDate.TabIndex = 4;
            this.lbPurchaseDate.Text = "Purchase date";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(143, 66);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(91, 23);
            this.txtIsbn.TabIndex = 5;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(143, 95);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(131, 23);
            this.txtMemberId.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(38, 167);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(69, 15);
            this.lbReturnDate.TabIndex = 9;
            this.lbReturnDate.Text = "Return Date";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(143, 127);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerPurchaseDate.TabIndex = 10;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(143, 159);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerReturnDate.TabIndex = 11;
            // 
            // dataGridViewBorrows
            // 
            this.dataGridViewBorrows.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBorrows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrows.Location = new System.Drawing.Point(398, 66);
            this.dataGridViewBorrows.Name = "dataGridViewBorrows";
            this.dataGridViewBorrows.RowTemplate.Height = 25;
            this.dataGridViewBorrows.Size = new System.Drawing.Size(336, 186);
            this.dataGridViewBorrows.TabIndex = 12;
            // 
            // checkBoxBorrow
            // 
            this.checkBoxBorrow.AutoSize = true;
            this.checkBoxBorrow.Location = new System.Drawing.Point(143, 189);
            this.checkBoxBorrow.Name = "checkBoxBorrow";
            this.checkBoxBorrow.Size = new System.Drawing.Size(64, 19);
            this.checkBoxBorrow.TabIndex = 13;
            this.checkBoxBorrow.Text = "Borrow";
            this.checkBoxBorrow.UseVisualStyleBackColor = true;
            // 
            // checkBoxReturn
            // 
            this.checkBoxReturn.AutoSize = true;
            this.checkBoxReturn.Location = new System.Drawing.Point(260, 188);
            this.checkBoxReturn.Name = "checkBoxReturn";
            this.checkBoxReturn.Size = new System.Drawing.Size(61, 19);
            this.checkBoxReturn.TabIndex = 14;
            this.checkBoxReturn.Text = "Return";
            this.checkBoxReturn.UseVisualStyleBackColor = true;
            // 
            // Borrowing_Returning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 264);
            this.Controls.Add(this.checkBoxReturn);
            this.Controls.Add(this.checkBoxBorrow);
            this.Controls.Add(this.dataGridViewBorrows);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lbPurchaseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Borrowing_Returning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow/Return";
            this.Load += new System.EventHandler(this.Borrowing_Returning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPurchaseDate;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DataGridView dataGridViewBorrows;
        private System.Windows.Forms.CheckBox checkBoxBorrow;
        private System.Windows.Forms.CheckBox checkBoxReturn;
    }
}