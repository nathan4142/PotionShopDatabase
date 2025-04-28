using PotionShopDatabase;
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

            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez1011;Integrated Security=SSPI;");
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
    }
}
