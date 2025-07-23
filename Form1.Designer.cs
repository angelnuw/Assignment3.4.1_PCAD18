namespace Assignment3._4._1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            coffeeGridView = new DataGridView();
            coffeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeStrengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeFlavorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeTemperatureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)coffeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // coffeeGridView
            // 
            coffeeGridView.AutoGenerateColumns = false;
            coffeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coffeeGridView.Columns.AddRange(new DataGridViewColumn[] { coffeeNameDataGridViewTextBoxColumn, coffeeTypeDataGridViewTextBoxColumn, coffeeSizeDataGridViewTextBoxColumn, coffeeStrengthDataGridViewTextBoxColumn, coffeeFlavorDataGridViewTextBoxColumn, coffeeTemperatureDataGridViewTextBoxColumn });
            coffeeGridView.DataSource = coffeeBindingSource;
            coffeeGridView.Location = new Point(12, 12);
            coffeeGridView.Name = "coffeeGridView";
            coffeeGridView.Size = new Size(714, 282);
            coffeeGridView.TabIndex = 0;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "coffeeName";
            coffeeNameDataGridViewTextBoxColumn.HeaderText = "coffeeName";
            coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // coffeeTypeDataGridViewTextBoxColumn
            // 
            coffeeTypeDataGridViewTextBoxColumn.DataPropertyName = "coffeeType";
            coffeeTypeDataGridViewTextBoxColumn.HeaderText = "coffeeType";
            coffeeTypeDataGridViewTextBoxColumn.Name = "coffeeTypeDataGridViewTextBoxColumn";
            // 
            // coffeeSizeDataGridViewTextBoxColumn
            // 
            coffeeSizeDataGridViewTextBoxColumn.DataPropertyName = "coffeeSize";
            coffeeSizeDataGridViewTextBoxColumn.HeaderText = "coffeeSize";
            coffeeSizeDataGridViewTextBoxColumn.Name = "coffeeSizeDataGridViewTextBoxColumn";
            // 
            // coffeeStrengthDataGridViewTextBoxColumn
            // 
            coffeeStrengthDataGridViewTextBoxColumn.DataPropertyName = "coffeeStrength";
            coffeeStrengthDataGridViewTextBoxColumn.HeaderText = "coffeeStrength";
            coffeeStrengthDataGridViewTextBoxColumn.Name = "coffeeStrengthDataGridViewTextBoxColumn";
            // 
            // coffeeFlavorDataGridViewTextBoxColumn
            // 
            coffeeFlavorDataGridViewTextBoxColumn.DataPropertyName = "coffeeFlavor";
            coffeeFlavorDataGridViewTextBoxColumn.HeaderText = "coffeeFlavor";
            coffeeFlavorDataGridViewTextBoxColumn.Name = "coffeeFlavorDataGridViewTextBoxColumn";
            // 
            // coffeeTemperatureDataGridViewTextBoxColumn
            // 
            coffeeTemperatureDataGridViewTextBoxColumn.DataPropertyName = "coffeeTemperature";
            coffeeTemperatureDataGridViewTextBoxColumn.HeaderText = "coffeeTemperature";
            coffeeTemperatureDataGridViewTextBoxColumn.Name = "coffeeTemperatureDataGridViewTextBoxColumn";
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coffeeGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)coffeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView coffeeGridView;
        private DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coffeeTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coffeeSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coffeeStrengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coffeeFlavorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coffeeTemperatureDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource;
    }
}
