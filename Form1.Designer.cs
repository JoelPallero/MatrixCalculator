
namespace MatrixCalculator
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
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.dtgvResultado = new System.Windows.Forms.DataGridView();
            this.txtFil = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnResul = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCargarMatriz = new System.Windows.Forms.Button();
            this.lblCargarMatriz = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPm = new System.Windows.Forms.Button();
            this.btnPe = new System.Windows.Forms.Button();
            this.btnTras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.AllowUserToDeleteRows = false;
            this.dtgvDatos.AllowUserToOrderColumns = true;
            this.dtgvDatos.AllowUserToResizeColumns = false;
            this.dtgvDatos.AllowUserToResizeRows = false;
            this.dtgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.ColumnHeadersVisible = false;
            this.dtgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowHeadersVisible = false;
            this.dtgvDatos.RowHeadersWidth = 51;
            this.dtgvDatos.RowTemplate.Height = 29;
            this.dtgvDatos.Size = new System.Drawing.Size(385, 243);
            this.dtgvDatos.TabIndex = 0;
            // 
            // dtgvResultado
            // 
            this.dtgvResultado.AllowUserToAddRows = false;
            this.dtgvResultado.AllowUserToDeleteRows = false;
            this.dtgvResultado.AllowUserToResizeColumns = false;
            this.dtgvResultado.AllowUserToResizeRows = false;
            this.dtgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultado.ColumnHeadersVisible = false;
            this.dtgvResultado.Location = new System.Drawing.Point(12, 288);
            this.dtgvResultado.Name = "dtgvResultado";
            this.dtgvResultado.RowHeadersVisible = false;
            this.dtgvResultado.RowHeadersWidth = 51;
            this.dtgvResultado.RowTemplate.Height = 29;
            this.dtgvResultado.Size = new System.Drawing.Size(385, 304);
            this.dtgvResultado.TabIndex = 1;
            // 
            // txtFil
            // 
            this.txtFil.Location = new System.Drawing.Point(414, 46);
            this.txtFil.Name = "txtFil";
            this.txtFil.Size = new System.Drawing.Size(57, 27);
            this.txtFil.TabIndex = 3;
            // 
            // btnSumar
            // 
            this.btnSumar.Enabled = false;
            this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSumar.Location = new System.Drawing.Point(414, 89);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(148, 47);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Enabled = false;
            this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(599, 89);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(148, 47);
            this.btnRestar.TabIndex = 5;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnResul
            // 
            this.btnResul.Location = new System.Drawing.Point(414, 226);
            this.btnResul.Name = "btnResul";
            this.btnResul.Size = new System.Drawing.Size(148, 29);
            this.btnResul.TabIndex = 6;
            this.btnResul.Text = "Resultado";
            this.btnResul.UseVisualStyleBackColor = true;
            this.btnResul.Click += new System.EventHandler(this.btnResul_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 556);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCargarMatriz
            // 
            this.btnCargarMatriz.Location = new System.Drawing.Point(599, 46);
            this.btnCargarMatriz.Name = "btnCargarMatriz";
            this.btnCargarMatriz.Size = new System.Drawing.Size(148, 29);
            this.btnCargarMatriz.TabIndex = 2;
            this.btnCargarMatriz.Text = "Cargar Matriz";
            this.btnCargarMatriz.UseVisualStyleBackColor = true;
            this.btnCargarMatriz.Click += new System.EventHandler(this.btnCargarMatriz_Click);
            // 
            // lblCargarMatriz
            // 
            this.lblCargarMatriz.AutoSize = true;
            this.lblCargarMatriz.Location = new System.Drawing.Point(414, 15);
            this.lblCargarMatriz.Name = "lblCargarMatriz";
            this.lblCargarMatriz.Size = new System.Drawing.Size(186, 20);
            this.lblCargarMatriz.TabIndex = 8;
            this.lblCargarMatriz.Text = "Elegir Tamaño de la Matriz";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(505, 46);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(57, 27);
            this.txtCol.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // btnPm
            // 
            this.btnPm.Enabled = false;
            this.btnPm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPm.Location = new System.Drawing.Point(599, 142);
            this.btnPm.Name = "btnPm";
            this.btnPm.Size = new System.Drawing.Size(148, 47);
            this.btnPm.TabIndex = 12;
            this.btnPm.Text = "* (PM)";
            this.btnPm.UseVisualStyleBackColor = true;
            this.btnPm.Click += new System.EventHandler(this.btnPm_Click);
            // 
            // btnPe
            // 
            this.btnPe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPe.Location = new System.Drawing.Point(414, 142);
            this.btnPe.Name = "btnPe";
            this.btnPe.Size = new System.Drawing.Size(148, 47);
            this.btnPe.TabIndex = 11;
            this.btnPe.Text = "* (EM)";
            this.btnPe.UseVisualStyleBackColor = true;
            this.btnPe.Click += new System.EventHandler(this.btnPe_Click);
            // 
            // btnTras
            // 
            this.btnTras.Enabled = false;
            this.btnTras.Location = new System.Drawing.Point(599, 226);
            this.btnTras.Name = "btnTras";
            this.btnTras.Size = new System.Drawing.Size(148, 29);
            this.btnTras.TabIndex = 13;
            this.btnTras.Text = "Traspuesta";
            this.btnTras.UseVisualStyleBackColor = true;
            this.btnTras.Click += new System.EventHandler(this.btnTras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 598);
            this.Controls.Add(this.btnTras);
            this.Controls.Add(this.btnPm);
            this.Controls.Add(this.btnPe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.lblCargarMatriz);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResul);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtFil);
            this.Controls.Add(this.btnCargarMatriz);
            this.Controls.Add(this.dtgvResultado);
            this.Controls.Add(this.dtgvDatos);
            this.Name = "Form1";
            this.Text = "Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridView dtgvResultado;
        private System.Windows.Forms.TextBox txtFil;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnResul;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCargarMatriz;
        private System.Windows.Forms.Label lblCargarMatriz;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPm;
        private System.Windows.Forms.Button btnPe;
        private System.Windows.Forms.Button btnTras;
    }
}

