using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listMovies1.Visible = false;
        }

        private void choice1_Load(object sender, EventArgs e)
        {
            choice1.choiceClick += Choice1_choiceClick;
        }

        private void Choice1_choiceClick(bool btn)
        {
            if (btn == true)
            {
                listMovies1.Visible = false;
                choice1.Visible = true;
            }
            else
            {
                choice1.Visible = false;
                listMovies1.Visible = true;
            }
        }
    }
}
