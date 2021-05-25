
namespace Poo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_title = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lv_restaurantes = new System.Windows.Forms.ListView();
            this.ch_nome = new System.Windows.Forms.ColumnHeader();
            this.ch_cnpj = new System.Windows.Forms.ColumnHeader();
            this.ch_cidade = new System.Windows.Forms.ColumnHeader();
            this.ch_endereco = new System.Windows.Forms.ColumnHeader();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lb_cardapio = new System.Windows.Forms.Label();
            this.lv_cardapios = new System.Windows.Forms.ListView();
            this.ch_nomeprato = new System.Windows.Forms.ColumnHeader();
            this.ch_descricao = new System.Windows.Forms.ColumnHeader();
            this.ch_valor = new System.Windows.Forms.ColumnHeader();
            this.ch_restaurante = new System.Windows.Forms.ColumnHeader();
            this.lb_nomeprato = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.tb_nomeprato = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.bt_adicionarprato = new System.Windows.Forms.Button();
            this.bt_removerprato = new System.Windows.Forms.Button();
            this.lb_cadastropratos = new System.Windows.Forms.Label();
            this.tb_nrestaurante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_title
            // 
            this.tb_title.AutoSize = true;
            this.tb_title.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_title.Location = new System.Drawing.Point(12, 9);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(249, 16);
            this.tb_title.TabIndex = 0;
            this.tb_title.Text = "Informações sobre o estabelecimento:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(12, 55);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(43, 15);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Location = new System.Drawing.Point(12, 87);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(78, 15);
            this.lb_cnpj.TabIndex = 2;
            this.lb_cnpj.Text = "Identificação:";
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Location = new System.Drawing.Point(12, 146);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(59, 15);
            this.lb_endereco.TabIndex = 3;
            this.lb_endereco.Text = "Endereço:";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(12, 118);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(47, 15);
            this.lb_cidade.TabIndex = 4;
            this.lb_cidade.Text = "Cidade:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(88, 142);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(100, 23);
            this.tb_endereco.TabIndex = 5;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(88, 113);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(100, 23);
            this.tb_cidade.TabIndex = 6;
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(88, 84);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(100, 23);
            this.tb_cnpj.TabIndex = 7;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(88, 55);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 23);
            this.tb_nome.TabIndex = 8;
            // 
            // lv_restaurantes
            // 
            this.lv_restaurantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nome,
            this.ch_cnpj,
            this.ch_cidade,
            this.ch_endereco});
            this.lv_restaurantes.FullRowSelect = true;
            this.lv_restaurantes.HideSelection = false;
            this.lv_restaurantes.Location = new System.Drawing.Point(275, 12);
            this.lv_restaurantes.Name = "lv_restaurantes";
            this.lv_restaurantes.Size = new System.Drawing.Size(582, 153);
            this.lv_restaurantes.TabIndex = 9;
            this.lv_restaurantes.UseCompatibleStateImageBehavior = false;
            this.lv_restaurantes.View = System.Windows.Forms.View.Details;
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 150;
            // 
            // ch_cnpj
            // 
            this.ch_cnpj.Text = "CNPJ";
            this.ch_cnpj.Width = 100;
            // 
            // ch_cidade
            // 
            this.ch_cidade.Text = "Cidade";
            this.ch_cidade.Width = 110;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "Endereço";
            this.ch_endereco.Width = 200;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(194, 83);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 10;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(194, 113);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(75, 23);
            this.bt_remover.TabIndex = 11;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // lb_cardapio
            // 
            this.lb_cardapio.AutoSize = true;
            this.lb_cardapio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cardapio.Location = new System.Drawing.Point(12, 237);
            this.lb_cardapio.Name = "lb_cardapio";
            this.lb_cardapio.Size = new System.Drawing.Size(150, 15);
            this.lb_cardapio.TabIndex = 12;
            this.lb_cardapio.Text = "Nome do estabelecimento:";
            // 
            // lv_cardapios
            // 
            this.lv_cardapios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nomeprato,
            this.ch_descricao,
            this.ch_valor,
            this.ch_restaurante});
            this.lv_cardapios.FullRowSelect = true;
            this.lv_cardapios.HideSelection = false;
            this.lv_cardapios.Location = new System.Drawing.Point(277, 207);
            this.lv_cardapios.Name = "lv_cardapios";
            this.lv_cardapios.Size = new System.Drawing.Size(580, 195);
            this.lv_cardapios.TabIndex = 14;
            this.lv_cardapios.UseCompatibleStateImageBehavior = false;
            this.lv_cardapios.View = System.Windows.Forms.View.Details;
            // 
            // ch_nomeprato
            // 
            this.ch_nomeprato.Text = "Nome";
            this.ch_nomeprato.Width = 130;
            // 
            // ch_descricao
            // 
            this.ch_descricao.Text = "Descrição";
            this.ch_descricao.Width = 200;
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
            this.ch_valor.Width = 90;
            // 
            // ch_restaurante
            // 
            this.ch_restaurante.Text = "Restaurante";
            this.ch_restaurante.Width = 100;
            // 
            // lb_nomeprato
            // 
            this.lb_nomeprato.AutoSize = true;
            this.lb_nomeprato.Location = new System.Drawing.Point(119, 266);
            this.lb_nomeprato.Name = "lb_nomeprato";
            this.lb_nomeprato.Size = new System.Drawing.Size(43, 15);
            this.lb_nomeprato.TabIndex = 16;
            this.lb_nomeprato.Text = "Nome:";
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Location = new System.Drawing.Point(101, 292);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(61, 15);
            this.lb_descricao.TabIndex = 17;
            this.lb_descricao.Text = "Descrição:";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(126, 324);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(36, 15);
            this.lb_valor.TabIndex = 18;
            this.lb_valor.Text = "Valor:";
            // 
            // tb_nomeprato
            // 
            this.tb_nomeprato.Location = new System.Drawing.Point(168, 263);
            this.tb_nomeprato.Name = "tb_nomeprato";
            this.tb_nomeprato.Size = new System.Drawing.Size(103, 23);
            this.tb_nomeprato.TabIndex = 19;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(168, 292);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(103, 23);
            this.tb_descricao.TabIndex = 20;
            this.tb_descricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(168, 321);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(103, 23);
            this.tb_valor.TabIndex = 21;
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valor_KeyPress);
            // 
            // bt_adicionarprato
            // 
            this.bt_adicionarprato.Location = new System.Drawing.Point(168, 350);
            this.bt_adicionarprato.Name = "bt_adicionarprato";
            this.bt_adicionarprato.Size = new System.Drawing.Size(101, 23);
            this.bt_adicionarprato.TabIndex = 22;
            this.bt_adicionarprato.Text = "Adicionar";
            this.bt_adicionarprato.UseVisualStyleBackColor = true;
            this.bt_adicionarprato.Click += new System.EventHandler(this.bt_adicionarprato_Click);
            // 
            // bt_removerprato
            // 
            this.bt_removerprato.Location = new System.Drawing.Point(168, 379);
            this.bt_removerprato.Name = "bt_removerprato";
            this.bt_removerprato.Size = new System.Drawing.Size(101, 23);
            this.bt_removerprato.TabIndex = 23;
            this.bt_removerprato.Text = "Remover";
            this.bt_removerprato.UseVisualStyleBackColor = true;
            this.bt_removerprato.Click += new System.EventHandler(this.bt_removerprato_Click);
            // 
            // lb_cadastropratos
            // 
            this.lb_cadastropratos.AutoSize = true;
            this.lb_cadastropratos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cadastropratos.Location = new System.Drawing.Point(21, 207);
            this.lb_cadastropratos.Name = "lb_cadastropratos";
            this.lb_cadastropratos.Size = new System.Drawing.Size(130, 16);
            this.lb_cadastropratos.TabIndex = 24;
            this.lb_cadastropratos.Text = "Cadastro de pratos:";
            // 
            // tb_nrestaurante
            // 
            this.tb_nrestaurante.Location = new System.Drawing.Point(168, 234);
            this.tb_nrestaurante.Name = "tb_nrestaurante";
            this.tb_nrestaurante.Size = new System.Drawing.Size(103, 23);
            this.tb_nrestaurante.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.tb_nrestaurante);
            this.Controls.Add(this.lb_cadastropratos);
            this.Controls.Add(this.bt_removerprato);
            this.Controls.Add(this.bt_adicionarprato);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_nomeprato);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_descricao);
            this.Controls.Add(this.lb_nomeprato);
            this.Controls.Add(this.lv_cardapios);
            this.Controls.Add(this.lb_cardapio);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.lv_restaurantes);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.lb_cnpj);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_title);
            this.Name = "Form2";
            this.Text = "Doraive turu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_title;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ListView lv_restaurantes;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_cnpj;
        private System.Windows.Forms.ColumnHeader ch_cidade;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label lb_cardapio;
        private System.Windows.Forms.ListView lv_cardapios;
        private System.Windows.Forms.Label lb_nomeprato;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox tb_nomeprato;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button bt_adicionarprato;
        private System.Windows.Forms.Button bt_removerprato;
        private System.Windows.Forms.ColumnHeader ch_nomeprato;
        private System.Windows.Forms.ColumnHeader ch_descricao;
        private System.Windows.Forms.ColumnHeader ch_valor;
        private System.Windows.Forms.ColumnHeader ch_restaurante;
        private System.Windows.Forms.Label lb_cadastropratos;
        private System.Windows.Forms.TextBox tb_nrestaurante;
    }
}