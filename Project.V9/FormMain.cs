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
                    for (int i = 0; i < data[0].Length; i++)
                    {
                        if (i == 0)
                        {
                            dataGridViewVideos_EIH.Columns.Add("Код видеоленты", "Код видеоленты");
                        }
                        else if (i == 1)
                        {
                            dataGridViewVideos_EIH.Columns.Add("Дата", "Дата");
                        }
                        else if (i == 2)
                        {
                        dataGridViewVideos_EIH.Columns.Add("Длительность", "Длительность, сек.");
                        }
                        else if (i == 3)
                        {
                        dataGridViewVideos_EIH.Columns.Add("Тема", "Тема");
                        }
                        else if (i == 4)
                        {
                        dataGridViewVideos_EIH.Columns.Add("Цена", "Цена, руб.");
                        }
                        else if (i == 5)
                        {
                        dataGridViewVideos_EIH.Columns.Add("ФИО актера", "ФИО актера");
                        }
                        else if (i == 6)
                        {
                        dataGridViewVideos_EIH.Columns.Add("Амплуа актера", "Амплуа актера");
                        }
                    }

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
    }
}
