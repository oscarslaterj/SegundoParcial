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
using SegundoParcial.DAL;
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

        public void LLenarCampo(MetasDetalle meta)
        {
            MetaIDNumericUpDown.Value = meta.MetaID;
            DescripcionTextBox.Text = meta.Descripcion;
            CuotaNumericUpDown.Value = Convert.ToDecimal(meta.Cuotas);
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            bool paso = false;
            MetasDetalle meta;
            Contexto contexto = new Contexto();


            meta = LlenaClase();
            try
            {
                if (MetaIDNumericUpDown.Value == 0)
                    paso = repositorio.Guardar(meta);

                if (paso)
                {
                    MessageBox.Show("Se Guardo Exitosamente", "Imformacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se Guardo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            };
        }


        private MetasDetalle LlenaClase()
        {

            MetasDetalle meta = new MetasDetalle()
            {
                MetaID = Convert.ToInt32(MetaIDNumericUpDown.Value),
                Descripcion = DescripcionTextBox.Text,
                Cuotas = Convert.ToDecimal(CuotaNumericUpDown.Value)
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
