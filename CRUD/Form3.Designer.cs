namespace CRUD
{
    partial class Form3
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
            this.btnShowUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowUsuario
            // 
            this.btnShowUsuario.Location = new System.Drawing.Point(324, 192);
            this.btnShowUsuario.Name = "btnShowUsuario";
            this.btnShowUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnShowUsuario.TabIndex = 0;
            this.btnShowUsuario.Text = "Usuarios";
            this.btnShowUsuario.UseVisualStyleBackColor = true;
            this.btnShowUsuario.Click += new System.EventHandler(this.btnShowUsuario_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowUsuario);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowUsuario;
    }
}