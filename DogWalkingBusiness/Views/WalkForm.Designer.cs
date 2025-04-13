namespace DogWalkingBusiness.WinFormsUI.Views
{
    partial class WalkForm
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
            txtId = new TextBox();
            dtDate = new DateTimePicker();
            lblDate = new Label();
            nmrDuration = new NumericUpDown();
            lblDuration = new Label();
            lblMinutes = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrDuration).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 37);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(82, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 1;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(82, 73);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 79);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date:";
            // 
            // nmrDuration
            // 
            nmrDuration.Location = new Point(82, 117);
            nmrDuration.Name = "nmrDuration";
            nmrDuration.Size = new Size(43, 23);
            nmrDuration.TabIndex = 4;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(12, 125);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(56, 15);
            lblDuration.TabIndex = 5;
            lblDuration.Text = "Duration:";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(131, 125);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(58, 15);
            lblMinutes.TabIndex = 6;
            lblMinutes.Text = "(minutes)";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(107, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(207, 172);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // WalkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 232);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lblMinutes);
            Controls.Add(lblDuration);
            Controls.Add(nmrDuration);
            Controls.Add(lblDate);
            Controls.Add(dtDate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "WalkForm";
            Text = "WalkForm";
            ((System.ComponentModel.ISupportInitialize)nmrDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private DateTimePicker dtDate;
        private Label lblDate;
        private NumericUpDown nmrDuration;
        private Label lblDuration;
        private Label lblMinutes;
        private Button btnSave;
        private Button btnDelete;
        private Button btnExit;
    }
}