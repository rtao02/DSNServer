using System;
using System.ServiceModel;
using System.Windows.Forms;
using DSNInterfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Threading;
using System.Data;

namespace DSNServer
{
    public partial class DSNServerForm : Form
    {
        // This BindingSource binds the list to the DataGridView control.
        static BindingSource spaceCraftsBindingSource = new BindingSource();
        static BindingList<SpaceCraft> spacecraftList = new BindingList<SpaceCraft>();
        static int _totalNumber = 9;
        //private DSNService d1 = null;

        //static BindingList<SpaceCraft> spacecraftList = new BindingList<SpaceCraft>();
        public DSNServerForm()
        {
            InitializeComponent();
        }

        private void DSNServerForm_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= _totalNumber; i++)
            {
                SpaceCraft temp = SpaceCraft.CreateNewSC_DSN();
                spacecraftList.Add(temp);
            }
            spaceCraftsBindingSource.DataSource = spacecraftList;
            this.spacecraftsDataGridView.DataSource = spaceCraftsBindingSource;
            var host = new ServiceHost(typeof(DSNService),
                       new Uri("net.pipe://localhost"));

            host.AddServiceEndpoint(typeof(IDSNService),
                                    new NetNamedPipeBinding(), "DSN");
            host.Open();
        }

        private void sendCMDBtn_Click(object sender, EventArgs e)
        {
            //DSNService.Callback.SendCallbackMessage("Hi, I'm the server");
            //send cmd from DSN server to space crafts
            string input_CMD = textBox1.Text;
            textBox1.Clear();
            DSNService.Callback.SendCallbackMessage(input_CMD);
        }
        //private void startSyncBtn_Click(object sender, EventArgs e)
        //{
        //    //DSNService.Callback.SendCallbackMessage("Hi, I'm the server");
        //    //start sync space crafts' info
        //}
        private void spacecraftsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.spacecraftsDataGridView.Columns["vehicle_Altitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["vehicle_Longitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["vehicle_Latitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["vehicle_Temperature1"].Visible = false;
            this.spacecraftsDataGridView.Columns["vehicle_Time_to_Orbit1"].Visible = false;

            this.spacecraftsDataGridView.Columns["payloadData1"].Visible = false;
            this.spacecraftsDataGridView.Columns["payload_Altitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["payload_Longitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["payload_Latitude1"].Visible = false;
            this.spacecraftsDataGridView.Columns["payload_Temperature1"].Visible = false;
            this.spacecraftsDataGridView.Columns["payload_Time_to_Orbit1"].Visible = false;
        }
        static public void GetNewData(BindingList<SpaceCraft> message)
        {
            BindingList<SpaceCraft> spacecraftList =
                spaceCraftsBindingSource.DataSource as BindingList<SpaceCraft>;
            for (int i = 0; i < _totalNumber; i++)
            {
                //MessageBox.Show("Updating");
                spacecraftList[i].Orbit_Info = message[i].Orbit_Info;
                spacecraftList[i].PayloadData = message[i].PayloadData;
                spacecraftList[i].Payload_Altitude = message[i].Payload_Altitude;
                spacecraftList[i].PayloadName = message[i].PayloadName;
                spacecraftList[i].PayloadType = message[i].PayloadType;
                spacecraftList[i].Payload_id = message[i].Payload_id;
                spacecraftList[i].Payload_Latitude = message[i].Payload_Latitude;
                spacecraftList[i].Payload_Longitude = message[i].Payload_Longitude;
                spacecraftList[i].Payload_Stat = message[i].Payload_Stat;
                spacecraftList[i].Payload_Temperature = message[i].Payload_Temperature;
                spacecraftList[i].Payload_Time_to_Orbit = message[i].Payload_Time_to_Orbit;
                spacecraftList[i].VehicleName = message[i].VehicleName;
                spacecraftList[i].Vehicle_Altitude = message[i].Vehicle_Altitude;
                spacecraftList[i].Vehicle_id = message[i].Vehicle_id;
                spacecraftList[i].Vehicle_Latitude = message[i].Vehicle_Latitude;
                spacecraftList[i].Vehicle_Longitude = message[i].Vehicle_Longitude;
                spacecraftList[i].Vehicle_Stat = message[i].Vehicle_Stat;
                spacecraftList[i].Vehicle_Temperature = message[i].Vehicle_Temperature;
                spacecraftList[i].Vehicle_Time_to_Orbit = message[i].Vehicle_Time_to_Orbit;
            }
        }
    }
}