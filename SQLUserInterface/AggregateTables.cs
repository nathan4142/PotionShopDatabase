using PotionShopDatabase;
using PotionShopDatabase.Models;
using PotionShopDatabase.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLUserInterface
{
    public partial class AggregateTables : Form
    {
        public AggregateTables()
        {
            InitializeComponent();

            ux_potionTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ux_potionTypeComboBox.DataSource = Enum.GetValues(typeof(PotionType));
            ux_potionTypeComboBox.SelectedIndex = 0;

            ux_storeIDPicker.Minimum = 1;
            ux_storeIDPicker.Maximum = 25;
            ux_storeIDPicker.Value = 1;
            ux_storeIDPicker.DecimalPlaces = 0;

        }

        private void ux_findCoolestStores_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");
            dataTable.Columns.Add("TotalGoldStars");

            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            int goldStars = (int)ux_numGoldStars.Value;
            var coolestStores = repo.GetCoolestStores(goldStars);

            foreach (var (store, goldstars) in coolestStores)
            {
                var row = dataTable.NewRow();

                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;
                //row["TotalGoldStars"] = store.TotalGoldStars;
                row["TotalGoldStars"] = goldstars;
                dataTable.Rows.Add(row);
            }

            ux_StoreTable.DataSource = dataTable;


        }

        private void ux_getMonthlyRankButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Month");
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");
            dataTable.Columns.Add("Sales");
            dataTable.Columns.Add("Rank");

            var repo = new SqlMonthlyRankOfStoresRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            DateTime firstDate = ux_firstDateTimePicker.Value;
            DateTime secondDate = ux_secondDateTimePicker.Value;
            var rankedStores = repo.GetMonthlyRankOfStores(firstDate, secondDate);

            foreach(var (year, month, store, sales, rank) in rankedStores )
            {
                var row = dataTable.NewRow();

                row["Year"] = year;
                row["Month"] = month;
                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;
                row["Sales"] = sales;
                row["Rank"] = rank;

                dataTable.Rows.Add(row);
            }
            ux_StoreTable.DataSource = dataTable;
        }

        private void ux_getPotionCountButtonClick(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");
            dataTable.Columns.Add("PotionCount");

            var repo = new SqlNumberOfPotionsByTypeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            var selectedType = (int)ux_potionTypeComboBox.SelectedItem!;
            var results = repo.GetNumberOfPotionsByType(selectedType);

            foreach ((Store store, int count) in results)
            {
                var row = dataTable.NewRow();
                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;
                row["PotionCount"] = count;
                dataTable.Rows.Add(row);
            }

            ux_StoreTable.DataSource = dataTable;

        }

        private void ux_getInventoryValueButtonClick(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");
            dataTable.Columns.Add("InventoryValue", typeof(decimal));

            var repo = new SqlInventoryValueRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            var selectedID = (int)ux_storeIDPicker.Value;
            var results = repo.GetStoreInventoryValueByStore(selectedID);

            foreach ((Store store, decimal inventory) in results)
            {
                var row = dataTable.NewRow();
                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;
                row["InventoryValue"] = inventory;
                dataTable.Rows.Add(row);
            }

            ux_StoreTable.DataSource = dataTable;

            var col = ux_StoreTable.Columns["InventoryValue"];
            if (col != null)
            {
                col.DefaultCellStyle.Format = "C2";
            }
        }

    }
}
