using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

// ICStation ICSE012A ICSE013A ICSE014A Tester - v1.01 26/8/2017 - © 2017 fabio.rossetti@gmail.com
// .net test program form icstation serial relay board model ICSE012A ICSE013A ICSE014A

namespace TestRelay
{
    public partial class frmIcStationRelay : Form
    {
        private SerialPort port;
         
        public frmIcStationRelay()
        {
            InitializeComponent();
        }
        private const int PORT_DELAY=500; //serial delay, I'm polling the serial port, could use the event support but it's unreliable
        private SerialPort initcom()
        {
            return new SerialPort(cbSerialPorts.Text, 9600, Parity.None, 8, StopBits.One); //recommended settings
             
            
        }


        private void btnInit_Click(object sender, EventArgs e)
        { 

            byte[] commandcode = new byte[] { (byte)'\x51' }; //put the board in operative mode
            byte[]  result = sendserial(commandcode); //should be nothing
            
            txtOutput.Text += "Sent Hex Code 51 to setup board."   + Environment.NewLine;
        }

 

   

        private void btnDeinit_Click(object sender, EventArgs e)
        {
             
             
            byte[] commandcode = new byte[] { (byte)'\x50' }; //ask board id, works only when first plugged and before the init command
           
            byte[] boardid   = sendserial(commandcode);  
            

            txtOutput.Text += "Sent Hex Code 50 (Request board id) : ";
            if (boardid.Length == 0 )
            {
                txtOutput.Text += "Received no response - try unplugging the board." + Environment.NewLine; //board has already been used
                
                return;
            }
            
            switch (boardid[0])
            {
                // one has to read individual bytes and not strings, otherwhise the .net encoding stuff will convert these codes to a '?' hex 3F
                case (byte)'\xAD':
                    txtOutput.Text += "Received code Hex AD - ICSE013A 2 relay model" + Environment.NewLine;
                    break;
                // untested with real hardware  
                case (byte)'\xAB':
                    txtOutput.Text += "Received code Hex AB - ICSE012A 4 relay model" + Environment.NewLine;
                    break;
                case (byte)'\xAC':
                    txtOutput.Text += "Received code Hex AC - ICSE014A 8 relay model" + Environment.NewLine;
                    break;
                default:
                    txtOutput.Text += "Received unkwnon code Hex" + String.Format("{0:X2}", Convert.ToInt32(boardid[0] ))   + Environment.NewLine;;
                    break;

            }
        }

   

        private void btnLoadSerialPorts_Click(object sender, EventArgs e)
        {
            setupserialportscombobox();
        }

        private void setupserialportscombobox()
        {
            cbSerialPorts.Items.Clear();
            // Get a list of serial port names.
            string[] serialports = SerialPort.GetPortNames(); 

            // Put into combobox
            foreach (string serialport in serialports)
            {
                cbSerialPorts.Items.Add(serialport);
            }

            if (cbSerialPorts.Items.Count >= 1) cbSerialPorts.SelectedIndex = 0;

        }

        private void frmIcStationRelay_Load(object sender, EventArgs e)
        {
            setupserialportscombobox();
        }

        private void btnSendRelays_Click(object sender, EventArgs e)
        {
            byte command = 0;
            //setup individual bits
            command += (byte)(cbRelay1.Checked ? 1 : 0);
            command += (byte)(cbRelay2.Checked ? 2 : 0);
            command += (byte)(cbRelay3.Checked ? 4 : 0);
            command += (byte)(cbRelay4.Checked ? 8 : 0);
            command += (byte)(cbRelay5.Checked ? 16 : 0);
            command += (byte)(cbRelay6.Checked ? 32 : 0);
            command += (byte)(cbRelay7.Checked ? 64 : 0);


            byte[] commandcode = new byte[] {  command };  
            
            byte[] result = sendserial(commandcode); //should be nothing
           
            txtOutput.Text += "Sent relay switch command Hex " + String.Format("{0:X2}", Convert.ToInt32(command))   + Environment.NewLine;
        }

        //marshal winforms data for background worker
        private struct bwarg
        {
            public string porta;
            public int frequenza;
        };

        private void btnAlterna_Click(object sender, EventArgs e)
        {

            //todo: check for possible conflicts with other buttons opening the serial port
            bwarg bwargument;
            bwargument.porta = cbSerialPorts.Text;
            bwargument.frequenza = (int) udFreq.Value;
            if (bwAlterna.IsBusy != true)
            {
                bwAlterna.RunWorkerAsync(bwargument);
            }

  
        }

        private void btnStopAlternate_Click(object sender, EventArgs e)
        {
            bwAlterna.CancelAsync();
        }


        byte[] sendserial(byte[] command)
        {
            try
            {
                port = initcom();
                port.Open();
                port.Write(command, 0, 1);
                System.Threading.Thread.Sleep(PORT_DELAY);


                byte[] buffer = new byte[port.ReadBufferSize];

                int bytesRead = 0;
                if (port.BytesToRead > 0) bytesRead = port.Read(buffer, 0, buffer.Length);
                

                 port.Close();
                if (bytesRead == 0)
                {
                    return new Byte[] {};
                }
                else
                {
                    return buffer.Skip(0).Take(bytesRead).ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
                return new Byte[] {};
            }
        }
        private void bwAlterna_DoWork(object sender, DoWorkEventArgs e)
        {

            //set all possible states of a 2 relay board continuously until the thread is stopped
            BackgroundWorker bw = (BackgroundWorker) sender;

            port = new SerialPort(((bwarg)(e.Argument)).porta, 9600, Parity.None, 8, StopBits.One); 
            port.Open();
            for (;;)
            {
                port.Write(new byte[] { 1 }, 0, 1);
                System.Threading.Thread.Sleep(((bwarg)(e.Argument)).frequenza);
                Application.DoEvents();
                port.Write(new byte[] { 2 }, 0, 1);
                System.Threading.Thread.Sleep(((bwarg)(e.Argument)).frequenza);
                port.Write(new byte[] { 3 }, 0, 1);
                System.Threading.Thread.Sleep(((bwarg)(e.Argument)).frequenza);
                Application.DoEvents();
                port.Write(new byte[] { 0 }, 0, 1);
                System.Threading.Thread.Sleep(((bwarg) (e.Argument)).frequenza);

                if ((bwAlterna.CancellationPending == true))
                {
                    port.Close();
                    e.Cancel = true;
                    break;
                }

            }
            port.Close();
        }

        
    }
}
