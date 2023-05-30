namespace Warehouse
{
    partial class FormChairs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextChairList = new System.Windows.Forms.Label();
            this.ListBoxChairs = new System.Windows.Forms.ListBox();
            this.PanelSearchInListBox = new System.Windows.Forms.Panel();
            this.TextBoxSearchChair = new System.Windows.Forms.TextBox();
            this.ButtonSearchChairName = new System.Windows.Forms.Button();
            this.PanelControlFurniture = new System.Windows.Forms.Panel();
            this.ButtonSotrListBox = new System.Windows.Forms.Button();
            this.ButtonDeleteSelectedItem = new System.Windows.Forms.Button();
            this.PanelControlListChairs = new System.Windows.Forms.Panel();
            this.NumericUpDownFilterPrice = new System.Windows.Forms.NumericUpDown();
            this.ButtonExite = new System.Windows.Forms.Button();
            this.ButtonRefreshListBox = new System.Windows.Forms.Button();
            this.ButtonFilterPriceSearch = new System.Windows.Forms.Button();
            this.TextValueChairsQuality = new System.Windows.Forms.Label();
            this.TextMaterialValue = new System.Windows.Forms.Label();
            this.TextValueReleaseDate = new System.Windows.Forms.Label();
            this.TextMeaningName = new System.Windows.Forms.Label();
            this.TextValueFurnitureQuality = new System.Windows.Forms.Label();
            this.TextCountValue = new System.Windows.Forms.Label();
            this.TextPriceValue = new System.Windows.Forms.Label();
            this.TextListValues = new System.Windows.Forms.Label();
            this.PanelCreateChair = new System.Windows.Forms.Panel();
            this.TextAddChairForList = new System.Windows.Forms.Label();
            this.TextBoxChairPrice = new System.Windows.Forms.TextBox();
            this.TextChairMaterial = new System.Windows.Forms.Label();
            this.TextChairReleaseYear = new System.Windows.Forms.Label();
            this.ButtonAddChairForList = new System.Windows.Forms.Button();
            this.TextCountChairs = new System.Windows.Forms.Label();
            this.TextChairPrice = new System.Windows.Forms.Label();
            this.TextBoxChairName = new System.Windows.Forms.TextBox();
            this.TextChairName = new System.Windows.Forms.Label();
            this.TextBoxChairReleaseYear = new System.Windows.Forms.TextBox();
            this.TextBoxCountChairs = new System.Windows.Forms.TextBox();
            this.TextBoxChairMaterial = new System.Windows.Forms.TextBox();
            this.TextWelcome = new System.Windows.Forms.Label();
            this.TextInformationForm = new System.Windows.Forms.Label();
            this.PanelSearchInListBox.SuspendLayout();
            this.PanelControlFurniture.SuspendLayout();
            this.PanelControlListChairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFilterPrice)).BeginInit();
            this.PanelCreateChair.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextChairList
            // 
            this.TextChairList.AutoSize = true;
            this.TextChairList.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.TextChairList.Location = new System.Drawing.Point(192, 17);
            this.TextChairList.Name = "TextChairList";
            this.TextChairList.Size = new System.Drawing.Size(207, 21);
            this.TextChairList.TabIndex = 39;
            this.TextChairList.Text = "Список на складе стульев:";
            // 
            // ListBoxChairs
            // 
            this.ListBoxChairs.BackColor = System.Drawing.Color.PapayaWhip;
            this.ListBoxChairs.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.ListBoxChairs.ForeColor = System.Drawing.Color.Sienna;
            this.ListBoxChairs.FormattingEnabled = true;
            this.ListBoxChairs.ItemHeight = 20;
            this.ListBoxChairs.Location = new System.Drawing.Point(20, 53);
            this.ListBoxChairs.Name = "ListBoxChairs";
            this.ListBoxChairs.Size = new System.Drawing.Size(569, 284);
            this.ListBoxChairs.TabIndex = 38;
            // 
            // PanelSearchInListBox
            // 
            this.PanelSearchInListBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.PanelSearchInListBox.Controls.Add(this.NumericUpDownFilterPrice);
            this.PanelSearchInListBox.Controls.Add(this.TextBoxSearchChair);
            this.PanelSearchInListBox.Controls.Add(this.ButtonSearchChairName);
            this.PanelSearchInListBox.Controls.Add(this.ButtonFilterPriceSearch);
            this.PanelSearchInListBox.Location = new System.Drawing.Point(20, 424);
            this.PanelSearchInListBox.Name = "PanelSearchInListBox";
            this.PanelSearchInListBox.Size = new System.Drawing.Size(348, 108);
            this.PanelSearchInListBox.TabIndex = 41;
            // 
            // TextBoxSearchChair
            // 
            this.TextBoxSearchChair.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxSearchChair.Location = new System.Drawing.Point(3, 12);
            this.TextBoxSearchChair.Name = "TextBoxSearchChair";
            this.TextBoxSearchChair.Size = new System.Drawing.Size(167, 36);
            this.TextBoxSearchChair.TabIndex = 1;
            // 
            // ButtonSearchChairName
            // 
            this.ButtonSearchChairName.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSearchChairName.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.ButtonSearchChairName.Location = new System.Drawing.Point(179, 12);
            this.ButtonSearchChairName.Name = "ButtonSearchChairName";
            this.ButtonSearchChairName.Size = new System.Drawing.Size(166, 36);
            this.ButtonSearchChairName.TabIndex = 7;
            this.ButtonSearchChairName.Text = "Поиск по названию";
            this.ButtonSearchChairName.UseVisualStyleBackColor = false;
            this.ButtonSearchChairName.Click += new System.EventHandler(this.ButtonSearchChairName_Click);
            // 
            // PanelControlFurniture
            // 
            this.PanelControlFurniture.BackColor = System.Drawing.Color.PapayaWhip;
            this.PanelControlFurniture.Controls.Add(this.ButtonSotrListBox);
            this.PanelControlFurniture.Controls.Add(this.ButtonDeleteSelectedItem);
            this.PanelControlFurniture.Location = new System.Drawing.Point(20, 343);
            this.PanelControlFurniture.Name = "PanelControlFurniture";
            this.PanelControlFurniture.Size = new System.Drawing.Size(348, 69);
            this.PanelControlFurniture.TabIndex = 40;
            // 
            // ButtonSotrListBox
            // 
            this.ButtonSotrListBox.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSotrListBox.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonSotrListBox.Location = new System.Drawing.Point(3, 5);
            this.ButtonSotrListBox.Name = "ButtonSotrListBox";
            this.ButtonSotrListBox.Size = new System.Drawing.Size(167, 56);
            this.ButtonSotrListBox.TabIndex = 10;
            this.ButtonSotrListBox.Text = "Сортировать список";
            this.ButtonSotrListBox.UseVisualStyleBackColor = false;
            this.ButtonSotrListBox.Click += new System.EventHandler(this.ButtonSotrListBox_Click);
            // 
            // ButtonDeleteSelectedItem
            // 
            this.ButtonDeleteSelectedItem.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonDeleteSelectedItem.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteSelectedItem.Location = new System.Drawing.Point(179, 5);
            this.ButtonDeleteSelectedItem.Name = "ButtonDeleteSelectedItem";
            this.ButtonDeleteSelectedItem.Size = new System.Drawing.Size(166, 56);
            this.ButtonDeleteSelectedItem.TabIndex = 8;
            this.ButtonDeleteSelectedItem.Text = "Удалить выбранное";
            this.ButtonDeleteSelectedItem.UseVisualStyleBackColor = false;
            this.ButtonDeleteSelectedItem.Click += new System.EventHandler(this.ButtonDeleteSelectedItem_Click);
            // 
            // PanelControlListChairs
            // 
            this.PanelControlListChairs.Controls.Add(this.ListBoxChairs);
            this.PanelControlListChairs.Controls.Add(this.ButtonExite);
            this.PanelControlListChairs.Controls.Add(this.PanelSearchInListBox);
            this.PanelControlListChairs.Controls.Add(this.ButtonRefreshListBox);
            this.PanelControlListChairs.Controls.Add(this.TextValueChairsQuality);
            this.PanelControlListChairs.Controls.Add(this.PanelControlFurniture);
            this.PanelControlListChairs.Controls.Add(this.TextChairList);
            this.PanelControlListChairs.Controls.Add(this.TextMaterialValue);
            this.PanelControlListChairs.Controls.Add(this.TextValueReleaseDate);
            this.PanelControlListChairs.Controls.Add(this.TextMeaningName);
            this.PanelControlListChairs.Controls.Add(this.TextValueFurnitureQuality);
            this.PanelControlListChairs.Controls.Add(this.TextCountValue);
            this.PanelControlListChairs.Controls.Add(this.TextPriceValue);
            this.PanelControlListChairs.Controls.Add(this.TextListValues);
            this.PanelControlListChairs.Location = new System.Drawing.Point(467, 3);
            this.PanelControlListChairs.Name = "PanelControlListChairs";
            this.PanelControlListChairs.Size = new System.Drawing.Size(609, 542);
            this.PanelControlListChairs.TabIndex = 42;
            // 
            // NumericUpDownFilterPrice
            // 
            this.NumericUpDownFilterPrice.ForeColor = System.Drawing.Color.Sienna;
            this.NumericUpDownFilterPrice.Location = new System.Drawing.Point(3, 59);
            this.NumericUpDownFilterPrice.Name = "NumericUpDownFilterPrice";
            this.NumericUpDownFilterPrice.Size = new System.Drawing.Size(167, 36);
            this.NumericUpDownFilterPrice.TabIndex = 59;
            // 
            // ButtonExite
            // 
            this.ButtonExite.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonExite.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonExite.Location = new System.Drawing.Point(404, 10);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new System.Drawing.Size(185, 33);
            this.ButtonExite.TabIndex = 50;
            this.ButtonExite.Text = "Сохранить и выйти";
            this.ButtonExite.UseVisualStyleBackColor = false;
            this.ButtonExite.Click += new System.EventHandler(this.ButtonExite_Click);
            // 
            // ButtonRefreshListBox
            // 
            this.ButtonRefreshListBox.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonRefreshListBox.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonRefreshListBox.Location = new System.Drawing.Point(20, 10);
            this.ButtonRefreshListBox.Name = "ButtonRefreshListBox";
            this.ButtonRefreshListBox.Size = new System.Drawing.Size(166, 33);
            this.ButtonRefreshListBox.TabIndex = 40;
            this.ButtonRefreshListBox.Text = "Обновить страницу";
            this.ButtonRefreshListBox.UseVisualStyleBackColor = false;
            this.ButtonRefreshListBox.Click += new System.EventHandler(this.ButtonRefreshListBox_Click);
            // 
            // ButtonFilterPriceSearch
            // 
            this.ButtonFilterPriceSearch.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonFilterPriceSearch.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonFilterPriceSearch.Location = new System.Drawing.Point(179, 59);
            this.ButtonFilterPriceSearch.Name = "ButtonFilterPriceSearch";
            this.ButtonFilterPriceSearch.Size = new System.Drawing.Size(166, 37);
            this.ButtonFilterPriceSearch.TabIndex = 43;
            this.ButtonFilterPriceSearch.Text = "Поик по цене";
            this.ButtonFilterPriceSearch.UseVisualStyleBackColor = false;
            this.ButtonFilterPriceSearch.Click += new System.EventHandler(this.ButtonFilterPriceSearch_Click);
            // 
            // TextValueChairsQuality
            // 
            this.TextValueChairsQuality.AutoSize = true;
            this.TextValueChairsQuality.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextValueChairsQuality.Location = new System.Drawing.Point(400, 508);
            this.TextValueChairsQuality.Name = "TextValueChairsQuality";
            this.TextValueChairsQuality.Size = new System.Drawing.Size(175, 24);
            this.TextValueChairsQuality.TabIndex = 58;
            this.TextValueChairsQuality.Text = "7) Качество стульев.";
            // 
            // TextMaterialValue
            // 
            this.TextMaterialValue.AutoSize = true;
            this.TextMaterialValue.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextMaterialValue.Location = new System.Drawing.Point(400, 436);
            this.TextMaterialValue.Name = "TextMaterialValue";
            this.TextMaterialValue.Size = new System.Drawing.Size(118, 24);
            this.TextMaterialValue.TabIndex = 55;
            this.TextMaterialValue.Text = "4) Материал.";
            // 
            // TextValueReleaseDate
            // 
            this.TextValueReleaseDate.AutoSize = true;
            this.TextValueReleaseDate.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextValueReleaseDate.Location = new System.Drawing.Point(400, 460);
            this.TextValueReleaseDate.Name = "TextValueReleaseDate";
            this.TextValueReleaseDate.Size = new System.Drawing.Size(181, 24);
            this.TextValueReleaseDate.TabIndex = 56;
            this.TextValueReleaseDate.Text = "5) Год изготовления.";
            // 
            // TextMeaningName
            // 
            this.TextMeaningName.AutoSize = true;
            this.TextMeaningName.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextMeaningName.Location = new System.Drawing.Point(400, 364);
            this.TextMeaningName.Name = "TextMeaningName";
            this.TextMeaningName.Size = new System.Drawing.Size(115, 24);
            this.TextMeaningName.TabIndex = 52;
            this.TextMeaningName.Text = "1) Название.";
            // 
            // TextValueFurnitureQuality
            // 
            this.TextValueFurnitureQuality.AutoSize = true;
            this.TextValueFurnitureQuality.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextValueFurnitureQuality.Location = new System.Drawing.Point(400, 484);
            this.TextValueFurnitureQuality.Name = "TextValueFurnitureQuality";
            this.TextValueFurnitureQuality.Size = new System.Drawing.Size(173, 24);
            this.TextValueFurnitureQuality.TabIndex = 57;
            this.TextValueFurnitureQuality.Text = "6) Качество мебели.";
            // 
            // TextCountValue
            // 
            this.TextCountValue.AutoSize = true;
            this.TextCountValue.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextCountValue.Location = new System.Drawing.Point(400, 412);
            this.TextCountValue.Name = "TextCountValue";
            this.TextCountValue.Size = new System.Drawing.Size(205, 24);
            this.TextCountValue.TabIndex = 54;
            this.TextCountValue.Text = "3) Количество в наборе.";
            // 
            // TextPriceValue
            // 
            this.TextPriceValue.AutoSize = true;
            this.TextPriceValue.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.TextPriceValue.Location = new System.Drawing.Point(400, 388);
            this.TextPriceValue.Name = "TextPriceValue";
            this.TextPriceValue.Size = new System.Drawing.Size(199, 24);
            this.TextPriceValue.TabIndex = 53;
            this.TextPriceValue.Text = "2) Цена за один набор.";
            // 
            // TextListValues
            // 
            this.TextListValues.AutoSize = true;
            this.TextListValues.Font = new System.Drawing.Font("Palatino Linotype", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextListValues.Location = new System.Drawing.Point(400, 340);
            this.TextListValues.Name = "TextListValues";
            this.TextListValues.Size = new System.Drawing.Size(171, 24);
            this.TextListValues.TabIndex = 51;
            this.TextListValues.Text = "Значения списка:";
            // 
            // PanelCreateChair
            // 
            this.PanelCreateChair.BackColor = System.Drawing.Color.PapayaWhip;
            this.PanelCreateChair.Controls.Add(this.TextAddChairForList);
            this.PanelCreateChair.Controls.Add(this.TextBoxChairPrice);
            this.PanelCreateChair.Controls.Add(this.TextChairMaterial);
            this.PanelCreateChair.Controls.Add(this.TextChairReleaseYear);
            this.PanelCreateChair.Controls.Add(this.ButtonAddChairForList);
            this.PanelCreateChair.Controls.Add(this.TextCountChairs);
            this.PanelCreateChair.Controls.Add(this.TextChairPrice);
            this.PanelCreateChair.Controls.Add(this.TextBoxChairName);
            this.PanelCreateChair.Controls.Add(this.TextChairName);
            this.PanelCreateChair.Controls.Add(this.TextBoxChairReleaseYear);
            this.PanelCreateChair.Controls.Add(this.TextBoxCountChairs);
            this.PanelCreateChair.Controls.Add(this.TextBoxChairMaterial);
            this.PanelCreateChair.Location = new System.Drawing.Point(14, 220);
            this.PanelCreateChair.Name = "PanelCreateChair";
            this.PanelCreateChair.Size = new System.Drawing.Size(447, 325);
            this.PanelCreateChair.TabIndex = 46;
            // 
            // TextAddChairForList
            // 
            this.TextAddChairForList.AutoSize = true;
            this.TextAddChairForList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddChairForList.Location = new System.Drawing.Point(3, 8);
            this.TextAddChairForList.Name = "TextAddChairForList";
            this.TextAddChairForList.Size = new System.Drawing.Size(390, 28);
            this.TextAddChairForList.TabIndex = 16;
            this.TextAddChairForList.Text = "Добавление информации о мебеди:";
            // 
            // TextBoxChairPrice
            // 
            this.TextBoxChairPrice.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxChairPrice.Location = new System.Drawing.Point(192, 95);
            this.TextBoxChairPrice.Name = "TextBoxChairPrice";
            this.TextBoxChairPrice.Size = new System.Drawing.Size(249, 36);
            this.TextBoxChairPrice.TabIndex = 5;
            // 
            // TextChairMaterial
            // 
            this.TextChairMaterial.AutoSize = true;
            this.TextChairMaterial.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.TextChairMaterial.Location = new System.Drawing.Point(3, 187);
            this.TextChairMaterial.Name = "TextChairMaterial";
            this.TextChairMaterial.Size = new System.Drawing.Size(118, 28);
            this.TextChairMaterial.TabIndex = 15;
            this.TextChairMaterial.Text = "Материал:";
            // 
            // TextChairReleaseYear
            // 
            this.TextChairReleaseYear.AutoSize = true;
            this.TextChairReleaseYear.Font = new System.Drawing.Font("Palatino Linotype", 12.75F);
            this.TextChairReleaseYear.Location = new System.Drawing.Point(4, 234);
            this.TextChairReleaseYear.Name = "TextChairReleaseYear";
            this.TextChairReleaseYear.Size = new System.Drawing.Size(164, 23);
            this.TextChairReleaseYear.TabIndex = 15;
            this.TextChairReleaseYear.Text = "Год изготоваления:";
            // 
            // ButtonAddChairForList
            // 
            this.ButtonAddChairForList.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAddChairForList.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonAddChairForList.Location = new System.Drawing.Point(192, 267);
            this.ButtonAddChairForList.Name = "ButtonAddChairForList";
            this.ButtonAddChairForList.Size = new System.Drawing.Size(249, 36);
            this.ButtonAddChairForList.TabIndex = 0;
            this.ButtonAddChairForList.Text = "Добавить";
            this.ButtonAddChairForList.UseVisualStyleBackColor = false;
            this.ButtonAddChairForList.Click += new System.EventHandler(this.ButtonAddChairForList_Click);
            // 
            // TextCountChairs
            // 
            this.TextCountChairs.AutoSize = true;
            this.TextCountChairs.Font = new System.Drawing.Font("Palatino Linotype", 10.75F);
            this.TextCountChairs.Location = new System.Drawing.Point(4, 153);
            this.TextCountChairs.Name = "TextCountChairs";
            this.TextCountChairs.Size = new System.Drawing.Size(183, 20);
            this.TextCountChairs.TabIndex = 14;
            this.TextCountChairs.Text = "Количество в комплекте:";
            // 
            // TextChairPrice
            // 
            this.TextChairPrice.AutoSize = true;
            this.TextChairPrice.Font = new System.Drawing.Font("Palatino Linotype", 13.75F);
            this.TextChairPrice.Location = new System.Drawing.Point(3, 105);
            this.TextChairPrice.Name = "TextChairPrice";
            this.TextChairPrice.Size = new System.Drawing.Size(173, 26);
            this.TextChairPrice.TabIndex = 13;
            this.TextChairPrice.Text = "Цена за комплект:";
            // 
            // TextBoxChairName
            // 
            this.TextBoxChairName.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxChairName.Location = new System.Drawing.Point(192, 53);
            this.TextBoxChairName.Name = "TextBoxChairName";
            this.TextBoxChairName.Size = new System.Drawing.Size(249, 36);
            this.TextBoxChairName.TabIndex = 4;
            // 
            // TextChairName
            // 
            this.TextChairName.AutoSize = true;
            this.TextChairName.Location = new System.Drawing.Point(3, 61);
            this.TextChairName.Name = "TextChairName";
            this.TextChairName.Size = new System.Drawing.Size(112, 28);
            this.TextChairName.TabIndex = 12;
            this.TextChairName.Text = "Название:";
            // 
            // TextBoxChairReleaseYear
            // 
            this.TextBoxChairReleaseYear.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxChairReleaseYear.Location = new System.Drawing.Point(192, 221);
            this.TextBoxChairReleaseYear.Name = "TextBoxChairReleaseYear";
            this.TextBoxChairReleaseYear.Size = new System.Drawing.Size(249, 36);
            this.TextBoxChairReleaseYear.TabIndex = 11;
            // 
            // TextBoxCountChairs
            // 
            this.TextBoxCountChairs.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxCountChairs.Location = new System.Drawing.Point(192, 137);
            this.TextBoxCountChairs.Name = "TextBoxCountChairs";
            this.TextBoxCountChairs.Size = new System.Drawing.Size(249, 36);
            this.TextBoxCountChairs.TabIndex = 6;
            // 
            // TextBoxChairMaterial
            // 
            this.TextBoxChairMaterial.ForeColor = System.Drawing.Color.Sienna;
            this.TextBoxChairMaterial.Location = new System.Drawing.Point(192, 179);
            this.TextBoxChairMaterial.Name = "TextBoxChairMaterial";
            this.TextBoxChairMaterial.Size = new System.Drawing.Size(249, 36);
            this.TextBoxChairMaterial.TabIndex = 11;
            // 
            // TextWelcome
            // 
            this.TextWelcome.AutoSize = true;
            this.TextWelcome.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextWelcome.Location = new System.Drawing.Point(9, 45);
            this.TextWelcome.Name = "TextWelcome";
            this.TextWelcome.Size = new System.Drawing.Size(219, 28);
            this.TextWelcome.TabIndex = 47;
            this.TextWelcome.Text = "Добро пожаловать!";
            // 
            // TextInformationForm
            // 
            this.TextInformationForm.AutoSize = true;
            this.TextInformationForm.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.TextInformationForm.Location = new System.Drawing.Point(10, 73);
            this.TextInformationForm.Name = "TextInformationForm";
            this.TextInformationForm.Size = new System.Drawing.Size(440, 17);
            this.TextInformationForm.TabIndex = 49;
            this.TextInformationForm.Text = "Здесь создаётся, редактируется и видна информация о стульях на складе.";
            // 
            // FormChairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1088, 555);
            this.ControlBox = false;
            this.Controls.Add(this.TextInformationForm);
            this.Controls.Add(this.TextWelcome);
            this.Controls.Add(this.PanelCreateChair);
            this.Controls.Add(this.PanelControlListChairs);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormChairs";
            this.Text = "Стулья на Складе.";
            this.Load += new System.EventHandler(this.FormChairs_Load);
            this.PanelSearchInListBox.ResumeLayout(false);
            this.PanelSearchInListBox.PerformLayout();
            this.PanelControlFurniture.ResumeLayout(false);
            this.PanelControlListChairs.ResumeLayout(false);
            this.PanelControlListChairs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFilterPrice)).EndInit();
            this.PanelCreateChair.ResumeLayout(false);
            this.PanelCreateChair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextChairList;
        private System.Windows.Forms.ListBox ListBoxChairs;
        private System.Windows.Forms.Button ButtonDeleteSelectedItem;
        private System.Windows.Forms.Button ButtonSotrListBox;
        private System.Windows.Forms.Panel PanelSearchInListBox;
        private System.Windows.Forms.TextBox TextBoxSearchChair;
        private System.Windows.Forms.Button ButtonSearchChairName;
        private System.Windows.Forms.Panel PanelControlFurniture;
        private System.Windows.Forms.Panel PanelControlListChairs;
        private System.Windows.Forms.Button ButtonRefreshListBox;
        private System.Windows.Forms.Button ButtonFilterPriceSearch;
        private System.Windows.Forms.Panel PanelCreateChair;
        private System.Windows.Forms.Label TextAddChairForList;
        private System.Windows.Forms.TextBox TextBoxChairPrice;
        private System.Windows.Forms.Button ButtonAddChairForList;
        private System.Windows.Forms.Label TextCountChairs;
        private System.Windows.Forms.Label TextChairPrice;
        private System.Windows.Forms.TextBox TextBoxChairName;
        private System.Windows.Forms.Label TextChairName;
        private System.Windows.Forms.TextBox TextBoxCountChairs;
        private System.Windows.Forms.TextBox TextBoxChairMaterial;
        private System.Windows.Forms.Label TextWelcome;
        private System.Windows.Forms.Label TextInformationForm;
        private System.Windows.Forms.Label TextChairMaterial;
        private System.Windows.Forms.Label TextChairReleaseYear;
        private System.Windows.Forms.TextBox TextBoxChairReleaseYear;
        private System.Windows.Forms.Button ButtonExite;
        private System.Windows.Forms.Label TextListValues;
        private System.Windows.Forms.Label TextMeaningName;
        private System.Windows.Forms.Label TextPriceValue;
        private System.Windows.Forms.Label TextCountValue;
        private System.Windows.Forms.Label TextMaterialValue;
        private System.Windows.Forms.Label TextValueReleaseDate;
        private System.Windows.Forms.Label TextValueFurnitureQuality;
        private System.Windows.Forms.Label TextValueChairsQuality;
        private System.Windows.Forms.NumericUpDown NumericUpDownFilterPrice;
    }
}

