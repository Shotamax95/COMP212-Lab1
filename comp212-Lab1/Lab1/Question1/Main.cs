using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Main : Form
    {
        public static int[] intArray = { 1, 30, 5, 78, 99, 111, 13, 55, 22, 104, 325, 12, 8 };


        public static List<Student> students = new List<Student>
        {
                //new Student("Shota", "Ito", 301),
                //new Student("Jason", "Derulo", 302),
                //new Student("Justin", "Bb", 303),
        };

        private BindingSource bSource;

        public Main()
        {
            InitializeComponent();

            foreach (var T in intArray)
            {
                arrayList.Items.Add(T);
            }

            bSource = new BindingSource();
            bSource.DataSource = students;
            dataGridView1.DataSource = bSource;
        }


        private void search_Click(object sender, EventArgs e)
        {
            // Array of Number
            if(radioButtonInt.Checked)
            {
                int searchItem = Convert.ToInt32(searchNum.Text);
                int result = Search.Searching(intArray, searchItem);
                if (result == 1)
                {
                    //MessageBox.Show($"The index location is {Search.position}");
                    txtResult.Text = ($"The index location is {Search.position}");

                }
                else
                {
                    //MessageBox.Show($"{searchItem} is not found");
                    txtResult.Text = ($"{searchItem} is not found");
                }
            }

            // Array of Student Object
            if(radioButtonStudent.Checked)
            {

                int searchItem = Convert.ToInt32(searchNum.Text);
                Student student = new Student(searchItem);
                int result = Search.Searching(students, student);

                if (result == 1)
                {
                    //MessageBox.Show($"The Student location is index : {Search.position}");
                    txtResult.Text = ($"The Student location is index : {Search.position}");

                }
                else
                {
                    //MessageBox.Show($"{searchItem} is not found");
                    txtResult.Text = ($"{searchItem} is not found");
                }
            }
        }

        // Add object data from user input
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            bSource.Add(new Student(txtFirst.Text, txtLast.Text, Convert.ToInt32(txtStudent.Text)));
            
        }
    }
}
