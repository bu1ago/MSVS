namespace Lab_Rab_7
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.шифрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колупакDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labRab9DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab_Rab_9DataSet = new Lab_Rab_7.Lab_Rab_9DataSet();
            this.таблица1TableAdapter = new Lab_Rab_7.Lab_Rab_9DataSetTableAdapters.Таблица1TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.аптекиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.упакВНалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шифрDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица2TableAdapter = new Lab_Rab_7.Lab_Rab_9DataSetTableAdapters.Таблица2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labRab9DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_Rab_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список настоек";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(159, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск лекарства";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(327, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Таблица";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Перекрёстная таблица";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.шифрDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.формаDataGridViewTextBoxColumn,
            this.колупакDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // шифрDataGridViewTextBoxColumn
            // 
            this.шифрDataGridViewTextBoxColumn.DataPropertyName = "Шифр";
            this.шифрDataGridViewTextBoxColumn.HeaderText = "Шифр";
            this.шифрDataGridViewTextBoxColumn.Name = "шифрDataGridViewTextBoxColumn";
            this.шифрDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // формаDataGridViewTextBoxColumn
            // 
            this.формаDataGridViewTextBoxColumn.DataPropertyName = "Форма";
            this.формаDataGridViewTextBoxColumn.HeaderText = "Форма";
            this.формаDataGridViewTextBoxColumn.Name = "формаDataGridViewTextBoxColumn";
            this.формаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колупакDataGridViewTextBoxColumn
            // 
            this.колупакDataGridViewTextBoxColumn.DataPropertyName = "Кол/упак";
            this.колупакDataGridViewTextBoxColumn.HeaderText = "Кол/упак";
            this.колупакDataGridViewTextBoxColumn.Name = "колупакDataGridViewTextBoxColumn";
            this.колупакDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.labRab9DataSetBindingSource;
            // 
            // labRab9DataSetBindingSource
            // 
            this.labRab9DataSetBindingSource.DataSource = this.lab_Rab_9DataSet;
            this.labRab9DataSetBindingSource.Position = 0;
            // 
            // lab_Rab_9DataSet
            // 
            this.lab_Rab_9DataSet.DataSetName = "Lab_Rab_9DataSet";
            this.lab_Rab_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.аптекиDataGridViewTextBoxColumn,
            this.упакВНалDataGridViewTextBoxColumn,
            this.шифрDataGridViewTextBoxColumn1,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.таблица2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(420, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.TabStop = false;
            // 
            // аптекиDataGridViewTextBoxColumn
            // 
            this.аптекиDataGridViewTextBoxColumn.DataPropertyName = "№ Аптеки";
            this.аптекиDataGridViewTextBoxColumn.HeaderText = "№ Аптеки";
            this.аптекиDataGridViewTextBoxColumn.Name = "аптекиDataGridViewTextBoxColumn";
            this.аптекиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // упакВНалDataGridViewTextBoxColumn
            // 
            this.упакВНалDataGridViewTextBoxColumn.DataPropertyName = "Упак в нал";
            this.упакВНалDataGridViewTextBoxColumn.HeaderText = "Упак в нал";
            this.упакВНалDataGridViewTextBoxColumn.Name = "упакВНалDataGridViewTextBoxColumn";
            this.упакВНалDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // шифрDataGridViewTextBoxColumn1
            // 
            this.шифрDataGridViewTextBoxColumn1.DataPropertyName = "Шифр";
            this.шифрDataGridViewTextBoxColumn1.HeaderText = "Шифр";
            this.шифрDataGridViewTextBoxColumn1.Name = "шифрDataGridViewTextBoxColumn1";
            this.шифрDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // таблица2BindingSource
            // 
            this.таблица2BindingSource.DataMember = "Таблица2";
            this.таблица2BindingSource.DataSource = this.labRab9DataSetBindingSource;
            // 
            // таблица2TableAdapter
            // 
            this.таблица2TableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 389);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Лаб9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labRab9DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_Rab_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource labRab9DataSetBindingSource;
        private Lab_Rab_9DataSet lab_Rab_9DataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Lab_Rab_9DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn шифрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колупакDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource таблица2BindingSource;
        private Lab_Rab_9DataSetTableAdapters.Таблица2TableAdapter таблица2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn аптекиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn упакВНалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шифрDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}