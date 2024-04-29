using Class;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace The_App
{
    public partial class FormMenuLL : Form
    {
        public FormMenuLL()
        {
            InitializeComponent();
        }

        private void TenantManaging_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Reload()
        {
            ConnectionManager.Current.openConnection();
            string query = "SELECT * FROM HIRED";
            SqlCommand command = new SqlCommand(query, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            kryptonDataGridViewCompany.DataSource = dataTable;

            ////////

            string query1 = "SELECT * FROM TENANT";
            SqlCommand command1 = new SqlCommand(query1, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            kryptonDataGridViewTenant.DataSource = dataTable1;

            ///////
            string querycom = "SELECT * FROM BROKERAGECOMPANY";
            SqlCommand commandcom = new SqlCommand(querycom, ConnectionManager.Current.getConnection);
            SqlDataAdapter adaptercom = new SqlDataAdapter(commandcom);
            DataTable dataTablecom = new DataTable();
            adaptercom.Fill(dataTablecom);
            kryptonDataGridViewCom.DataSource = dataTablecom;

            ///////
            string queryRent = "SELECT * FROM RENT";
            SqlCommand commandRent = new SqlCommand(queryRent, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterRent = new SqlDataAdapter(commandRent);
            DataTable dataTableRent = new DataTable();
            adapterRent.Fill(dataTableRent);
            kryptonDataGridViewRent.DataSource = dataTableRent;

            /////
            string queryRoom = "SELECT * FROM ROOM";
            SqlCommand commandRoom = new SqlCommand(queryRoom, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterRoom = new SqlDataAdapter(commandRoom);
            DataTable dataTableRoom = new DataTable();
            adapterRoom.Fill(dataTableRoom);
            kryptonDataGridViewRoom.DataSource = dataTableRoom;

            /////
            string queryContract = "SELECT * FROM CONTRACT";
            SqlCommand commandContract = new SqlCommand(queryContract, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterContract = new SqlDataAdapter(commandContract);
            DataTable dataTableContract = new DataTable();
            adapterContract.Fill(dataTableContract);
            kryptonDataGridViewContract.DataSource = dataTableContract;

            ////
            string queryBill = "SELECT * FROM BILL";
            SqlCommand commandBill = new SqlCommand(queryBill, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterBill = new SqlDataAdapter(commandBill);
            DataTable dataTableBill = new DataTable();
            adapterBill.Fill(dataTableBill);
            kryptonDataGridViewBill.DataSource = dataTableBill;

            ////
            string queryLandlord = "SELECT * FROM LANDLORD";
            SqlCommand commandLandlord = new SqlCommand(queryLandlord, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterLandlord = new SqlDataAdapter(commandLandlord);
            DataTable dataTableLandlord = new DataTable();
            adapterLandlord.Fill(dataTableLandlord);
            kryptonDataGridViewLandlord.DataSource = dataTableLandlord;

            ////
            string queryCompany_Landlords_List = "SELECT * FROM Company_Landlords_List";
            SqlCommand commandCompany_Landlords_List = new SqlCommand(queryCompany_Landlords_List, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterCompany_Landlords_List = new SqlDataAdapter(commandCompany_Landlords_List);
            DataTable dataTableCompany_Landlords_List = new DataTable();
            adapterCompany_Landlords_List.Fill(dataTableCompany_Landlords_List);
            kryptonDataGridViewCompany_Landlords_List.DataSource = dataTableCompany_Landlords_List;

            /////
            string queryLandlord_Rooms_List = "SELECT * FROM Landlord_Rooms_List";
            SqlCommand commandLandlord_Rooms_List = new SqlCommand(queryLandlord_Rooms_List, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterLandlord_Rooms_List = new SqlDataAdapter(commandLandlord_Rooms_List);
            DataTable dataTableLandlord_Rooms_List = new DataTable();
            adapterLandlord_Rooms_List.Fill(dataTableLandlord_Rooms_List);
            kryptonDataGridViewLandlord_Rooms_List.DataSource = dataTableLandlord_Rooms_List;

            ////
            string queryLandlord_Tenants_List = "SELECT * FROM Landlord_Tenants_List";
            SqlCommand commandLandlord_Tenants_List = new SqlCommand(queryLandlord_Tenants_List, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterLandlord_Tenants_List = new SqlDataAdapter(commandLandlord_Tenants_List);
            DataTable dataTableLandlord_Tenants_List = new DataTable();
            adapterLandlord_Tenants_List.Fill(dataTableLandlord_Tenants_List);
            kryptonDataGridViewLandlord_Tenants_List.DataSource = dataTableLandlord_Tenants_List;

            ////
            string queryLandlord_Contracts_List = "SELECT * FROM Landlord_Contracts_List";
            SqlCommand commandLandlord_Contracts_List = new SqlCommand(queryLandlord_Contracts_List, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterLandlord_Contracts_List = new SqlDataAdapter(commandLandlord_Contracts_List);
            DataTable dataTableLandlord_Contracts_List = new DataTable();
            adapterLandlord_Contracts_List.Fill(dataTableLandlord_Contracts_List);
            kryptonDataGridViewLandlord_Contracts_List.DataSource = dataTableLandlord_Contracts_List;

            ////
            string queryTenant_Contracts = "SELECT * FROM Tenant_Contracts";
            SqlCommand commandTenant_Contracts = new SqlCommand(queryTenant_Contracts, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapterTenant_Contracts = new SqlDataAdapter(commandTenant_Contracts);
            DataTable dataTableTenant_Contracts = new DataTable();
            adapterTenant_Contracts.Fill(dataTableTenant_Contracts);
            kryptonDataGridViewTenant_Contracts.DataSource = dataTableTenant_Contracts;
        }
        private void FormMenuLL_Load(object sender, EventArgs e)
        {

            Reload();


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            RoomManager.DeleteRoom(tb_RoomNumber_Room.Text);
            Reload();
        }

        private void bt_insert_hired_Click(object sender, EventArgs e)
        {
            HiredManager.InsertHired(tb_ID_l_Hired.Text, TaxcodeCompany_Hired.Text, DayStart_Hired.Value, DayEnd_Hired.Value);
            Reload();
        }

        private void bt_insert_company_Click(object sender, EventArgs e)
        {
            CompanyManager.InsertCompany(tb_taxcode_Company.Text, tb_name_company.Text, tb_address_company.Text, Convert.ToDecimal(tb_wallet_company1.Text), Convert.ToDecimal(tb_bonusprice_company1.Text), Convert.ToDecimal(tb_pricepermonth_company1.Text));
            Reload();
        }

        private void bt_update_company_Click(object sender, EventArgs e)
        {
            CompanyManager.UpdateCompany(tb_taxcode_Company.Text, tb_name_company.Text, tb_address_company.Text, Convert.ToDecimal(tb_wallet_company1.Text), Convert.ToDecimal(tb_bonusprice_company1.Text), Convert.ToDecimal(tb_pricepermonth_company1.Text));
            Reload();
        }

        private void bt_delete_company_Click(object sender, EventArgs e)
        {
            CompanyManager.DeleteCompany(tb_taxcode_Company.Text);
            Reload();
        }

        private void bt_insert_Rent_Click(object sender, EventArgs e)
        {
            RentManager.InsertRent(tb_ID_t_Rent.Text, tb_Roomnumber_Rent.Text, DayStart_Rent.Value, DateEnd_Rent.Value, tb_Taxcode_Rent.Text);
            Reload();
        }

        private void bt_update_rent_Click(object sender, EventArgs e)
        {

        }

        private void bt_Code_Contract_Click(object sender, EventArgs e)
        {
            ContractManager.DeleteContract(tb_Code_Contract.Text);
            Reload();
        }

        private void bt_insert_room_Click(object sender, EventArgs e)
        {
            bool temp = false;
            if (materialComboBox1.SelectedIndex == 1 )
                temp = true;
            RoomManager.InsertRoom(tb_RoomNumber_Room.Text, 
                Convert.ToInt32(tb_Area_Room.Text), 
                Convert.ToInt32(tb_Insterior_Room.Text), 
                temp, 
                Convert.ToDecimal(tb_ElectricityPrice_room),
                Convert.ToDecimal(tb_WaterPrice_Room.Text), 
                ID_l_room.Text);
            Reload();
        }

        private void bt_update_room_Click(object sender, EventArgs e)
        {
            bool temp = false;
            if (materialComboBox1.SelectedIndex == 1)
                temp = true;
            RoomManager.UpdateRoom(tb_RoomNumber_Room.Text, Convert.ToInt32(tb_Area_Room.Text), Convert.ToInt32(tb_Insterior_Room.Text), temp, Convert.ToDecimal(tb_ElectricityPrice_room.Text), Convert.ToDecimal(tb_WaterPrice_Room.Text), ID_l_room.Text);
            Reload();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButtonINs_Click(object sender, EventArgs e)
        {
            TenantManager.InsertTenant(materialMaskedTextBoxID.Text, materialMaskedTextBoxName.Text, materialMaskedTextBoxPhone.Text, materialMaskedTextBoxJob.Text, kryptonDateTimePickerTenantBday.Value, Convert.ToDecimal(materialMaskedTextBoxBLc.Text));
        }

        private void materialButtonupdatetn_Click(object sender, EventArgs e)
        {
            TenantManager.UpdateTenant(materialMaskedTextBoxID.Text, materialMaskedTextBoxName.Text, materialMaskedTextBoxPhone.Text, materialMaskedTextBoxJob.Text, kryptonDateTimePickerTenantBday.Value, Convert.ToDecimal(materialMaskedTextBoxBLc.Text));

        }

        private void materialButtondeletetn_Click(object sender, EventArgs e)
        {
            TenantManager.DeleteTenant(materialMaskedTextBoxID.Text);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialMaskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void materialButtonInsBill_Click(object sender, EventArgs e)
        {
            BillManagercs.InsertBill(materialMaskedTextBoxCodebILL.Text, float.Parse(materialMaskedTextBoxElectricNumber.Text), float.Parse(materialMaskedTextBoxWaterNumber.Text), kryptonDateTimePickerDay.Value, materialMaskedTextBoxID_lBill.Text, materialMaskedTextBoxRoomNumber.Text, materialMaskedTextBoxIDtenant.Text);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            BillManagercs.UpdateBill(materialMaskedTextBoxCodebILL.Text, float.Parse(materialMaskedTextBoxElectricNumber.Text), float.Parse(materialMaskedTextBoxWaterNumber.Text), kryptonDateTimePickerDay.Value);

        }

        private void materialButtonFindBill_Click(object sender, EventArgs e)
        {
            kryptonDataGridViewBill.DataSource = BillManagercs.FindBillByCode(materialMaskedTextBoxCodebILL.Text);
        }

        private void materialButtonFindTenant_Click(object sender, EventArgs e)
        {
            kryptonDataGridViewTenant.DataSource = TenantManager.FindTenantByID(materialMaskedTextBoxID.Text);
        }

        private void materialButtonFindLW_Click(object sender, EventArgs e)
        {
            kryptonDataGridViewLandlord.DataSource = LandlordManager.FindLandlordByID(materialMaskedTextBoxIDLW.Text);
        }
    }
}
