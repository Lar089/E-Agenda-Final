
namespace eAgenda.WindowsApp.Features.Contatos
{
    partial class AgruparContatoForm
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
            this.rdbTodosContatos = new System.Windows.Forms.RadioButton();
            this.rdbAgruparEmpresa = new System.Windows.Forms.RadioButton();
            this.rdbAgruparCargo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbTodosContatos
            // 
            this.rdbTodosContatos.AutoSize = true;
            this.rdbTodosContatos.Location = new System.Drawing.Point(21, 92);
            this.rdbTodosContatos.Name = "rdbTodosContatos";
            this.rdbTodosContatos.Size = new System.Drawing.Size(114, 17);
            this.rdbTodosContatos.TabIndex = 11;
            this.rdbTodosContatos.TabStop = true;
            this.rdbTodosContatos.Text = "Todos os Contatos";
            this.rdbTodosContatos.UseVisualStyleBackColor = true;
            // 
            // rdbAgruparEmpresa
            // 
            this.rdbAgruparEmpresa.AutoSize = true;
            this.rdbAgruparEmpresa.Location = new System.Drawing.Point(21, 58);
            this.rdbAgruparEmpresa.Name = "rdbAgruparEmpresa";
            this.rdbAgruparEmpresa.Size = new System.Drawing.Size(162, 17);
            this.rdbAgruparEmpresa.TabIndex = 10;
            this.rdbAgruparEmpresa.TabStop = true;
            this.rdbAgruparEmpresa.Text = "Agrupar contato por empresa";
            this.rdbAgruparEmpresa.UseVisualStyleBackColor = true;
            // 
            // rdbAgruparCargo
            // 
            this.rdbAgruparCargo.AutoSize = true;
            this.rdbAgruparCargo.Location = new System.Drawing.Point(21, 24);
            this.rdbAgruparCargo.Name = "rdbAgruparCargo";
            this.rdbAgruparCargo.Size = new System.Drawing.Size(149, 17);
            this.rdbAgruparCargo.TabIndex = 9;
            this.rdbAgruparCargo.TabStop = true;
            this.rdbAgruparCargo.Text = "Agrupar contato por cargo";
            this.rdbAgruparCargo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(270, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(189, 188);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // AgruparContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.rdbTodosContatos);
            this.Controls.Add(this.rdbAgruparEmpresa);
            this.Controls.Add(this.rdbAgruparCargo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "AgruparContatoForm";
            this.Text = "AgruparContatoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTodosContatos;
        private System.Windows.Forms.RadioButton rdbAgruparEmpresa;
        private System.Windows.Forms.RadioButton rdbAgruparCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}