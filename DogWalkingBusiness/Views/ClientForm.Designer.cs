namespace DogWalkingBusiness.WinFormsUI.Views
{
    partial class ClientForm
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
            btnSave = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dataGridDogs = new DataGridView();
            lblId = new Label();
            lblName = new Label();
            lblPhone = new Label();
            btnAddDog = new Button();
            btnEditDog = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            lblDogs = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridDogs).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(39, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(145, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(586, 157);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridDogs
            // 
            dataGridDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDogs.Location = new Point(244, 51);
            dataGridDogs.Name = "dataGridDogs";
            dataGridDogs.Size = new Size(331, 131);
            dataGridDogs.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Id:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(23, 113);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // btnAddDog
            // 
            btnAddDog.Location = new Point(586, 51);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(75, 23);
            btnAddDog.TabIndex = 7;
            btnAddDog.Text = "Add";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += btnAddDog_Click;
            // 
            // btnEditDog
            // 
            btnEditDog.Location = new Point(586, 80);
            btnEditDog.Name = "btnEditDog";
            btnEditDog.Size = new Size(75, 23);
            btnEditDog.TabIndex = 8;
            btnEditDog.Text = "Edit";
            btnEditDog.UseVisualStyleBackColor = true;
            btnEditDog.Click += btnEditDog_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(71, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(71, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(71, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 11;
            // 
            // lblDogs
            // 
            lblDogs.AutoSize = true;
            lblDogs.Location = new Point(244, 29);
            lblDogs.Name = "lblDogs";
            lblDogs.Size = new Size(34, 15);
            lblDogs.TabIndex = 12;
            lblDogs.Text = "Dogs";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 203);
            Controls.Add(lblDogs);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnEditDog);
            Controls.Add(btnAddDog);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(dataGridDogs);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)dataGridDogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dataGridDogs;
        private Label lblId;
        private Label lblName;
        private Label lblPhone;
        private Button btnAddDog;
        private Button btnEditDog;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label lblDogs;
    }
}