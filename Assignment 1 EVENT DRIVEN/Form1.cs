using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  

namespace Assignment_1_EVENT_DRIVEN
{
    public partial class Form1 : Form
    {
        const int NUMBER_OF_CONTACTS = 30; // limit of contacts
        bool changesMade = false; // boolean that change status when amending list
        public Form1()
        {
            InitializeComponent();
        }
        //Button terminating program
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                saveChanges();
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure ?", "EXIT PROGRAM", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
         // button deleting contact
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deletingContact();
        }
        //button adding contact
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //checking if lsit is full
            if (lstTelephone.Items.Count >= NUMBER_OF_CONTACTS) // check if list box full
            {
                MessageBox.Show("Your list is full \n Please delete contact");
                clearAddTxtBoxs();
            }
            else
            {
                //validating input adn adding contact
                if (inputValidation(txtAddTelephone.Text, txtAddName.Text, txtAddSurname.Text))
                {
                    lstTelephone.Items.Add(txtAddTelephone.Text);
                    lstName.Items.Add(txtAddName.Text);
                    lstSurname.Items.Add(txtAddSurname.Text);
                    bubbleSort();
                    count();
                    clearAddTxtBoxs();
                    enableButton();
                    changesMade = true;
                }
            }
        }
        //button searching contacts 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool searching = false;
            int index = 0;
            int count = 1;
            if (rdoTelephone.Checked) // Binary search
            {
                if (correctTelephone(txtSearch.Text))
                {
                    double number = Convert.ToDouble(txtSearch.Text);
                    int start = 0, end = lstTelephone.Items.Count - 1, mid;
                    while (start <= end)
                    {
                        mid = (start + end) / 2;
                        if (number == Convert.ToDouble(lstTelephone.Items[mid]))
                        {
                            index = mid;
                            searching = true;
                            break;
                        }
                        else if (number < Convert.ToDouble(lstTelephone.Items[mid]))
                        {
                            end = mid - 1;
                            count++;
                        }
                        else if (number > Convert.ToDouble(lstTelephone.Items[mid]))
                        {
                            start = mid + 1;
                            count++;
                        }

                    }
                }
            }
            // linear name search
            if(rdoName.Checked )

            {
                for (int i = 0; i < lstName.Items.Count; i++)
                {
                    if (txtSearch.Text.ToUpper() == lstName.Items[i].ToString().ToUpper())
                    {
                        index = i;
                        searching = true;
                        break;
                    }
                    count++;
                }
            }
            // linear surname search
            if(rdoSurname.Checked )
            {
                for (int i = 0; i < lstSurname.Items.Count; i++)
                {
                    if (txtSearch.Text.ToUpper() == lstSurname.Items[i].ToString().ToUpper())
                    {
                        index = i;
                        searching = true;
                        break;
                    }
                    count++;
                }
            }
            //printing search result
            if(searching == true)
            {
                lblProbes.Visible = true;
                lblProbes.Text = "Probes: " + count;
                txtSearchDisplay.Text = lstName.Items[index].ToString() + Environment.NewLine
                                        + lstSurname.Items[index].ToString() + Environment.NewLine
                                        + lstTelephone.Items[index].ToString();
            }
            //if no result found
            else
            {
                lblProbes.Visible = true;
                lblProbes.Text = "Probes: " + count;
                txtSearchDisplay.Text = "NO CONTACTS FOUND" + Environment.NewLine 
                                        + "TRY AGAIN";
                txtSearch.Text = "";
            }
        }
        //button saving to file
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveToFile();
        }
        //button loading from file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                saveChanges();
            }
            using (OpenFileDialog ofd = new OpenFileDialog()) //openstream
            {
                ofd.Filter = "Text Documents|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    clearListBoxes();
                    using (StreamReader loadStream = new StreamReader(ofd.FileName))
                    {
                        // reading from file
                        string temp;
                        temp = loadStream.ReadLine();
                        while (temp != "00000000000")
                        {
                            lstTelephone.Items.Add(temp);
                            temp = loadStream.ReadLine();
                            lstName.Items.Add(temp);
                            temp = loadStream.ReadLine();
                            lstSurname.Items.Add(temp);
                            temp = loadStream.ReadLine();
                        }
                    }
                }
            }
            count();
            enableButton();
            bubbleSort();
            changesMade = false;
        }

        //clearing listboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                saveChanges();
            }
            clearListBoxes();
            changesMade = false;
        }

        /* 
         * 
         * 
         * 
         * functions
         * 
         * 
         * 
         */

         // label changing count number
        private void count()
        {
            if (lstTelephone.Items.Count >= NUMBER_OF_CONTACTS)
                lblCount.Text = "List is FULL !";
            else
                lblCount.Text = "Entries: " + lstTelephone.Items.Count + "\nFree memory: " + (NUMBER_OF_CONTACTS - lstTelephone.Items.Count);
        }
        // turn on delete/clear/search button
        private void enableButton()
        {
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = true;
        }
        // turn off delete/clear/search button
        private void disableButton()
        {
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = false;
        }
        //clearing add txt boxes
        private void clearAddTxtBoxs()
        {
            txtAddName.Text = "";
            txtAddTelephone.Text = "";
            txtAddSurname.Text = "";
        }
        // validating input
        private bool inputValidation(string telephone, string name, string surname)
        {
            if (!emptyInput(telephone))
            {
                return false;
            }
            else
            if (!correctTelephone(telephone))
                return false;
            if(!exsistingNumber(telephone))
            {
                return false;
            }
            if (!emptyInput(name))
            {
                return false;
            }
            if (!emptyInput(surname))
            {
                return false;
            }
            else
                return true;
        }
        //check if contact details is empty
        private bool emptyInput(string str)
        {
            if (str == "")
                return false;
            else
                return true;
        }
        //check if telephone number is valid
        private bool correctTelephone(string telephone)
        {
            //check if only digits in telephone
            foreach (char c in telephone)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Please enter only digits to phone number");
                    return false;
                }
            }
            // check if its 11 digit
            if (telephone.Length != 11)
            {
                MessageBox.Show("Please enter 11-digit number");
                return false;
            }
            if (!zeroOnly(telephone))
            {
                MessageBox.Show("Incorrect Phone Number");
                return false;
            }
            else
                return true;
        }
        // checking in number already exist
        private bool exsistingNumber(string telephone)
        {
            foreach(var phoneNumber in lstTelephone.Items)
            {
                // linear search for telephone numbers
                if (telephone == phoneNumber.ToString())
                {
                    MessageBox.Show("Contact already exist!");
                    return false;
                }
            }
            return true;
        }
        // checking if phone number contains only 0
        private bool zeroOnly(string telephone)
            {
            if (telephone == "00000000000")
                return false;
            else
                return true;
            }

        //connecting list boxes together 
        private void lstBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstTelephone.Items.Count > 0)
            {
                ListBox listBox = sender as ListBox;
                lstTelephone.SelectedIndex = listBox.SelectedIndex;
                lstName.SelectedIndex = listBox.SelectedIndex;
                lstSurname.SelectedIndex = listBox.SelectedIndex;
                DoDragDrop("", DragDropEffects.Move);
            }
        }
        private void lstSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
                ListBox listBox = sender as ListBox;
                lstTelephone.SelectedIndex = listBox.SelectedIndex;
                lstName.SelectedIndex = listBox.SelectedIndex;
                lstSurname.SelectedIndex = listBox.SelectedIndex;
        }

        // drag drop effedct
        private void picDelete_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //deleting contact with pic
        private void picDelete_DragDrop(object sender, DragEventArgs e)
        {
            deletingContact();
        }
        //event that will allow me hit eneter key instead button click
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
        //deleting contact function
        private void deletingContact()
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want Delete Contact ?", "DELETE ENTRIES", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)  // checking if delete
            {
                if (lstTelephone.Items.Count == 0)
                {
                    disableButton();
                    return;
                }
                //deleting 
                else
                {
                    int index = lstTelephone.SelectedIndex;
                    int lastIndex = lstTelephone.Items.Count - 1;

                    //loop moving contacts one up
                    for(int i = index; i < lastIndex ; i++)
                    {
                        lstTelephone.Items[i] = lstTelephone.Items[i + 1];
                        lstName.Items[i] = lstName.Items[i + 1];
                        lstSurname.Items[i] = lstSurname.Items[i + 1];
                    }
                    //deleting last contact
                    lstTelephone.Items.RemoveAt(lastIndex);
                    lstName.Items.RemoveAt(lastIndex);
                    lstSurname.Items.RemoveAt(lastIndex);
                    count();
                    changesMade = true;
                }
            }
            //if decide to cancel to delete
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //clearing listboxes
        private void clearListBoxes()
        {
            if (lstTelephone.Items.Count > 0)
            {
                lstTelephone.Items.Clear();
                lstName.Items.Clear();
                lstSurname.Items.Clear();
                count();
                disableButton();
                txtSearchDisplay.Text = "";
            }
        }
        //colour delete button
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.BlueViolet;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Yellow;
        }
        // bubble sort
        private void bubbleSort()
        {
            int length = lstTelephone.Items.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (lstTelephone.Items[j].ToString().CompareTo(lstTelephone.Items[j + 1].ToString()) > 0)
                        swap(j, j+1);
                }
            }
        }
        // swap for buble sort
        private void swap(int i, int j)
        {
            //swaping telephone
            string tempTelephone = lstTelephone.Items[j].ToString();
            lstTelephone.Items[j] = lstTelephone.Items[i];
            lstTelephone.Items[i] = tempTelephone;

            //swaping name
            string tempName = lstName.Items[j].ToString();
            lstName.Items[j] = lstName.Items[i];
            lstName.Items[i] = tempName;

            //swaping surname
            string tempSurname = lstSurname.Items[j].ToString();
            lstSurname.Items[j] = lstSurname.Items[i];
            lstSurname.Items[i] = tempSurname;
        }
        // function saving when changes made to the list
        private void saveChanges()
        {
            DialogResult dialogResult = MessageBox.Show("Would You like to save changes?", "SAVE ?",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveToFile();
            }
            else
                return;
        }
        //function saving to file
        private void saveToFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog()) //openstream
            {
                sfd.Filter = "Text Documents|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter saveStream = new StreamWriter(sfd.FileName))
                    {
                        //writting to file line by line
                        for (int i = 0; i < lstTelephone.Items.Count; i++)
                        {
                            saveStream.WriteLine(lstTelephone.Items[i].ToString());
                            saveStream.WriteLine(lstName.Items[i].ToString());
                            saveStream.WriteLine(lstSurname.Items[i].ToString());
                        }
                        //writting last line
                        saveStream.Write("00000000000");
                    }
                    changesMade = false;
                }
            }
        }
    }
}
