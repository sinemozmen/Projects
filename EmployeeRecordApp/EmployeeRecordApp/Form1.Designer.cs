namespace EmployeeRecordApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.pictureBoxEmp = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxDrivingLic = new System.Windows.Forms.GroupBox();
            this.cbD1 = new System.Windows.Forms.CheckBox();
            this.cbE = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA2 = new System.Windows.Forms.CheckBox();
            this.cbA1 = new System.Windows.Forms.CheckBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpEmployementDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployementDate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblDateofBirth = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeRecordDataSet = new EmployeeRecordApp.EmployeeRecordDataSet();
            this.employeeRecordDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).BeginInit();
            this.groupBoxDrivingLic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.btnUpdate);
            this.groupBoxEmployee.Controls.Add(this.btnDel);
            this.groupBoxEmployee.Controls.Add(this.btnAdd);
            this.groupBoxEmployee.Controls.Add(this.btnClearPicture);
            this.groupBoxEmployee.Controls.Add(this.btnAddPicture);
            this.groupBoxEmployee.Controls.Add(this.pictureBoxEmp);
            this.groupBoxEmployee.Controls.Add(this.lblStatus);
            this.groupBoxEmployee.Controls.Add(this.rbSingle);
            this.groupBoxEmployee.Controls.Add(this.rbMarried);
            this.groupBoxEmployee.Controls.Add(this.txtTitle);
            this.groupBoxEmployee.Controls.Add(this.lblTitle);
            this.groupBoxEmployee.Controls.Add(this.groupBoxDrivingLic);
            this.groupBoxEmployee.Controls.Add(this.lblSex);
            this.groupBoxEmployee.Controls.Add(this.rbMale);
            this.groupBoxEmployee.Controls.Add(this.rbFemale);
            this.groupBoxEmployee.Controls.Add(this.txtSurname);
            this.groupBoxEmployee.Controls.Add(this.txtName);
            this.groupBoxEmployee.Controls.Add(this.lblAddress);
            this.groupBoxEmployee.Controls.Add(this.lblMail);
            this.groupBoxEmployee.Controls.Add(this.txtAddress);
            this.groupBoxEmployee.Controls.Add(this.txtEmail);
            this.groupBoxEmployee.Controls.Add(this.lblPhone);
            this.groupBoxEmployee.Controls.Add(this.txtPhone);
            this.groupBoxEmployee.Controls.Add(this.dtpEmployementDate);
            this.groupBoxEmployee.Controls.Add(this.lblEmployementDate);
            this.groupBoxEmployee.Controls.Add(this.dtpBirthdate);
            this.groupBoxEmployee.Controls.Add(this.lblDateofBirth);
            this.groupBoxEmployee.Controls.Add(this.lblSurname);
            this.groupBoxEmployee.Controls.Add(this.lblName);
            this.groupBoxEmployee.Controls.Add(this.txtIdNumber);
            this.groupBoxEmployee.Controls.Add(this.lblId);
            this.groupBoxEmployee.Location = new System.Drawing.Point(52, 8);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(806, 369);
            this.groupBoxEmployee.TabIndex = 0;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(666, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(550, 311);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 36);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(434, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.Location = new System.Drawing.Point(434, 101);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(75, 36);
            this.btnClearPicture.TabIndex = 29;
            this.btnClearPicture.Text = "Clear Picture";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.BtnClearPicture_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(434, 44);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 36);
            this.btnAddPicture.TabIndex = 28;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.BtnAddPicture_Click);
            // 
            // pictureBoxEmp
            // 
            this.pictureBoxEmp.Image = global::EmployeeRecordApp.Properties.Resources.PictureAddIcon;
            this.pictureBoxEmp.Location = new System.Drawing.Point(542, 33);
            this.pictureBoxEmp.Name = "pictureBoxEmp";
            this.pictureBoxEmp.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmp.TabIndex = 27;
            this.pictureBoxEmp.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(434, 260);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Marital Status";
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(566, 260);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 25;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(644, 260);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(60, 17);
            this.rbMarried.TabIndex = 24;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(542, 225);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(434, 229);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Title";
            // 
            // groupBoxDrivingLic
            // 
            this.groupBoxDrivingLic.Controls.Add(this.cbD1);
            this.groupBoxDrivingLic.Controls.Add(this.cbE);
            this.groupBoxDrivingLic.Controls.Add(this.cbC);
            this.groupBoxDrivingLic.Controls.Add(this.cbB);
            this.groupBoxDrivingLic.Controls.Add(this.cbA2);
            this.groupBoxDrivingLic.Controls.Add(this.cbA1);
            this.groupBoxDrivingLic.Location = new System.Drawing.Point(15, 311);
            this.groupBoxDrivingLic.Name = "groupBoxDrivingLic";
            this.groupBoxDrivingLic.Size = new System.Drawing.Size(273, 50);
            this.groupBoxDrivingLic.TabIndex = 21;
            this.groupBoxDrivingLic.TabStop = false;
            this.groupBoxDrivingLic.Text = "Driving Licence";
            // 
            // cbD1
            // 
            this.cbD1.AutoSize = true;
            this.cbD1.Location = new System.Drawing.Point(179, 19);
            this.cbD1.Name = "cbD1";
            this.cbD1.Size = new System.Drawing.Size(34, 17);
            this.cbD1.TabIndex = 6;
            this.cbD1.Text = "D";
            this.cbD1.UseVisualStyleBackColor = true;
            // 
            // cbE
            // 
            this.cbE.AutoSize = true;
            this.cbE.Location = new System.Drawing.Point(219, 19);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(33, 17);
            this.cbE.TabIndex = 5;
            this.cbE.Text = "E";
            this.cbE.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(140, 19);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 17);
            this.cbC.TabIndex = 3;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(101, 20);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(33, 17);
            this.cbB.TabIndex = 2;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA2
            // 
            this.cbA2.AutoSize = true;
            this.cbA2.Location = new System.Drawing.Point(56, 20);
            this.cbA2.Name = "cbA2";
            this.cbA2.Size = new System.Drawing.Size(39, 17);
            this.cbA2.TabIndex = 1;
            this.cbA2.Text = "A2";
            this.cbA2.UseVisualStyleBackColor = true;
            // 
            // cbA1
            // 
            this.cbA1.AutoSize = true;
            this.cbA1.Location = new System.Drawing.Point(11, 20);
            this.cbA1.Name = "cbA1";
            this.cbA1.Size = new System.Drawing.Size(39, 17);
            this.cbA1.TabIndex = 0;
            this.cbA1.Text = "A1";
            this.cbA1.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 288);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 20;
            this.lblSex.Text = "Sex";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(185, 286);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 19;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(101, 286);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(88, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 255);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 218);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-Mail";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 181);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Telephone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 174);
            this.txtPhone.Mask = "(999) 0000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // dtpEmployementDate
            // 
            this.dtpEmployementDate.Location = new System.Drawing.Point(542, 192);
            this.dtpEmployementDate.Name = "dtpEmployementDate";
            this.dtpEmployementDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEmployementDate.TabIndex = 9;
            // 
            // lblEmployementDate
            // 
            this.lblEmployementDate.AutoSize = true;
            this.lblEmployementDate.Location = new System.Drawing.Point(434, 198);
            this.lblEmployementDate.Name = "lblEmployementDate";
            this.lblEmployementDate.Size = new System.Drawing.Size(102, 13);
            this.lblEmployementDate.TabIndex = 8;
            this.lblEmployementDate.Text = "Date of Employment";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(88, 137);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdate.TabIndex = 7;
            // 
            // lblDateofBirth
            // 
            this.lblDateofBirth.AutoSize = true;
            this.lblDateofBirth.Location = new System.Drawing.Point(12, 144);
            this.lblDateofBirth.Name = "lblDateofBirth";
            this.lblDateofBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateofBirth.TabIndex = 6;
            this.lblDateofBirth.Text = "Date of Birth";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 107);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(88, 26);
            this.txtIdNumber.Mask = "00000000000";
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(200, 20);
            this.txtIdNumber.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 182);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionChangedAll);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // employeeRecordDataSet
            // 
            this.employeeRecordDataSet.DataSetName = "EmployeeRecordDataSet";
            this.employeeRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeRecordDataSetBindingSource
            // 
            this.employeeRecordDataSetBindingSource.DataSource = this.employeeRecordDataSet;
            this.employeeRecordDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).EndInit();
            this.groupBoxDrivingLic.ResumeLayout(false);
            this.groupBoxDrivingLic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.GroupBox groupBoxDrivingLic;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA2;
        private System.Windows.Forms.CheckBox cbA1;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpEmployementDate;
        private System.Windows.Forms.Label lblEmployementDate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblDateofBirth;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtIdNumber;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox cbD1;
        private System.Windows.Forms.CheckBox cbE;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox pictureBoxEmp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeRecordDataSetBindingSource;
        private EmployeeRecordDataSet employeeRecordDataSet;
    }
}

