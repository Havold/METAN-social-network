using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPchat;
using ZXing;
using static System.Net.Mime.MediaTypeNames;

namespace Instagram
{
    public partial class ChatBox : Form
    {
        
        public void setUser(string userSend, string userRecv)
        {
            txtTenTK.Text = userSend;
            txtTenTK2.Text = userRecv;
        }
        private int y = 1;
        public ChatBox()
        {
            InitializeComponent();
        }
        Modify Modify = new Modify();
        private static Socket client;
        private static byte[] data = new byte[1024];

        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }

        void Connected(IAsyncResult iar)
        {
            try
            {
                client.EndConnect(iar);
                Thread receiver = new Thread(new ThreadStart(ReceiveData));
                receiver.Start();
            }
            catch (SocketException)
            {
            }
        }
        List<showChat> userControlList = new List<showChat>();

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == String.Empty || newText.Text == String.Empty)
            {
                MessageBox.Show("Nhap chua day du thong tin");
            }
            string input = newText.Text;
            string TenTK = txtTenTK.Text;
            string TenTK2 = txtTenTK2.Text;
            string path = "select * from Taikhoan where TenTk ='" + TenTK + "'";
            string combinedData = $"{TenTK}:{input}";
            byte[] message = Encoding.UTF8.GetBytes(combinedData);
            newText.Clear();
            client.BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client);
        }
        void ReceiveData()
        {
            try
            {
                int recv;
                string stringData;
                while (true)
                {
                    recv = client.Receive(data);
                    stringData = Encoding.UTF8.GetString(data, 0, recv);
                    if (stringData == "bye")
                        break;
                    this.Invoke((MethodInvoker)delegate
                    {
                        showChat newShowChat = new showChat();
                        string[] parts = stringData.Split(':');
                        string TenTK = parts[0];
                        string input = parts[1];
                        string path = "select * from ACCOUNT where USERNAME ='" + TenTK + "'";
                        bool isCurrentClient = (TenTK == txtTenTK.Text);
                        if (isCurrentClient)
                        {
                            newShowChat.SetFontSize(input, Modify.Taikhoans(path)[0].Avatar, TenTK);
                        }
                        else
                        {
                            newShowChat.SetText(input, Modify.Taikhoans(path)[0].Avatar, TenTK);
                        }

                        userControlList.Add(newShowChat);
                        results.Controls.Add(newShowChat);
                        newShowChat.Location = new System.Drawing.Point(0, y);
                        y = y + 40;
                        try
                        {
                            SaveInDataUpdate(TenTK, txtTenTK2.Text, input, Modify.Taikhoans(path)[0].Avatar);
                        }
                        catch
                        {
                            Se_SaveInDataUpdate(TenTK, txtTenTK2.Text, input, Modify.Taikhoans(path)[0].Avatar);
                        }
                    });
                }
                stringData = "bye";
                byte[] message = Encoding.UTF8.GetBytes(stringData);
                client.Send(message);
                client.Close();
                return;
            }
            catch (Exception ex) { }
        }
        private void SaveInDataUpdate(string Tentk, string Tentk2, string input, string image)
        {
            string add = "INSERT INTO Messed (Classify, Text) VALUES ('" + Tentk + "-" + Tentk2 + "', '" + Tentk + "-" + input + "-" + image + "');";
            string add1 = "INSERT INTO Messed (Classify, Text) VALUES ('" + Tentk2 + "-" + Tentk + "', '" + Tentk + "-" + input + "-" + image + "');";
            Modify.command(add);
            Modify.command(add1);
        }
        private void Se_SaveInDataUpdate(string Tentk, string Tentk2, string input, string image)
        {
            string add = "Update Messed set Text = Text + '-" + Tentk + "-" + input + "-" + image + "' where Classify = '" + Tentk + "-" + Tentk2 + "'";
            string add1 = "Update Messed set Text = Text + '-" + Tentk + "-" + input + "-" + image + "' where Classify = '" + Tentk2 + "-" + Tentk + "'";
            Modify.command(add);
            Modify.command(add1);
        }
        private void loadHistory()
        {
            string TenTK = txtTenTK.Text;
            string TenTK2 = txtTenTK2.Text;
            string cmd = "select * from Messed where Classify = '" + TenTK + "-" + TenTK2 + "'";
            try
            {
                string Mess = Modify.Messeds(cmd)[0].Text;
                string[] parts = Mess.Split('-');
                for (int i = 0; i < parts.Length; i = i + 3)
                {
                    showChat newShowChat = new showChat();
                    if (parts[i] == TenTK)
                    {
                        newShowChat.SetFontSize(parts[i + 1].ToString(), parts[i + 2].ToString(), parts[i].ToString());
                    }
                    else
                    {
                        newShowChat.SetText(parts[i + 1].ToString(), parts[i + 2].ToString(), parts[i].ToString());
                    }
                    userControlList.Add(newShowChat);
                    results.Controls.Add(newShowChat);
                    newShowChat.Location = new System.Drawing.Point(0, y);
                    y = y + 40;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void ChatBox_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            client.BeginConnect(iep, new AsyncCallback(Connected), client);
            loadHistory();
        }
    }
}
