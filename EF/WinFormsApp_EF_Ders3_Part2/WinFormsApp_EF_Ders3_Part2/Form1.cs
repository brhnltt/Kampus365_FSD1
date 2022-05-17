using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp_EF_Ders3_Part2.Models;

namespace WinFormsApp_EF_Ders3_Part2
{
    public partial class Form1 : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPass.Text.Trim();

            User user = new User
            {
                FullName = fullname,
                Email = email,
                Password = pass,
                IsActive = true
            };

            db.Users.Add(user);
            db.SaveChanges();

            LoadUsers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            List<User> users = db.Users.ToList();

            lstUsers.DataSource = null;
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = nameof(User.FullName);
            lstUsers.ValueMember = nameof(User.Id);
        }

        private void btnAddressSave_Click(object sender, EventArgs e)
        {
            User selectedUser = lstUsers.SelectedItem as User;

            //List<User> users = db.Users.ToList();
            //bool varmi = false;

            //foreach (User u in users)
            //{
            //    if(u.Id == selectedUser.Id)
            //    {
            //        varmi = true;
            //        break;
            //    }
            //}


            //if (db.Users.Any(u => u.Id == selectedUser.Id) == true)
            //{

            //}

            User user = db.Users.FirstOrDefault(u => u.Id == selectedUser.Id);

            if (user != null)
            {
                string addressDetail = txtAddressDetail.Text.Trim();

                Address address = new Address
                {
                    Detail = addressDetail,
                    User = user
                };

                db.Addresses.Add(address);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen user listesini yenileyiniz. İlgili user silinmiştir.");
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = lstUsers.SelectedItem as User;

            if (selectedUser == null)
            {
                return;
            }

            List<Address> list = null;

            list = LoadAddressMethod1(selectedUser);
            //list = LoadAddressMethod2EagerLoading(selectedUser);
            //list = LoadAddressMethod3LazyLoading(selectedUser);

            lstAddresses.DataSource = null;
            lstAddresses.DataSource = list;
            lstAddresses.DisplayMember = nameof(Address.Detail);
            lstAddresses.ValueMember = nameof(Address.Id);
        }

        private List<Address> LoadAddressMethod3LazyLoading(User selectedUser)
        {
            List<Address> list;
            User user = db.Users.FirstOrDefault(u => u.Id == selectedUser.Id);

            list = user.Addresses;
            return list;
        }

        private List<Address> LoadAddressMethod2EagerLoading(User selectedUser)
        {
            // Eager Loading..

            User user = db.Users
                .Include(u => u.Addresses)
                .Include(u => u.Phones)
                .FirstOrDefault(u => u.Id == selectedUser.Id);

            //User user = db.Users.Find(selectedUser.Id);

            List<Address> list = user.Addresses;
            return list;
        }

        private List<Address> LoadAddressMethod1(User selectedUser)
        {
            //List<Address> addresses = db.Addresses.Where(a => a.User.Id == selectedUser.Id).ToList();
            List<Address> addresses = db.Addresses.Where(a => a.UserId == selectedUser.Id).ToList();

            return addresses;
        }

        private void btnPhoneSave_Click(object sender, EventArgs e)
        {
            User selectedUser = lstUsers.SelectedItem as User;

            string phoneNo = txtPhoneNumber.Text.Trim();

            Phone phone = new Phone
            {
                PhoneNumber = phoneNo,
                UserId = selectedUser.Id
            };

            db.Phones.Add(phone);
            db.SaveChanges();
        }
    }
}
