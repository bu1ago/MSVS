namespace Лаб7
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Izm = new System.Windows.Forms.Button();
            this.KolIzm = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.IzmText = new System.Windows.Forms.TextBox();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabsDataSet = new Лаб7.TabsDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new Лаб7.TabsDataSetTableAdapters.Table1TableAdapter();
            this.table2TableAdapter = new Лаб7.TabsDataSetTableAdapters.Table2TableAdapter();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(484, 188);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(271, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "ИЗМЕНИТЬ МАССИВ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(280, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 173);
            this.listBox1.TabIndex = 3;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.SystemColors.Window;
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text1.Cursor = System.Windows.Forms.Cursors.Default;
            this.text1.HideSelection = false;
            this.text1.Location = new System.Drawing.Point(280, 108);
            this.text1.Name = "text1";
            this.text1.ReadOnly = true;
            this.text1.Size = new System.Drawing.Size(147, 13);
            this.text1.TabIndex = 4;
            this.text1.Text = "Измененный массив :";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Location = new System.Drawing.Point(0, -1);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(918, 357);
            this.tabcontrol1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.text1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лаб7";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(62, 45);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(793, 42);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(484, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(271, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Введите массив :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.Text2);
            this.tabPage2.Controls.Add(this.Izm);
            this.tabPage2.Controls.Add(this.KolIzm);
            this.tabPage2.Controls.Add(this.InputText);
            this.tabPage2.Controls.Add(this.IzmText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лаб8";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Location = new System.Drawing.Point(462, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(155, 13);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Полученная строка :";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Location = new System.Drawing.Point(221, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(121, 13);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Введите строку :";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.SystemColors.Control;
            this.Text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Text2.Location = new System.Drawing.Point(221, 165);
            this.Text2.Name = "Text2";
            this.Text2.ReadOnly = true;
            this.Text2.Size = new System.Drawing.Size(187, 13);
            this.Text2.TabIndex = 4;
            this.Text2.Text = "Кол-во удаленных символов :";
            this.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Izm
            // 
            this.Izm.Location = new System.Drawing.Point(462, 136);
            this.Izm.Name = "Izm";
            this.Izm.Size = new System.Drawing.Size(176, 68);
            this.Izm.TabIndex = 3;
            this.Izm.Text = "ИЗМЕНИТЬ СТРОКУ";
            this.Izm.UseVisualStyleBackColor = true;
            this.Izm.Click += new System.EventHandler(this.Izm_Click);
            // 
            // KolIzm
            // 
            this.KolIzm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KolIzm.Cursor = System.Windows.Forms.Cursors.Default;
            this.KolIzm.Location = new System.Drawing.Point(221, 186);
            this.KolIzm.Name = "KolIzm";
            this.KolIzm.ReadOnly = true;
            this.KolIzm.Size = new System.Drawing.Size(100, 13);
            this.KolIzm.TabIndex = 2;
            this.KolIzm.TextChanged += new System.EventHandler(this.KolIzm_TextChanged);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(221, 110);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(176, 20);
            this.InputText.TabIndex = 1;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // IzmText
            // 
            this.IzmText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IzmText.Location = new System.Drawing.Point(462, 110);
            this.IzmText.Name = "IzmText";
            this.IzmText.ReadOnly = true;
            this.IzmText.Size = new System.Drawing.Size(176, 20);
            this.IzmText.TabIndex = 0;
            this.IzmText.TextChanged += new System.EventHandler(this.IzmText_TextChanged);
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table2";
            this.table2BindingSource.DataSource = this.tabsDataSet;
            // 
            // tabsDataSet
            // 
            this.tabsDataSet.DataSetName = "TabsDataSet";
            this.tabsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.tabsDataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // table2TableAdapter
            // 
            this.table2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(916, 357);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "Лаб";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox KolIzm;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox IzmText;
        private System.Windows.Forms.TextBox Text2;
        private System.Windows.Forms.Button Izm;
        private TabsDataSet tabsDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private TabsDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private TabsDataSetTableAdapters.Table2TableAdapter table2TableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;

    }
}

