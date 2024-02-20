using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SimpleTCP;


namespace KitchenForm
{
    public partial class kitchenForm : Form
    {
   

        int x, y = 100;
        int lx = 10;
        int ly = 30;
        List<string> comingOrderList = new List<string>();

        GroupBox groupBox;
        Label timeLbl;
        Label timeLbl1;
        int remainingTime = 0;
   
        SimpleTcpClient client;
        SimpleTcpServer server;
        Dictionary<string, List<string>> addresses = new Dictionary<string, List<string>>()
    {
        {"kitchen", new List<string> { "192.168.1.165", "4001" } },
        {"stuff", new List<string> { "192.168.1.102", "4000" } },
        {"customer", new List<string> { "192.168.1.232", "4002" } }
    };
        public kitchenForm()
        {
            InitializeComponent();
        }

      

        private bool ConnectToClient()
        {
            try
            {
                client.Connect(addresses["stuff"][0], Convert.ToInt32(addresses["stuff"][1]));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Connect To Kitchen, Try Again");
                return false;
            }
        }

        private void StartServer()
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(addresses["kitchen"][0]); // çalışan ipsi
            int pcport = Convert.ToInt32(addresses["kitchen"][1]);
            server.Start(ip, pcport);
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            if (!String.IsNullOrEmpty(e.MessageString))
            {
                comingOrderList = e.MessageString.Split('_').Skip(1).ToList();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var status = ConnectToClient();
            if (status)
                client.WriteLineAndGetReply("aaaa", TimeSpan.FromSeconds(3));
        }

        
       
        private void FillGroupBox()
        {


            groupBox = new GroupBox();
            groupBox.Size = new Size(300, 300);
            groupBox.Location = new Point(x, y);

            for (int i = 0; i < comingOrderList.Count(); i++)
            {
                Label productName = new Label();
                productName.Size = new Size(150, 30);

                productName.Location = new Point(lx, ly);
                if (i % 2 == 0)
                {
                    ly += 35;
                productName.Name = Guid.NewGuid().ToString();
                productName.Text = comingOrderList[i];
                groupBox.BackColor = Color.Blue;
                groupBox.Controls.Add(productName);
                }
                else
                {
                    remainingTime += Convert.ToInt32(comingOrderList[i]);
                }


            }
            timeLbl = new Label();
            timeLbl.Name = Guid.NewGuid().ToString();
            //timeLbl.Text = "Remainin Time: " +  remainingTime.ToString();
            timeLbl.Location = new Point(150, 230);
            timeLbl.Size = new Size(130, 40);
            groupBox.Controls.Add(timeLbl);
            //productName.Text = comingOrderList[0];
            panel1.Controls.Add(groupBox);
            x += 320;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1300;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comingOrderList.Count() > 0)
            {
                FillGroupBox();

                comingOrderList.Clear();

                lx = 10;
                ly = 30;
            }
        }

        private void kitchenForm_Load_1(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            server = new SimpleTcpServer();

            client.StringEncoder = Encoding.UTF8;

            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;//türkçe karakter okuma
            server.DataReceived += Server_DataReceived;

            StartServer();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (remainingTime > 0)
            {
                remainingTime--;
                timeLbl.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");
            }
            else
            {
                groupBox.BackColor = Color.Green;
                //((System.Windows.Forms.Timer)sender).Stop();
            }
        }



    }
}
