using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FinalHomework
{
    public partial class Form1 : Form
    {
        List<string> regions;
        private string messageToSend;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            messageToSend = "Enemy is attacking to: " + txtAttack.Text;
            byte[] message = Encoding.ASCII.GetBytes(messageToSend);
            txtInfo.Clear();
            client.BeginSend(message, 0, message.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_List_Regions(sender, e);
            MainForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (regions.Count==4)
            {
                regions.Add(txtAttack.Text);
                System.Console.WriteLine("You Win!");
                client.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (regions.Count >= 1)
            {
                try
                {
                    regions.Remove(txtAttack.Text);
                }
                catch
                {
                    System.Console.WriteLine("You dont have this region");
                }
            }
            else if (regions.Count == 0)
            {
                System.Console.WriteLine("You Lose!");
            }
        }
        private void Add_List_Regions(object sender, EventArgs e)
        {
            regions = lstAreaSelect.CheckedItems.OfType<string>().ToList();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Click += new EventHandler(ButtonConnectOnClick);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Click += new EventHandler(ButtonDisconOnClick);
        }

        private void txtAttack_TextChanged(object sender, EventArgs e)
        {
            this.txtAttack.Text = txtAttack.Text.Trim();
        }


        void ButtonConnectOnClick(object obj, EventArgs ea)
        {
            txtInfo.Text = "Connecting...";
            Socket newsock = new Socket(AddressFamily.InterNetwork,
                                  SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }

        void ButtonSendOnClick(object obj, EventArgs ea)
        {
            byte[] message = Encoding.ASCII.GetBytes(txtInfo.Text);
            txtInfo.Clear();
            client.BeginSend(message, 0, message.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }

        void ButtonDisconOnClick(object obj, EventArgs ea)
        {
            client.Close();
            txtInfo.Text = "Disconnected";
        }

        void Connected(IAsyncResult iar)
        {
            client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                txtInfo.Text = "Connected to: " + client.RemoteEndPoint.ToString();
                client.BeginReceive(data, 0, size, SocketFlags.None,
                              new AsyncCallback(ReceiveData), client);
            }
            catch (SocketException)
            {
                txtInfo.Text = "Error connecting";
            }
        }

        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            txtInfo.Text = stringData;
        }

        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, size, SocketFlags.None,
                          new AsyncCallback(ReceiveData), remote);
        }

        public void LimitCheckedListBoxMaxSelection(CheckedListBox list, int max)
        {
            list.ItemCheck += (o, args) =>
            {
                if (lstAreaSelect.CheckedItems.Count == max)
                {
                    if (!lstAreaSelect.GetItemChecked(lstAreaSelect.SelectedIndex))
                        (args as ItemCheckEventArgs).NewValue = (args as ItemCheckEventArgs).CurrentValue;
                }
            };

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            LimitCheckedListBoxMaxSelection(lstAreaSelect, 5);

        }

    }
}