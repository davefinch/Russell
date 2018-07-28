using System;
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
            // TODO: This line of code loads data into the 'jODataSet.Job' table. You can move, or remove it, as needed.
            //this.jobTableAdapter.Fill(this.jODataSet.Job);

            Dictionary<string, int> listAgency = new Dictionary<string, int>();

            MessageBox.Show("Does this show");

            using (Sql sql = new Sql())
            {

                listAgency = sql.GetAgencies();
                comboBoxAgency.DataSource = listAgency.ToList();
                comboBoxAgency.DisplayMember = "Key";
                comboBoxAgency.ValueMember = "Value";


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

                //Insert Job
                newFileId = sql.InsertNewJob(dj);
                MessageBox.Show(newFileId.ToString());
            }
        }
    }
}
