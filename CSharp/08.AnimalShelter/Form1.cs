using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _08.AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);

            Customers.Add(cus);
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

            CusPetInfo.Text = "";
            foreach (Cat cat in cus.MyCats)
                CusPetInfo.Text = cat.Name + ":" + cat.MakeSound() + Environment.NewLine;
            foreach (Dog dog in cus.MyDogs)
                CusPetInfo.Text = dog.Name + ":" + dog.MakeSound() + Environment.NewLine;
        }

        // private void CustomerList_Click(object sender, EventArgs e)
        // {
        //     string firstName = CustomerList.SelectedItem.ToString();
        //
        //     foreach (Customer cus in Customers)
        //     {
        //         if (cus.FirstName == firstName)
        //         {
        //             ShowDetails(cus);
        //             break;
        //         }
        //     }
        //     for (int i = 0; i < CustomerArrayIndex; i++)
        //     {
        //         if (CustomerArray[i].FirstName == firstName)
        //         {
        //             ShowDetails(CustomerArray[i]);
        //             break;
        //         }
        //     }
        // }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;


            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
            CusDetailPanel.Show();
            CusNewPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "na", new DateTime(1990, 1, 2));
            Cat cat = new Cat(1, "송이", "Black", "Female");
            cus.Adopt(cat);
            Cat cat2 = new Cat(3, "설이", "Black", "Female");
            cus.Adopt(cat2);
            
            Dog dog = new Dog(2, "아찌", "white", "Male", DogBreed.Mixed );
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }
    }
}
