using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace StudentGrades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Students> StudentsList = new List<Students>();

        private void ReadFileBtn_Click(object sender, EventArgs e)
        {
            readFile();
            loadListBox();
        }
        private void readFile() 
        {
            try {
                StudentsList.Clear();
                using (StreamReader reader = new StreamReader("student_grades.csv"))
                {
                    if(!reader.EndOfStream)
                    {
                        reader.ReadLine();

                    } while(!reader.EndOfStream) { 
                        string[] studentArr =reader.ReadLine().Split(',');
                        string student_id = studentArr[0];
                        string first_name = studentArr[1];
                        string last_name = studentArr[2];
                        double.TryParse(studentArr[3], out double quiz_score);
                        double.TryParse(studentArr[4], out double midterm_score);
                        double.TryParse(studentArr[5], out double final_score);
                        Students student = new Students(student_id,first_name,last_name,quiz_score,midterm_score,final_score);
                        StudentsList.Add(student);
                    }
                }
            } catch (Exception err) {

                MessageBox.Show($"Error: {err}");
            }

        }
        private void loadListBox()
        {
            string[] header = { "student_id","first_name","last_name","quiz_score","midterm_score","final_score","final_grade","final_score" };
            StudListBox.Items.Clear();
            StudListBox.Items.Add($"{header[0],-15}{header[1],-15}{header[2],-15}{header[3],-15}{header[4],-15}{header[5],-15}{header[6],-15}{header[7],-15}");

            foreach(Students student in StudentsList)
            {
                StudListBox.Items.Add(student);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int indx = StudListBox.SelectedIndex;

            if (indx < 1) {
                MessageBox.Show("Please Slect a valid item");
            } else
            {
                if (!double.TryParse(QuizTextBox.Text, out double quiz_score) || quiz_score < 0 || quiz_score > 100)
                {
                    MessageBox.Show($"{quiz_score} Invalid Quizz Score");
                }
                else if (!double.TryParse(MidTermTextBox.Text, out double midterm_score) || midterm_score < 0 || midterm_score > 100)
                {
                    MessageBox.Show("Invalid MidTerm Score");
                }
                else if (!double.TryParse(FinalsTextBox.Text, out double final_score) || final_score < 0 || final_score>100)
                {
                    MessageBox.Show("Invalid Final Score");
                }
                else
                {
                    StudentsList[indx-1].QuizzScore = quiz_score;
                    StudentsList[indx-1].MidtermScore = midterm_score;
                    StudentsList[indx-1].FinalsScore = final_score;
                    loadListBox();
                    QuizTextBox.Text = "";
                    MidTermTextBox.Text = "";
                    FinalsTextBox.Text = "";
                }
                
            }
        }

        private void StudListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = StudListBox.SelectedIndex;
            if (indx >0) {
                QuizTextBox.Text = $"{StudentsList[indx - 1].QuizzScore}";
                MidTermTextBox.Text = $"{StudentsList[indx - 1].MidtermScore}";
                FinalsTextBox.Text = $"{StudentsList[indx - 1].FinalsScore}";
            }
            

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int indx = StudListBox.SelectedIndex;

            if (indx < 1)
            {
                MessageBox.Show("Please Slect a valid item");
            }
            else
            {
                StudentsList.RemoveAt(indx-1);
                StudListBox.Items.RemoveAt(indx);
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            List<Students> sortedList = new List<Students>();
            sortedList = (from Student in  StudentsList orderby Student.FinalGrade descending select Student).ToList();
            StudentsList = sortedList;
            loadListBox();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try { 
                using (StreamWriter writer = new StreamWriter("FinalGrades.csv"))
                {
                    writer.WriteLine("student_id,first_name,last_name,quiz_score,midterm_score,final_score,final_grade,final_score");
                    foreach(Students student in StudentsList)
                    {
                        writer.WriteLine($"{student.StudentId},{student.StudentFirstName},{student.StudentLastName},{student.QuizzScore},{student.MidtermScore},{student.FinalsScore},{student.FinalGrade},{student.systemGrade}");
                    }
                    

                }
            } 
            catch(Exception err) {
                MessageBox.Show($"Error {err}");
            }
        }
    }
}
