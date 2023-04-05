﻿using System;
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
    {
        //Form data
        //Form field members
        //Form data members
        //visible to all the methods in the form
        List<UserInfo> UserList = new List<UserInfo>();


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
            } else if (!int.TryParse(UserIdTextBox.Text, out int UserId) 
                        || UserId <= 0)
            {
                MessageBox.Show("UserId must be valid int > 0");
            } else if (!double.TryParse(UserAgeTextBox.Text, out double UserAge) 
                || UserAge <= 0)
            {
                MessageBox.Show("User Age must be valid double > 0");
            } else
            {
                //process valid data
                //create a UserInfo object
                //Display it in MessageBox.Show using ToString()
                UserInfo eachUser = new UserInfo(UserNameTextBox.Text, UserId, UserAge);
                // MessageBox.Show(eachUser.ToString());


                OutputListBox.Items.Clear();
                OutputListBox.Items.Add("User Name: " + eachUser.UserName);
                OutputListBox.Items.Add("User Id: " + eachUser.UserId);
                OutputListBox.Items.Add("User Age: " + eachUser.UserAge.ToString("F1"));
                OutputListBox.Items.Add("User Category: " + eachUser.UserCategory);

                //Add eachUser to the UserList
                UserList.Add(eachUser);

                //label text does not recognize \t
                //label text will recognize \n
                StatusLabel.Text = "Added User: " + eachUser.ToString();
                StatusLabel.Text += "\nTotal User: " + UserList.Count;

                LoadAllUsersToListBox();
                //Clear Text Fields
                ClearFields();


            }
           

        }
        private void LoadAllUsersToListBox()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("UserName\tUserId\tUserAge\tUserCategory");
            foreach(UserInfo user in UserList)
            {
                OutputListBox.Items.Add(user); //automatically calls user.ToString()
            }
        }
        private void ClearFields()
        {
            UserNameTextBox.Text = "";
            UserIdTextBox.Clear();
            UserAgeTextBox.Clear();
        }

        private void buttonNewName_Click(object sender, EventArgs e)
        {

        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if (lbIndex != -1)
            {
                if (lbIndex == 0)
                {
                    MessageBox.Show("Please select data lines");
                } else if (UserList.Count > 0)
                {
                    int listIndex = lbIndex - 1;
                    UserNameTextBox.Text = UserList[listIndex].UserName;
                    UserIdTextBox.Text = UserList[listIndex].UserId.ToString();
                    UserAgeTextBox.Text = UserList[listIndex].UserAge.ToString("F1");
                }
            }
        }

        private void UpdateSelectedUserBtn_Click(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                MessageBox.Show("Please select data to update");
            }
            else if (UserList.Count > 0)
            {
                //update UserList[lbIndex - 1]
                //all the validations on text as before
                if (UserNameTextBox.Text == ""
                    || UserIdTextBox.Text == "" || UserAgeTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all fields");
                }
                else if (!int.TryParse(UserIdTextBox.Text, out int UserId)
                    || UserId <= 0
                    || !double.TryParse(UserAgeTextBox.Text, out double UserAge)
                    || UserAge <= 0)
                {
                    MessageBox.Show("Please enter valid data");
                }
                else
                {
                    //process valid data
                    UserInfo eachUser
                        = new UserInfo(UserNameTextBox.Text, UserId, UserAge);
                    UserList[lbIndex - 1] = eachUser;

                    OutputListBox.Items[lbIndex] = UserList[lbIndex - 1];
                    StatusLabel.Text = "Updated details for User with Id: "
                                                + eachUser.UserId;

                    //UserList[lbIndex - 1].UserAge -= 10;
                    //Update listbox for that item as well
                }
            }
        }
    }
}
