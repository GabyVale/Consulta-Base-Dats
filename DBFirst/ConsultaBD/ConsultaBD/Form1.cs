using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaBD
{
    public partial class Form1 : Form
    {
        string id;
        public Form1()
        {
            InitializeComponent();
        }

        DbOps.CustomerOps cliente = new DbOps.CustomerOps();

        private void button5_Click(object sender, EventArgs e)
        {
            
            cliente.GetCustomers();
            dtView1.DataSource = cliente.GetCustomers();
            
        }

        private void button2_Click(object sender, EventArgs e) //Buscar
        {
            id = txtDato.Text;
           // dtView1.DataSource = cliente.GetCustomerById(id);
            List<Customer> listaCustomers = new List<Customer>();
            listaCustomers.Add(cliente.GetCustomerById(id));
            dtView1.DataSource = listaCustomers;
        }
        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Customer nuevoCustomer = new Customer();
            nuevoCustomer.CustomerID = txtIdCustomer.Text;
            nuevoCustomer.CompanyName = txtCompanyName.Text;
            nuevoCustomer.ContactName = txtNombreContact.Text;
            nuevoCustomer.ContactTitle = txtTituloContact.Text;
            nuevoCustomer.Address = txtAddress.Text;
            nuevoCustomer.City = txtCity.Text;
            nuevoCustomer.Region = "NULL";
            nuevoCustomer.PostalCode = txtPostalCode.Text;            
            nuevoCustomer.Country = txtCountry.Text;
            nuevoCustomer.Phone = txtPhone.Text;
            nuevoCustomer.Fax = txtFax.Text;
            cliente.AgregarCustomer(nuevoCustomer);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nameCompany;
            id = txtDato.Text;
            nameCompany = txtCompaniModifi.Text;
            DbOps.CustomerOps nuevoCliente = new DbOps.CustomerOps();
            nuevoCliente.UpdateCustomerCompanyName(id, nameCompany);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DbOps.CustomerOps cliente = new DbOps.CustomerOps();
            id = txtDato.Text;
            cliente.DeleteCustomer(id);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
