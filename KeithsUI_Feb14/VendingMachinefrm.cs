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
using System.Data.OleDb;

namespace VendingMachine
{
    public partial class VendingMachinefrm : Form
    {

        public static Display display = new Display();
        DollarBill dollar = new DollarBill();
        Penny penny = new Penny();
        VendingMachine Vending = new VendingMachine();
        string selectedId;


        public VendingMachinefrm()
        {
            InitializeComponent();
        }

        private void VendingMachinefrm_Load(object sender, EventArgs e)
        {
            display.MoneyAdded += new Display.MoneyAddedHandler(displayMoney);
        }

        private void displayMoney(decimal money)
        {
            txtAmountInserted.Text = money.ToString("c");
        }

        private void btnDollarBill_Click(object sender, EventArgs e)
        {
            Vending.InputMoney(penny);
        }



        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Coke");
        }

        private void btnCrush_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Crush");
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Fanta");
        }

        private void btnPotLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("PotLays");
        }

        private void btnSourLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("SourLays");
        }

        private void btnChaletLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("ChaletLays");
        }

        private void GiveCostumerProduct(string id)
        {
            Product userProduct = new Product();
            OleDbParameter productBrand = new OleDbParameter("ProductBrand", id);
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\2018\\Repository\\KeithsUI_Feb14\\VendingMachineDb.accdb");
            OleDbCommand getProductById = new OleDbCommand("SELECT Product.ProductId, Product.ProductBrand, Product.DateSold, Products.ProductCost" +
                                                           "FROM Products INNER JOIN Product ON Products.ProductsId = Product.ProductBrand" +
                                                           "WHERE product.ProductBrand = ?");
            getProductById.Parameters.Add(productBrand);

            try
            {
                connection.Open();
                OleDbDataReader reader =
                    getProductById.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    
                }
            }
            catch
            {
                
            }
        }
    }
}
