using DogWalkingBusiness.Applications.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkingBusiness.WinFormsUI.Views
{
    public partial class MainForm: Form
    {
        private readonly IClientService _clientService;
        //private readonly IDogService _dogService;

        public MainForm(IClientService clientService/*, IDogService dogService*/)
        {
            InitializeComponent();
            _clientService = clientService;
            //_dogService = dogService;

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
    }
}
