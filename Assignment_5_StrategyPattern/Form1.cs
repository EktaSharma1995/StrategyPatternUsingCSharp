using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;
                string name = textBoxName.Text;
                string phoneNumber = textBoxPhone.Text;


                Context ctxNumeric = new Context(new NumericValidation());

                if (ctxNumeric.executeStrategy(id))
                {
                    lblNumericStatus.Text = "Numeric validation approved";
                }
                else
                {
                    lblNumericStatus.Text = "Numeric validation failed";
                }

                Context ctxAlphanumeric = new Context(new AlphanumericValidation());

                if (ctxAlphanumeric.executeStrategy(name))
                {
                    lblAlphanumericStatus.Text = "Alphanumeric validation approved";
                }
                else
                {
                    lblAlphanumericStatus.Text = "Alphanumeric validation failed";
                }

                Context ctxTelephonic = new Context(new TelephonicValidation());

                if (ctxTelephonic.executeStrategy(phoneNumber))
                {
                    lblTelephonicStatus.Text = "Telephonic validation approved";
                }
                else
                {
                    lblTelephonicStatus.Text = "Telephonic validation failed";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
