using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("IP Address", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Hostname", 200);
            listView1.FullRowSelect = true;
        }

        private async void scanBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label7.Text = "";

            if (!IPAddress.TryParse(firstSearchBox.Text, out IPAddress startIP))
            {
                MessageBox.Show("The starting IP is invalid!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IPAddress.TryParse(secondSearchBox.Text, out IPAddress endIP))
            {
                MessageBox.Show("End IP is invalid!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uint start = IpToUInt(startIP);
            uint end = IpToUInt(endIP);

            if (start > end)
            {
                MessageBox.Show("The start IP cannot be greater than the end IP!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            scanBtn.Enabled = false;
            progressBar1.Visible = true;
            label5.Visible = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)(end - start + 1);
            progressBar1.Value = 0;

            int bosIpSayisi = 0;
            int count = 0;

            for (uint i = start; i <= end; i++)
            {
                string ip = UIntToIp(i);
                bool cevapVerdi = false;
                string hostname = "Linux";

                try
                {
                    using (Ping ping = new Ping())
                    {
                        PingReply reply = await ping.SendPingAsync(ip, 200);
                        cevapVerdi = reply.Status == IPStatus.Success;
                    }

                    if (cevapVerdi)
                    {
                        try
                        {
                            IPHostEntry hostEntry = await Dns.GetHostEntryAsync(ip);
                            hostname = hostEntry.HostName;
                        }
                        catch { hostname = "Linux"; }
                    }
                }
                catch { cevapVerdi = false; }

                listView1.Invoke(new Action(() =>
                {
                    ListViewItem item = new ListViewItem(ip);

                    if (cevapVerdi)
                    {
                        item.SubItems.Add("is being used");
                        item.SubItems.Add(hostname);
                        item.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        item.SubItems.Add("available");
                        item.SubItems.Add("-");
                        item.ForeColor = System.Drawing.Color.Red;
                        bosIpSayisi++;
                    }

                    listView1.Items.Add(item);

                    count++;
                    progressBar1.Value = count;
                    label5.Text = $"%{(count * 100) / (end - start + 1)} scanned";
                    label7.Text = $"Available IP address: {bosIpSayisi}";
                }));
            }

            scanBtn.Enabled = true;
            exportBtn.Enabled = true;
            MessageBox.Show("Scan finished!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private uint IpToUInt(IPAddress ip)
        {
            byte[] bytes = ip.GetAddressBytes();
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        private string UIntToIp(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return new IPAddress(bytes).ToString();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("List is empty! There is nothing to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string baseFileName = "IP_Scan_Result.txt";
                string filePath = System.IO.Path.Combine(desktopPath, baseFileName);

                int counter = 1;
                while (System.IO.File.Exists(filePath))
                {
                    string newFileName = $"IP_Scan_Result({counter}).txt";
                    filePath = System.IO.Path.Combine(desktopPath, newFileName);
                    counter++;
                }

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                {
                    writer.WriteLine("IP Address\tStatus\tHostname");

                    foreach (ListViewItem item in listView1.Items)
                    {
                        string line = $"{item.SubItems[0].Text}\t{item.SubItems[1].Text}\t{item.SubItems[2].Text}";
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show($"Data exported successfully to {filePath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
