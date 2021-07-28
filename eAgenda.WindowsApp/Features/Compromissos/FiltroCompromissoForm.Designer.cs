
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class FiltroCompromissoForm
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
            this.rdbCompromissosConcluidos = new System.Windows.Forms.RadioButton();
            this.rdbCompromissosPendentes = new System.Windows.Forms.RadioButton();
            this.rdbTodosCompromissos = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbCompromissosConcluidos
            // 
            this.rdbCompromissosConcluidos.AutoSize = true;
            this.rdbCompromissosConcluidos.Location = new System.Drawing.Point(28, 95);
            this.rdbCompromissosConcluidos.Name = "rdbCompromissosConcluidos";
            this.rdbCompromissosConcluidos.Size = new System.Drawing.Size(229, 17);
            this.rdbCompromissosConcluidos.TabIndex = 11;
            this.rdbCompromissosConcluidos.TabStop = true;
            this.rdbCompromissosConcluidos.Text = "Visualizar somente compromissos passados";
            this.rdbCompromissosConcluidos.UseVisualStyleBackColor = true;
            this.rdbCompromissosConcluidos.CheckedChanged += new System.EventHandler(this.rdbCompromissosConcluidos_CheckedChanged);
            // 
            // rdbCompromissosPendentes
            // 
            this.rdbCompromissosPendentes.AutoSize = true;
            this.rdbCompromissosPendentes.Location = new System.Drawing.Point(28, 61);
            this.rdbCompromissosPendentes.Name = "rdbCompromissosPendentes";
            this.rdbCompromissosPendentes.Size = new System.Drawing.Size(216, 17);
            this.rdbCompromissosPendentes.TabIndex = 10;
            this.rdbCompromissosPendentes.TabStop = true;
            this.rdbCompromissosPendentes.Text = "Visualizar somente compromissos futuros";
            this.rdbCompromissosPendentes.UseVisualStyleBackColor = true;
            this.rdbCompromissosPendentes.CheckedChanged += new System.EventHandler(this.rdbCompromissosPendentes_CheckedChanged);
            // 
            // rdbTodosCompromissos
            // 
            this.rdbTodosCompromissos.AutoSize = true;
            this.rdbTodosCompromissos.Location = new System.Drawing.Point(28, 27);
            this.rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            this.rdbTodosCompromissos.Size = new System.Drawing.Size(182, 17);
            this.rdbTodosCompromissos.TabIndex = 9;
            this.rdbTodosCompromissos.TabStop = true;
            this.rdbTodosCompromissos.Text = "Visualizar todos os Compromissos";
            this.rdbTodosCompromissos.UseVisualStyleBackColor = true;
            this.rdbTodosCompromissos.CheckedChanged += new System.EventHandler(this.rdbTodosCompromissos_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(277, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(196, 191);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.dateDataFinal.Enabled = false;
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(110, 161);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(100, 20);
            this.dateDataFinal.TabIndex = 16;
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.dateDataInicial.Enabled = false;
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.Location = new System.Drawing.Point(110, 127);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(100, 20);
            this.dateDataInicial.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Inicial:";
            // 
            // FiltroCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.dateDataFinal);
            this.Controls.Add(this.dateDataInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbCompromissosConcluidos);
            this.Controls.Add(this.rdbCompromissosPendentes);
            this.Controls.Add(this.rdbTodosCompromissos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "FiltroCompromissoForm";
            this.Text = "FiltroCompromissoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCompromissosConcluidos;
        private System.Windows.Forms.RadioButton rdbCompromissosPendentes;
        private System.Windows.Forms.RadioButton rdbTodosCompromissos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}