
using Events1.Librery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_UI
{
    public partial class Form1 : Form
    {
        public delegate void PrintDelegate(string str);

        public Form1()
        {

            StudentManager.FiveStudentAdded += PrintMessegeBox;
            Student.TooLongNameEvent += PrintByMessegeBox;
            Student.LuckyNumberEvent += PrintByMessegeBox;
            InitializeComponent();

            BindingSource bs = new BindingSource();
            bs.DataSource =  StudentManager.GetList();
            gridStudents.DataSource = bs;
        }

        private void PrintMessegeBox()
        {
            MessageBox.Show("You Get 5% Discount!");
        }

 
        public static void PrintByMessegeBox(string str)
        {
            MessageBox.Show(str);
        }

        public static void PrintByMessegeBox(object ob , TooLongNameEventArgs e)
        {
            MessageBox.Show(e.Messege);
        }

        public static void PrintByMessegeBox(object ob, LuckyNumberEventArgs e)
        {      
            MessageBox.Show(e.Messege);
        }


        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
            Student student = new Student() { Number = txtNumber.Text };
           
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            StudentManager.Add(new Student() { FirstName = txtAddStudent.Text, Number = txtNumber.Text });
            BindingSource bs = new BindingSource();
            bs.DataSource = StudentManager.GetList();
            gridStudents.DataSource = bs;
            
        }

        
    }
}