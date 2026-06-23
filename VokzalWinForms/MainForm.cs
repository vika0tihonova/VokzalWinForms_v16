using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace VokzalWinForms
{


    public partial class MainForm : Form
    {
        private string dbPath;
        private string connectionString;
        private string currentTable = "РаботникиВокзала";

        private DataTable dataTable;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder commandBuilder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string fileWithPath = Path.Combine(Application.StartupPath, "db_path.txt");

            if (File.Exists(fileWithPath))
            {
                dbPath = File.ReadAllText(fileWithPath);
            }
            else
            {
                dbPath = Path.Combine(Application.StartupPath, "vokzal.accdb");
            }

            connectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + dbPath + ";Persist Security Info=False;";
            statusLabel.Text = "База данных: " + dbPath;

            LoadTable(currentTable);
        }

        private void LoadTable(string tableName)
        {
            currentTable = tableName;
            searchTextBox.Text = "";

            string sql = "SELECT * FROM [" + currentTable + "]";

            adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            commandBuilder = new OleDbCommandBuilder(adapter);

            dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            titleLabel.Text = "Информационная система железнодорожного вокзала — " + tableName;
        }

        private void SaveTable()
        {
            dataGridView1.EndEdit();
            adapter.Update(dataTable);
            LoadTable(currentTable);
            MessageBox.Show("Изменения сохранены.");
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            LoadTable("РаботникиВокзала");
        }

        private void trainsButton_Click(object sender, EventArgs e)
        {
            LoadTable("Поезда");
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            LoadTable("РасписаниеДвиженияПоездов");
        }

        private void brigadesButton_Click(object sender, EventArgs e)
        {
            LoadTable("БригадыПоездов");
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            LoadTable("ВедомостьПродажиБилетов");
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTable(currentTable);
        }

        private void chooseDbButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Access database (*.accdb)|*.accdb";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dbPath = dialog.FileName;
                connectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + dbPath + ";Persist Security Info=False;";

                File.WriteAllText(Path.Combine(Application.StartupPath, "db_path.txt"), dbPath);
                statusLabel.Text = "База данных: " + dbPath;

                LoadTable(currentTable);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataTable == null)
            {
                return;
            }

            string text = searchTextBox.Text.Replace("'", "''");

            if (text == "")
            {
                dataTable.DefaultView.RowFilter = "";
                return;
            }

            string filter = "";

            foreach (DataColumn column in dataTable.Columns)
            {
                if (filter != "")
                {
                    filter += " OR ";
                }

                filter += "CONVERT([" + column.ColumnName + "], 'System.String') LIKE '%" + text + "%'";
            }

            dataTable.DefaultView.RowFilter = filter;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
