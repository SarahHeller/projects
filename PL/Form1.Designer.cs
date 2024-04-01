namespace PL
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
            Search = new Button();
            txtSearch = new TextBox();
            titel = new Label();
            dataGridView1 = new DataGridView();
            Search_word = new RadioButton();
            searchPasukToName = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Location = new Point(435, 125);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 0;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(423, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // titel
            // 
            titel.AutoSize = true;
            titel.Location = new Point(436, 57);
            titel.Name = "titel";
            titel.Size = new Size(94, 20);
            titel.TabIndex = 2;
            titel.Text = "Enter a value";
            titel.Click += titel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(667, 254);
            dataGridView1.TabIndex = 3;
            // 
            // Search_word
            // 
            Search_word.AutoSize = true;
            Search_word.Location = new Point(121, 76);
            Search_word.Name = "Search_word";
            Search_word.Size = new Size(112, 24);
            Search_word.TabIndex = 5;
            Search_word.TabStop = true;
            Search_word.Text = "Search word";
            Search_word.UseVisualStyleBackColor = true;
            Search_word.CheckedChanged += Search_word_CheckedChanged;
            // 
            // searchPasukToName
            // 
            searchPasukToName.AutoSize = true;
            searchPasukToName.Location = new Point(121, 106);
            searchPasukToName.Name = "searchPasukToName";
            searchPasukToName.Size = new Size(175, 24);
            searchPasukToName.TabIndex = 6;
            searchPasukToName.TabStop = true;
            searchPasukToName.Text = "Search pasuk to name";
            searchPasukToName.UseVisualStyleBackColor = true;
            searchPasukToName.CheckedChanged += searchPasukToName_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchPasukToName);
            Controls.Add(Search_word);
            Controls.Add(dataGridView1);
            Controls.Add(titel);
            Controls.Add(txtSearch);
            Controls.Add(Search);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Search;
        private TextBox txtSearch;
        private Label titel;
        private DataGridView dataGridView1;
        private RadioButton Search_word;
        private RadioButton searchPasukToName;
    }
}