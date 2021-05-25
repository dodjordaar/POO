using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Poo
{
    public partial class Form2 : Form
    {
        List<Restaurante> restaurantes;
        List<Cardápio> cardápios;
        public Form2()
        {
            InitializeComponent();
            restaurantes = new List<Restaurante>();
            cardápios = new List<Cardápio>();
        }

        private void erase()
        {
            tb_nome.Clear();
            tb_cnpj.Clear();
            tb_cidade.Clear();
            tb_endereco.Clear();
        }
        private void erase2()
        {
            tb_nomeprato.Clear();
            tb_descricao.Clear();
            tb_valor.Clear();
            tb_nrestaurante.Clear();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("O campo nome está vazio.");
                tb_nome.Focus();
                return;
            }
            else if (tb_cnpj.Text == "")
            {
                MessageBox.Show("O campo identificação está vazio.");
                tb_cnpj.Focus();
                return;
            }
            else if (tb_cidade.Text == "")
            {
                MessageBox.Show("O campo cidade está vazio.");
                tb_cidade.Focus();
                return;
            }
            else if (tb_endereco.Text == "")
            {
                MessageBox.Show("O campo endereço está vazio.");
                tb_endereco.Focus();
                return;
            }
            //else if (tb_nome.Text != "")
            {
                //tb_cardapios.Items.Add(tb_nome.Text);
            }

            string[] rcadastro = new string[4];
            rcadastro[0] = tb_nome.Text;
            rcadastro[1] = tb_cnpj.Text;
            rcadastro[2] = tb_cidade.Text;
            rcadastro[3] = tb_endereco.Text;

            ListViewItem r = new ListViewItem(rcadastro);
            lv_restaurantes.Items.Add(r);
            erase();
            atrestaurante();
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            lv_restaurantes.Items.RemoveAt(lv_restaurantes.SelectedIndices[0]);
        }

        private void atrestaurante()
        {
           // foreach(Restaurante r in restaurantes)
            {
                //cb_cardapios.Items.Add($"{r.nome} {r.cnpj} {r.cidade} {r.endereco}");
            }
        }

        private void atcardapios()
        {
            foreach(Cardápio c in cardápios)
            {
                ListViewItem item = new ListViewItem(c.nome);
                item.SubItems.Add(c.descricao);
                item.SubItems.Add(c.valor.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_removerprato_Click(object sender, EventArgs e)
        {
            lv_cardapios.Items.RemoveAt(lv_cardapios.SelectedIndices[0]);
        }
        private void bt_adicionarprato_Click(object sender, EventArgs e)
        {
            //if(tb_nomeprato.Text != "" &&
            // tb_descricao.Text != "" &&
            //tb_valor.Text != "")
            //Restaurante r = restaurantes[cb_cardapios.SelectedIndex];
            //restaurantes.Add(r);
            //Cardápio c = new Cardápio(tb_nomeprato.Text, tb_descricao.Text, (int)float.Parse(tb_valor.Text));
            //r.cardápios.Add(c);
            //tb_nomeprato.Text = "";
            //tb_descricao.Text = "";
            //tb_valor.Text = "";
            //atcardapios();
            string[] cadastrop = new string[4];
            cadastrop[0] = tb_nomeprato.Text;
            cadastrop[1] = tb_descricao.Text;
            cadastrop[2] = tb_valor.Text;
            cadastrop[3] = tb_nrestaurante.Text;
            ListViewItem r = new ListViewItem(cadastrop);
            lv_cardapios.Items.Add(r);
            erase2();
            atcardapios();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {}

        private void tb_valor_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void cb_cardapios_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
