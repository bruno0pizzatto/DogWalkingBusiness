using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Applications.Services;
using System.Drawing.Drawing2D;


namespace DogWalkingBusiness.WinFormsUI.Views
{
    public partial class DogForm : Form
    {
        private readonly IDogService _dogService;
        private readonly IWalkService _walkService;
        private readonly DogDTO _dogDto; // Nullable for Add mode

        public DogForm(DogDTO dogDto, IDogService dogService, IWalkService walkService)
        {
            InitializeComponent();
            _dogService = dogService;
            _dogDto = dogDto;
            this.Text = "Add Dog";
            _dogService = dogService;
            isWalkButtonsVisible(false);
            _walkService = walkService;
        }

        public DogForm(IDogService dogService, IWalkService walkService, DogDTO dogDto) : this(dogDto, dogService, walkService)
        {
            _dogDto = dogDto;
            this.Text = "Edit dog";
            txtId.Text = dogDto.Id.ToString();
            txtName.Text = dogDto.Name;
            txtBreed.Text = dogDto.Breed;
            txtAge.Text = dogDto.Age.ToString();
            isWalkButtonsVisible(true);
            LoadWalksDataAsync();
        }

        private async void btnDogSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtBreed.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dog = new DogDTO
            {
                Id = _dogDto?.Id ?? 0,
                ClientId = _dogDto.ClientId,
                Name = txtName.Text.Trim(),
                Breed = txtBreed.Text.Trim(),
                Age = Convert.ToInt32(txtAge.Text)
            };

            try
            {
                await _dogService.SaveAsync(dog);
                MessageBox.Show("Dog saved successfully!");
                isWalkButtonsVisible(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on trying to save a dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isWalkButtonsVisible(false);
            }            
        }

        private async void btnDogDelete_Click(object sender, EventArgs e)
        {
            if (_dogDto?.Id > 0)
            {
                try
                {
                    await _dogService.DeleteAsync(_dogDto.Id);
                    MessageBox.Show("Dog deleted successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on trying to delete a Dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnWalkAdd_Click(object sender, EventArgs e)
        {
            WalkDTO newWalk = new WalkDTO { DogId = _dogDto.Id };
            using (var walkForm = new WalkForm(newWalk, _walkService))
            {
                walkForm.ShowDialog();
                LoadWalksDataAsync();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridWalks.CurrentRow?.DataBoundItem is WalkDTO selectedDog)
            {
                using (var walkForm = new WalkForm(_walkService, selectedDog))
                {
                    walkForm.ShowDialog();
                    LoadWalksDataAsync(); // Refresh list
                }
            }
            else
            {
                MessageBox.Show("Please select a walk to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadWalksDataAsync()
        {
            var walks = await _walkService.GetByDogIdAsync(_dogDto.Id);

            if (walks?.Count() > 0)
                dataGridWalks.DataSource = walks;
        }
        private void isWalkButtonsVisible(bool visible)
        {
            btnEditWalk.Visible = visible;
            btnAddWalk.Visible = visible;
        }
    }
}
