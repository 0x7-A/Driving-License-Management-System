using Project_19_DVDL__2nd_.Properties;
using Project19_businessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Project_19_DVDL__2nd_
{
    public partial class frmAddEditPerson : frmPerson
    {
        enum enMode { Addnew = 0, Edit = 1 };
        private enMode Mode;
        string selectedFilePath = "";
        private clsPerson Person;

        private DataTable dt;

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            if (PersonID == -1)
            {
                Mode = enMode.Addnew;
                Person = new clsPerson();
                this.Text = "Add Person";
            }
            else
            {
                Mode = enMode.Edit;
                Person = clsPerson.FindPersonByID(PersonID);
                this.Text = "Update Person";
            }
            Check();
        }

        private void frmAddDelete_Load(object sender, EventArgs e)
        {
            
        }

        private void Check()
        {


            if (Person == null)
            {
                MessageBox.Show("Error: Person object could not be initialized.");
                this.Close();
                return;
            }
            CountryList();
            UpdateDateTime();
            if (Mode == enMode.Addnew)
            {
                lblTitle.Text = "Add New Person";
                rbMale.Checked = true;
            
                return;
            }
            else
            {
                lblTitle.Text = "Update Person";

                
                lblID.Text = Person.PersonID.ToString();
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                txtSecondName.Text = Person.SecondName;
                txtThirdName.Text = Person.ThirdName;   
                txtPhone.Text = Person.Phone;
                txtEmail.Text = Person.Email;
                txtAddress.Text = Person.Address;
                txtNationalNumber.Text = Person.NationalNumber;
                dtDateOfBirth.Value = Person.DateOfBirth;
                ActiveGender();

                if (Person.ImagePath != "" && File.Exists(Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = Person.ImagePath;
                }
                else
                {
                 
                    if (Person.Gendor == 0)
                        pbPersonImage.Image = Resources.Male_512;
                    else
                        pbPersonImage.Image = Resources.Female_512;
                    
                }
                cbCountry.SelectedItem = Person.CountryName;
            }
        }

        private void ActiveGender()
        {
            if (Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNationalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            Control tempControl = (Control)sender;

            if (string.IsNullOrWhiteSpace(tempControl.Text))
            {

                e.Cancel = false;
                errorProvider.SetError(tempControl, "");
                return;
            }

            if (Mode == enMode.Addnew)
            {
                if (clsPerson.DoesPersonExists(txtNationalNumber.Text))
                {
                    e.Cancel = true;
                    txtNationalNumber.Focus();
                    errorProvider.SetError(txtNationalNumber,
                   "National number with " + txtNationalNumber.Text + " already Exists, try again");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtNationalNumber, "");
                }
            }
        }



      

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateGenderImage();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (Mode == enMode.Addnew)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtEmail, "");
                    return;
                }


                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, "Please enter a valid email address (e.g. name@example.com)");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtEmail, "");
                }
            }
        }

        private void CountryList()
        {
            dt = clsPerson.GetAllCountries();
            foreach (DataRow r in dt.Rows)
            {
                cbCountry.Items.Add(r["CountryName"]);
            }
            cbCountry.SelectedItem = "Jordan";
        }


        private void txtEmpty_Validating(object sender, CancelEventArgs e)
        {

            Control tempControl = (Control)sender;


            if (string.IsNullOrWhiteSpace(tempControl.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tempControl, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tempControl, "");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                selectedFilePath = openFileDialog.FileName;
                pbPersonImage.ImageLocation = selectedFilePath;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtSecondName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                       string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Can't add person untill Filling all the requirement");
                return;
            }


            int PersonID = 0;

            int result = GetCountryID(cbCountry.SelectedItem.ToString());

            string oldImagePath = Person.ImagePath;

            if (!_HandlePersonImage())
                return;

            if (result == -1)
            {
                MessageBox.Show("An Error Happend with country combobox");
                return;
            }

            if (Mode == enMode.Addnew)
            {


                if (clsPerson.AddNewPerson(ref PersonID, txtNationalNumber.Text, txtFirstName.Text, txtSecondName.Text,
                     txtThirdName.Text, txtLastName.Text,
                     dtDateOfBirth.Value, GetGender(), txtAddress.Text, txtPhone.Text, txtEmail.Text, result, Person.ImagePath))
                {
                    lblID.Text = PersonID.ToString();
                    MessageBox.Show("Person with " + PersonID + " ID Added SucessFully");
                    Mode = enMode.Edit;
                    DataBack?.Invoke(this, PersonID);

                }
                else
                {
                    MessageBox.Show("Error, something went wrong");
                }
            }
            else
            {
                if (clsPerson.Update(Person.PersonID, txtNationalNumber.Text, txtFirstName.Text, txtSecondName.Text,
                         txtThirdName.Text, txtLastName.Text,
                         dtDateOfBirth.Value, GetGender(), txtAddress.Text, txtPhone.Text, txtEmail.Text, result, Person.ImagePath))
                {
                    if (oldImagePath != "" && oldImagePath != Person.ImagePath)
                    {
                        _DeleteOldPhysicalImage(oldImagePath);
                    }
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    MessageBox.Show("error failed to update successfully");
                }

            }
                

        }

        private void _DeleteOldPhysicalImage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath)) return;

            try
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }
            catch (IOException ex)
            {
                System.Diagnostics.Debug.WriteLine("Physical file deletion failed: " + ex.Message);
            }
        }

        private int GetGender()
        {
            return rbMale.Checked ? 0 : 1;
        }

        private int GetCountryID(string CountryName)
        {
            return clsPerson.GetCountryID(CountryName);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _UpdateGenderImage();

           
            pbPersonImage.ImageLocation = null;
            selectedFilePath = "";
            linkLabel2.Visible = false;
        }
        private void _UpdateGenderImage()
        {
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }
        
           private bool _HandlePersonImage()
        {
           
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                Person.ImagePath = "";
                return true;
            }

            
            if (pbPersonImage.ImageLocation == Person.ImagePath)
                return true;

            string DestinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "People-Images");
            if (!Directory.Exists(DestinationFolder))
                Directory.CreateDirectory(DestinationFolder);

            string SourceFile = pbPersonImage.ImageLocation;
            string FileExtension = Path.GetExtension(SourceFile);
            string DestinationFile = Path.Combine(DestinationFolder, Guid.NewGuid().ToString() + FileExtension);

            try
            {
                // 3. This is now safe because we checked for null above
                File.Copy(SourceFile, DestinationFile, true);
                Person.ImagePath = DestinationFile;
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error copying image: " + ex.Message);
                return false;
            }
        }
    }

    }


