using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPTest.Views;
using MVPTest.Presenters;

namespace MVPTest
{
    public partial class Form1 : Form, IRectangle
    {
        string IRectangle.heightText
        {
            get
            {
                return heightText.Text;
            }

            set
            {
               heightText.Text = value;
            }
        }
        string IRectangle.widthText
        {
            get
            {
                return widthText.Text;
            }

            set
            {
                widthText.Text = value;
            }
        }
        public string areaText
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }

    }
}
