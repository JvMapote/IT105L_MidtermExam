using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPOTE_JAYVEE_IT105L_C11
{
    public partial class Form2 : Form
    {
        int count = 0;
        double salary;
        Warehouse1[] warehouse1 = new Warehouse1[1]; 
        Employee1[] employee1 = new Employee1[4];
        Itemslist[] itemslist = new Itemslist[4];
        public Form2()
        {
            InitializeComponent();
        }

        public void getname() 
        {
          
            Resultname.Text = ($"{warehouse1[0].property1}");
            

        }

        public void GetfullLocation() 
        {
            ResultLocation.Text = ($"{warehouse1[0].property4} {warehouse1[0].property2} {warehouse1[0].property3}");
        }

        public void gethourlyrate() 
        {
            
            for (int i = 0; i < 4; i++)
            {
                salary = Convert.ToDouble(employee1[i].property4) * 8 * 6;

                listBox1.Items.Add("Hourly Rate: " + employee1[i].property4);
            }

        }
        public void getsalary() 
        {
            for (int i = 0; i < 4; i++)
            {
                salary = Convert.ToDouble(employee1[i].property4) * 8 * 6;

                listBox1.Items.Add("Salary: " + salary);
            }
        }

        public void getbrandname() 
        {
            listBox1.Items.Add(itemslist[0].property1 + " " + itemslist[0].property2);
            listBox1.Items.Add(itemslist[1].property1 + " " + itemslist[1].property2);
            listBox1.Items.Add(itemslist[2].property1 + " " + itemslist[2].property2);
            listBox1.Items.Add(itemslist[3].property1 + " " + itemslist[3].property2);
        }
        

        public void getfullname() 
        {
            
            listBox1.Items.Clear();


             for (int i = 0; i < 4; i++)
             {
                listBox1.Items.Add("Fullname: " + employee1[i].property1 + " " + employee1[i].property2);
                
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            warehouse1[0] = new Warehouse1(namebox.Text, CityBox.Text, ProvinceBox.Text, BuildingNumberBox.Text);
            
            getname();
            GetfullLocation();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 0) 
            {
                double hr = Convert.ToDouble(drbox1.Text) / 8;
                employee1[0] = new Employee1(fnbox1.Text, lnbox1.Text, idbox1.Text, Convert.ToString(hr));
                count++;
                MessageBox.Show("Input submitted");
            }
            else if (count == 1)
            {
                double hr = Convert.ToDouble(drbox1.Text) / 8;
                double salary = Convert.ToDouble(drbox1.Text) * 6;
                employee1[1] = new Employee1(fnbox1.Text, lnbox1.Text, idbox1.Text, Convert.ToString(hr));
                count++;
                MessageBox.Show("Input submitted");
            }
            else if (count == 2) 
            {
                double hr = Convert.ToDouble(drbox1.Text) / 8;
                double salary = Convert.ToDouble(drbox1.Text) * 6;
                employee1[2] = new Employee1(fnbox1.Text, lnbox1.Text, idbox1.Text, Convert.ToString(hr));
                count++;
                MessageBox.Show("Input submitted");
            }
            else if (count == 3) 
            {
                double hr = Convert.ToDouble(drbox1.Text) / 8;
                double salary = Convert.ToDouble(drbox1.Text) * 6;
                employee1[3] = new Employee1(fnbox1.Text, lnbox1.Text, idbox1.Text, Convert.ToString(hr));
                count++;
                getfullname();
                gethourlyrate();
                getsalary();
                getbrandname();

            }
            
            



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            itemslist[0] = new Itemslist("Nestle","Orangejuice","01","10");
            itemslist[1] = new Itemslist("Delmonte", "ketchup", "02", "50");
            itemslist[2] = new Itemslist("Nestle", "bananajuice", "03", "15");
            itemslist[3] = new Itemslist("Delmonte", "banana ketchup", "04", "60");
        }
    }
}
