namespace DogWalkingBusiness.WinFormsUI.Views
{
    partial class MainForm
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
            dataGridViewClients = new DataGridView();
            btnSearchClient = new Button();
            txtSearchClient = new TextBox();
            btnAddClient = new Button();
            btnEditClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(29, 86);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(370, 340);
            dataGridViewClients.TabIndex = 0;
            // 
            // btnSearchClient
            // 
            btnSearchClient.Location = new Point(324, 44);
            btnSearchClient.Name = "btnSearchClient";
            btnSearchClient.Size = new Size(75, 23);
            btnSearchClient.TabIndex = 1;
            btnSearchClient.Text = "Search";
            btnSearchClient.UseVisualStyleBackColor = true;
            btnSearchClient.Click += btnSearchClient_Click;
            // 
            // txtSearchClient
            // 
            txtSearchClient.Location = new Point(29, 44);
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.Size = new Size(289, 23);
            txtSearchClient.TabIndex = 2;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(406, 86);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(75, 23);
            btnAddClient.TabIndex = 3;
            btnAddClient.Text = "Add";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(406, 115);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(75, 23);
            btnEditClient.TabIndex = 4;
            btnEditClient.Text = "Edit";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 450);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(txtSearchClient);
            Controls.Add(btnSearchClient);
            Controls.Add(dataGridViewClients);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button btnSearchClient;
        private TextBox txtSearchClient;
        private Button btnAddClient;
        private Button btnEditClient;
    }
}