using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        int nFil;
        int nCol;
        int nFilB;
        int nColB;
        string operacion;
        bool txtvacio;
        decimal[,] matriz1;
        decimal[,] matriz2;
        int k;

        #endregion

        private void btnCargarMatriz_Click(object sender, EventArgs e)
        {
            ControlText();
            if (txtvacio)
            {
                MessageBox.Show("No puede haber casilleros vacíos", "Completar datos", MessageBoxButtons.OK);
            }
            else
            {
                if (nFil < 1)
                {
                    nFil = Convert.ToInt32(txtFil.Text);
                    nCol = Convert.ToInt32(txtCol.Text);
                    DimensionMatrizA();
                }
                else
                {
                    nFilB = Convert.ToInt32(txtFil.Text);
                    nColB = Convert.ToInt32(txtCol.Text);
                }

                switch (operacion)
                {
                    case "prodem":
                        DimensionMatrizR();
                        break;
                    case "producto":
                        if (nCol != nFilB)
                        {
                            MessageBox.Show("Las columnas de la primera matriz no coincide con las filas de esta nueva matriz. Tiene que tener " + nCol + " filas.", "No se puede realizar la opreación", MessageBoxButtons.OK);
                        }
                        else
                        {
                            DimensionMatrizB();
                            DimensionMatrizR();
                        }
                        break;
                }
                btnSumar.Enabled = true;
                btnRestar.Enabled = true;
                btnPm.Enabled = true;
                btnTras.Enabled = true;
            }
            ClearControl();
        }

        private void DimensionMatrizA()
        {
            for (int i = 0; i < nCol; i++)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "N";
                dtgvDatos.Columns.Add(column1);
            }
            dtgvDatos.Rows.Add(nFil);
        }

        private void DimensionMatrizB()
        {
            for (int i = 0; i < nColB; i++)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "N";
                dtgvDatos.Columns.Add(column1);
            }
            dtgvDatos.Rows.Add(nFilB);
        }

        private void DimensionMatrizR()
        {
            if (operacion == "producto")
            {
                for (int i = 0; i < nColB; i++)
                {
                    DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                    column1.HeaderText = "N";
                    dtgvResultado.Columns.Add(column1);
                }
                dtgvResultado.Rows.Add(nFil);
            }
            else
            {
                for (int i = 0; i < nCol; i++)
                {
                    DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                    column1.HeaderText = "N";
                    dtgvResultado.Columns.Add(column1);
                }
                dtgvResultado.Rows.Add(nFil);
            }            
        }


        private void ControlText()
        {
            foreach (var txt in this.Controls.OfType<TextBox>())
            {
                if (txt is TextBox)
                {
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        txtvacio = true;
                    }
                    else
                    {
                        txtvacio = false;
                    }
                }
            }
        }

        private void ControlDtgv()
        {
            foreach (var txt in this.Controls.OfType<TextBox>())
            {
                if (txt is TextBox)
                {
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        txtvacio = true;
                    }
                    else
                    {
                        txtvacio = false;
                    }
                }
            }
        }

        private void CleanDtgd()
        {
            foreach (var dgv in this.Controls.OfType<DataGridView>())
            {
                dgv.Rows.Clear();
                dgv.Columns.Clear();
            }
        }

        private void ClearControl()
        {
            foreach (var txt in this.Controls.OfType<TextBox>())
            {
                if (txt is TextBox)
                {
                    txt.Clear();
                }
            }
        }

        private void AsignarMatriz()
        {
            matriz1 = new decimal[nFil, nCol];
            for (int i = 0; i < nFil; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    matriz1[i, j] = Convert.ToDecimal(dtgvDatos.Rows[i].Cells[j].Value);
                }
            }
        }
        private void btnResul_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "sumar":
                    for (int i = 0; i < nFil; i++)
                    {
                        for (int j = 0; j < nCol; j++)
                        {
                            matriz1[i, j] += Convert.ToDecimal(dtgvDatos.Rows[i].Cells[j].Value);
                        }
                    }
                    break;

                case "restar":
                    for (int i = 0; i < nFil; i++)
                    {
                        for (int j = 0; j < nCol; j++)
                        {
                            matriz1[i, j] = matriz1[i, j] - Convert.ToDecimal(dtgvDatos.Rows[i].Cells[j].Value);
                        }
                    }
                    break;
                case "prodem":
                    AsignarMatriz();
                    for (int i = 0; i < nFil; i++)
                    {
                        for (int j = 0; j < nCol; j++)
                        {
                            matriz1[i, j] = k * Convert.ToDecimal(dtgvDatos.Rows[i].Cells[j].Value);
                        }
                    }
                    break;
                case "producto":

                    matriz2 = new decimal[nFil, nColB];

                    for (int i = 0; i < nFil; i++)
                    {
                        for (int j = 0; j < nColB; j++)
                        {
                            for (int k = 0; k < nCol; k++)
                            {
                                matriz2[i, j] += matriz1[i, k] * Convert.ToDecimal(dtgvDatos.Rows[k].Cells[j].Value);
                            }
                        }
                    }
                    break;
                case "traspuesta":
                    for (int i = 0; i < nFil; i++)
                    {
                        for (int j = 0; j < nCol; j++)
                        {
                            dtgvResultado.Rows[j].Cells[i].Value = dtgvDatos.Rows[i].Cells[j].Value;
                        }
                    }
                    break;
            }
            if (operacion != "traspuesta")
            {
                MostrarMatriz();
            }
        }

        private void MostrarMatriz()
        {
            if (operacion == "producto")
            {
                for (int i = 0; i < nFil; i++)
                {
                    for (int j = 0; j < nColB; j++)
                    {
                        dtgvResultado.Rows[i].Cells[j].Value = matriz2[i, j].ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < nFil; i++)
                {
                    for (int j = 0; j < nCol; j++)
                    {
                        dtgvResultado.Rows[i].Cells[j].Value = matriz1[i, j].ToString();
                    }
                }
            }            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operacion = "sumar";
            AsignarMatriz();
            dtgvDatos.Columns.Clear();
            DimensionMatrizA();
            DimensionMatrizR();
            txtFil.Enabled = false;
            txtCol.Enabled = false;
        }
        

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operacion = "restar";
            AsignarMatriz();
            dtgvDatos.Columns.Clear();
            DimensionMatrizA();
            DimensionMatrizR();
            txtFil.Enabled = false;
            txtCol.Enabled = false;
        }

        private void btnPe_Click(object sender, EventArgs e)
        {
            operacion = "prodem";
            k = Convert.ToInt32(txtFil.Text);
            ClearControl();
        }

        private void btnPm_Click(object sender, EventArgs e)
        {
            operacion = "producto";
            AsignarMatriz();
            dtgvDatos.Columns.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            CleanDtgd();
            ClearControl();
            nFil = 0;
            nCol = 0;
            nFilB = 0;
            nColB = 0;
            operacion = string.Empty;
            txtvacio = false;
            k = 0;
            btnSumar.Enabled = false;
            btnRestar.Enabled = false;
            btnTras.Enabled = false;
            btnPm.Enabled = false;
            txtFil.Enabled = true;
            txtCol.Enabled = true;
            this.Refresh();
        }

        private void btnTras_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nFil; i++)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "N";
                dtgvResultado.Columns.Add(column1);
            }
            dtgvResultado.Rows.Add(nCol);
            operacion = "traspuesta";                        
        }
    }
}