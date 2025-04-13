using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Applications.Services;
using System.Xml.Linq;

namespace DogWalkingBusiness.WinFormsUI.Views
{
    public partial class WalkForm : Form
    {
        private readonly IWalkService _walkService;
        private readonly WalkDTO _walkDto; // Nullable for Add mode

        public WalkForm(WalkDTO walkDto, IWalkService walkService)
        {
            InitializeComponent();
            _walkDto = walkDto;
            this.Text = "Add Walk";
            _walkService = walkService;
        }

        public WalkForm(IWalkService walkService, WalkDTO walkDto) : this(walkDto, walkService)
        {
            _walkDto = walkDto;
            this.Text = "Edit dog";
            txtId.Text = walkDto.Id.ToString();
            dtDate.Value = walkDto.WalkDate;
            nmrDuration.Value = (decimal)walkDto.Duration.TotalMinutes;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblDate.Text) || string.IsNullOrWhiteSpace(nmrDuration.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var walk = new WalkDTO
            {
                Id = _walkDto?.Id ?? 0,
                DogId = _walkDto.DogId,
                WalkDate =dtDate.Value,
                Duration = TimeSpan.FromMinutes((long)nmrDuration.Value),                
            };

            try
            {
                await _walkService.SaveAsync(walk);
                MessageBox.Show("Walk saved successfully!");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on trying to save a walk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_walkDto?.Id > 0)
            {
                try
                {
                    await _walkService.DeleteAsync(_walkDto.Id);
                    MessageBox.Show("Walk deleted successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on trying to delete an Walk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
