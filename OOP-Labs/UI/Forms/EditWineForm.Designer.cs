namespace UI.Forms
{
    partial class EditWineForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbAlcoholContent = new System.Windows.Forms.TextBox();
            this.lblAlcoholContent = new System.Windows.Forms.Label();
            this.lblDateOfBottling = new System.Windows.Forms.Label();
            this.dtpDageOfBottling = new System.Windows.Forms.DateTimePicker();
            this.lblGrapeSort = new System.Windows.Forms.Label();
            this.tbGrapeSort = new System.Windows.Forms.TextBox();
            this.lblVinesAge = new System.Windows.Forms.Label();
            this.tbVinesAge = new System.Windows.Forms.TextBox();
            this.gbEditWine = new System.Windows.Forms.GroupBox();
            this.gbEditBottle = new System.Windows.Forms.GroupBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbEditWine.SuspendLayout();
            this.gbEditBottle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(62, 48);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(43, 13);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost($):";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(111, 45);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(185, 20);
            this.tbCost.TabIndex = 3;
            // 
            // tbAlcoholContent
            // 
            this.tbAlcoholContent.Location = new System.Drawing.Point(111, 71);
            this.tbAlcoholContent.Name = "tbAlcoholContent";
            this.tbAlcoholContent.Size = new System.Drawing.Size(185, 20);
            this.tbAlcoholContent.TabIndex = 4;
            // 
            // lblAlcoholContent
            // 
            this.lblAlcoholContent.AutoSize = true;
            this.lblAlcoholContent.Location = new System.Drawing.Point(7, 74);
            this.lblAlcoholContent.Name = "lblAlcoholContent";
            this.lblAlcoholContent.Size = new System.Drawing.Size(98, 13);
            this.lblAlcoholContent.TabIndex = 5;
            this.lblAlcoholContent.Text = "Alcohol content(%):";
            // 
            // lblDateOfBottling
            // 
            this.lblDateOfBottling.AutoSize = true;
            this.lblDateOfBottling.Location = new System.Drawing.Point(23, 100);
            this.lblDateOfBottling.Name = "lblDateOfBottling";
            this.lblDateOfBottling.Size = new System.Drawing.Size(82, 13);
            this.lblDateOfBottling.TabIndex = 6;
            this.lblDateOfBottling.Text = "Date of bottling:";
            // 
            // dtpDageOfBottling
            // 
            this.dtpDageOfBottling.Location = new System.Drawing.Point(111, 97);
            this.dtpDageOfBottling.Name = "dtpDageOfBottling";
            this.dtpDageOfBottling.Size = new System.Drawing.Size(185, 20);
            this.dtpDageOfBottling.TabIndex = 7;
            // 
            // lblGrapeSort
            // 
            this.lblGrapeSort.AutoSize = true;
            this.lblGrapeSort.Location = new System.Drawing.Point(46, 126);
            this.lblGrapeSort.Name = "lblGrapeSort";
            this.lblGrapeSort.Size = new System.Drawing.Size(59, 13);
            this.lblGrapeSort.TabIndex = 8;
            this.lblGrapeSort.Text = "Grape sort:";
            // 
            // tbGrapeSort
            // 
            this.tbGrapeSort.Location = new System.Drawing.Point(111, 123);
            this.tbGrapeSort.Name = "tbGrapeSort";
            this.tbGrapeSort.Size = new System.Drawing.Size(185, 20);
            this.tbGrapeSort.TabIndex = 9;
            // 
            // lblVinesAge
            // 
            this.lblVinesAge.AutoSize = true;
            this.lblVinesAge.Location = new System.Drawing.Point(48, 152);
            this.lblVinesAge.Name = "lblVinesAge";
            this.lblVinesAge.Size = new System.Drawing.Size(57, 13);
            this.lblVinesAge.TabIndex = 10;
            this.lblVinesAge.Text = "Vines age:";
            // 
            // tbVinesAge
            // 
            this.tbVinesAge.Location = new System.Drawing.Point(111, 149);
            this.tbVinesAge.Name = "tbVinesAge";
            this.tbVinesAge.Size = new System.Drawing.Size(185, 20);
            this.tbVinesAge.TabIndex = 11;
            // 
            // gbEditWine
            // 
            this.gbEditWine.Controls.Add(this.tbName);
            this.gbEditWine.Controls.Add(this.tbVinesAge);
            this.gbEditWine.Controls.Add(this.lblName);
            this.gbEditWine.Controls.Add(this.lblVinesAge);
            this.gbEditWine.Controls.Add(this.lblCost);
            this.gbEditWine.Controls.Add(this.tbGrapeSort);
            this.gbEditWine.Controls.Add(this.tbCost);
            this.gbEditWine.Controls.Add(this.lblGrapeSort);
            this.gbEditWine.Controls.Add(this.tbAlcoholContent);
            this.gbEditWine.Controls.Add(this.dtpDageOfBottling);
            this.gbEditWine.Controls.Add(this.lblAlcoholContent);
            this.gbEditWine.Controls.Add(this.lblDateOfBottling);
            this.gbEditWine.Location = new System.Drawing.Point(12, 12);
            this.gbEditWine.Name = "gbEditWine";
            this.gbEditWine.Size = new System.Drawing.Size(315, 182);
            this.gbEditWine.TabIndex = 12;
            this.gbEditWine.TabStop = false;
            this.gbEditWine.Text = "Edit wine";
            // 
            // gbEditBottle
            // 
            this.gbEditBottle.Controls.Add(this.tbVolume);
            this.gbEditBottle.Controls.Add(this.lblVolume);
            this.gbEditBottle.Controls.Add(this.lblColor);
            this.gbEditBottle.Controls.Add(this.tbColor);
            this.gbEditBottle.Location = new System.Drawing.Point(333, 12);
            this.gbEditBottle.Name = "gbEditBottle";
            this.gbEditBottle.Size = new System.Drawing.Size(260, 76);
            this.gbEditBottle.TabIndex = 13;
            this.gbEditBottle.TabStop = false;
            this.gbEditBottle.Text = "Edit bottle";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(69, 19);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(185, 20);
            this.tbVolume.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(3, 22);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(61, 13);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume(ml):";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(29, 48);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(69, 45);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(185, 20);
            this.tbColor.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditWineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 206);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEditBottle);
            this.Controls.Add(this.gbEditWine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditWineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit wine";
            this.gbEditWine.ResumeLayout(false);
            this.gbEditWine.PerformLayout();
            this.gbEditBottle.ResumeLayout(false);
            this.gbEditBottle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbAlcoholContent;
        private System.Windows.Forms.Label lblAlcoholContent;
        private System.Windows.Forms.Label lblDateOfBottling;
        private System.Windows.Forms.DateTimePicker dtpDageOfBottling;
        private System.Windows.Forms.Label lblGrapeSort;
        private System.Windows.Forms.TextBox tbGrapeSort;
        private System.Windows.Forms.Label lblVinesAge;
        private System.Windows.Forms.TextBox tbVinesAge;
        private System.Windows.Forms.GroupBox gbEditWine;
        private System.Windows.Forms.GroupBox gbEditBottle;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnSave;
    }
}