using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATV05_190922
{
    public partial class ATV05 : Form
    {
        public ATV05()
        {
            InitializeComponent();
        }

        public void Limpar(Control con)
        {
            foreach (Control caixa in con.Controls)
            {
                if(caixa is TextBox)
                {
                    ((TextBox)caixa).Clear();
                }
                else
                {
                    Limpar(caixa);
                }

                txtCod.Focus();
                picBox.Image = null;
            }
        }
        
        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName !="")
            {
                picBox.Load(openFileDialog1.FileName);
            }
            else
            {
                picBox.Image = null;
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnFoto.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCod.Text, txtNome.Text, picBox.Image);
            this.Limpar(this);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(0, txtCod.Text, txtNome.Text, picBox.Image);
            this.Limpar(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpar(this);
            dataGridView1.Rows.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Linha = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int reg = dataGridView1.RowCount;
            if(Linha == 0)
            {
                MessageBox.Show("A T E N Ç Ã O Selecione um item para excluir !!",
                                "*** EXCLUIR ITEM ***",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Asterisk);
            }
            else if(reg != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
