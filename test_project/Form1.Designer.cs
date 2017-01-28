namespace test_project
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
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadButton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(54, 51);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 1;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(227, 51);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(100, 20);
            this.qTextBox.TabIndex = 2;
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(387, 52);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(100, 20);
            this.pTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(412, 94);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // totalbutton
            // 
            this.totalbutton.Location = new System.Drawing.Point(412, 345);
            this.totalbutton.Name = "totalbutton";
            this.totalbutton.Size = new System.Drawing.Size(75, 23);
            this.totalbutton.TabIndex = 11;
            this.totalbutton.Text = "Total";
            this.totalbutton.UseVisualStyleBackColor = true;
            this.totalbutton.Click += new System.EventHandler(this.totalbutton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Item,
            this.Quantity,
            this.Price,
            this.Cost});
            this.listView1.Location = new System.Drawing.Point(16, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(471, 158);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 51;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 165;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 92;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 88;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 84;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(16, 385);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(16, 345);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 14;
            this.LoadButton.Text = "Load Data";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(108, 345);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 15;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(387, 311);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 16;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Totallabel.Location = new System.Drawing.Point(330, 317);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(31, 13);
            this.Totallabel.TabIndex = 17;
            this.Totallabel.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 428);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.totalbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.nTextBox);
            this.Name = "Form1";
            this.Text = "Billing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button totalbutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label Totallabel;
    }
}

