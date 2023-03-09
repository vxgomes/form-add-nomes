using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_add_nomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(textBoxNomes.TextLength == 0)
                MessageBox.Show("Por favor digite algo!", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxNomes.Focus();
            {
                comboBoxNomes.Items.Add(textBoxNomes.Text);
                textBoxNomes.Clear();
                textBoxNomes.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)//
        {
           comboBoxNomes.SelectedIndex = 0;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if(comboBoxNomes.SelectedIndex == 0)
                MessageBox.Show("Por favor digite algo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                comboBoxNomes.Items.Remove(comboBoxNomes.SelectedItem);
                comboBoxNomes.SelectedIndex = 0;
            }
        }
    }
}
