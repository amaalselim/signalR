using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.AspNet.SignalR.Client;  

namespace ChatAppD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IHubProxy _proxy;
        private void Form1_Load(object sender, EventArgs e)
        {
            HubConnection con= new HubConnection("https://localhost:44394/");
            _proxy= con.CreateHubProxy("ChatHub");
            con.Start();

            _proxy.On<data>("NewMessage",(m)=>lb_message.Invoke(new Action(() => lb_message.Items.Add(m.Sender + ":" + m.Content))));
            _proxy.On<string,string>("NewMember",(n,g)=> lb_message.Invoke(new Action(() => lb_message.Items.Add(n + " joinned " + g))));
            _proxy.On<string,string,string>("groupmsg",(n,g,m)=> lb_message.Invoke(new Action(() => lb_message.Items.Add(n + " in " + g + " : " + m))));    


        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("SendMessage",new data() {Sender=txt_name.Text,Content=text_message.Text});
        }
    }
}
