using StudentForm;
using System.Diagnostics;

namespace CChavezStudentFormDemo
{
    public partial class fCchavezStudentFormDemo : Form
    {
        public fCchavezStudentFormDemo()
        {
            InitializeComponent();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Figure out major
            string major = "TBD";
            if (rbProgramming.Checked) major = rbProgramming.Text;
            else if (rbWebDesign.Checked) major = rbWebDesign.Text;
            else if (rbIT.Checked) major = rbIT.Text;

            //Instantiate a student
            Student st = new Student(txbStudentID.Text, txbFirstName.Text, txbLastName.Text, major);
            st.StudentNumber = txbStudentID.Text;

            //Count number of check boxes checked
            int count = 0;
            if (cbxCIS101.Checked) count++;
            if (cbxCIS102.Checked) count++;
            if (cbxCIS103.Checked) count++;
            if (cbxCIS104.Checked) count++;


            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cbxCIS101.Checked)
            {
                courses[index] = cbxCIS101.Text;
                int.TryParse(txbScore1.Text, out scores[index++]);
            }
            if (cbxCIS102.Checked)
            {
                courses[index] = cbxCIS102.Text;
                int.TryParse(txbScore2.Text, out scores[index++]);
            }
            if (cbxCIS103.Checked)
            {
                courses[index] = cbxCIS103.Text;
                int.TryParse(txbScore3.Text, out scores[index++]);
            }
            if (cbxCIS104.Checked)
            {
                courses[index] = cbxCIS104.Text;
                int.TryParse(txbScore4.Text, out scores[index++]);
            }

            //Set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output
            txbResult.Text = st.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.cnm.edu") { UseShellExecute = true });
            linkLabel1.LinkVisited = true;
        }
    }
}
