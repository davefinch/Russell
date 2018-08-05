﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russell
{
    public partial class Form1 : Form
    {
        //private List<DataJob> _jobs = new List<DataJob>();
        private BindingSource sr = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            this.Text = Constants.AppName + " - " + Constants.UserFullName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Load up the DataGrid
            using (Sql sql = new Sql())
            {
                List<DataJob> listDataJob = new List<DataJob>();


                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { listDataJob = sql.SQLGetJobs(); } else { listDataJob = sql.OLEGetJobs(); }

                foreach (DataJob item in listDataJob)
                {
                    var index = dataGridViewJobs.Rows.Add();

                    dataGridViewJobs.Rows[index].Cells["JobId"].Value = item.JobId;
                    dataGridViewJobs.Rows[index].Cells["EmployeeId"].Value = item.EmployeeId;
                    dataGridViewJobs.Rows[index].Cells["AgencyId"].Value = item.AgencyId;
                    dataGridViewJobs.Rows[index].Cells["JobDetails"].Value = item.JobDetails;
                    dataGridViewJobs.Rows[index].Cells["StartJob"].Value = item.StartJob;
                    dataGridViewJobs.Rows[index].Cells["EndJob"].Value = item.EndJob;
                    dataGridViewJobs.Rows[index].Cells["Hours"].Value = item.Hours;
                    dataGridViewJobs.Rows[index].Cells["Rate"].Value = item.Rate;
                    dataGridViewJobs.Rows[index].Cells["PaymentReceivedDate"].Value = item.PaymentReceivedDate;
                    dataGridViewJobs.Rows[index].Cells["TotalPaymentReceived"].Value = item.TotalPaymentReceived;



                }

            }


            // Load up the Agency Combo Box
            using (Sql sql = new Sql())
            {
                Dictionary<string, int> listAgency = new Dictionary<string, int>();

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { listAgency = sql.SQLGetAgencies(); } else { listAgency = sql.OLEGetAgencies(); }

                comboBoxAgency.DataSource = listAgency.ToList();
                comboBoxAgency.DisplayMember = "Key";
                comboBoxAgency.ValueMember = "Value";

                //Fill dgv combo box aswell
                // dataGridViewJobs.Combobox
            }


        }

        private void dataGridViewJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataJob dj = new DataJob();
            int newFileId = 0;

            using (Sql sql = new Sql())
            {
                // Do validation first so we know we've got everything
                dj.EmployeeId = Constants.UserId;
                dj.AgencyId = Convert.ToInt32(comboBoxAgency.SelectedValue);
                dj.JobDetails = textBoxjobDetails.Text;
                dj.StartJob = Convert.ToDateTime(dateTimePickerStartJob.Value);
                dj.EndJob = Convert.ToDateTime(dateTimePickerEndJob.Value);
                dj.Hours = Convert.ToDecimal(numericUpDownHours.Value);
                dj.Rate = Convert.ToDecimal(textBoxRate.Text);
                dj.PaymentReceivedDate = Convert.ToDateTime(dateTimePickerPaymentReceivedDate.Value);
                dj.TotalPaymentReceived = Convert.ToDecimal(textBoxTotalPayment.Text);

                //Insert Job to DB and dgv.
                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL")
                {
                    newFileId = sql.SQLInsertNewJob(dj);
                }
                else
                {
                    sql.OLEInsertNewJob(dj);
                }

                // Add to dgv - Or could just do a refresh of the dgv from the db??????????
                var index = dataGridViewJobs.Rows.Add();
                dataGridViewJobs.Rows[index].Cells["JobId"].Value = dj.JobId;
                dataGridViewJobs.Rows[index].Cells["EmployeeId"].Value = dj.EmployeeId;
                dataGridViewJobs.Rows[index].Cells["AgencyId"].Value = dj.AgencyId;
                dataGridViewJobs.Rows[index].Cells["JobDetails"].Value = dj.JobDetails;
                dataGridViewJobs.Rows[index].Cells["StartJob"].Value = dj.StartJob;
                dataGridViewJobs.Rows[index].Cells["EndJob"].Value = dj.EndJob;
                dataGridViewJobs.Rows[index].Cells["Hours"].Value = dj.Hours;
                dataGridViewJobs.Rows[index].Cells["Rate"].Value = dj.Rate;
                dataGridViewJobs.Rows[index].Cells["PaymentReceivedDate"].Value = dj.PaymentReceivedDate;
                dataGridViewJobs.Rows[index].Cells["TotalPaymentReceived"].Value = dj.TotalPaymentReceived;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
