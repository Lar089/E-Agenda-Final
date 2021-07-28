
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class TelaCompromissoForm
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
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.maskTxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbContato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateData
            // 
            this.dateData.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateData.Location = new System.Drawing.Point(85, 137);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(100, 20);
            this.dateData.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora de Termino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hora de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(85, 51);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(326, 20);
            this.txtAssunto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assunto:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(85, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(336, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(255, 238);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Local:";
            // 
            // rdbRemoto
            // 
            this.rdbRemoto.AutoSize = true;
            this.rdbRemoto.Location = new System.Drawing.Point(165, 82);
            this.rdbRemoto.Name = "rdbRemoto";
            this.rdbRemoto.Size = new System.Drawing.Size(62, 17);
            this.rdbRemoto.TabIndex = 31;
            this.rdbRemoto.TabStop = true;
            this.rdbRemoto.Text = "Remoto";
            this.rdbRemoto.UseVisualStyleBackColor = true;
            this.rdbRemoto.CheckedChanged += new System.EventHandler(this.rdbRemoto_CheckedChanged);
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(85, 82);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(74, 17);
            this.rdbPresencial.TabIndex = 30;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            this.rdbPresencial.CheckedChanged += new System.EventHandler(this.rdbPresencial_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Link:";
            // 
            // txtLink
            // 
            this.txtLink.Enabled = false;
            this.txtLink.Location = new System.Drawing.Point(85, 105);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(326, 20);
            this.txtLink.TabIndex = 33;
            // 
            // maskTxtHoraInicio
            // 
            this.maskTxtHoraInicio.Location = new System.Drawing.Point(85, 165);
            this.maskTxtHoraInicio.Mask = "90:00";
            this.maskTxtHoraInicio.Name = "maskTxtHoraInicio";
            this.maskTxtHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.maskTxtHoraInicio.TabIndex = 34;
            this.maskTxtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskTxtHoraTermino
            // 
            this.maskTxtHoraTermino.Location = new System.Drawing.Point(311, 165);
            this.maskTxtHoraTermino.Mask = "90:00";
            this.maskTxtHoraTermino.Name = "maskTxtHoraTermino";
            this.maskTxtHoraTermino.Size = new System.Drawing.Size(100, 20);
            this.maskTxtHoraTermino.TabIndex = 35;
            this.maskTxtHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Contato:";
            // 
            // cmbContato
            // 
            this.cmbContato.FormattingEnabled = true;
            this.cmbContato.Location = new System.Drawing.Point(83, 194);
            this.cmbContato.Name = "cmbContato";
            this.cmbContato.Size = new System.Drawing.Size(328, 21);
            this.cmbContato.TabIndex = 38;
            // 
            // TelaCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 273);
            this.Controls.Add(this.cmbContato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskTxtHoraTermino);
            this.Controls.Add(this.maskTxtHoraInicio);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdbRemoto);
            this.Controls.Add(this.rdbPresencial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "TelaCompromissoForm";
            this.Text = "TelaCompromissoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbRemoto;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.MaskedTextBox maskTxtHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskTxtHoraTermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbContato;
    }
}