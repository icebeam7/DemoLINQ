namespace DemoLINQ
{
    partial class Form1
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
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.TableStudents = new System.Windows.Forms.DataGridView();
            this.SortDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeFilter = new System.Windows.Forms.NumericUpDown();
            this.SearchAgeButton = new System.Windows.Forms.Button();
            this.CountryFilter = new System.Windows.Forms.TextBox();
            this.SearchCountryButton = new System.Windows.Forms.Button();
            this.CalculateAvgGradeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(48, 27);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataButton.TabIndex = 0;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // TableStudents
            // 
            this.TableStudents.AllowUserToAddRows = false;
            this.TableStudents.AllowUserToDeleteRows = false;
            this.TableStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableStudents.Location = new System.Drawing.Point(48, 238);
            this.TableStudents.Name = "TableStudents";
            this.TableStudents.ReadOnly = true;
            this.TableStudents.Size = new System.Drawing.Size(591, 178);
            this.TableStudents.TabIndex = 1;
            // 
            // SortDataButton
            // 
            this.SortDataButton.Location = new System.Drawing.Point(48, 77);
            this.SortDataButton.Name = "SortDataButton";
            this.SortDataButton.Size = new System.Drawing.Size(131, 23);
            this.SortDataButton.TabIndex = 2;
            this.SortDataButton.Text = "Sort Data";
            this.SortDataButton.UseVisualStyleBackColor = true;
            this.SortDataButton.Click += new System.EventHandler(this.SortDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // AgeFilter
            // 
            this.AgeFilter.Location = new System.Drawing.Point(103, 132);
            this.AgeFilter.Name = "AgeFilter";
            this.AgeFilter.Size = new System.Drawing.Size(76, 20);
            this.AgeFilter.TabIndex = 4;
            // 
            // SearchAgeButton
            // 
            this.SearchAgeButton.Location = new System.Drawing.Point(217, 132);
            this.SearchAgeButton.Name = "SearchAgeButton";
            this.SearchAgeButton.Size = new System.Drawing.Size(95, 23);
            this.SearchAgeButton.TabIndex = 5;
            this.SearchAgeButton.Text = "Search by Age";
            this.SearchAgeButton.UseVisualStyleBackColor = true;
            this.SearchAgeButton.Click += new System.EventHandler(this.SearchAgeButton_Click);
            // 
            // CountryFilter
            // 
            this.CountryFilter.Location = new System.Drawing.Point(103, 185);
            this.CountryFilter.Name = "CountryFilter";
            this.CountryFilter.Size = new System.Drawing.Size(76, 20);
            this.CountryFilter.TabIndex = 6;
            // 
            // SearchCountryButton
            // 
            this.SearchCountryButton.Location = new System.Drawing.Point(217, 185);
            this.SearchCountryButton.Name = "SearchCountryButton";
            this.SearchCountryButton.Size = new System.Drawing.Size(119, 23);
            this.SearchCountryButton.TabIndex = 7;
            this.SearchCountryButton.Text = "Search by Country";
            this.SearchCountryButton.UseVisualStyleBackColor = true;
            this.SearchCountryButton.Click += new System.EventHandler(this.SearchCountryButton_Click);
            // 
            // CalculateAvgGradeButton
            // 
            this.CalculateAvgGradeButton.Location = new System.Drawing.Point(217, 77);
            this.CalculateAvgGradeButton.Name = "CalculateAvgGradeButton";
            this.CalculateAvgGradeButton.Size = new System.Drawing.Size(153, 23);
            this.CalculateAvgGradeButton.TabIndex = 8;
            this.CalculateAvgGradeButton.Text = "Calculate Average Age";
            this.CalculateAvgGradeButton.UseVisualStyleBackColor = true;
            this.CalculateAvgGradeButton.Click += new System.EventHandler(this.CalculateAvgGradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateAvgGradeButton);
            this.Controls.Add(this.SearchCountryButton);
            this.Controls.Add(this.CountryFilter);
            this.Controls.Add(this.SearchAgeButton);
            this.Controls.Add(this.AgeFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortDataButton);
            this.Controls.Add(this.TableStudents);
            this.Controls.Add(this.LoadDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.DataGridView TableStudents;
        private System.Windows.Forms.Button SortDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AgeFilter;
        private System.Windows.Forms.Button SearchAgeButton;
        private System.Windows.Forms.TextBox CountryFilter;
        private System.Windows.Forms.Button SearchCountryButton;
        private System.Windows.Forms.Button CalculateAvgGradeButton;
    }
}

