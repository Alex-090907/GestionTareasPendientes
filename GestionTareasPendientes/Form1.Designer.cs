namespace GestionTareasPendientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarTarea = new Button();
            txtTarea = new TextBox();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            btnLimpiarLista = new Button();
            SuspendLayout();
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.Blue;
            btnAgregarTarea.FlatStyle = FlatStyle.Flat;
            btnAgregarTarea.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold);
            btnAgregarTarea.ForeColor = Color.White;
            btnAgregarTarea.Location = new Point(41, 126);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(904, 84);
            btnAgregarTarea.TabIndex = 0;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // txtTarea
            // 
            txtTarea.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTarea.Location = new Point(41, 53);
            txtTarea.Multiline = true;
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(904, 50);
            txtTarea.TabIndex = 1;
            // 
            // lstTareas
            // 
            lstTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTareas.Font = new Font("Rockwell Condensed", 12F);
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(41, 226);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(904, 352);
            lstTareas.TabIndex = 2;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.Red;
            btnEliminarTarea.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarTarea.ForeColor = Color.White;
            btnEliminarTarea.Location = new Point(44, 621);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(439, 84);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.BackColor = Color.Gray;
            btnLimpiarLista.FlatStyle = FlatStyle.Flat;
            btnLimpiarLista.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold);
            btnLimpiarLista.ForeColor = Color.White;
            btnLimpiarLista.Location = new Point(506, 621);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(439, 84);
            btnLimpiarLista.TabIndex = 4;
            btnLimpiarLista.Text = "Limpiar Lista";
            btnLimpiarLista.UseVisualStyleBackColor = false;
            btnLimpiarLista.Click += btnLimpiarLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 746);
            Controls.Add(btnLimpiarLista);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(txtTarea);
            Controls.Add(btnAgregarTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarTarea;
        private TextBox txtTarea;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
        private Button btnLimpiarLista;
    }
}
