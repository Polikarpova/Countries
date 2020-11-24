using System;
using System.Windows.Forms;
using Countries.Iterfaces;

namespace Countries.View
{
    public partial class UpdateConfig : Form
    {
        private ILogic logicManager;

        public UpdateConfig(ILogic manager, ConfigData data)
        {
            InitializeComponent();

            logicManager = manager;

            ServerText.Text = data.Server;
            UserText.Text = data.User;
            DatabaseText.Text = data.Database;
            PasswordText.Text = data.Password;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ConfigData data = new ConfigData(ServerText.Text, UserText.Text, DatabaseText.Text, PasswordText.Text);

            logicManager.UpdateConfig(data);

            string errorMessage = "";
            logicManager.CheckConnectToDatabase(out errorMessage);

            if (errorMessage == "")
            {
                Close();
                return;
            }

            MessageBox.Show(errorMessage, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
