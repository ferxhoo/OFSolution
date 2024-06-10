using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formNegocio : Form
    {
        public formNegocio()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
            CentrarPanel();
        }

        private void InicializarComponentesPersonalizados()
        {
            this.DoubleBuffered = true;
            this.Resize += new EventHandler(formNegocio_Resize);
        }

        private void CentrarPanel()
        {
            int x = (this.ClientSize.Width - panelPrincipal.Width) / 2;
            int y = (this.ClientSize.Height - panelPrincipal.Height) / 2;
            panelPrincipal.Location = new System.Drawing.Point(x, y);
        }

        private void formNegocio_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void btnCambiosLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                    bool respuesta = new ServicioNegocio().ActualizarLogo(byteimage, out mensaje);

                    if (respuesta)
                        picLogo.Image = ByteToImage(byteimage);
                    else
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new ServicioNegocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo.Image = ByteToImage(byteimage);

            Negocio datos = new ServicioNegocio().ObtenerDatos();

            txtNombre.Texts = datos.Nombre;
            txtRUC.Texts = datos.RUT;
            txtDireccion.Texts = datos.Direccion;
            txtCorreo.Texts = datos.Correo;
            txtContraseña.Texts = datos.Contraseña;
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio dato = new Negocio()
            {
                Nombre = txtNombre.Texts,
                RUT = txtRUC.Texts,
                Correo = txtCorreo.Texts,
                Contraseña = txtContraseña.Texts,
                Direccion = txtDireccion.Texts
                
            };

            bool respuesta = new ServicioNegocio().GuardarDatos(dato, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
