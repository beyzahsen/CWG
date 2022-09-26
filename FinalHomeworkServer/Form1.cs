using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FinalHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptConn), server);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Connected";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Disconnected";
        }

        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            Socket client = oldserver.EndAccept(iar);
            txtInfo.Text = "Connected to: " + client.RemoteEndPoint.ToString();
            string stringData = "Welcome to the game!";
            byte[] message1 = Encoding.ASCII.GetBytes(stringData);
            client.BeginSend(message1, 0, message1.Length, SocketFlags.None,
                        new AsyncCallback(SendData), client);
        }

        void SendData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
            client.BeginReceive(data, 0, size, SocketFlags.None,
                        new AsyncCallback(ReceiveData), client);
        }

        void ReceiveData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int recv = client.EndReceive(iar);
            if (recv == 0)
            {
                client.Close();
                txtInfo.Text = "Waiting for player...";
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
                return;
            }
            string receivedData = Encoding.ASCII.GetString(data, 0, recv);
            txtInfo.Text = receivedData;
            byte[] message2 = Encoding.ASCII.GetBytes(receivedData);
            client.BeginSend(message2, 0, message2.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }
        public void LimitCheckedListBoxMaxSelection(CheckedListBox checkedLB, int maxCount)
        {
            checkedLB.ItemCheck += (o, args) =>
            {

                if (lstAreaSelect.CheckedItems.Count == maxCount)
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