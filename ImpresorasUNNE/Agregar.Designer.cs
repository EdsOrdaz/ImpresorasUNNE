
namespace ImpresorasUNNE
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.basetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.comentarios = new System.Windows.Forms.TextBox();
            this.estatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Impresora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // basetxt
            // 
            this.basetxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.basetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basetxt.Location = new System.Drawing.Point(61, 6);
            this.basetxt.Name = "basetxt";
            this.basetxt.Size = new System.Drawing.Size(204, 22);
            this.basetxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estatus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comentarios:";
            // 
            // departamento
            // 
            this.departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(115, 38);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(150, 22);
            this.departamento.TabIndex = 2;
            // 
            // ip
            // 
            this.ip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(41, 108);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(224, 22);
            this.ip.TabIndex = 4;
            // 
            // comentarios
            // 
            this.comentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentarios.Location = new System.Drawing.Point(105, 172);
            this.comentarios.Name = "comentarios";
            this.comentarios.Size = new System.Drawing.Size(160, 22);
            this.comentarios.TabIndex = 6;
            // 
            // estatus
            // 
            this.estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatus.FormattingEnabled = true;
            this.estatus.Items.AddRange(new object[] {
            "RENTADA",
            "PROPIA"});
            this.estatus.Location = new System.Drawing.Point(73, 141);
            this.estatus.Name = "estatus";
            this.estatus.Size = new System.Drawing.Size(192, 24);
            this.estatus.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Impresora
            // 
            this.Impresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Impresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impresora.FormattingEnabled = true;
            this.Impresora.Location = new System.Drawing.Point(90, 75);
            this.Impresora.Name = "Impresora";
            this.Impresora.Size = new System.Drawing.Size(175, 24);
            this.Impresora.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Impresora:";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 246);
            this.Controls.Add(this.Impresora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estatus);
            this.Controls.Add(this.comentarios);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basetxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Impresora";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox basetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox comentarios;
        private System.Windows.Forms.ComboBox estatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Impresora;
        private System.Windows.Forms.Label label6;
    }
}