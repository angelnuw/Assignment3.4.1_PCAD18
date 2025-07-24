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
            coffeeBindingSource = new BindingSource(components);
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            coffeeRoastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeOfCoffeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeStrengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hasMilkDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            beverageIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageExDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageContainerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageFlavorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageTemperatureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)coffeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // coffeeGridView
            // 
            coffeeGridView.AutoGenerateColumns = false;
            coffeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coffeeGridView.Columns.AddRange(new DataGridViewColumn[] { isDecafDataGridViewCheckBoxColumn, coffeeRoastDataGridViewTextBoxColumn, typeOfCoffeeDataGridViewTextBoxColumn, coffeeStrengthDataGridViewTextBoxColumn, hasMilkDataGridViewCheckBoxColumn, beverageIDDataGridViewTextBoxColumn, beverageNameDataGridViewTextBoxColumn, beverageExDateDataGridViewTextBoxColumn, beverageContainerDataGridViewTextBoxColumn, beverageSizeDataGridViewTextBoxColumn, beverageFlavorDataGridViewTextBoxColumn, beverageTemperatureDataGridViewTextBoxColumn });
            coffeeGridView.DataSource = coffeeBindingSource;
            coffeeGridView.Location = new Point(12, 12);
            coffeeGridView.Name = "coffeeGridView";
            coffeeGridView.Size = new Size(1266, 331);
            coffeeGridView.TabIndex = 0;
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // coffeeRoastDataGridViewTextBoxColumn
            // 
            coffeeRoastDataGridViewTextBoxColumn.DataPropertyName = "CoffeeRoast";
            coffeeRoastDataGridViewTextBoxColumn.HeaderText = "CoffeeRoast";
            coffeeRoastDataGridViewTextBoxColumn.Name = "coffeeRoastDataGridViewTextBoxColumn";
            // 
            // typeOfCoffeeDataGridViewTextBoxColumn
            // 
            typeOfCoffeeDataGridViewTextBoxColumn.DataPropertyName = "TypeOfCoffee";
            typeOfCoffeeDataGridViewTextBoxColumn.HeaderText = "TypeOfCoffee";
            typeOfCoffeeDataGridViewTextBoxColumn.Name = "typeOfCoffeeDataGridViewTextBoxColumn";
            // 
            // coffeeStrengthDataGridViewTextBoxColumn
            // 
            coffeeStrengthDataGridViewTextBoxColumn.DataPropertyName = "CoffeeStrength";
            coffeeStrengthDataGridViewTextBoxColumn.HeaderText = "CoffeeStrength";
            coffeeStrengthDataGridViewTextBoxColumn.Name = "coffeeStrengthDataGridViewTextBoxColumn";
            // 
            // hasMilkDataGridViewCheckBoxColumn
            // 
            hasMilkDataGridViewCheckBoxColumn.DataPropertyName = "HasMilk";
            hasMilkDataGridViewCheckBoxColumn.HeaderText = "HasMilk";
            hasMilkDataGridViewCheckBoxColumn.Name = "hasMilkDataGridViewCheckBoxColumn";
            // 
            // beverageIDDataGridViewTextBoxColumn
            // 
            beverageIDDataGridViewTextBoxColumn.DataPropertyName = "BeverageID";
            beverageIDDataGridViewTextBoxColumn.HeaderText = "BeverageID";
            beverageIDDataGridViewTextBoxColumn.Name = "beverageIDDataGridViewTextBoxColumn";
            // 
            // beverageNameDataGridViewTextBoxColumn
            // 
            beverageNameDataGridViewTextBoxColumn.DataPropertyName = "BeverageName";
            beverageNameDataGridViewTextBoxColumn.HeaderText = "BeverageName";
            beverageNameDataGridViewTextBoxColumn.Name = "beverageNameDataGridViewTextBoxColumn";
            // 
            // beverageExDateDataGridViewTextBoxColumn
            // 
            beverageExDateDataGridViewTextBoxColumn.DataPropertyName = "BeverageExDate";
            beverageExDateDataGridViewTextBoxColumn.HeaderText = "BeverageExDate";
            beverageExDateDataGridViewTextBoxColumn.Name = "beverageExDateDataGridViewTextBoxColumn";
            // 
            // beverageContainerDataGridViewTextBoxColumn
            // 
            beverageContainerDataGridViewTextBoxColumn.DataPropertyName = "BeverageContainer";
            beverageContainerDataGridViewTextBoxColumn.HeaderText = "BeverageContainer";
            beverageContainerDataGridViewTextBoxColumn.Name = "beverageContainerDataGridViewTextBoxColumn";
            // 
            // beverageSizeDataGridViewTextBoxColumn
            // 
            beverageSizeDataGridViewTextBoxColumn.DataPropertyName = "BeverageSize";
            beverageSizeDataGridViewTextBoxColumn.HeaderText = "BeverageSize";
            beverageSizeDataGridViewTextBoxColumn.Name = "beverageSizeDataGridViewTextBoxColumn";
            // 
            // beverageFlavorDataGridViewTextBoxColumn
            // 
            beverageFlavorDataGridViewTextBoxColumn.DataPropertyName = "BeverageFlavor";
            beverageFlavorDataGridViewTextBoxColumn.HeaderText = "BeverageFlavor";
            beverageFlavorDataGridViewTextBoxColumn.Name = "beverageFlavorDataGridViewTextBoxColumn";
            // 
            // beverageTemperatureDataGridViewTextBoxColumn
            // 
            beverageTemperatureDataGridViewTextBoxColumn.DataPropertyName = "BeverageTemperature";
            beverageTemperatureDataGridViewTextBoxColumn.HeaderText = "BeverageTemperature";
            beverageTemperatureDataGridViewTextBoxColumn.Name = "beverageTemperatureDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 737);
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
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn coffeeRoastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeOfCoffeeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hasMilkDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn beverageIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageExDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageContainerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageFlavorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageTemperatureDataGridViewTextBoxColumn;
    }
}
