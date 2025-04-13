using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Applications.Services;

namespace DogWalkingBusiness.WinFormsUI.Views
{
    public partial class MainForm : Form
    {
        private readonly IClientService _clientService;
        private readonly IDogService _dogService;
        private readonly IWalkService _walkService;

        public MainForm(IClientService clientService, IDogService dogService, IWalkService walkService)
        {
            InitializeComponent();
            _clientService = clientService;
            _dogService = dogService;
            _walkService = walkService;

            this.Load += MainForm_Load;            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var clients = await _clientService.GetAllAsync();
            dataGridViewClients.DataSource = clients;
        }

        private async void btnSearchClient_Click(object sender, EventArgs e)
        {
            var searchTerm = txtSearchClient.Text.Trim();

            var clients = string.IsNullOrEmpty(searchTerm)
                ? await _clientService.GetAllAsync()
                : await _clientService.SearchAsync(searchTerm);

            dataGridViewClients.DataSource = clients;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var clientForm = new ClientForm(_clientService, _dogService, _walkService))
            {
                clientForm.ShowDialog();
                LoadDataAsync();
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow?.DataBoundItem is ClientDTO selectedClient)
            {
                using (var clientForm = new ClientForm(_clientService, _dogService, _walkService, selectedClient))
                {
                    clientForm.ShowDialog();
                    LoadDataAsync(); // Refresh list
                }
            }
            else
            {
                MessageBox.Show("Please select a client to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
