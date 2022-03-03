using GG.PlugInTabanliHesapMakinesi.Contracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GG.PlugInTabanliHesapMakinesi.WinUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // PlugInStarter plug-inlerimizi ilgili application domain'de instance'larını üretip bize geriye dönüyor.
            List<ICalculationCommand> cmdList = PlugInStarter.PlugInStarter.Start();
            lstCommands.Items.AddRange(cmdList.ToArray());
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedItem != null)
            {
                var cmd = lstCommands.SelectedItem as ICalculationCommand;
                var arg1 = Convert.ToDouble(txtSayi1.Text);
                var arg2 = Convert.ToDouble(txtSayi2.Text);
                var result = cmd.Execute(arg1, arg2);

                MessageBox.Show(string.Format("Sonuç: {0}", result));
            }
        }
    }
}
