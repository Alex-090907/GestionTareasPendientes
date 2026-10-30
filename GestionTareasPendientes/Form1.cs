namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text.Trim();

            if (string.IsNullOrEmpty(tarea))
            {
                MessageBox.Show("Por favor, escribe una tarea.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarea.Focus();
                return;
            }

            lstTareas.Items.Add(tarea);
            txtTarea.Clear();
            txtTarea.Focus();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            if (lstTareas.Items.Count == 0)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres borrar todas las tareas?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                lstTareas.Items.Clear();
            }

        }
    }
}
