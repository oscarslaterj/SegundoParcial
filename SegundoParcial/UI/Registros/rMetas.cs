using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoParcial.BLL;
using SegundoParcial.Entidades;

namespace SegundoParcial.UI.Registros
{
    public partial class rMetas : Form
    {

        private RepositorioBase<Vendedores> repositorio;
        public rMetas()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            bool paso = false;
            MetasDetalle tipo;
            if (!Validar())
                return;
            tipo= LlenaClase();

            if (MetaIDNumericUpDown.Value == 0)
                paso = repositorio.Guardar(tipo);


            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private MetasDetalle LlenaClase()
        {

            MetasDetalle meta = new MetasDetalle()
            {
                MetaID = Convert.ToInt32(MetaIDNumericUpDown.Value),
                Descripcion = DescripcionTextBox.Text,
                Cuotas = Convert.ToInt64(CuotaNumericUpDown.Value)
            };
            return meta;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Campo esta vacio");
                paso = false;
            }

            return paso;
        }

    }
}
