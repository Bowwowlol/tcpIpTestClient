using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace tcpIpTestClient
{
    public partial class Form1 : Form
    {
        Socket SckSPort; // 先行宣告Socket

        string RmIp = "127.0.0.1";  // 其中 xxx.xxx.xxx.xxx 為Server端的IP
        Thread SckSReceiveTd = null;
        int SPort = 888;
        bool connectContinue = true;
        int RDataLen = 640*480;  // 此文Server端和Client端都是用固定長度5在傳送資料~ 可以針對自己的需要改長度 
        Form2 fm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            textBox_IPaddress.Text = RmIp;
            textBoxPort.Text = SPort.ToString();
        }

        // 連線
        private void ConnectServer()

        {
            //我在這邊家東西測試github.
            try

            {

                SckSPort = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                SckSPort.Connect(new IPEndPoint(IPAddress.Parse(RmIp), SPort));

                // RmIp和SPort分別為string和int型態, 前者為Server端的IP, 後者為Server端的Port



                // 同 Server 端一樣要另外開一個執行緒用來等待接收來自 Server 端傳來的資料, 與Server概念同

                SckSReceiveTd = new Thread(SckSReceiveProc);

                SckSReceiveTd.Start();
                if(SckSPort.Connected)
                {
                    listBox_Info.Items.Add("Connected!!");
                    listBox_Info.Items.Add("The server IP address is " + RmIp + " and port is " + SPort);

                }
                //SckSReceiveTd.IsBackground = true;
            }
            catch { }

        }

        // SckSReceiveProc 是接受來自 Server 端的資料其函式內容幾乎同 Server 端的 SckSAcceptProc 接收資料的Code~  ,  只差在 Client 只有一個Socket. 



        private void SckSReceiveProc()
        {

            try
            {

                long IntAcceptData;

                byte[] clientData = new byte[RDataLen];

                while (connectContinue)
                {

                    // 程式會被 hand 在此, 等待接收來自 Server 端傳來的資料

                    IntAcceptData = SckSPort.Receive(clientData);

                    // 往下就自己寫接收到來自Server端的資料後要做什麼事唄~^^”

                    //string S = Encoding.Default.GetString(clientData);
                    try
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(clientData);

                        ms.Write(clientData, 0, clientData.Length);

                        Bitmap b = (Bitmap)Bitmap.FromStream(ms);
                       // Bitmap b = new Bitmap((Image)new Bitmap(ms));
                        //PictureBox px = fm2.GetForm2PictureBox();
                        //px.Image = b;
                        //fm2.ShowDialog();
                        pictureBox1.Image = b;
                        ms.Dispose();
                        //SckSSend();
                        ms.Close();
                        //Thread.Sleep(1);
                        //Console.WriteLine(S);
                    }
                    catch (ArgumentException aee)
                    {
                        
                    }
                 
                    

                }

            }

            catch
            {



            }
        }


        // 當然 Client 端也可以傳送資料給Server端~ 和 Server 端的SckSSend一樣, 只差在Client端只有一個Socket

        private void SckSSend()

        {



            try

            {

                string SendS = "Get image!";

                SckSPort.Send(Encoding.ASCII.GetBytes(SendS));

            }

            catch

            {



            }





        }
        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectServer();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {

                    if (SckSPort.Connected == true)
                    {
                        connectContinue = false;
                        //SckSPort.Shutdown(SocketShutdown.Both);
                        SckSPort.Close();
                        SckSReceiveTd.Abort();
                        listBox_Info.Items.Add("disconnect!\n");
                    }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SckSSend();
        }

        private void textBox_IPaddress_TextChanged(object sender, EventArgs e)
        {
            RmIp = textBox_IPaddress.Text;
            
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            SPort = Convert.ToInt32(textBoxPort.Text);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (SckSPort != null && SckSPort.Connected == true)
            {
                connectContinue = false;
                SckSPort.Shutdown(SocketShutdown.Both);
                SckSPort.Close();
                SckSReceiveTd.Abort();
            }
        }
    }
}
