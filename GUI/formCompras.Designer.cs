using System.Windows.Forms;

namespace GUI
{
    partial class formCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            #region contenedores principales
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCentrado = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.panelPrincipal.Controls.Add(this.panelCentrado);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1261, 741);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelCentrado
            // 
            this.panelCentrado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentrado.Location = new System.Drawing.Point(0, 0);
            this.panelCentrado.Name = "panelCentrado";
            this.panelCentrado.Size = new System.Drawing.Size(1261, 741);
            this.panelCentrado.TabIndex = 0;
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "formCompras";
            this.Text = "formCompras";
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            #endregion
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelCentrado;
        
    }

}