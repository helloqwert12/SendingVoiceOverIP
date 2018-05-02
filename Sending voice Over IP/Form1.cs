using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sending_voice_Over_IP
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        string Get_privateIP()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry hostentery = Dns.GetHostEntry(hostname);
            IPAddress[] ip = hostentery.AddressList;
            return ip[ip.Length - 1].ToString();
            
        }

        Voice v = new Voice();
        private void frm_Load(object sender, EventArgs e)
        {

            v.Receive(2000);
        }

        private void snd_btn(object sender, EventArgs e)
        {
            String ip = Get_privateIP();
            button1.Text = ip.ToString();
            v.Send("127.0.0.1", 2000);
        }


    }
}
