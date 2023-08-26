namespace administradordeTareas.formularios
{
    partial class formDeTareas
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
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.tasklabel = new System.Windows.Forms.Label();
            this.addtaskGroupBox = new System.Windows.Forms.GroupBox();
            this.addtaskButton = new System.Windows.Forms.Button();
            this.addtaskTextBox = new System.Windows.Forms.TextBox();
            this.administrarTareasGroupbox = new System.Windows.Forms.GroupBox();
            this.editTaskbutton = new System.Windows.Forms.Button();
            this.deleteTaskbutton = new System.Windows.Forms.Button();
            this.editTaskLabel = new System.Windows.Forms.Label();
            this.editTasktextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estadoTareasgroupBox = new System.Windows.Forms.GroupBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoButton = new System.Windows.Forms.Button();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.posicionLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.CargoTextBox = new System.Windows.Forms.TextBox();
            this.addtaskGroupBox.SuspendLayout();
            this.administrarTareasGroupbox.SuspendLayout();
            this.estadoTareasgroupBox.SuspendLayout();
            this.userInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksListBox
            // 
            this.tasksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 23;
            this.tasksListBox.Items.AddRange(new object[] {
            "Gestión de Proyectos",
            "Atención al Cliente",
            "Contabilidad y Finanzas",
            "Recursos Humanos",
            "Marketing y Publicidad",
            "Desarrollo de Productos",
            "Gestión de Operaciones"});
            this.tasksListBox.Location = new System.Drawing.Point(23, 62);
            this.tasksListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(206, 326);
            this.tasksListBox.TabIndex = 0;
            // 
            // tasklabel
            // 
            this.tasklabel.AutoSize = true;
            this.tasklabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasklabel.Location = new System.Drawing.Point(13, 30);
            this.tasklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tasklabel.Name = "tasklabel";
            this.tasklabel.Size = new System.Drawing.Size(216, 28);
            this.tasklabel.TabIndex = 1;
            this.tasklabel.Text = "LISTADO DE TAREAS";
            // 
            // addtaskGroupBox
            // 
            this.addtaskGroupBox.Controls.Add(this.addtaskTextBox);
            this.addtaskGroupBox.Controls.Add(this.addtaskButton);
            this.addtaskGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtaskGroupBox.Location = new System.Drawing.Point(265, 12);
            this.addtaskGroupBox.Name = "addtaskGroupBox";
            this.addtaskGroupBox.Size = new System.Drawing.Size(323, 195);
            this.addtaskGroupBox.TabIndex = 2;
            this.addtaskGroupBox.TabStop = false;
            this.addtaskGroupBox.Text = "           AGREGAR TAREAS";
            // 
            // addtaskButton
            // 
            this.addtaskButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtaskButton.Location = new System.Drawing.Point(77, 133);
            this.addtaskButton.Name = "addtaskButton";
            this.addtaskButton.Size = new System.Drawing.Size(187, 37);
            this.addtaskButton.TabIndex = 0;
            this.addtaskButton.Text = "Agregar Tarea";
            this.addtaskButton.UseVisualStyleBackColor = true;
            this.addtaskButton.Click += new System.EventHandler(this.addtaskButton_Click);
            // 
            // addtaskTextBox
            // 
            this.addtaskTextBox.Location = new System.Drawing.Point(21, 62);
            this.addtaskTextBox.Name = "addtaskTextBox";
            this.addtaskTextBox.Size = new System.Drawing.Size(283, 35);
            this.addtaskTextBox.TabIndex = 1;
            // 
            // administrarTareasGroupbox
            // 
            this.administrarTareasGroupbox.Controls.Add(this.label1);
            this.administrarTareasGroupbox.Controls.Add(this.editTasktextBox);
            this.administrarTareasGroupbox.Controls.Add(this.editTaskLabel);
            this.administrarTareasGroupbox.Controls.Add(this.deleteTaskbutton);
            this.administrarTareasGroupbox.Controls.Add(this.editTaskbutton);
            this.administrarTareasGroupbox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarTareasGroupbox.Location = new System.Drawing.Point(265, 257);
            this.administrarTareasGroupbox.Name = "administrarTareasGroupbox";
            this.administrarTareasGroupbox.Size = new System.Drawing.Size(323, 261);
            this.administrarTareasGroupbox.TabIndex = 3;
            this.administrarTareasGroupbox.TabStop = false;
            this.administrarTareasGroupbox.Text = "      ADMINISTRAR TAREAS";
            // 
            // editTaskbutton
            // 
            this.editTaskbutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.editTaskbutton.Location = new System.Drawing.Point(77, 132);
            this.editTaskbutton.Name = "editTaskbutton";
            this.editTaskbutton.Size = new System.Drawing.Size(187, 47);
            this.editTaskbutton.TabIndex = 0;
            this.editTaskbutton.Text = "Editar Tarea";
            this.editTaskbutton.UseVisualStyleBackColor = true;
            this.editTaskbutton.Click += new System.EventHandler(this.editTaskbutton_Click);
            // 
            // deleteTaskbutton
            // 
            this.deleteTaskbutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.deleteTaskbutton.Location = new System.Drawing.Point(77, 207);
            this.deleteTaskbutton.Name = "deleteTaskbutton";
            this.deleteTaskbutton.Size = new System.Drawing.Size(187, 45);
            this.deleteTaskbutton.TabIndex = 1;
            this.deleteTaskbutton.Text = "Eliminar Tarea";
            this.deleteTaskbutton.UseVisualStyleBackColor = true;
            this.deleteTaskbutton.Click += new System.EventHandler(this.deleteTaskbutton_Click);
            // 
            // editTaskLabel
            // 
            this.editTaskLabel.AutoSize = true;
            this.editTaskLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskLabel.Location = new System.Drawing.Point(72, 46);
            this.editTaskLabel.Name = "editTaskLabel";
            this.editTaskLabel.Size = new System.Drawing.Size(210, 28);
            this.editTaskLabel.TabIndex = 2;
            this.editTaskLabel.Text = "CAMBIAR SELECCION ";
            // 
            // editTasktextBox
            // 
            this.editTasktextBox.Location = new System.Drawing.Point(21, 91);
            this.editTasktextBox.Name = "editTasktextBox";
            this.editTasktextBox.Size = new System.Drawing.Size(283, 35);
            this.editTasktextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 4;
            // 
            // estadoTareasgroupBox
            // 
            this.estadoTareasgroupBox.Controls.Add(this.estadoButton);
            this.estadoTareasgroupBox.Controls.Add(this.estadoComboBox);
            this.estadoTareasgroupBox.Controls.Add(this.estadoLabel);
            this.estadoTareasgroupBox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTareasgroupBox.Location = new System.Drawing.Point(655, 12);
            this.estadoTareasgroupBox.Name = "estadoTareasgroupBox";
            this.estadoTareasgroupBox.Size = new System.Drawing.Size(320, 183);
            this.estadoTareasgroupBox.TabIndex = 4;
            this.estadoTareasgroupBox.TabStop = false;
            this.estadoTareasgroupBox.Text = "                  ESTADO";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLabel.Location = new System.Drawing.Point(22, 40);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(273, 25);
            this.estadoLabel.TabIndex = 0;
            this.estadoLabel.Text = "Seleccione el estado de la tarea";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(27, 82);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(268, 36);
            this.estadoComboBox.TabIndex = 1;
            // 
            // estadoButton
            // 
            this.estadoButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoButton.Location = new System.Drawing.Point(82, 124);
            this.estadoButton.Name = "estadoButton";
            this.estadoButton.Size = new System.Drawing.Size(150, 43);
            this.estadoButton.TabIndex = 2;
            this.estadoButton.Text = "Agregar";
            this.estadoButton.UseVisualStyleBackColor = true;
            this.estadoButton.Click += new System.EventHandler(this.estadoButton_Click);
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.Controls.Add(this.CargoTextBox);
            this.userInfoGroupBox.Controls.Add(this.nombreTextBox);
            this.userInfoGroupBox.Controls.Add(this.posicionLabel);
            this.userInfoGroupBox.Controls.Add(this.nameLabel);
            this.userInfoGroupBox.Controls.Add(this.addInfoButton);
            this.userInfoGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoGroupBox.Location = new System.Drawing.Point(655, 201);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(322, 317);
            this.userInfoGroupBox.TabIndex = 5;
            this.userInfoGroupBox.TabStop = false;
            this.userInfoGroupBox.Text = "    INFORMACION DEL USUARIO";
            // 
            // addInfoButton
            // 
            this.addInfoButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInfoButton.Location = new System.Drawing.Point(82, 228);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(150, 38);
            this.addInfoButton.TabIndex = 0;
            this.addInfoButton.Text = "Agregar";
            this.addInfoButton.UseVisualStyleBackColor = true;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(120, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre";
            // 
            // posicionLabel
            // 
            this.posicionLabel.AutoSize = true;
            this.posicionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicionLabel.Location = new System.Drawing.Point(77, 132);
            this.posicionLabel.Name = "posicionLabel";
            this.posicionLabel.Size = new System.Drawing.Size(171, 25);
            this.posicionLabel.TabIndex = 3;
            this.posicionLabel.Text = "Posicion de trabajo";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(63, 70);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(185, 32);
            this.nombreTextBox.TabIndex = 4;
            // 
            // CargoTextBox
            // 
            this.CargoTextBox.Location = new System.Drawing.Point(63, 176);
            this.CargoTextBox.Name = "CargoTextBox";
            this.CargoTextBox.Size = new System.Drawing.Size(185, 32);
            this.CargoTextBox.TabIndex = 6;
            // 
            // formDeTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.userInfoGroupBox);
            this.Controls.Add(this.estadoTareasgroupBox);
            this.Controls.Add(this.administrarTareasGroupbox);
            this.Controls.Add(this.addtaskGroupBox);
            this.Controls.Add(this.tasklabel);
            this.Controls.Add(this.tasksListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formDeTareas";
            this.Text = "formDeTareas";
            this.addtaskGroupBox.ResumeLayout(false);
            this.addtaskGroupBox.PerformLayout();
            this.administrarTareasGroupbox.ResumeLayout(false);
            this.administrarTareasGroupbox.PerformLayout();
            this.estadoTareasgroupBox.ResumeLayout(false);
            this.estadoTareasgroupBox.PerformLayout();
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Label tasklabel;
        private System.Windows.Forms.GroupBox addtaskGroupBox;
        private System.Windows.Forms.Button addtaskButton;
        private System.Windows.Forms.TextBox addtaskTextBox;
        private System.Windows.Forms.GroupBox administrarTareasGroupbox;
        private System.Windows.Forms.TextBox editTasktextBox;
        private System.Windows.Forms.Label editTaskLabel;
        private System.Windows.Forms.Button deleteTaskbutton;
        private System.Windows.Forms.Button editTaskbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox estadoTareasgroupBox;
        private System.Windows.Forms.Button estadoButton;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label posicionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addInfoButton;
        private System.Windows.Forms.TextBox CargoTextBox;
    }
}