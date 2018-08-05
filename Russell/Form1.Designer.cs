namespace Russell
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
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jODataSet = new Russell.JODataSet();
            this.jobTableAdapter = new Russell.JODataSetTableAdapters.JobTableAdapter();
            this.labelJobDetails = new System.Windows.Forms.Label();
            this.textBoxjobDetails = new System.Windows.Forms.TextBox();
            this.labelAgency = new System.Windows.Forms.Label();
            this.comboBoxAgency = new System.Windows.Forms.ComboBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartJob = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndJob = new System.Windows.Forms.DateTimePicker();
            this.labelHours = new System.Windows.Forms.Label();
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxPaymentReceived = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPaymentReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotalPayment = new System.Windows.Forms.TextBox();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgencyName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JobDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaymentReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jODataSet)).BeginInit();
            this.groupBoxEntry.SuspendLayout();
            this.groupBoxPaymentReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.AllowUserToOrderColumns = true;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobId,
            this.EmployeeId,
            this.AgencyId,
            this.AgencyName,
            this.JobDetails,
            this.Startjob,
            this.EndJob,
            this.Hours,
            this.Rate,
            this.PaymentReceivedDate,
            this.TotalPaymentReceived});
            this.dataGridViewJobs.Location = new System.Drawing.Point(13, 24);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(861, 481);
            this.dataGridViewJobs.TabIndex = 0;
            this.dataGridViewJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellContentClick);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.jODataSet;
            // 
            // jODataSet
            // 
            this.jODataSet.DataSetName = "JODataSet";
            this.jODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // labelJobDetails
            // 
            this.labelJobDetails.AutoSize = true;
            this.labelJobDetails.Location = new System.Drawing.Point(12, 72);
            this.labelJobDetails.Name = "labelJobDetails";
            this.labelJobDetails.Size = new System.Drawing.Size(62, 13);
            this.labelJobDetails.TabIndex = 1;
            this.labelJobDetails.Text = "Job Details:";
            // 
            // textBoxjobDetails
            // 
            this.textBoxjobDetails.Location = new System.Drawing.Point(80, 72);
            this.textBoxjobDetails.Multiline = true;
            this.textBoxjobDetails.Name = "textBoxjobDetails";
            this.textBoxjobDetails.Size = new System.Drawing.Size(227, 45);
            this.textBoxjobDetails.TabIndex = 2;
            // 
            // labelAgency
            // 
            this.labelAgency.AutoSize = true;
            this.labelAgency.Location = new System.Drawing.Point(15, 31);
            this.labelAgency.Name = "labelAgency";
            this.labelAgency.Size = new System.Drawing.Size(46, 13);
            this.labelAgency.TabIndex = 3;
            this.labelAgency.Text = "Agency:";
            // 
            // comboBoxAgency
            // 
            this.comboBoxAgency.FormattingEnabled = true;
            this.comboBoxAgency.Location = new System.Drawing.Point(80, 31);
            this.comboBoxAgency.Name = "comboBoxAgency";
            this.comboBoxAgency.Size = new System.Drawing.Size(227, 21);
            this.comboBoxAgency.TabIndex = 4;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(321, 32);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "StartDate:";
            // 
            // dateTimePickerStartJob
            // 
            this.dateTimePickerStartJob.Location = new System.Drawing.Point(382, 32);
            this.dateTimePickerStartJob.Name = "dateTimePickerStartJob";
            this.dateTimePickerStartJob.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerStartJob.TabIndex = 6;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(324, 73);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "End Date:";
            // 
            // dateTimePickerEndJob
            // 
            this.dateTimePickerEndJob.Location = new System.Drawing.Point(382, 73);
            this.dateTimePickerEndJob.Name = "dateTimePickerEndJob";
            this.dateTimePickerEndJob.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerEndJob.TabIndex = 8;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(533, 34);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(38, 13);
            this.labelHours.TabIndex = 9;
            this.labelHours.Text = "Hours:";
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.buttonAdd);
            this.groupBoxEntry.Controls.Add(this.groupBoxPaymentReceived);
            this.groupBoxEntry.Controls.Add(this.textBoxTotalPayment);
            this.groupBoxEntry.Controls.Add(this.labelTotalPayment);
            this.groupBoxEntry.Controls.Add(this.textBoxRate);
            this.groupBoxEntry.Controls.Add(this.labelRate);
            this.groupBoxEntry.Controls.Add(this.numericUpDownHours);
            this.groupBoxEntry.Controls.Add(this.comboBoxAgency);
            this.groupBoxEntry.Controls.Add(this.labelHours);
            this.groupBoxEntry.Controls.Add(this.labelJobDetails);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerEndJob);
            this.groupBoxEntry.Controls.Add(this.textBoxjobDetails);
            this.groupBoxEntry.Controls.Add(this.labelEndDate);
            this.groupBoxEntry.Controls.Add(this.labelAgency);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerStartJob);
            this.groupBoxEntry.Controls.Add(this.labelStartDate);
            this.groupBoxEntry.Location = new System.Drawing.Point(13, 521);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(861, 203);
            this.groupBoxEntry.TabIndex = 10;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Job Details";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(765, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxPaymentReceived
            // 
            this.groupBoxPaymentReceived.Controls.Add(this.dateTimePickerPaymentReceivedDate);
            this.groupBoxPaymentReceived.Location = new System.Drawing.Point(324, 119);
            this.groupBoxPaymentReceived.Name = "groupBoxPaymentReceived";
            this.groupBoxPaymentReceived.Size = new System.Drawing.Size(227, 55);
            this.groupBoxPaymentReceived.TabIndex = 16;
            this.groupBoxPaymentReceived.TabStop = false;
            this.groupBoxPaymentReceived.Text = "Payment Received Date";
            // 
            // dateTimePickerPaymentReceivedDate
            // 
            this.dateTimePickerPaymentReceivedDate.Location = new System.Drawing.Point(19, 19);
            this.dateTimePickerPaymentReceivedDate.Name = "dateTimePickerPaymentReceivedDate";
            this.dateTimePickerPaymentReceivedDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPaymentReceivedDate.TabIndex = 0;
            this.dateTimePickerPaymentReceivedDate.Value = new System.DateTime(2018, 7, 28, 7, 35, 48, 0);
            // 
            // textBoxTotalPayment
            // 
            this.textBoxTotalPayment.Location = new System.Drawing.Point(783, 31);
            this.textBoxTotalPayment.Name = "textBoxTotalPayment";
            this.textBoxTotalPayment.Size = new System.Drawing.Size(57, 20);
            this.textBoxTotalPayment.TabIndex = 15;
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.Location = new System.Drawing.Point(738, 31);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(48, 32);
            this.labelTotalPayment.TabIndex = 14;
            this.labelTotalPayment.Text = "Total Payment:";
            this.labelTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(668, 32);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(54, 20);
            this.textBoxRate.TabIndex = 13;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(638, 34);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(33, 13);
            this.labelRate.TabIndex = 12;
            this.labelRate.Text = "Rate:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.DecimalPlaces = 2;
            this.numericUpDownHours.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownHours.Location = new System.Drawing.Point(568, 31);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownHours.TabIndex = 11;
            // 
            // JobId
            // 
            this.JobId.HeaderText = "JobId";
            this.JobId.Name = "JobId";
            this.JobId.Visible = false;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = false;
            // 
            // AgencyId
            // 
            this.AgencyId.HeaderText = "AgencyId";
            this.AgencyId.Name = "AgencyId";
            this.AgencyId.Visible = false;
            // 
            // AgencyName
            // 
            this.AgencyName.HeaderText = "AgencyName";
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgencyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // JobDetails
            // 
            this.JobDetails.HeaderText = "JobDetails";
            this.JobDetails.Name = "JobDetails";
            // 
            // Startjob
            // 
            this.Startjob.HeaderText = "Startjob";
            this.Startjob.Name = "Startjob";
            // 
            // EndJob
            // 
            this.EndJob.HeaderText = "EndJob";
            this.EndJob.Name = "EndJob";
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // PaymentReceivedDate
            // 
            this.PaymentReceivedDate.HeaderText = "PaymentReceivedDate";
            this.PaymentReceivedDate.Name = "PaymentReceivedDate";
            // 
            // TotalPaymentReceived
            // 
            this.TotalPaymentReceived.HeaderText = "TotalPaymentReceived";
            this.TotalPaymentReceived.Name = "TotalPaymentReceived";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 736);
            this.Controls.Add(this.groupBoxEntry);
            this.Controls.Add(this.dataGridViewJobs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jODataSet)).EndInit();
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.groupBoxPaymentReceived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private JODataSet jODataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private JODataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.Label labelJobDetails;
        private System.Windows.Forms.TextBox textBoxjobDetails;
        private System.Windows.Forms.Label labelAgency;
        private System.Windows.Forms.ComboBox comboBoxAgency;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartJob;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndJob;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.GroupBox groupBoxPaymentReceived;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentReceivedDate;
        private System.Windows.Forms.TextBox textBoxTotalPayment;
        private System.Windows.Forms.Label labelTotalPayment;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgencyId;
        private System.Windows.Forms.DataGridViewComboBoxColumn AgencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaymentReceived;
    }
}

