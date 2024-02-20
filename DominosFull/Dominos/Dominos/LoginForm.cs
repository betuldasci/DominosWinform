using Dominos.Entity;
using Dominos.Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominos
{
    public partial class LoginForm : Form
    {
        DataContext db = new DataContext();
        public string personelName;
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void enterBtn_Click(object sender, EventArgs e)
        {
            var personel = db.Personel.Where(x=>x.Name==nameTxt.Text).FirstOrDefault();
            personelName = nameTxt.Text;

            if (personel != null)
            {
                OrderForm orderForm = new OrderForm(personel);
                orderForm.personelLabel(nameTxt.Text);
                orderForm.ShowDialog();
            }
            
            
        }
    }
}
