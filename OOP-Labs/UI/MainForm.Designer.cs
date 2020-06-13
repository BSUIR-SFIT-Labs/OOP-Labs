namespace UI
{
    partial class MainForm
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
            this.lblTypeOfDrink = new System.Windows.Forms.Label();
            this.cbTypeOfDrink = new System.Windows.Forms.ComboBox();
            this.lblListOfDrinks = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDrinkInfo = new System.Windows.Forms.Label();
            this.lbListOfDrinks = new System.Windows.Forms.ListBox();
            this.lbDrinkInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTypeOfDrink
            // 
            this.lblTypeOfDrink.AutoSize = true;
            this.lblTypeOfDrink.Location = new System.Drawing.Point(12, 9);
            this.lblTypeOfDrink.Name = "lblTypeOfDrink";
            this.lblTypeOfDrink.Size = new System.Drawing.Size(72, 13);
            this.lblTypeOfDrink.TabIndex = 1;
            this.lblTypeOfDrink.Text = "Type of drink:";
            // 
            // cbTypeOfDrink
            // 
            this.cbTypeOfDrink.FormattingEnabled = true;
            this.cbTypeOfDrink.Location = new System.Drawing.Point(12, 25);
            this.cbTypeOfDrink.Name = "cbTypeOfDrink";
            this.cbTypeOfDrink.Size = new System.Drawing.Size(237, 21);
            this.cbTypeOfDrink.TabIndex = 2;
            this.cbTypeOfDrink.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfDrink_SelectedIndexChanged);
            // 
            // lblListOfDrinks
            // 
            this.lblListOfDrinks.AutoSize = true;
            this.lblListOfDrinks.Location = new System.Drawing.Point(12, 64);
            this.lblListOfDrinks.Name = "lblListOfDrinks";
            this.lblListOfDrinks.Size = new System.Drawing.Size(69, 13);
            this.lblListOfDrinks.TabIndex = 3;
            this.lblListOfDrinks.Text = "List of drinks:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDrinkInfo
            // 
            this.lblDrinkInfo.AutoSize = true;
            this.lblDrinkInfo.Location = new System.Drawing.Point(270, 9);
            this.lblDrinkInfo.Name = "lblDrinkInfo";
            this.lblDrinkInfo.Size = new System.Drawing.Size(55, 13);
            this.lblDrinkInfo.TabIndex = 8;
            this.lblDrinkInfo.Text = "Drink info:";
            // 
            // lbListOfDrinks
            // 
            this.lbListOfDrinks.FormattingEnabled = true;
            this.lbListOfDrinks.Location = new System.Drawing.Point(12, 80);
            this.lbListOfDrinks.Name = "lbListOfDrinks";
            this.lbListOfDrinks.Size = new System.Drawing.Size(237, 277);
            this.lbListOfDrinks.TabIndex = 9;
            this.lbListOfDrinks.SelectedIndexChanged += new System.EventHandler(this.lbListOfDrinks_SelectedIndexChanged);
            // 
            // lbDrinkInfo
            // 
            this.lbDrinkInfo.FormattingEnabled = true;
            this.lbDrinkInfo.Location = new System.Drawing.Point(273, 25);
            this.lbDrinkInfo.Name = "lbDrinkInfo";
            this.lbDrinkInfo.Size = new System.Drawing.Size(318, 368);
            this.lbDrinkInfo.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 403);
            this.Controls.Add(this.lbDrinkInfo);
            this.Controls.Add(this.lbListOfDrinks);
            this.Controls.Add(this.lblDrinkInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblListOfDrinks);
            this.Controls.Add(this.cbTypeOfDrink);
            this.Controls.Add(this.lblTypeOfDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP Labs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTypeOfDrink;
        private System.Windows.Forms.ComboBox cbTypeOfDrink;
        private System.Windows.Forms.Label lblListOfDrinks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDrinkInfo;
        private System.Windows.Forms.ListBox lbListOfDrinks;
        private System.Windows.Forms.ListBox lbDrinkInfo;
    }
}

