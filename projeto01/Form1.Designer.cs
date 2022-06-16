namespace projeto01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.varBox01 = new System.Windows.Forms.TextBox();
            this.varBox02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.varBox03 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRutinas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblResultado.Location = new System.Drawing.Point(402, 141);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(73, 15);
            this.LblResultado.TabIndex = 0;
            this.LblResultado.Text = "Estoy dentro";
            this.LblResultado.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // varBox01
            // 
            this.varBox01.Location = new System.Drawing.Point(392, 44);
            this.varBox01.Name = "varBox01";
            this.varBox01.Size = new System.Drawing.Size(100, 23);
            this.varBox01.TabIndex = 2;
            // 
            // varBox02
            // 
            this.varBox02.Location = new System.Drawing.Point(392, 73);
            this.varBox02.Name = "varBox02";
            this.varBox02.Size = new System.Drawing.Size(100, 23);
            this.varBox02.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "variable02";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // varBox03
            // 
            this.varBox03.Location = new System.Drawing.Point(392, 102);
            this.varBox03.Name = "varBox03";
            this.varBox03.Size = new System.Drawing.Size(100, 23);
            this.varBox03.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "variable03";
            // 
            // cboRutinas
            // 
            this.cboRutinas.FormattingEnabled = true;
            this.cboRutinas.Location = new System.Drawing.Point(392, 204);
            this.cboRutinas.Name = "cboRutinas";
            this.cboRutinas.Size = new System.Drawing.Size(177, 23);
            this.cboRutinas.TabIndex = 8;
            this.cboRutinas.SelectedIndexChanged += new System.EventHandler(this.CboRutinas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "variable01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRutinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varBox03);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varBox02);
            this.Controls.Add(this.varBox01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblResultado;
        private Button button1;
        private TextBox varBox01;
        private TextBox varBox02;
        private Label label1;
        private TextBox varBox03;
        private Label label3;
        private ComboBox cboRutinas;
        private Label label2;
    }
}