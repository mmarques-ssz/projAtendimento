namespace Atendimento
{
    partial class Form1
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
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.lstSenhasGeradas = new System.Windows.Forms.ListBox();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnChamadaGuiche1 = new System.Windows.Forms.Button();
            this.lstAtendimento1 = new System.Windows.Forms.ListBox();
            this.btnListarChamadas = new System.Windows.Forms.Button();
            this.txtIdGuiche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSenha.Location = new System.Drawing.Point(84, 31);
            this.btnGerarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(128, 34);
            this.btnGerarSenha.TabIndex = 0;
            this.btnGerarSenha.Text = "Gerar senha";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // lstSenhasGeradas
            // 
            this.lstSenhasGeradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSenhasGeradas.FormattingEnabled = true;
            this.lstSenhasGeradas.ItemHeight = 25;
            this.lstSenhasGeradas.Location = new System.Drawing.Point(16, 75);
            this.lstSenhasGeradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSenhasGeradas.Name = "lstSenhasGeradas";
            this.lstSenhasGeradas.Size = new System.Drawing.Size(300, 204);
            this.lstSenhasGeradas.TabIndex = 1;
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSenhas.Location = new System.Drawing.Point(55, 303);
            this.btnListarSenhas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(227, 33);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Listar senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnChamadaGuiche1
            // 
            this.btnChamadaGuiche1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamadaGuiche1.Location = new System.Drawing.Point(791, 31);
            this.btnChamadaGuiche1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChamadaGuiche1.Name = "btnChamadaGuiche1";
            this.btnChamadaGuiche1.Size = new System.Drawing.Size(161, 38);
            this.btnChamadaGuiche1.TabIndex = 4;
            this.btnChamadaGuiche1.Text = "Chamar";
            this.btnChamadaGuiche1.UseVisualStyleBackColor = true;
            this.btnChamadaGuiche1.Click += new System.EventHandler(this.btnChamadaGuiche1_Click);
            // 
            // lstAtendimento1
            // 
            this.lstAtendimento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAtendimento1.FormattingEnabled = true;
            this.lstAtendimento1.ItemHeight = 25;
            this.lstAtendimento1.Location = new System.Drawing.Point(517, 87);
            this.lstAtendimento1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAtendimento1.Name = "lstAtendimento1";
            this.lstAtendimento1.Size = new System.Drawing.Size(493, 179);
            this.lstAtendimento1.TabIndex = 5;
            // 
            // btnListarChamadas
            // 
            this.btnListarChamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarChamadas.Location = new System.Drawing.Point(576, 297);
            this.btnListarChamadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarChamadas.Name = "btnListarChamadas";
            this.btnListarChamadas.Size = new System.Drawing.Size(391, 46);
            this.btnListarChamadas.TabIndex = 6;
            this.btnListarChamadas.Text = "Listar Atendimentos";
            this.btnListarChamadas.UseVisualStyleBackColor = true;
            this.btnListarChamadas.Click += new System.EventHandler(this.btnListarChamadas_Click);
            // 
            // txtIdGuiche
            // 
            this.txtIdGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGuiche.Location = new System.Drawing.Point(649, 31);
            this.txtIdGuiche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdGuiche.Name = "txtIdGuiche";
            this.txtIdGuiche.Size = new System.Drawing.Size(87, 30);
            this.txtIdGuiche.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guiche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qtde guichês";
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiches.Location = new System.Drawing.Point(385, 159);
            this.lblQtdeGuiches.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(42, 46);
            this.lblQtdeGuiches.TabIndex = 10;
            this.lblQtdeGuiches.Text = "0";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(343, 208);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(128, 34);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 183);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 660);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdGuiche);
            this.Controls.Add(this.btnListarChamadas);
            this.Controls.Add(this.lstAtendimento1);
            this.Controls.Add(this.btnChamadaGuiche1);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.lstSenhasGeradas);
            this.Controls.Add(this.btnGerarSenha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.ListBox lstSenhasGeradas;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnChamadaGuiche1;
        private System.Windows.Forms.ListBox lstAtendimento1;
        private System.Windows.Forms.Button btnListarChamadas;
        private System.Windows.Forms.TextBox txtIdGuiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdeGuiches;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

