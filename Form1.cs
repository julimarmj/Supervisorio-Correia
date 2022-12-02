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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        OPC Opc = new OPC();
        public delegate void OPC_Monitor();
        BackgroundWorker Monitor;
        BackgroundWorker ThUpdate;
        bool SecClock;
        bool closed = false;

        public event ValueUpdated ValueStart;

        public Form1()
        {  
            InitializeComponent();
            log.Info("Programa Iniciado");

            Monitor = new BackgroundWorker();
            Monitor.DoWork += OpcMonitor;
            Monitor.RunWorkerAsync();

            ThUpdate = new BackgroundWorker();
            ThUpdate.DoWork += Update;
            ThUpdate.RunWorkerAsync();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 sec
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            
        }
        ~Form1() 
        {
            
        }

        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            SecClock = !SecClock;
        }
        private void btOn_Click(object sender, EventArgs e)
        {
            Opc.Start = true;
            Opc.WriteBlock();
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            Opc.Start = false;
            Opc.WriteBlock();
        }
        private void btRearm_Click(object sender, EventArgs e)
        {
            Opc.Reset = true;
            Opc.WriteBlock();
        }
        private void btEmer_Click(object sender, EventArgs e)
        {
            Opc.Emergency = true;
        }
        private void OpcMonitor(object sender, DoWorkEventArgs e)
        {
            Delegate read = new OPC_Monitor(Opc.ReadBlock);
            Delegate write = new OPC_Monitor(Opc.WriteBlock);
            Thread.Sleep(200);

            while (!closed)
            {
                try
                {
                    this.Invoke(read);
                    Thread.Sleep(200);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha na leitura");
                }
            }
        }
        private void Update(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
            while (!closed)
            {

                if (Opc.Busy && SecClock)
                {
                    this.Invoke(new MethodInvoker(() => pbBusy1.Visible = true));
                    this.Invoke(new MethodInvoker(() => pbBusy2.Visible = true));
                    this.Invoke(new MethodInvoker(() => pbBusy3.Visible = true));
                }
                else
                {
                    this.Invoke(new MethodInvoker(() => pbBusy1.Visible = false));
                    this.Invoke(new MethodInvoker(() => pbBusy2.Visible = false));
                    this.Invoke(new MethodInvoker(() => pbBusy3.Visible = false));
                }

                if (Opc.Start)
                    this.Invoke(new MethodInvoker(() => pbMotor.Image = Properties.Resources.ON));
                else
                    this.Invoke(new MethodInvoker(() => pbMotor.Image = Properties.Resources.OFF));

                if (Opc.Transparent)
                    this.Invoke(new MethodInvoker(() => pbSC.Image = Properties.Resources.ON));
                else
                    this.Invoke(new MethodInvoker(() => pbSC.Image = Properties.Resources.OFF));

                if (Opc.Opaque)
                {
                    this.Invoke(new MethodInvoker(() => pbSF1.Image = Properties.Resources.ON));
                    this.Invoke(new MethodInvoker(() => pbSF2.Image = Properties.Resources.ON));
                }
                else
                {
                    this.Invoke(new MethodInvoker(() => pbSF1.Image = Properties.Resources.OFF));
                    this.Invoke(new MethodInvoker(() => pbSF2.Image = Properties.Resources.OFF));
                }

                if (Opc.Error)
                {
                    this.Invoke(new MethodInvoker(() => lbDef.Visible = true));
                    if (SecClock)    
                        this.Invoke(new MethodInvoker(() => lbDef.ForeColor = System.Drawing.Color.Black));
                    else
                        this.Invoke(new MethodInvoker(() => lbDef.ForeColor = System.Drawing.Color.Red)); 
                }
                else
                    this.Invoke(new MethodInvoker(() => lbDef.Visible = false));

                this.Invoke(new MethodInvoker(() => lbTransp.Text = Opc.Number_Transparent.ToString()));
                this.Invoke(new MethodInvoker(() => lbOpac.Text = Opc.Number_Opaque.ToString()));

            }
        }

        private void on_closing(object sender, FormClosingEventArgs e)
        {
            closed = true;
            var result = MessageBox.Show("Deseja sair?", "sair",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);

            if (result == DialogResult.No)
            {
                closed = true;

            }else if(result == DialogResult.Yes)
                log.Info("Programa Finalizado");

        }
    }
}
