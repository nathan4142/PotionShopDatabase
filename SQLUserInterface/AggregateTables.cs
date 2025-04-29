using PotionShopDatabase;
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

    }
}
