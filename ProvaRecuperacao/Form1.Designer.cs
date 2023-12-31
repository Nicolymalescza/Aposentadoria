﻿namespace ProvaRecuperacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_dtnascimento = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_InicioProfissao = new System.Windows.Forms.Label();
            this.lb_profissao = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cb_profissao = new System.Windows.Forms.ComboBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_verificar = new System.Windows.Forms.Button();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.tx_tempoCont = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(48, 61);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(54, 20);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(321, 133);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(45, 20);
            this.lb_sexo.TabIndex = 1;
            this.lb_sexo.Text = "Sexo";
            // 
            // lb_dtnascimento
            // 
            this.lb_dtnascimento.AutoSize = true;
            this.lb_dtnascimento.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtnascimento.Location = new System.Drawing.Point(321, 63);
            this.lb_dtnascimento.Name = "lb_dtnascimento";
            this.lb_dtnascimento.Size = new System.Drawing.Size(50, 20);
            this.lb_dtnascimento.TabIndex = 2;
            this.lb_dtnascimento.Text = "Idade";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(48, 133);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(36, 20);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "CPF";
            // 
            // lb_InicioProfissao
            // 
            this.lb_InicioProfissao.AutoSize = true;
            this.lb_InicioProfissao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InicioProfissao.Location = new System.Drawing.Point(48, 279);
            this.lb_InicioProfissao.Name = "lb_InicioProfissao";
            this.lb_InicioProfissao.Size = new System.Drawing.Size(232, 20);
            this.lb_InicioProfissao.TabIndex = 4;
            this.lb_InicioProfissao.Text = "Anos de exercício da profissão";
            // 
            // lb_profissao
            // 
            this.lb_profissao.AutoSize = true;
            this.lb_profissao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_profissao.Location = new System.Drawing.Point(48, 214);
            this.lb_profissao.Name = "lb_profissao";
            this.lb_profissao.Size = new System.Drawing.Size(75, 20);
            this.lb_profissao.TabIndex = 5;
            this.lb_profissao.Text = "Profissão";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(127, 63);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 20);
            this.tx_nome.TabIndex = 6;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(127, 133);
            this.mask_cpf.Mask = "000.000.000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 7;
            this.mask_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_profissao
            // 
            this.cb_profissao.FormattingEnabled = true;
            this.cb_profissao.Items.AddRange(new object[] {
            "Professor",
            "Agentes de Segurança",
            "Saúde",
            "Demais serviços"});
            this.cb_profissao.Location = new System.Drawing.Point(171, 214);
            this.cb_profissao.Name = "cb_profissao";
            this.cb_profissao.Size = new System.Drawing.Size(121, 21);
            this.cb_profissao.TabIndex = 9;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(418, 133);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 10;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(152, 395);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(98, 35);
            this.bt_cancelar.TabIndex = 12;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_verificar
            // 
            this.bt_verificar.Location = new System.Drawing.Point(418, 395);
            this.bt_verificar.Name = "bt_verificar";
            this.bt_verificar.Size = new System.Drawing.Size(98, 35);
            this.bt_verificar.TabIndex = 13;
            this.bt_verificar.Text = "Verificar";
            this.bt_verificar.UseVisualStyleBackColor = true;
            this.bt_verificar.Click += new System.EventHandler(this.bt_verificar_Click);
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(418, 63);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(100, 20);
            this.tx_idade.TabIndex = 14;
            // 
            // tx_tempoCont
            // 
            this.tx_tempoCont.Location = new System.Drawing.Point(302, 281);
            this.tx_tempoCont.Name = "tx_tempoCont";
            this.tx_tempoCont.Size = new System.Drawing.Size(100, 20);
            this.tx_tempoCont.TabIndex = 15;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.Location = new System.Drawing.Point(48, 346);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 20);
            this.lb_result.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 462);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.tx_tempoCont);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.bt_verificar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.cb_profissao);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lb_profissao);
            this.Controls.Add(this.lb_InicioProfissao);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_dtnascimento);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_dtnascimento;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_InicioProfissao;
        private System.Windows.Forms.Label lb_profissao;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.ComboBox cb_profissao;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_verificar;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.TextBox tx_tempoCont;
        private System.Windows.Forms.Label lb_result;
    }
}

