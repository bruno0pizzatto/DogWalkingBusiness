using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;

namespace DogWalkingBusiness.WinFormsUI.Views
{
    public partial class ClientForm : Form
    {
        private readonly IClientService _clientService;
        private readonly IDogService _dogService;
        private readonly IWalkService _walkService;
        private readonly ClientDTO _clientDto; // Nullable for Add mode


        public ClientForm(IClientService clientService, IDogService dogService, IWalkService walkService)
        {
            InitializeComponent();
            _clientService = clientService;
            _dogService = dogService;
            _walkService = walkService;
            _clientDto = null;
            this.Text = "Add Client";
            isDogButtonsVisible(false);
            _dogService = dogService;
        }

        public ClientForm(IClientService clientService, IDogService dogService, IWalkService walkService, ClientDTO clientDto) : this(clientService, dogService, walkService)
        {
            _clientDto = clientDto;
            this.Text = "Edit Client";
            txtId.Text = _clientDto.Id.ToString();
            txtName.Text = _clientDto.Name;
            txtPhone.Text = _clientDto.PhoneNumber;
            LoadDogsDataAsync();
            isDogButtonsVisible(true);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var client = new ClientDTO
            {
                Id = _clientDto?.Id ?? 0,
                Name = txtName.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim()
            };

            try
            {
                await _clientService.SaveAsync(client);
                MessageBox.Show("Client saved successfully!");
                isDogButtonsVisible(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on trying to save a client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isDogButtonsVisible(false);
            }            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_clientDto?.Id > 0)
            {
                try
                {
                    await _clientService.DeleteAsync(_clientDto.Id);
                    MessageBox.Show("Client deleted successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on trying to delete a client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void LoadDogsDataAsync()
        {
            var dogs = _dogService.GetByClientIdAsync(_clientDto.Id);

            if (dogs?.Count() > 0)
                dataGridDogs.DataSource = dogs;
        }


        private void isDogButtonsVisible(bool visible)
        {
            btnEditDog.Visible = visible;
            btnAddDog.Visible = visible;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            DogDTO newDog = new DogDTO { ClientId = _clientDto.Id };
            using (var dogForm = new DogForm(newDog, _dogService, _walkService))
            {
                dogForm.ShowDialog();
                LoadDogsDataAsync();
            }
        }

        private void btnEditDog_Click(object sender, EventArgs e)
        {
            if (dataGridDogs.CurrentRow?.DataBoundItem is DogDTO selectedDog)
            {
                using (var dogForm = new DogForm(_dogService, _walkService, selectedDog))
                {
                    dogForm.ShowDialog();
                    LoadDogsDataAsync(); // Refresh list
                }
            }
            else
            {
                MessageBox.Show("Please select a dog to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
