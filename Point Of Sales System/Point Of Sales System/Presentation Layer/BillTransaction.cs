using Point_Of_Sales_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales_System.Presentation_Layer
{
    public partial class BillTransaction : Form
    {
        List<Cart> cartlist = new List<Cart>();
        public BillTransaction()
        {
            InitializeComponent();
            UpdateCartList();
            TotalAmountTextBox.ReadOnly = true;
            ChangeAmountTextBox.ReadOnly = true;
            //AddProductButton.Visible = false;
        }
        public void UpdateProductList()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            ProductDataListGridView.DataSource = productDataAccess.GetAllProducts();
        }
        private void UpdateCartList()
        {
            CartDataAccess cartDataAccess = new CartDataAccess();
            CartItemsDataGridView.DataSource = cartDataAccess.GetAllCartItems();
        }
        private void BillTransaction_Load(object sender, EventArgs e)
        {
            CartDataAccess cartDataAccess = new CartDataAccess();
            bool ok = cartDataAccess.RemoveAllItems();
            CartItemsDataGridView.DataSource = null;
            UpdateProductList();
        }

        private void BillTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            CartDataAccess cartDataAccess = new CartDataAccess();
            ProductDataAccess productDataAccess = new ProductDataAccess();
            Product product = productDataAccess.GetProduct(Convert.ToInt32(SearchProductIdTextBox.Text));
            if(product == null)
            {
                MessageBox.Show("Product ID and amount cannot be left empty");
            }
            if(cartDataAccess.AddNewIem(product.ProductId, product.ProductName, product.Price,Convert.ToDouble(ProductAmountTextBox.Text), Convert.ToDouble(ProductAmountTextBox.Text) * product.Price))
            {
                MessageBox.Show("Item added to cart");
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
            UpdateCartList();
            CartDataAccess cda = new CartDataAccess();
            List<Cart> list = cda.GetAllCartItems();
            double tot = 0.0;
            foreach(Cart cart in list)
            {
                tot += cart.TotalPrice;
            }
            TotalAmountTextBox.Text = tot.ToString();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CartDataAccess cartDataAccess = new CartDataAccess();
            if (cartDataAccess.RemoveAllItems())
            {
                MessageBox.Show("Items Cleared");
            }
            else MessageBox.Show("Error in clearing");
            CartItemsDataGridView.DataSource = null;
            TotalAmountTextBox.Text = "";
            PaidAmountTextBox.Text = "";
            ChangeAmountTextBox.Text = "";
        }

        // Clear Button 
        private void button1_Click(object sender, EventArgs e)
        {
            SearchProductIdTextBox.Text = "";
            ProductAmountTextBox.Text = "";
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (PaidAmountTextBox.Text == null)
            {
                MessageBox.Show("Paid amount field cannot be empty");
            }
            double chng = -Convert.ToInt32(TotalAmountTextBox.Text) + Convert.ToInt32(PaidAmountTextBox.Text);
            ChangeAmountTextBox.Text = chng.ToString();
        }
        void ADDBILL()
        {
            SaveBillDataAccess saveBillDataAccess = new SaveBillDataAccess();
            if(!saveBillDataAccess.AddNewBill(Convert.ToDouble(TotalAmountTextBox.Text), Convert.ToDouble(PaidAmountTextBox.Text), Convert.ToDouble(ChangeAmountTextBox.Text)))
            {
                MessageBox.Show("Error in saving bill");
            }
        }
        private void OkayButton_Click(object sender, EventArgs e)
        {
            ADDBILL();
            SearchProductIdTextBox.Text = "";
            ProductAmountTextBox.Text = "";
            TotalAmountTextBox.Text = "";
            ChangeAmountTextBox.Text = "";
            PaidAmountTextBox.Text = "";
            CartDataAccess cartDataAccess = new CartDataAccess();
            bool ok = cartDataAccess.RemoveAllItems();
            CartItemsDataGridView.DataSource = null;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalespersonNavigationPanel snp = new SalespersonNavigationPanel();
            snp.Show();
        }
    }
}


//void AddToCart()
//{
//    ProductDataAccess productDataAccess = new ProductDataAccess();
//    Product product = new Product();
//    product = productDataAccess.GetProduct(Convert.ToInt32(SearchProductIdTextBox.Text));
//    Cart cart = new Cart();
//    cart.ProductId = product.ProductId;
//    cart.ProductName = product.ProductName;
//    cart.Amount = Convert.ToDouble(ProductAmountTextBox.Text);
//    cart.TotalPrice = cart.Amount * product.Price;
//    cartlist.Add(cart);
//    TotalAmountTextBox.Text = cart.TotalPrice.ToString();
//    UpdateCartList();
//}