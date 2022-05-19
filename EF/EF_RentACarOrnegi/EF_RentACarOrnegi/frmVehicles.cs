using EF_RentACarOrnegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EF_RentACarOrnegi
{
    public partial class frmVehicles : Form
    {
        DatabaseContext db = new DatabaseContext();

        public frmVehicles()
        {
            InitializeComponent();
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Year  = (int)nudYear.Value,
                AgeLimit = (int)nudAgeLimit.Value,
                DailyPrice = nudDailyPrice.Value,
                KMExtraPrice = nudExtraKMPrice.Value,
                PlateNo = txtPlateNo.Text,
                LimitKM = (int)nudLimitKM.Value,
            };

            db.Vehicles.Add(vehicle);
            db.SaveChanges();

            LoadVehicles();
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            List<Vehicle> vehicles = db.Vehicles.ToList();

            lstVehicles.DataSource = null;
            lstVehicles.DataSource = vehicles;
        }
    }
}
