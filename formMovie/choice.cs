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
    public partial class choice : UserControl
    {
        public choice()
        {
            InitializeComponent();
        }
        public delegate void DelegateChoiceClick(bool btn);
        public event DelegateChoiceClick choiceClick;

        private void choices_click(object sender, EventArgs e)
        {
            if (choiceClick != null)
            {
                if (((Button)sender).Text == "Add Movie")
                {
                    choiceClick(true);
                }
                else
                {
                    choiceClick(false);
                }
            }
        }
    }
}
