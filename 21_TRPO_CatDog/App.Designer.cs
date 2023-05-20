namespace _21_TRPO_CatDog
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage5 = new TabPage();
            buttonAddPet = new Button();
            tabControl3 = new TabControl();
            tabPage7 = new TabPage();
            label5 = new Label();
            comboBoxKind = new ComboBox();
            label4 = new Label();
            comboBoxPoroda = new ComboBox();
            label3 = new Label();
            comboBoxSex = new ComboBox();
            label2 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            label1 = new Label();
            textBoxKlichka = new TextBox();
            tabPage8 = new TabPage();
            textBoxReason = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerDateCall = new DateTimePicker();
            label6 = new Label();
            textBoxFIOOwner = new TextBox();
            tabPage6 = new TabPage();
            label12 = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewVet = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            buttonAddDir = new Button();
            dataGridViewDir = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            tabControlDir = new TabControl();
            tabPage9 = new TabPage();
            label9 = new Label();
            textBoxAnimalKind = new TextBox();
            tabPage10 = new TabPage();
            label10 = new Label();
            textBoxBreed = new TextBox();
            tabPage4 = new TabPage();
            label11 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label13 = new Label();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVet).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartReport).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).BeginInit();
            tabControlDir.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Controls.Add(tabPage4);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(803, 451);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(dataGridViewVet);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ветлечебница";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Location = new Point(1, 2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(243, 421);
            tabControl2.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(buttonAddPet);
            tabPage5.Controls.Add(tabControl3);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(235, 393);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Добавление";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonAddPet
            // 
            buttonAddPet.Location = new Point(6, 364);
            buttonAddPet.Name = "buttonAddPet";
            buttonAddPet.Size = new Size(223, 23);
            buttonAddPet.TabIndex = 3;
            buttonAddPet.Text = "Добавить питомца";
            buttonAddPet.UseVisualStyleBackColor = true;
            buttonAddPet.Click += buttonAddPet_Click;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Controls.Add(tabPage8);
            tabControl3.Location = new Point(1, 3);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(234, 355);
            tabControl3.TabIndex = 2;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label5);
            tabPage7.Controls.Add(comboBoxKind);
            tabPage7.Controls.Add(label4);
            tabPage7.Controls.Add(comboBoxPoroda);
            tabPage7.Controls.Add(label3);
            tabPage7.Controls.Add(comboBoxSex);
            tabPage7.Controls.Add(label2);
            tabPage7.Controls.Add(dateTimePickerDOB);
            tabPage7.Controls.Add(label1);
            tabPage7.Controls.Add(textBoxKlichka);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(226, 327);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "Данные о питомце";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 93);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Вид";
            // 
            // comboBoxKind
            // 
            comboBoxKind.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKind.FormattingEnabled = true;
            comboBoxKind.Location = new Point(6, 111);
            comboBoxKind.Name = "comboBoxKind";
            comboBoxKind.Size = new Size(214, 23);
            comboBoxKind.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 181);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Порода";
            // 
            // comboBoxPoroda
            // 
            comboBoxPoroda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPoroda.FormattingEnabled = true;
            comboBoxPoroda.Location = new Point(6, 199);
            comboBoxPoroda.Name = "comboBoxPoroda";
            comboBoxPoroda.Size = new Size(214, 23);
            comboBoxPoroda.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 137);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Пол";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Муж.", "Жен.", "Гермафродит" });
            comboBoxSex.Location = new Point(6, 155);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(214, 23);
            comboBoxSex.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата рождения";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(6, 67);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(214, 23);
            dateTimePickerDOB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Кличка";
            // 
            // textBoxKlichka
            // 
            textBoxKlichka.Location = new Point(6, 23);
            textBoxKlichka.Name = "textBoxKlichka";
            textBoxKlichka.Size = new Size(214, 23);
            textBoxKlichka.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(textBoxReason);
            tabPage8.Controls.Add(label8);
            tabPage8.Controls.Add(label7);
            tabPage8.Controls.Add(dateTimePickerDateCall);
            tabPage8.Controls.Add(label6);
            tabPage8.Controls.Add(textBoxFIOOwner);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(226, 327);
            tabPage8.TabIndex = 1;
            tabPage8.Text = "Остальное";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(6, 109);
            textBoxReason.Multiline = true;
            textBoxReason.Name = "textBoxReason";
            textBoxReason.ScrollBars = ScrollBars.Both;
            textBoxReason.Size = new Size(214, 212);
            textBoxReason.TabIndex = 12;
            textBoxReason.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 11;
            label8.Text = "Причина обращения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(171, 15);
            label7.TabIndex = 5;
            label7.Text = "Дата обращения в лечебницу";
            // 
            // dateTimePickerDateCall
            // 
            dateTimePickerDateCall.Location = new Point(6, 65);
            dateTimePickerDateCall.Name = "dateTimePickerDateCall";
            dateTimePickerDateCall.Size = new Size(214, 23);
            dateTimePickerDateCall.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 2;
            label6.Text = "ФИО хозяина";
            // 
            // textBoxFIOOwner
            // 
            textBoxFIOOwner.Location = new Point(6, 21);
            textBoxFIOOwner.Name = "textBoxFIOOwner";
            textBoxFIOOwner.Size = new Size(214, 23);
            textBoxFIOOwner.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(buttonUpdate);
            tabPage6.Controls.Add(buttonDelete);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(235, 393);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Редактор";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.Size = new Size(216, 75);
            label12.TabIndex = 6;
            label12.Text = "Чтобы отредактировать запись,\r\nотредактируй ячейку в самом гриде\r\nи нажми обновить.\r\nЧтобы удалить - нажми на заголовок \r\nстрочки и нажми удалить";
            // 
            // buttonUpdate
            // 
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(6, 335);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(223, 23);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(6, 364);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(223, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewVet
            // 
            dataGridViewVet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVet.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column9 });
            dataGridViewVet.Location = new Point(250, 6);
            dataGridViewVet.Name = "dataGridViewVet";
            dataGridViewVet.RowTemplate.Height = 25;
            dataGridViewVet.Size = new Size(539, 411);
            dataGridViewVet.TabIndex = 0;
            dataGridViewVet.RowHeaderMouseDoubleClick += dataGridViewVet_RowHeaderMouseDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Кличка";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Дата рождения";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Вид";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Пол";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Порода";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "ФИО хозяина";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Дата обращения";
            Column7.Name = "Column7";
            // 
            // Column9
            // 
            Column9.HeaderText = "Причина";
            Column9.Name = "Column9";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(chartReport);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отчет";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartReport.Legends.Add(legend1);
            chartReport.Location = new Point(6, 6);
            chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartReport.Series.Add(series1);
            chartReport.Size = new Size(778, 411);
            chartReport.TabIndex = 0;
            chartReport.Text = "chart1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonAddDir);
            tabPage3.Controls.Add(dataGridViewDir);
            tabPage3.Controls.Add(tabControlDir);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(795, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Справочник";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAddDir
            // 
            buttonAddDir.Location = new Point(6, 391);
            buttonAddDir.Name = "buttonAddDir";
            buttonAddDir.Size = new Size(238, 23);
            buttonAddDir.TabIndex = 4;
            buttonAddDir.Text = "Добавить";
            buttonAddDir.UseVisualStyleBackColor = true;
            buttonAddDir.Click += buttonAddDir_Click;
            // 
            // dataGridViewDir
            // 
            dataGridViewDir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDir.Columns.AddRange(new DataGridViewColumn[] { Column8 });
            dataGridViewDir.Location = new Point(250, 3);
            dataGridViewDir.Name = "dataGridViewDir";
            dataGridViewDir.RowTemplate.Height = 25;
            dataGridViewDir.Size = new Size(539, 411);
            dataGridViewDir.TabIndex = 1;
            // 
            // Column8
            // 
            Column8.HeaderText = "Значение";
            Column8.Name = "Column8";
            // 
            // tabControlDir
            // 
            tabControlDir.Controls.Add(tabPage9);
            tabControlDir.Controls.Add(tabPage10);
            tabControlDir.Location = new Point(3, 3);
            tabControlDir.Name = "tabControlDir";
            tabControlDir.SelectedIndex = 0;
            tabControlDir.Size = new Size(241, 382);
            tabControlDir.TabIndex = 0;
            tabControlDir.SelectedIndexChanged += tabControlDir_SelectedIndexChanged;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(label9);
            tabPage9.Controls.Add(textBoxAnimalKind);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(233, 354);
            tabPage9.TabIndex = 0;
            tabPage9.Text = "Вид животного";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 4;
            label9.Text = "Значение";
            // 
            // textBoxAnimalKind
            // 
            textBoxAnimalKind.Location = new Point(6, 21);
            textBoxAnimalKind.Name = "textBoxAnimalKind";
            textBoxAnimalKind.Size = new Size(221, 23);
            textBoxAnimalKind.TabIndex = 3;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(label10);
            tabPage10.Controls.Add(textBoxBreed);
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(233, 354);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "Порода";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 3);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 6;
            label10.Text = "Значение";
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(6, 21);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(221, 23);
            textBoxBreed.TabIndex = 5;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(795, 423);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Справка";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 3);
            label11.Name = "label11";
            label11.Size = new Size(383, 15);
            label11.TabIndex = 4;
            label11.Text = "Чтобы узнать причину обращения, дабл клик по заголовку строчки";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 3);
            label13.Name = "label13";
            label13.Size = new Size(127, 15);
            label13.TabIndex = 5;
            label13.Text = "Причины обращения";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "App";
            Text = "Vet";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVet).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartReport).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).EndInit();
            tabControlDir.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dataGridViewVet;
        private TabControl tabControl3;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button buttonAddPet;
        private Label label2;
        private DateTimePicker dateTimePickerDOB;
        private Label label1;
        private TextBox textBoxKlichka;
        private Label label4;
        private ComboBox comboBoxPoroda;
        private Label label3;
        private ComboBox comboBoxSex;
        private Label label5;
        private ComboBox comboBoxKind;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerDateCall;
        private Label label6;
        private TextBox textBoxFIOOwner;
        private TabControl tabControlDir;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TextBox textBoxReason;
        private DataGridView dataGridViewDir;
        private Button buttonAddDir;
        private Label label9;
        private TextBox textBoxAnimalKind;
        private Label label10;
        private TextBox textBoxBreed;
        private DataGridViewTextBoxColumn Column8;
        private Label label11;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label13;
    }
}