using EF_RentACarOrnegi.Models;
using MFramework.Services.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EF_RentACarOrnegi
{
    public partial class Form1 : Form
    {
        DatabaseContext db = new DatabaseContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVehicles frm = new frmVehicles();
            //frm.Parent = this;

            frm.ShowDialog();

            LoadVehicles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadVehicles();
            LoadCustomers();
            LoadRentings();
        }

        private void LoadCustomers()
        {
            List<Customer> customers = db.Customers.ToList();

            cmbCustomers.DataSource = null;
            cmbCustomers.DataSource = customers;
            cmbCustomers.DisplayMember = nameof(Customer.NameSurname);
            cmbCustomers.ValueMember = nameof(Customer.Id);

        }

        private void LoadVehicles()
        {
            List<Vehicle> vehicles = db.Vehicles.ToList();

            cmbVehicles.DataSource = null;
            cmbVehicles.DataSource = vehicles;
        }

        private void btnCreateCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO : müşteriler formu açılır ve ekleme, silme, güncelleme orada yapılır.

            // FAKE :
            Customer customer = new Customer
            {
                NameSurname = NameData.GetFullName(),
                Email = NetworkData.GetEmail(),
                Age = NumberData.GetNumber(18, 80),
                Phone = PhoneNumberData.GetPhoneNumber(),
                Note = TextData.GetSentence(),
                IsBlackList = BooleanData.GetBoolean()
            };

            db.Customers.Add(customer);
            db.SaveChanges();

            LoadCustomers();
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            Customer customer = cmbCustomers.SelectedItem as Customer;
            Vehicle vehicle = cmbVehicles.SelectedItem as Vehicle;

            int rentTypeIndex = cmbRentType.SelectedIndex;
            RentType rentType = (RentType)rentTypeIndex;

            Renting renting = new Renting
            {
                CustomerId = customer.Id,
                VehicleId = vehicle.Id,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                RentType = rentType,
                StartKM = (int)nudStartKM.Value,
                EndKM = (int)nudEndKM.Value,
                LimitKM = (int)nudLimitKM.Value,
                Price = nudPrice.Value,
                Discount = nudDiscount.Value,
                ExtraPrice = nudExtraPrice.Value,
            };

            db.Rentings.Add(renting);
            db.SaveChanges();

            LoadRentings();
        }

        private void LoadRentings()
        {
            List<Renting> rentings = db.Rentings.ToList();
            List<RentingViewModel> rentingViewModels = new List<RentingViewModel>();    // DTO : Data Transfer Object

            foreach (Renting item in rentings)
            {
                string rentType = string.Empty;

                switch (item.RentType)
                {
                    case RentType.None:
                        rentType = "Yok";
                        break;
                    case RentType.ShortTerm:
                        rentType = "Kısa Dönem Kiralama";
                        break;
                    case RentType.LongTerm:
                        rentType = "Uzun Dönem Kiralama";
                        break;
                    default:
                        break;
                }

                RentingViewModel renting = new RentingViewModel
                {
                    RentingId = item.Id,
                    Customer = item.Customer.NameSurname,
                    Vehicle = $"{item.Vehicle.Brand} - {item.Vehicle.Model} - {item.Vehicle.PlateNo}",
                    StartKM = item.StartKM,
                    EndKM = item.EndKM,
                    LimitKM = item.LimitKM,
                    Price = item.Price,
                    Discount = item.Discount,
                    ExtraPrice = item.ExtraPrice,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    RentType = rentType
                };

                rentingViewModels.Add(renting);
            }


            dgvRentings.DataSource = null;
            dgvRentings.DataSource = rentingViewModels;

            dgvRentings.Columns["RentingId"].Visible = false;
        }

        private void cmbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicles.SelectedIndex == -1)
                return;

            Vehicle vehicle = cmbVehicles.SelectedItem as Vehicle;

            nudPrice.Value = vehicle.DailyPrice;
            nudLimitKM.Value = vehicle.LimitKM;
        }
    }
}
