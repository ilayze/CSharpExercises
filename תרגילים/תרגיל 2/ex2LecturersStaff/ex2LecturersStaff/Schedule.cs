using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ex2LecturersStaff.Properties;

namespace ex2LecturersStaff
{
    public partial class Schedule : Form
    {
        readonly Staff _staff;
        private Lecturer SelectedLecturer;

        public Schedule()
        {
            InitializeComponent();
            _staff=new Staff();
            AddRowsToDG();
        }

        private void AddRowsToDG()
        {
            DG.Rows.Add("8:00-9:00");
            DG.Rows.Add("9:00-10:00");
            DG.Rows.Add("10:00-11:00");
            DG.Rows.Add("11:00-12:00");
            DG.Rows.Add("12:00-13:00");
            DG.Rows.Add("13:00-14:00");
            DG.Rows.Add("14:00-15:00");
            DG.Rows.Add("15:00-16:00");
            DG.Rows.Add("16:00-17:00");
            DG.Rows.Add("17:00-18:00");
            DG.Rows.Add("18:00-19:00");
            DG.Rows.Add("19:00-20:00");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirst.Text) || String.IsNullOrEmpty(txtLast.Text))
            {
                MessageBox.Show(Resources.Schedule_btnOk_Click_Error__required_First_name_and_Last_name_, Resources.Click_Error);
                return;
            }

           DG.ClearSelection();
            ClearDG();

            string first = txtFirst.Text;
            string last = txtLast.Text;

            foreach (var lecturer in _staff.Lecturers)
            {
                if (lecturer.FirstName == first && lecturer.LastName == last)
                {
                    SelectedLecturer = lecturer;
                    EnableComponents(lecturer);
                    FillInConstraints(lecturer);
                   

                    return;
                }
            }

            MessageBox.Show(Resources.Schedule_btnOk_Click_Error__Lecturer_not_exist, Resources.Click_Error);
            txtFirst.Text = "";
            txtLast.Text = "";
        }

        private void ClearDG()
        {
            for (int i = 1; i < DG.ColumnCount; i++)
            {
                for (int j = 0; j < DG.Rows.Count; j++)
                {
                    DG[i, j].Style.BackColor = Color.White;
                }
            }
        }

        private void FillInConstraints(Lecturer lecturer)
        {
            LinkedList<TimeConstraint> constraints = lecturer.GetConstraints();
            if (constraints == null)
                return;
            foreach (var constraint in constraints)
            {
                int beginIndex = constraint.BeginHour - 8;
                int endIndex = constraint.EndHour - 8;
                int day = getDayInt(constraint.Day);

                for (int i = beginIndex; i < endIndex; i++)
                {
                    DG[day, i].Style.BackColor = Color.Aqua;
                }
            }
        }

        private int getDayInt(string day)
        {
            switch(day) 
            {
                case "Sunday":
                    return 1;
                case "Monday":
                    return 2;
                case "Tuesday":
                    return 3;
                case "Wednesday":
                    return 4;
                case "Thursday":
                    return 5;
                default:
                    return -1;

            }
        }

        private void EnableComponents(Lecturer lecturer)
        {
            lblHeader.Visible = true;
            lblHeader.Text = lecturer.FirstName + " " + lecturer.LastName + "'s " + "Schedule";
            btnSubmit.Visible = true;
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            btnOk.Enabled = false;

           
            DG.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveConstraints();
            DisableComponents();

        }

        private void DisableComponents()
        {
            DG.Visible = false;
            btnSubmit.Visible = false;
            lblHeader.Visible = false;

            btnOk.Enabled = true;
            txtFirst.Enabled = true;
            txtLast.Enabled = true;
            txtFirst.Text = "";
            txtLast.Text = "";
        }

        private void SaveConstraints()
        {
            for (int i = 1; i < DG.ColumnCount; i++)
            {
                for (int j = 0; j < DG.Rows.Count; j++)
                {
                    if (DG[i, j].Selected)
                    {
                        SelectedLecturer.AddConstraint(new TimeConstraint(getDayString(i), j+8, j+9));
                    }
                }
            }
        }

        private string getDayString(int i)
        {
            switch (i)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                default:
                    return "";
            }
        }

        private void Schedule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S  )
            {
                if (btnSubmit.Visible)
                {
                    btnSubmit_Click(this, null);
                }
                else
                {
                    txtFirst.Text = "ilay";
                    txtLast.Text = "zeidman";
                }
            }

            if (e.Control && e.KeyCode == Keys.A && !btnSubmit.Visible)
            {
                txtFirst.Text = "a";
                txtLast.Text = "b";
            }

        }
    }
}
