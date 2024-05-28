#region Importaciones necesarias
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace GUI.Componentes_Personalizad
{
    public class MenuSnapAsisstOFSolution : ToolStripDropDown
    {
        #region Campos de Componente
        private Timer closeMenuTimer;
        private TableLayoutPanel tableLayoutPanel;
        private Form ownerForm;
        #endregion

        #region Configuracion Inicial
        public MenuSnapAsisstOFSolution(Form owner)
        {
            this.ownerForm = owner;

            // Inicializar el TableLayoutPanel
            tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Añadir el TableLayoutPanel al ToolStripControlHost
            ToolStripControlHost host = new ToolStripControlHost(tableLayoutPanel);
            this.Items.Add(host);

            // Configurar los botones en el menú
            ConfigureMenuButtons();

            // Inicializar el temporizador
            closeMenuTimer = new Timer { Interval = 250 }; // 250 milisegundos
            closeMenuTimer.Tick += CloseMenuTimer_Tick;

            // Asignar eventos de mouse al menú
            this.MouseEnter += new EventHandler(Menu_MouseEnter);
            this.MouseLeave += new EventHandler(Menu_MouseLeave);
        }
        #endregion

        #region Configuracion de Botones
        private void ConfigureMenuButtons()
        {
            // Crear botones y añadirlos al TableLayoutPanel
            for (int i = 0; i < 6; i++)
            {
                var button = new Button
                {
                    Width = 150,
                    Height = 150,
                    TextAlign = ContentAlignment.BottomCenter,
                    ImageAlign = ContentAlignment.TopCenter
                };

                // Asignar eventos de mouse a los botones
                button.MouseEnter += new EventHandler(Button_MouseEnter);
                button.MouseLeave += new EventHandler(Button_MouseLeave);

                button.Click += Button_Click;
                tableLayoutPanel.Controls.Add(button);
            }

            // Configurar los botones del menú
            ConfigureButton(0, "Mitad de Pantalla Izquierda", Properties.Resources.Left, ButtonLeft_Click);
            ConfigureButton(1, "Mitad de Pantalla Derecha", Properties.Resources.Right, ButtonRight_Click);
            ConfigureButton(2, "Un Cuarto de Pantalla (Arriba - Izquierda)", Properties.Resources.Left_Top, ButtonQuarterTopLeftScreen_Click);
            ConfigureButton(3, "Un Cuarto de Pantalla (Arriba - Derecha)", Properties.Resources.Right_Top, ButtonQuarterTopRightScreen_Click);
            ConfigureButton(4, "Un Cuarto de Pantalla (Abajo - Izquierda)", Properties.Resources.Left_Bottom, ButtonQuarterLeftScreen_Click);
            ConfigureButton(5, "Un Cuarto de Pantalla (Abajo - Derecha)", Properties.Resources.Right_Bottom, ButtonQuarterRightScreen_Click);
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            // Ajustar a la mitad izquierda de la pantalla
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height);
            ownerForm.Location = new Point(0, 0);
            this.Close();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            // Ajustar a la mitad derecha de la pantalla
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height);
            ownerForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2, 0);
            Close();
        }

        private void ButtonQuarterTopLeftScreen_Click(object sender, EventArgs e)
        {
            // Ajustar a la esquina superior izquierda
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            ownerForm.Location = new Point(0, 0);
            Close();
        }

        private void ButtonQuarterTopRightScreen_Click(object sender, EventArgs e)
        {
            // Ajustar a la esquina superior derecha
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            ownerForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2, 0);
            Close();
        }

        private void ButtonQuarterLeftScreen_Click(object sender, EventArgs e)
        {
            // Ajustar a la esquina inferior izquierda
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            ownerForm.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height / 2);
            Close();
        }

        private void ButtonQuarterRightScreen_Click(object sender, EventArgs e)
        {
            // Ajustar a la esquina inferior derecha
            ownerForm.WindowState = FormWindowState.Normal;
            ownerForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            ownerForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            Close();
        }
        #endregion

        #region Eventos del Mouse
        private void Button_Click(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento click de los botones por defecto
            Button button = sender as Button;
            MessageBox.Show("Button clicked: " + button.Text);
            Close();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Iniciar el temporizador para cerrar el menú después de 2 segundos
            StartCloseMenuTimer();
        }

        public void StartCloseMenuTimer()
        {
            closeMenuTimer.Start();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Detener el temporizador cuando el mouse entra en un botón del menú
            StopCloseMenuTimer();
        }

        public void StopCloseMenuTimer()
        {
            closeMenuTimer.Stop();
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            // Detener el temporizador cuando el mouse entra en el menú
            StopCloseMenuTimer();
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            // Iniciar el temporizador para cerrar el menú después de 2 segundos
            StartCloseMenuTimer();
        }
        #endregion

        #region Métodos de Acciones
        // Método para configurar un botón específico
        public void ConfigureButton(int index, string text, Image image, EventHandler onClick)
        {
            if (index < 0 || index >= tableLayoutPanel.Controls.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Button button = tableLayoutPanel.Controls[index] as Button;
            if (button != null)
            {
                button.Text = text;
                button.Image = image;
                if (onClick != null)
                {
                    button.Click -= Button_Click; // Remover cualquier manejador anterior
                    button.Click += onClick; // Añadir el nuevo manejador
                }
            }
        }

        // Método para mostrar el menú contextual
        public void ShowMenu(Control control, Point position)
        {
            this.Show(position);
        }

        private void CloseMenuTimer_Tick(object sender, EventArgs e)
        {
            // Cerrar el menú y detener el temporizador
            Close();
            closeMenuTimer.Stop();
        }
        #endregion
    }
}