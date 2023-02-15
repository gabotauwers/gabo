using System;
using System.Windows.Forms;
using Calculus;

namespace Lagrange
{
    public partial class Form1 : Form
    {
        double[] x = new double[5];
        double[] fx = new double[5];
        double x_interpolar = 0, fx_interpolar = 0;
        int grado = 0;
        string ecuacion, operacion;
        Calculo calcular = new Calculo();

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        public void Inicio()
        {
            txtX0.Hide(); lblX0.Hide();
            txtX1.Hide(); lblX1.Hide();
            txtX2.Hide(); lblX2.Hide();
            txtX3.Hide(); lblX3.Hide();
            lblFormula.Hide();
            btnCalcular.Enabled = false;
            pbFormula.Hide();
        }
        private void cbP_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbFormula.Show();
            lblFormula.Show();
            switch (Convert.ToInt16(cbP.SelectedItem))
            {
                case 1:
                    txtX0.Show(); lblX0.Show();
                    txtX1.Show(); lblX1.Show();
                    txtX2.Hide(); lblX2.Hide();
                    txtX3.Hide(); lblX3.Hide();
                    pbFormula.Image = Lagrange.Properties.Resources.grado_1;
                    break;
                case 2:
                    txtX0.Show(); lblX0.Show();
                    txtX1.Show(); lblX1.Show();
                    txtX2.Show(); lblX2.Show();
                    txtX3.Hide(); lblX3.Hide();
                    pbFormula.Image = Lagrange.Properties.Resources.grado_2;
                    break;
                case 3:
                    txtX0.Show(); lblX0.Show();
                    txtX1.Show(); lblX1.Show();
                    txtX2.Show(); lblX2.Show();
                    txtX3.Show(); lblX3.Show();
                    pbFormula.Image = Lagrange.Properties.Resources.grado_3;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Ecuacion()
        {
            ecuacion = "";
            operacion = txtEcuacion.Text;
            for (int k = 0; k < operacion.Length; k++)
            {
                if (k != 0)
                {
                    if (operacion[k] == 'x' && (operacion[k - 1] != '(' && operacion[k - 1] != '^'))
                    {
                        ecuacion += "*x";
                    }
                    else if (operacion[k] == 'x' && (operacion[k - 1] == '(' || operacion[k - 1] == '^'))
                        ecuacion += 'x';
                    else
                        ecuacion += operacion[k];
                }
                else
                {
                    if (operacion[k] == 'e')
                        ecuacion += "2.718281828";
                    else
                        ecuacion += operacion[k];
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (seleccion != DialogResult.Yes)
            {
                e.Cancel = true;
                Focus();
            }
        }

        public void Asignar()
        {
            Ecuacion();
            grado = Convert.ToInt16(cbP.SelectedItem);
            switch (grado)
            {
                case 1:
                    x[0] = Convert.ToDouble(txtX0.Text);
                    x[1] = Convert.ToDouble(txtX1.Text);
                    break;
                case 2:
                    x[0] = Convert.ToDouble(txtX0.Text);
                    x[1] = Convert.ToDouble(txtX1.Text);
                    x[2] = Convert.ToDouble(txtX2.Text);
                    break;
                case 3:
                    x[0] = Convert.ToDouble(txtX0.Text);
                    x[1] = Convert.ToDouble(txtX1.Text);
                    x[2] = Convert.ToDouble(txtX2.Text);
                    x[3] = Convert.ToDouble(txtX3.Text);
                    break;
            }
            x_interpolar = Convert.ToDouble(txtInterpolar.Text); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtX0_TextChanged(object sender, EventArgs e)
        {
            bool cajaVacia = false;
            foreach (Control control in Controls)
            {
                if (control is TextBox && control.TabIndex < 15 && control.Visible)
                {
                    if (control.Text == String.Empty)
                        cajaVacia = true;
                }
            }

            if (cajaVacia)
                btnCalcular.Enabled = false;
            else
                btnCalcular.Enabled = true;
        }

        public bool tieneSolucion()
        {
            bool haySolucion;
            if (calcular.Sintaxis(ecuacion, 'x'))
                haySolucion = true;
            else
                haySolucion = false;
            return haySolucion;
        }
        public void primerGrado()
        {
            fx[0] = calcular.EvaluaFx(x[0]);
            fx[1] = calcular.EvaluaFx(x[1]);
            fx_interpolar = (((x_interpolar - x[1]) / (x[0] - x[1])) * fx[0]) + (((x_interpolar - x[0]) / (x[1] - x[0])) * fx[1]);
            for(int i = 0; i < 2; i++)
            {
                dgv1.Rows.Add(i, x[i], fx[i]);
            }
        }
        public void segundoGrado()
        {
            fx[0] = calcular.EvaluaFx(x[0]);
            fx[1] = calcular.EvaluaFx(x[1]);
            fx[2] = calcular.EvaluaFx(x[2]);
            fx_interpolar = ((((x_interpolar - x[1]) * (x_interpolar - x[2])) / ((x[0] - x[1]) * (x[0] - x[2])))) * (fx[0]);
            fx_interpolar += ((((x_interpolar - x[0]) * (x_interpolar - x[2])) / ((x[1] - x[0]) * (x[1] - x[2])))) * (fx[1]);
            for (int i = 0; i < 3; i++)
            {
                dgv1.Rows.Add(i, x[i], fx[i]);
            }
        }
        public void tercerGrado()
        {
            fx[0] = calcular.EvaluaFx(x[0]);
            fx[1] = calcular.EvaluaFx(x[1]);
            fx[2] = calcular.EvaluaFx(x[2]);
            fx[3] = calcular.EvaluaFx(x[3]);
            fx_interpolar = ((((x_interpolar - x[1]) * (x_interpolar - x[2]) * (x_interpolar - x[3])) / ((x[0] - x[1]) * (x[0] - x[2]) * (x[0] - x[3])))) * (fx[0]);
            fx_interpolar += ((((x_interpolar - x[0]) * (x_interpolar - x[2]) * (x_interpolar - x[3])) / ((x[1] - x[0]) * (x[1] - x[2]) * (x[1] - x[3])))) * (fx[1]);
            fx_interpolar += ((((x_interpolar - x[0]) * (x_interpolar - x[1]) * (x_interpolar - x[3])) / ((x[2] - x[0]) * (x[2] - x[1]) * (x[2] - x[3])))) * (fx[2]);
            fx_interpolar += ((((x_interpolar - x[0]) * (x_interpolar - x[1]) * (x_interpolar - x[2])) / ((x[3] - x[0]) * (x[3] - x[1]) * (x[3] - x[2])))) * (fx[3]);
            for (int i = 0; i < 4; i++)
            {
                dgv1.Rows.Add(i, x[i], fx[i]);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch
            {
                MessageBox.Show("Los valores ingresados son incorrectos, ingresa nuevos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpiar();
            }
        }
        public void Calcular()
        {
            Asignar();
            if (tieneSolucion())
            {
                switch (grado)
                {
                    case 1:
                        primerGrado();
                        break;
                    case 2:
                        segundoGrado();
                        break;
                    case 3:
                        tercerGrado();
                        break;
                }
                foreach (Control control in Controls)
                {
                    if (control is TextBox && control.TabIndex < 7)
                        control.Enabled = false;
                }
                cbP.Enabled = false;
                if (fx_interpolar < 100000000 && fx_interpolar > -100000000000)
                {
                    txtResultado.Text = Convert.ToString(fx_interpolar);
                }
                else
                {
                    MessageBox.Show("Hubo un error con los puntos ingresados, por favor, ingresa nuevos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("La ecuación ingresada no tiene solución, ingresa una nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEcuacion.Text = String.Empty;
                btnCalcular.Enabled = false;
            }
            btnCalcular.Enabled = false;
        }
        public void Limpiar()
        {
            foreach(Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                    control.Enabled = true;
                }
            }
            cbP.SelectedIndex = -1;
            cbP.Enabled = true;
            Inicio();
            dgv1.Rows.Clear();
            fx_interpolar = 0;
            x_interpolar = 0;
        }
    }
}
