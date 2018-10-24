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
    public partial class rVendedores : Form
    {
        private int id;

        public List<MetasDetalle> Detalle { get; set; }
       

        private RepositorioBase<Vendedores> repositorio;
        public rVendedores()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            CuotanumericUpDown.Value = 0;
            MetasComboBox.Text = string.Empty;
            this.Detalle = new List<MetasDetalle>();
            CargarGrid();
        }


        private Vendedores LlenaClase()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.VendedorId = Convert.ToInt32(IDnumericUpDown.Value);
            vendedor.Nombres = NombrestextBox.Text;
            vendedor.Fecha = FechadateTimePicker.Value;
            vendedor.metas = this.Detalle;
            return vendedor;
        }

        private void LlenaCampo(Vendedores vendedor)
        {
            IDnumericUpDown.Value = vendedor.VendedorId;
            NombrestextBox.Text = vendedor.Nombres;
            FechadateTimePicker.Value = vendedor.Fecha;
            CuotanumericUpDown.Value = vendedor.Cuota;

            this.Detalle = vendedor.metas;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Vendedores>();
            Vendedores vendedores = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (vendedores != null);
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }


        private bool Validar(int validar)
        {
            bool paso = false;
            if (validar == 1 && IDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IDnumericUpDown, "Ingrese un ID");
                paso = true;
            }
            if (validar == 2 && NombrestextBox.Text == String.Empty)
            {
                errorProvider.SetError(NombrestextBox, "digite los nombres");
                paso = true;
            }
            if (validar == 2 && CuotanumericUpDown.Value == 0)
            {
                errorProvider.SetError(CuotanumericUpDown, "Cuota");
                paso = true;

                if (validar == 2 && string.IsNullOrWhiteSpace(MetasComboBox.Text))
                {
                    errorProvider.SetError(MetasComboBox, "Campo esta vacio");
                    paso = false;
                }
            }
            
            return paso;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            int id;
            Vendedores vendedor = new Vendedores();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            vendedor = repositorio.Buscar(id);

            if (vendedor != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(vendedor);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            Vendedores vendedor;
            bool paso = false;

            if (Validar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            vendedor = LlenaClase();
            Limpiar();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un vendedor que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(vendedor);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingresar un ID");
                return;
            }

            int id = Convert.ToInt32(IDnumericUpDown.Value);

            if (repositorio.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                Detalle = (List<MetasDetalle>)DetalleDataGridView.DataSource;
            this.Detalle.Add(
           new MetasDetalle
           (
             metaid: 0,
             descripcion: NombrestextBox.Text,
             cuotas: (decimal)CuotanumericUpDown.Value
            )
               );
            CargarGrid();

        }


        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void LlenarComboBox()
        {
            RepositorioBase<MetasDetalle> repositorio = new RepositorioBase<MetasDetalle>();
            MetasComboBox.ValueMember = "Descripcion";
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            rMetas registroMetas = new rMetas();
            registroMetas.ShowDialog();
        }
    }
}
