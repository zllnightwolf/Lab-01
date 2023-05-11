namespace Lab_01
{
    partial class TelaPrincipal
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_curso = new System.Windows.Forms.Label();
            this.lb_mensagem = new System.Windows.Forms.Label();
            this.tB_nome = new System.Windows.Forms.TextBox();
            this.cBox_curso = new System.Windows.Forms.ComboBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(196, 37);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(282, 23);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Laboratório de Teste 01";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.Location = new System.Drawing.Point(41, 104);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(62, 19);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_curso.Location = new System.Drawing.Point(41, 143);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(70, 19);
            this.lb_curso.TabIndex = 2;
            this.lb_curso.Text = "Curso:";
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.BackColor = System.Drawing.Color.Khaki;
            this.lb_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mensagem.Location = new System.Drawing.Point(133, 246);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(412, 56);
            this.lb_mensagem.TabIndex = 3;
            this.lb_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_nome
            // 
            this.tB_nome.Location = new System.Drawing.Point(121, 100);
            this.tB_nome.Name = "tB_nome";
            this.tB_nome.Size = new System.Drawing.Size(235, 23);
            this.tB_nome.TabIndex = 4;
            // 
            // cBox_curso
            // 
            this.cBox_curso.FormattingEnabled = true;
            this.cBox_curso.Items.AddRange(new object[] {
            "C#",
            "Lógica de programação",
            "PHP",
            "JavaScript",
            "Java",
            "C++",
            "C",
            "Python",
            "GO"});
            this.cBox_curso.Location = new System.Drawing.Point(121, 143);
            this.cBox_curso.Name = "cBox_curso";
            this.cBox_curso.Size = new System.Drawing.Size(121, 23);
            this.cBox_curso.TabIndex = 5;
            // 
            // btn_exibir
            // 
            this.btn_exibir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_exibir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exibir.Location = new System.Drawing.Point(133, 192);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(412, 30);
            this.btn_exibir.TabIndex = 6;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = false;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(688, 311);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.cBox_curso);
            this.Controls.Add(this.tB_nome);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_titulo);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo;
        private Label lb_nome;
        private Label lb_curso;
        private Label lb_mensagem;
        private TextBox tB_nome;
        private ComboBox cBox_curso;
        private Button btn_exibir;
    }
}