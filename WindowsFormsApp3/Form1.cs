using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "Mercedes",
            //    "Ferrari",
            //    "Chevrolet"
            //};
            //listBox1.DataSource = cars;
            // listBox1.SelectedIndex = 2;


            //List<Car> cars = new List<Car>
            //{
            //    new Car
            //    {
            //        Name="Mercedes"
            //    },
            //    new Car
            //    {
            //        Name="Ferrari"
            //    },
            //    new Car
            //    {
            //        Name="Chevrolet"
            //    },
            //    new Car
            //    {
            //        Name="Cadillac"
            //    },
            //};
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            //listBox1.DataSource = cars;
            //    listBox1.DisplayMember = "Id";



            //listBox1.Items.Add(new Car
            //{
            //    Name = "Mercedes"
            //});
            //listBox1.Items.Add(new Car
            //{
            //    Name = "Ferrari"
            //});


            listBox1.Items.Add(new Meal
            {
                Name = "Kabab",
                Price = 12
            });
            listBox1.Items.Add(new Meal
            {
                Name = "Salad",
                Price = 5
            });
            listBox1.Items.Add(new Meal
            {
                Name = "Tendirde Quzu",
                Price = 300
            });

            //listBox2.DisplayMember = "Name";




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var item = (listBox1.SelectedValue as string);
            //var item = (listBox1.SelectedValue as Car);
            //label1.Text = item?.Name;

            var obj = listBox1.SelectedItem;
            label1.Text = (obj as Meal)?.Name;
            try
            {

            listBox1.Items.Remove(obj);
            listBox2.Items.Add(obj);
            listBox1.SelectedItem = null;

            }
            catch (Exception)
            {
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //List<string> fruits = new List<string>
            //{
            //    "Apple",
            //    "Mango",
            //    "Magnolia",
            //    "PineApple"
            //};
            //listBox1.DataSource = fruits;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in listBox1.SelectedItems)
            {
                var car = item as Car;
                stringBuilder.Append($"{car.Name}\n");
            }

            label1.Text = stringBuilder.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            listBox1.DisplayMember = textBox1.Text;
            //listBox1.Items.Add(
            //    new Car
            //    {
            //        Name = textBox1.Text
            //    }
            //    );
        }
    }
}
