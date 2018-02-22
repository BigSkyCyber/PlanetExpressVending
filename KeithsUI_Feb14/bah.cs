using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyLib;
namespace VendingMachine
{
    public partial class VendingMachinefrm : Form
    {
        public Display display = new Display();

        private void VendingMachinefrm_Load(object sender, EventArgs e)
        {
            
            display.MoneyAdded += new Display.MoneyAddedHandler(DisplayMoney);
        }

        private void DisplayMoney(decimal money)
        {
            //txtAmountInserted.Text = money.ToString();
        }
    }
}
