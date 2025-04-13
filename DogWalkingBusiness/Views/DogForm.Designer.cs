namespace DogWalkingBusiness.WinFormsUI.Views
{
    partial class DogForm
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
            lblId = new Label();
            lblName = new Label();
            lblBreed = new Label();
            lblAge = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtBreed = new TextBox();
            txtAge = new TextBox();
            btnDogSave = new Button();
            btnDogDelete = new Button();
            dataGridWalks = new DataGridView();
            lblWalk = new Label();
            btnAddWalk = new Button();
            btnEditWalk = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridWalks).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(30, 124);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(40, 15);
            lblBreed.TabIndex = 2;
            lblBreed.Text = "Breed:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 163);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(99, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(99, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(99, 121);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(100, 23);
            txtBreed.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.AcceptsReturn = true;
            txtAge.Location = new Point(99, 155);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 7;
            // 
            // btnDogSave
            // 
            btnDogSave.Location = new Point(30, 206);
            btnDogSave.Name = "btnDogSave";
            btnDogSave.Size = new Size(75, 23);
            btnDogSave.TabIndex = 8;
            btnDogSave.Text = "Save";
            btnDogSave.UseVisualStyleBackColor = true;
            btnDogSave.Click += btnDogSave_Click;
            // 
            // btnDogDelete
            // 
            btnDogDelete.Location = new Point(124, 206);
            btnDogDelete.Name = "btnDogDelete";
            btnDogDelete.Size = new Size(75, 23);
            btnDogDelete.TabIndex = 9;
            btnDogDelete.Text = "Delete";
            btnDogDelete.UseVisualStyleBackColor = true;
            btnDogDelete.Click += btnDogDelete_Click;
            // 
            // dataGridWalks
            // 
            dataGridWalks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWalks.Location = new Point(275, 79);
            dataGridWalks.Name = "dataGridWalks";
            dataGridWalks.Size = new Size(271, 150);
            dataGridWalks.TabIndex = 10;
            // 
            // lblWalk
            // 
            lblWalk.AutoSize = true;
            lblWalk.Location = new Point(275, 51);
            lblWalk.Name = "lblWalk";
            lblWalk.Size = new Size(41, 15);
            lblWalk.TabIndex = 11;
            lblWalk.Text = "Walks:";
            // 
            // btnAddWalk
            // 
            btnAddWalk.Location = new Point(582, 51);
            btnAddWalk.Name = "btnAddWalk";
            btnAddWalk.Size = new Size(75, 23);
            btnAddWalk.TabIndex = 12;
            btnAddWalk.Text = "Add";
            btnAddWalk.UseVisualStyleBackColor = true;
            btnAddWalk.Click += btnWalkAdd_Click;
            // 
            // btnEditWalk
            // 
            btnEditWalk.Location = new Point(582, 87);
            btnEditWalk.Name = "btnEditWalk";
            btnEditWalk.Size = new Size(75, 23);
            btnEditWalk.TabIndex = 13;
            btnEditWalk.Text = "Edit";
            btnEditWalk.UseVisualStyleBackColor = true;
            btnEditWalk.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(582, 206);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // DogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 263);
            Controls.Add(btnExit);
            Controls.Add(btnEditWalk);
            Controls.Add(btnAddWalk);
            Controls.Add(lblWalk);
            Controls.Add(dataGridWalks);
            Controls.Add(btnDogDelete);
            Controls.Add(btnDogSave);
            Controls.Add(txtAge);
            Controls.Add(txtBreed);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblAge);
            Controls.Add(lblBreed);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "DogForm";
            Text = "DogForm";
            ((System.ComponentModel.ISupportInitialize)dataGridWalks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblBreed;
        private Label lblAge;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtBreed;
        private TextBox txtAge;
        private Button btnDogSave;
        private Button btnDogDelete;
        private DataGridView dataGridWalks;
        private Label lblWalk;
        private Button btnAddWalk;
        private Button btnEditWalk;
        private Button btnExit;
    }
}