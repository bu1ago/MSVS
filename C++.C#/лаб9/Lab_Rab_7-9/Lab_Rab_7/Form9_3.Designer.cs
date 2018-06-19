namespace Lab_Rab_7
{
    partial class Form9_3
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.lab_Rab_9DataSet = new Lab_Rab_7.Lab_Rab_9DataSet();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица1TableAdapter = new Lab_Rab_7.Lab_Rab_9DataSetTableAdapters.Таблица1TableAdapter();
            this.таблица2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица2TableAdapter = new Lab_Rab_7.Lab_Rab_9DataSetTableAdapters.Таблица2TableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_Rab_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Grid1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid1.Location = new System.Drawing.Point(12, 12);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.Size = new System.Drawing.Size(419, 237);
            this.Grid1.TabIndex = 0;
            // 
            // lab_Rab_9DataSet
            // 
            this.lab_Rab_9DataSet.DataSetName = "Lab_Rab_9DataSet";
            this.lab_Rab_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.lab_Rab_9DataSet;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // таблица2BindingSource
            // 
            this.таблица2BindingSource.DataMember = "Таблица2";
            this.таблица2BindingSource.DataSource = this.lab_Rab_9DataSet;
            // 
            // таблица2TableAdapter
            // 
            this.таблица2TableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Лек\\Апт";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form9_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.Grid1);
            this.Name = "Form9_3";
            this.Text = "Перекрёстная таблица";
            this.Load += new System.EventHandler(this.Form9_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_Rab_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private Lab_Rab_9DataSet lab_Rab_9DataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Lab_Rab_9DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.BindingSource таблица2BindingSource;
        private Lab_Rab_9DataSetTableAdapters.Таблица2TableAdapter таблица2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}