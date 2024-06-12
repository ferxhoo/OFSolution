using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.formulariosModales
{
    public partial class ModalCorreo : Form
    {
        private string NombreCliente = null;
        private string correoParaEnvio = null;
        private string pdfFilePath = null;

        private string miCorreo = null;
        private string miContraseña = null;

        public ModalCorreo(string cliente, string correo, string pdfFilePath)
        {
            InitializeComponent();
            NombreCliente = cliente;
            correoParaEnvio = correo;
            this.pdfFilePath = pdfFilePath;
        }

        private void ModalCorreo_Load(object sender, EventArgs e)
        {
            Negocio negocio = new ServicioNegocio().ObtenerDatos();

            miCorreo = negocio.Correo;
            miContraseña = negocio.Contraseña;

            txtCorreo.Texts = correoParaEnvio;

            string asunto = $"Hola {NombreCliente}, Aqui esta tu Factura";

            txtAsunto.Texts = asunto;

            string mensaje = "Gracias por tu Compra... Regresa Pronto ;)";


            txtMensaje.Texts = mensaje;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarCorreoConAdjunto(correoParaEnvio, pdfFilePath);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnviarCorreoConAdjunto(string correo, string pdfFilePath)
        {

            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            if(miCorreo == "")
            {
                MessageBox.Show("El correo de el negocio no ha sido registrado");
                return;
            }
            else
            {
                mail.From = new MailAddress(miCorreo);
                mail.To.Add(correo);

                mail.Subject = txtAsunto.Texts;
                string html = $"<html><body><p>{txtMensaje.Texts}</p></body></html>";

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                mail.AlternateViews.Add(htmlView);

                if (!string.IsNullOrEmpty(pdfFilePath))
                {
                    Attachment attachment = new Attachment(pdfFilePath);
                    mail.Attachments.Add(attachment);
                }

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(miCorreo, miContraseña);
                smtp.EnableSsl = true;

                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Correo enviado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;


        
    }
}
