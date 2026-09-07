using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeLeonAccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
       private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNoValue.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProgramValue.Text = DelProgram(StudentInfoClass.Program);
            lblLastNameValue.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstNameValue.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleNameValue.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAgeValue.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNoValue.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddressValue.Text = DelAddress(StudentInfoClass.Address);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
