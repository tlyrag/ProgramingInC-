using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInfoApp
{
    public partial class Form1 : Form
    {   //Form data
        //Form field memebers
        //Form data members
        //Visible to all methods in the form
        List<UserInfo> usersList = new List<UserInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //do not delete accidentally created event handlers
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //accidentally created by
            //double clicking textbox
            //do not delete
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World! \nMy Name is Priya");

            //Performing user validations
            //Then if valid input
            //create an object
            //and display object details
            //using MessageBox.Show()

            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("User Name cannot be empty");
            } else if (UserIdTextBox.Text == "")
            {
                MessageBox.Show("User Id cannot be empty");
            } else if (UserAgeTextBox.Text == "")
            {
                MessageBox.Show("User Age cannot be empty");
            } else if (!int.TryParse(UserIdTextBox.Text, out int UserID)|| UserID <=0)
            {
                MessageBox.Show("UserId must be valid int >0");
            } else if(!double.TryParse(UserAgeTextBox.Text, out double UserAge) || UserAge<=0)
            {
                MessageBox.Show("User Age must be valid double >0");
            } else
            {
               
                //process valid data
                //create a UserInfo object
                // Display it in MessagebOx.Show using ToString()
                UserInfo eachUser = new UserInfo(UserNameTextBox.Text, UserID, UserAge);

                //MessageBox.Show(eachUser.ToString());
                //Add each user to the UserList
                usersList.Add(eachUser);
                
                StatusLabel.Text = $"Added User: {eachUser.ToString()}";
                StatusLabel.Text += $"\nTotal User: {usersList.Count()}";
                ClearFields(UserIdTextBox,UserNameTextBox,UserAgeTextBox);

                OutputListBox.Items.Clear();
                OutputListBox.Items.Add($"User Name:{eachUser.UserName}");
                OutputListBox.Items.Add($"User Id:{eachUser.UserId}");
                OutputListBox.Items.Add($"User Age:{eachUser.UserAge:F1}");
                OutputListBox.Items.Add($"User Category:{eachUser.UserCategory:F1}");
                
                LoadAllUsersToListBox();
            }
        }
        private void LoadAllUsersToListBox()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("UsernName\tUserId\tUserAge\tUserCategory");
            foreach(UserInfo user in usersList)
            {
                OutputListBox.Items.Add(user);

            }

        }
        private void ClearFields(params TextBox[] textboxes)
        {
            foreach(TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
        }
        private void CLearFields ()
        {
            UserIdTextBox.Clear();
            UserNameTextBox.Clear();
            UserAgeTextBox.Clear();
        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lbINdex = OutputListBox.SelectedIndex;
            if(lbINdex != -1)
            {
                if(lbINdex == 0)
                {
                    MessageBox.Show("Please select data lines");
                } else if (usersList.Count > 0)
                {
                    int listIndex = lbINdex - 1;
                    UserNameTextBox.Text = usersList[listIndex].UserName;
                    UserAgeTextBox.Text = usersList[listIndex].UserAge.ToString("F1");
                    UserIdTextBox.Text = usersList[listIndex].UserId.ToString();

                }
            }
        }

        private void UpdateSelectedUserBtn_Click(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                MessageBox.Show("Please Select data to update");
            }
            else if (usersList.Count > 0)
            {
                if (UserNameTextBox.Text == "" || UserAgeTextBox.Text == "" || UserIdTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all fields");
                }
                else if (!int.TryParse(UserIdTextBox.Text, out int UserID)
                    || UserID <= 0
                    || !double.TryParse(UserAgeTextBox.Text, out double UserAge)
                    || UserAge <= 0
                    )
                {
                    MessageBox.Show("Please enter valid data");
                }
                else
                {
                    UserInfo eachUser = new UserInfo(UserNameTextBox.Text, UserID, UserAge);
                    usersList[lbIndex - 1] = eachUser;
                    OutputListBox.Items[lbIndex] = usersList[lbIndex - 1];
                }
            }
        }
    }
}
