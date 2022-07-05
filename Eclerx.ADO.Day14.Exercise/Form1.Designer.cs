namespace Eclerx.ADO.Day14.Exercise
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
            this.LblStudCode = new System.Windows.Forms.Label();
            this.LblStudName = new System.Windows.Forms.Label();
            this.LblDeptCode = new System.Windows.Forms.Label();
            this.LblStudDob = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtStudCode = new System.Windows.Forms.TextBox();
            this.TxtStudName = new System.Windows.Forms.TextBox();
            this.TxtDeptCode = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.DTPStudDob = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStudCode
            // 
            this.LblStudCode.AutoSize = true;
            this.LblStudCode.Location = new System.Drawing.Point(146, 45);
            this.LblStudCode.Name = "LblStudCode";
            this.LblStudCode.Size = new System.Drawing.Size(72, 13);
            this.LblStudCode.TabIndex = 0;
            this.LblStudCode.Text = "Student Code";
            // 
            // LblStudName
            // 
            this.LblStudName.AutoSize = true;
            this.LblStudName.Location = new System.Drawing.Point(146, 86);
            this.LblStudName.Name = "LblStudName";
            this.LblStudName.Size = new System.Drawing.Size(75, 13);
            this.LblStudName.TabIndex = 1;
            this.LblStudName.Text = "Student Name";
            // 
            // LblDeptCode
            // 
            this.LblDeptCode.AutoSize = true;
            this.LblDeptCode.Location = new System.Drawing.Point(146, 125);
            this.LblDeptCode.Name = "LblDeptCode";
            this.LblDeptCode.Size = new System.Drawing.Size(90, 13);
            this.LblDeptCode.TabIndex = 2;
            this.LblDeptCode.Text = "Department Code";
            // 
            // LblStudDob
            // 
            this.LblStudDob.AutoSize = true;
            this.LblStudDob.Location = new System.Drawing.Point(146, 163);
            this.LblStudDob.Name = "LblStudDob";
            this.LblStudDob.Size = new System.Drawing.Size(70, 13);
            this.LblStudDob.TabIndex = 3;
            this.LblStudDob.Text = "Student DOB";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(146, 202);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "Address";
            // 
            // TxtStudCode
            // 
            this.TxtStudCode.Location = new System.Drawing.Point(270, 42);
            this.TxtStudCode.Name = "TxtStudCode";
            this.TxtStudCode.Size = new System.Drawing.Size(200, 20);
            this.TxtStudCode.TabIndex = 5;
            // 
            // TxtStudName
            // 
            this.TxtStudName.Location = new System.Drawing.Point(270, 83);
            this.TxtStudName.Name = "TxtStudName";
            this.TxtStudName.Size = new System.Drawing.Size(200, 20);
            this.TxtStudName.TabIndex = 6;
            // 
            // TxtDeptCode
            // 
            this.TxtDeptCode.Location = new System.Drawing.Point(270, 122);
            this.TxtDeptCode.Name = "TxtDeptCode";
            this.TxtDeptCode.Size = new System.Drawing.Size(200, 20);
            this.TxtDeptCode.TabIndex = 7;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(270, 199);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(200, 20);
            this.TxtAddress.TabIndex = 8;
            // 
            // DTPStudDob
            // 
            this.DTPStudDob.Location = new System.Drawing.Point(270, 155);
            this.DTPStudDob.Name = "DTPStudDob";
            this.DTPStudDob.Size = new System.Drawing.Size(200, 20);
            this.DTPStudDob.TabIndex = 9;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(527, 34);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(149, 269);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 12;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(324, 269);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(494, 269);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DTPStudDob);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtDeptCode);
            this.Controls.Add(this.TxtStudName);
            this.Controls.Add(this.TxtStudCode);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblStudDob);
            this.Controls.Add(this.LblDeptCode);
            this.Controls.Add(this.LblStudName);
            this.Controls.Add(this.LblStudCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudCode;
        private System.Windows.Forms.Label LblStudName;
        private System.Windows.Forms.Label LblDeptCode;
        private System.Windows.Forms.Label LblStudDob;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtStudCode;
        private System.Windows.Forms.TextBox TxtStudName;
        private System.Windows.Forms.TextBox TxtDeptCode;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.DateTimePicker DTPStudDob;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}

