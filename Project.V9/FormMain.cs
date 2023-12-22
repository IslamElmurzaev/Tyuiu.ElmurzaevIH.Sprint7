using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_EIH_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAddVideo_EIH_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }

        private void buttonOpenFile_EIH_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Выберите файл CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Чтение данных из CSV файла
                string filePath = openFileDialog.FileName;
                List<string[]> data = ReadCSV(filePath);

                // Очистить DataGridView перед загрузкой новых данных
                dataGridViewVideos_EIH.Rows.Clear();
                dataGridViewVideos_EIH.Columns.Clear();

                // Добавить колонки в DataGridView
                if (data.Count > 0)
                {       
                    dataGridViewVideos_EIH.Columns.Add("Код видеоленты", "Код видеоленты");
                    dataGridViewVideos_EIH.Columns.Add("Дата", "Дата");
                    dataGridViewVideos_EIH.Columns.Add("Длительность, сек.", "Длительность, сек.");
                    dataGridViewVideos_EIH.Columns.Add("Тема", "Тема");
                    dataGridViewVideos_EIH.Columns.Add("Цена, руб.", "Цена, руб.");
                    dataGridViewVideos_EIH.Columns.Add("ФИО актера", "ФИО актера");                        
                    dataGridViewVideos_EIH.Columns.Add("Амплуа актера", "Амплуа актера");
 
                    // Добавить строки в DataGridView
                    foreach (var row in data)
                    {
                        dataGridViewVideos_EIH.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Файл CSV не содержит данных.", "Пустой файл");
                }
            }

            ConvertStringColToInt("Длительность, сек.");
            ConvertStringColToInt("Цена, руб.");

        }

        private List<string[]> ReadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(';');

                        data.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении CSV файла: " + ex.Message, "Ошибка");
            }

            return data;
        }

        private void textBoxSearch_EIH_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = textBoxSearch_EIH.Text.ToLower();
            if (searchKeyword.Length == 0 )
            {
                return;
            }
            
            foreach (DataGridViewRow row in dataGridViewVideos_EIH.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool rowVisible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchKeyword.ToLower()))
                        {
                            rowVisible = true;
                            break;
                        }
                    }
                    row.Visible = rowVisible;
                }
            }
        }

        private void ConvertStringColToInt(string colName)
        {
            foreach (DataGridViewRow row in dataGridViewVideos_EIH.Rows)
            {
                object cellValue = row.Cells[colName].Value;

                if (cellValue != null)
                {
                    string stringValue = cellValue.ToString();
                    if (int.TryParse(stringValue, out int intValue))
                    {
                        row.Cells[colName].Value = intValue;
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка преобразования в строке {row.Index + 1}");
                    }
                }
            }
        }
    }
}
