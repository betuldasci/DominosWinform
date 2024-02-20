using Dominos.Controller;
using Dominos.Entity;
using Dominos.Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominos
{
    public partial class OrderForm : Form
    {
        Dominos.Entity.PizzaSize size = new Dominos.Entity.PizzaSize();
        double totalPrice = 0;
        DataGridView orderDgv;
        private PizzaSize selectedSize;
        int xStart = 100;
        int yStart = 100;
        ProductCrud productCrud = new ProductCrud();    
        DataContext db = new DataContext();
        public List<Product> products = new List<Product>();
        Personel _personel;
        Product selectedProduct;

        public OrderForm(Personel personel)
        {
            _personel = personel;
            InitializeComponent();
        }



        public void personelLabel(string name)
        {
            PersonelLbl.Text = $"Personel: {name}";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dateLbl.Text = "Tarih: " + DateTime.Now.ToShortDateString();
            
            PizzaPnl.AutoScroll = true;

            InitializeDataGridView();


        }

        public void InitializeDataGridView()
        {
            orderDgv = new DataGridView();
            orderDgv.Name = "orderDgv";
            orderDgv.Location = new Point(12, 154);
            orderDgv.Size = new Size(300, 700);


            orderDgv.Columns.Add("Product Name", "Product Name");
            orderDgv.Columns.Add("Product Size", "Product Size");

            panel3.Controls.Add(orderDgv);
        }

        public void ButtonCreate(Panel panel, string title, double price)
        {
            if (xStart < 800)
            {
                Button button = new Button();
                button.Text = $"{title} / {price} TL";
                button.Size = new System.Drawing.Size(200, 100);
                button.Location = new System.Drawing.Point(xStart, yStart);
                button.BackColor = Color.DarkBlue;
                button.ForeColor = Color.White;
                panel.Controls.Add(button);
                xStart += 220;

                button.Click += (sender, e) =>
                {
                    string[] productInfo = button.Text.Split('/');
                    string productName = productInfo[0].Trim();
                    double productPrice = double.Parse(productInfo[1].Trim().Split(' ')[0]);

                    selectedProduct = productCrud.GetByName(productName);
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Ürün bulunamadı veya hatalı.");
                        return;
                    }
                    products.Add(selectedProduct);

                    orderDgv.Rows.Add(productName, selectedSize != null ? selectedSize.Name : "Standard");
                    totalPrice += price;
                    TotalPriceLbl.Text = totalPrice.ToString() + "₺";
                };
            }
            else
            {
                yStart += 150;
                xStart = 100;
                Button button = new Button();
                button.Text = $"{title} / {price} TL";
                button.Size = new System.Drawing.Size(200, 100);
                button.Location = new System.Drawing.Point(xStart, yStart);
                button.BackColor = Color.DarkBlue;
                button.ForeColor = Color.White;
                panel.Controls.Add(button);
                xStart += 220;

                button.Click += (sender, e) =>
                {
                    string[] productInfo = button.Text.Split('/');
                    string productName = productInfo[0].Trim();
                    double productPrice = double.Parse(productInfo[1].Trim().Split(' ')[0]);

                    selectedProduct = productCrud.GetByName(productName);
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Ürün bulunamadı veya hatalı.");
                        return;
                    }
                    products.Add(selectedProduct);
                    totalPrice += price;
                    TotalPriceLbl.Text = totalPrice.ToString() + "₺";
                    orderDgv.Rows.Add(productName);
            

                };
            }
        }


        private void PizzaBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pizzaLbl.Text = "Pizza";
            yStart = 100;
            xStart = 100;
            PizzaPnl.Controls.Clear();
            int xs = 400;
            int xy = 10;
            var sizeList = db.PizzaSize.ToList();
            SizePnl.Visible = true;
           
                
            

            foreach (var item in sizeList)
            {
                Button sizeButton = new Button();
                sizeButton.Text = item.Name;
                sizeButton.Location = new Point(xs, xy);
                sizeButton.Size = new Size(100,70);
                sizeButton.BackColor = Color.DarkBlue;
                sizeButton.ForeColor = Color.White;
                xs += 100;
                sizeButton.Click += SizeButton_Click;
                SizePnl.Controls.Add(sizeButton);


            }
       
        
            
        }

        private void SizeButton_Click(object sender, EventArgs e)
        {
            yStart = 50;
            xStart = 50;
            var sizeButton = (Button)sender;
            selectedSize = db.PizzaSize.FirstOrDefault(x => x.Name == sizeButton.Text);

            PizzaPnl.Controls.Clear();

            var list = productCrud.GetByCategory("Pizza");

            foreach (var item in list)
            {
                Button button = new Button();
                button.Text = $"{item.Name} / {item.Price + selectedSize.PriceChange} TL";
                button.Size = new System.Drawing.Size(200, 100);
                button.Location = new Point(xStart, yStart);
                button.BackColor = Color.DarkBlue;
                button.ForeColor = Color.White;

                button.Tag = new Product { Name = item.Name, Price = item.Price + selectedSize.PriceChange };
               
                button.Click += PizzaButton_Click; 

                PizzaPnl.Controls.Add(button);
                xStart += 220;
                yStart += (xStart > 800) ? 150 : 0; 
                xStart = (xStart > 800) ? 100 : xStart; 
            }
        }
        private void PizzaButton_Click(object sender, EventArgs e)
        {
            var pizzaButton = (Button)sender;
            var product = (Product)pizzaButton.Tag;

            orderDgv.Rows.Add(selectedSize.Name, product.Name);
            totalPrice += product.Price;
            TotalPriceLbl.Text = totalPrice.ToString() + "₺";

            selectedProduct = productCrud.GetByName(product.Name);
            if (selectedProduct == null)
            {
                MessageBox.Show("Ürün bulunamadı veya hatalı.");
                return;
            }
            products.Add(selectedProduct);

        }
        private void ByProductsBtn_Click(object sender, EventArgs e)
        {
            yStart = 40;
            xStart = 40;
            PizzaPnl.Controls.Clear();
            SizePnl.Visible = false;
            panel1.Visible = false;
            pizzaLbl.Text = "By Products";
            var list = productCrud.GetByCategory("ByProducts");

            foreach ( var product in list )
            {
                ButtonCreate(PizzaPnl, product.Name, product.Price);
                             
            }
          

        }

        private void beverageBtn_Click(object sender, EventArgs e)
        {
            yStart = 40;
            xStart = 40;
            PizzaPnl.Controls.Clear();
            SizePnl.Visible = false;
            panel1.Visible = false;
            pizzaLbl.Text = "Beverages";
            var list = productCrud.GetByCategory("Beverage");

            foreach (var product in list)
            {
                ButtonCreate(PizzaPnl, product.Name, product.Price);
                 

            }
        }

        private void sauceBtn_Click(object sender, EventArgs e)
        {
            yStart = 40;
            xStart = 40;
            PizzaPnl.Controls.Clear();
            SizePnl.Visible = false;
            panel1.Visible = false;
            pizzaLbl.Text = "Sauces";
            var list = productCrud.GetByCategory("Sauces");

            foreach (var product in list)
            {
                ButtonCreate(PizzaPnl, product.Name, product.Price);
                
            }
        }
  
        private void campaignBtn_Click(object sender, EventArgs e)
        {
            yStart = 40;
            xStart = 40;
            PizzaPnl.Controls.Clear();
            SizePnl.Visible = false;
            panel1.Visible = false;
            var list = db.Campaign.ToList();

            foreach (var item in list)
            {
                ButtonCreate(PizzaPnl, item.Name, item.Price);
            }
        }

        private void dessertBtn_Click(object sender, EventArgs e)
        {
            yStart = 40;
            xStart = 40;
            PizzaPnl.Controls.Clear();
            SizePnl.Visible = false;
            panel1.Visible = false;
            pizzaLbl.Text = "Desserts";
            var list = productCrud.GetByCategory("Desserts");

            foreach (var product in list)
            {
                ButtonCreate(PizzaPnl, product.Name, product.Price);
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();

            if (products.Count > 0)
            {
                Order newOrder = new Order
                {
                    Name = "Sipariş",
                    CreateTime = DateTime.Now,
                    TotalPrice = totalPrice,
                    PersonelId = _personel.Id,
                    IsStatus = true,
                    IsDelete = false,

                };

                db.Order.Add(newOrder);

                try
                {
                    db.SaveChanges(); 
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Error updating the database: {ex.Message}");
                    return;
                }

                List<OrderProduct> orderProducts = new List<OrderProduct>();

                foreach (var product in products)
                {
                    OrderProduct orderProduct = new OrderProduct();
                    if (product.CategoryId == 1)
                    {
                        orderProduct.OrderId = newOrder.Id;
                        orderProduct.ProductId = product.Id;
                        orderProduct.Quantity = 1;

                        if (selectedSize != null)
                        {
                            orderProduct.SizeId = selectedSize.Id;
                        }
                        else
                        {
                            orderProduct.SizeId = 1;
                        }
                    }
                    else if (product.CategoryId == 2 || product.CategoryId == 3 || product.CategoryId == 4 || product.CategoryId == 5 || product.CategoryId == 9)
                    {
                        orderProduct.OrderId = newOrder.Id;
                        orderProduct.ProductId = product.Id;
                        orderProduct.Quantity = 1;
                        orderProduct.SizeId = 5;
                    }

                    orderProducts.Add(orderProduct);
                }

                db.OrderProduct.AddRange(orderProducts);


                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Error updating the database: {ex.Message}");
                    return;
                }


                orderProducts.Clear();

                products.Clear();

                orderDgv.DataSource = null;
                orderDgv.Refresh();

                totalPrice = 0;
                TotalPriceLbl.Text = "₺0";

                MessageBox.Show("Siparişiniz başarıyla alındı!");
            }
            else
            {
                MessageBox.Show("Sipariş içeriği boş!");
            }
        }

      
    }
}

