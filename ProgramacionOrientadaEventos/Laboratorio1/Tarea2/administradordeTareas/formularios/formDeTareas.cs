using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradordeTareas.formularios
{
    public partial class formDeTareas : Form
    {
        public formDeTareas()
        {
            InitializeComponent();
            InitializeestadoComboBox();
        }

        private void InitializeestadoComboBox()
        {
            estadoComboBox.Items.AddRange(Enum.GetNames(typeof(estadoTareas)));
            estadoComboBox.SelectedIndex = 0; 
        }
        

        private void addtaskButton_Click(object sender, EventArgs e)
        {
            tasksListBox.Items.Add(addtaskTextBox.Text);



        }

        private void deleteTaskbutton_Click(object sender, EventArgs e)
        {
            tasksListBox.Items.Remove(tasksListBox.SelectedItem);
        }

        private void editTaskbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editTasktextBox.Text) || string.IsNullOrWhiteSpace(editTasktextBox.Text))
            {
                MessageBox.Show("Ingresa el nuevo valor para modificar.");
                return;
            }
            int indice = tasksListBox.SelectedIndex;
            if (indice >= 0 && indice < tasksListBox.Items.Count)
            {
                tasksListBox.Items[indice] = editTasktextBox.Text;
            }
            else
            {
                MessageBox.Show("Selecciona un evento para modificar.");
            }
        }

        private void addInfoButton_Click(object sender, EventArgs e)
        {
            tasksListBox.Items.Add(nombreTextBox.Text);
            tasksListBox.Items.Add(CargoTextBox.Text);
        }

        private void estadoButton_Click(object sender, EventArgs e)
        {
            tasksListBox.Items.Add(addtaskTextBox.Text);

        }
    }
}
