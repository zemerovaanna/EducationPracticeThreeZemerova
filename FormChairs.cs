using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormChairs : Form
    {
        private static Warehouse warehouse;

        public FormChairs()
        {
            InitializeComponent();
            warehouse = new Warehouse();
        }

        public void RefreshList()
        {
            ListBoxChairs.Items.Clear();
            foreach (Chair chair in warehouse.GetChair().ToList())
            {
                ListBoxChairs.Items.Add(chair.GetInformation());
            }
        }

        private void FormChairs_Load(object sender, EventArgs e)
        {
            if (File.Exists("WarehouseChairs.txt"))
            {
                FurnitureLoader.Load(warehouse, "WarehouseChairs.txt");
                RefreshList();
            }
            else
            {
                MessageBox.Show("Файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExite_Click(object sender, EventArgs e)
        {
            FurnitureLoader.Save(warehouse, "WarehouseChairs.txt");
            this.Close();
        }

        private void ButtonRefreshListBox_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ButtonSearchChairName_Click(object sender, EventArgs e)
        {
            string SearchComponent = TextBoxSearchChair.Text;
            if (SearchComponent != "")
            {
                List<Chair> searchresults = warehouse.SearchChairName(warehouse, SearchComponent);
                ListBoxChairs.Items.Clear();
                foreach (Chair chair in searchresults)
                {
                    ListBoxChairs.Items.Add(chair.GetInformation());
                }
            }
        }

        private void ButtonSotrListBox_Click(object sender, EventArgs e)
        {
            ListBoxChairs.Sorted = true;
        }

        private void ButtonDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            if(ListBoxChairs.SelectedIndex != -1)
            {
                warehouse.RemoveChair(warehouse, ListBoxChairs.SelectedIndex);

                RefreshList();
            }
        }

        private void ButtonFilterPriceSearch_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(NumericUpDownFilterPrice.Value) != "")
            {
                string SearchComponent = Convert.ToString(NumericUpDownFilterPrice.Value);
                if (SearchComponent != "")
                {
                    List<Chair> searchResults = warehouse.SearchChairPrice(warehouse, SearchComponent);

                    ListBoxChairs.Items.Clear();

                    foreach (Chair chair in searchResults)
                    {
                        ListBoxChairs.Items.Add(chair.GetInformation());
                    }
                }
            }
            else
            {
                MessageBox.Show("Поле для ввода цены не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        static string CheckName(string TextName)
        {
            string message = "";

            if (TextName == "")
            {
                message = "Поле для ввода названия не может быть пустым.";
            }
            else
            {
                foreach (char symbol in TextName)
                {
                    if (!char.IsLetter(symbol) && symbol != ' ')
                    {
                        message = "Поле название может содержать только буквы.";
                        break;
                    }

                }
            }

            return message;
        }

        static string CheckTextBoxMaterial(string TextMaterial)
        {
            string message = "";

            if (TextMaterial == "")
            {
                message = "Поле для ввода материала не может быть пустым.";
            }
            else
            {
                foreach (char symbol in TextMaterial)
                {
                    if (symbol == ';')
                    {
                        message = "Поле для ввода материала не может содержать символ \';\'";
                        break;
                    }

                }
            }

            return message;
        }

        static string CheckTextBoxInt(string TextPrice, string TextCount, string TextYear)
        {
            string message = "";

            if (TextPrice == "" || TextCount == "" || TextYear == "")
            {
                message = "Поля для ввода цены, количества, и года изготовления не могут быть пустым.";
            }
            else
            {
                if (message == "")
                {
                    foreach (char symbol in TextPrice)
                    {
                        if (!char.IsDigit(symbol))
                        {
                            message = "Поле для ввода цены может содержать только положиельное целочисленное значение.";
                            break;
                        }

                    }

                    foreach (char symbol in TextCount)
                    {
                        if (!char.IsDigit(symbol))
                        {
                            message = "Поле для ввода цены может содержать только положиельное целочисленное значение.";
                            break;
                        }

                    }

                    foreach (char symbol in TextYear)
                    {
                        if (!char.IsDigit(symbol))
                        {
                            message = "Поле для ввода цены может содержать только положиельное целочисленное значение.";
                            break;
                        }

                    }
                }

                if (message == "")
                {
                    if (TextYear.Length < 4 || TextYear.Length > 4)
                    {
                        message = "Некорректное количество символов в поле года изготовления.";
                    }
                }

                if (message == "")
                {
                    if (Convert.ToInt32(TextYear) < 2000 || Convert.ToInt32(TextYear) > DateTime.Now.Year)
                    {
                        message = "Год изготовления не может быть больше текущего года и раньше 2000-ного года. На этом складе запрещено хранение антиквариата.";
                    }
                }
            }

            return message;
        }

        static void AddFurniture(string name, string price, string count, string material, string releaseyear)
        {
            Chair chair = new Chair(name, int.Parse(price), int.Parse(count), material, int.Parse(releaseyear));
            warehouse.AddChair(chair);
        }

        private void ButtonAddChairForList_Click(object sender, EventArgs e)
        {
            string name = TextBoxChairName.Text;
            string price = TextBoxChairPrice.Text;
            string count = TextBoxCountChairs.Text;
            string material = TextBoxChairMaterial.Text;
            string releaseyear = TextBoxChairReleaseYear.Text;

            string message;

            message = CheckName(name);

            if (message == "")
            {
                message = CheckTextBoxMaterial(material);

                if (message == "")
                {
                    message = CheckTextBoxInt(price, count, releaseyear);

                    if (message == "")
                    {
                        bool NotFound = warehouse.CheckContainsChair(name);
                        if (NotFound == true)
                        {
                            AddFurniture(name, price, count, material, releaseyear);
                            RefreshList();
                            MessageBox.Show("Мебель добавлена.");
                        }
                        else
                        {
                            MessageBox.Show("Такая мебель уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}