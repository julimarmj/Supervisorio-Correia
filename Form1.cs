using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervisório___Correia
{
    public partial class Form1 : Form
    {
        OPC Opc = new OPC();

        public delegate void OPC_Monitor();
        BackgroundWorker Monitor;
        BackgroundWorker ThUpdate;
        public Form1()
        {
            InitializeComponent();
            Monitor = new BackgroundWorker();
            Monitor.DoWork += OpcMonitor;
            Monitor.RunWorkerAsync();

            ThUpdate = new BackgroundWorker();
            ThUpdate.DoWork += Update;
            ThUpdate.RunWorkerAsync();
        }

        private void btTeste_Click(object sender, EventArgs e)
        {
            Opc.Start = bool.Parse(tbTeste1.Text);
            pbSF1.Image = Properties.Resources.OFF;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            tbTeste1.Text = Opc.Start.ToString();
        }
        private void OpcMonitor(object sender, DoWorkEventArgs e)
        {
            Delegate read = new OPC_Monitor(Opc.ReadBlock);
            Delegate write = new OPC_Monitor(Opc.WriteBlock);

            while (true)
            {
                try
                {
                    this.Invoke(read);
                    Thread.Sleep(200);
                    this.Invoke(write);
                }
                catch (Exception)
                {
                }
            }
        }
        private void Update(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                //System.Drawing.Graphics formGraphics;
                //formGraphics = this.CreateGraphics();
                //formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
                //formGraphics.FillRectangle(myBrush, new Rectangle(200, 200, 200, 300));
                //myBrush.Dispose();
                //formGraphics.Dispose();
                

                try
                {
                    this.Invoke(new MethodInvoker(() => this.tbTeste2.Text = Opc.Start.ToString()));
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
