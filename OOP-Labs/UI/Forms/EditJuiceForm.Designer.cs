namespace UI.Forms
{
    partial class EditJuiceForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gbEditBottle = new System.Windows.Forms.GroupBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.gbEditWine = new System.Windows.Forms.GroupBox();
            this.tbFruit = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPulpContent = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPulpContent = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbJuiceContent = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lblJuiceContent = new System.Windows.Forms.Label();
            this.tbSugarContent = new System.Windows.Forms.TextBox();
            this.lblSugarContent = new System.Windows.Forms.Label();
            this.lblFruit = new System.Windows.Forms.Label();
            this.gbEditBottle.SuspendLayout();
            this.gbEditWine.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.gbEditBottle.TabIndex = 19;
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
            this.lblVolume.Location = new System.Drawing.Point(4, 22);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(61, 13);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume(ml):";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(27, 48);
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
            // gbEditWine
            // 
            this.gbEditWine.Controls.Add(this.tbFruit);
            this.gbEditWine.Controls.Add(this.tbName);
            this.gbEditWine.Controls.Add(this.tbPulpContent);
            this.gbEditWine.Controls.Add(this.lblName);
            this.gbEditWine.Controls.Add(this.lblPulpContent);
            this.gbEditWine.Controls.Add(this.lblCost);
            this.gbEditWine.Controls.Add(this.tbJuiceContent);
            this.gbEditWine.Controls.Add(this.tbCost);
            this.gbEditWine.Controls.Add(this.lblJuiceContent);
            this.gbEditWine.Controls.Add(this.tbSugarContent);
            this.gbEditWine.Controls.Add(this.lblSugarContent);
            this.gbEditWine.Controls.Add(this.lblFruit);
            this.gbEditWine.Location = new System.Drawing.Point(12, 12);
            this.gbEditWine.Name = "gbEditWine";
            this.gbEditWine.Size = new System.Drawing.Size(315, 182);
            this.gbEditWine.TabIndex = 18;
            this.gbEditWine.TabStop = false;
            this.gbEditWine.Text = "Edit wine";
            // 
            // tbFruit
            // 
            this.tbFruit.Location = new System.Drawing.Point(111, 97);
            this.tbFruit.Name = "tbFruit";
            this.tbFruit.Size = new System.Drawing.Size(185, 20);
            this.tbFruit.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPulpContent
            // 
            this.tbPulpContent.Location = new System.Drawing.Point(111, 149);
            this.tbPulpContent.Name = "tbPulpContent";
            this.tbPulpContent.Size = new System.Drawing.Size(185, 20);
            this.tbPulpContent.TabIndex = 11;
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
            // lblPulpContent
            // 
            this.lblPulpContent.AutoSize = true;
            this.lblPulpContent.Location = new System.Drawing.Point(21, 152);
            this.lblPulpContent.Name = "lblPulpContent";
            this.lblPulpContent.Size = new System.Drawing.Size(84, 13);
            this.lblPulpContent.TabIndex = 10;
            this.lblPulpContent.Text = "Pulp content(%):";
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
            // tbJuiceContent
            // 
            this.tbJuiceContent.Location = new System.Drawing.Point(111, 123);
            this.tbJuiceContent.Name = "tbJuiceContent";
            this.tbJuiceContent.Size = new System.Drawing.Size(185, 20);
            this.tbJuiceContent.TabIndex = 9;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(111, 45);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(185, 20);
            this.tbCost.TabIndex = 3;
            // 
            // lblJuiceContent
            // 
            this.lblJuiceContent.AutoSize = true;
            this.lblJuiceContent.Location = new System.Drawing.Point(17, 126);
            this.lblJuiceContent.Name = "lblJuiceContent";
            this.lblJuiceContent.Size = new System.Drawing.Size(88, 13);
            this.lblJuiceContent.TabIndex = 8;
            this.lblJuiceContent.Text = "Juicec ontent(%):";
            // 
            // tbSugarContent
            // 
            this.tbSugarContent.Location = new System.Drawing.Point(111, 71);
            this.tbSugarContent.Name = "tbSugarContent";
            this.tbSugarContent.Size = new System.Drawing.Size(185, 20);
            this.tbSugarContent.TabIndex = 4;
            // 
            // lblSugarContent
            // 
            this.lblSugarContent.AutoSize = true;
            this.lblSugarContent.Location = new System.Drawing.Point(14, 74);
            this.lblSugarContent.Name = "lblSugarContent";
            this.lblSugarContent.Size = new System.Drawing.Size(91, 13);
            this.lblSugarContent.TabIndex = 5;
            this.lblSugarContent.Text = "Sugar content(%):";
            // 
            // lblFruit
            // 
            this.lblFruit.AutoSize = true;
            this.lblFruit.Location = new System.Drawing.Point(75, 103);
            this.lblFruit.Name = "lblFruit";
            this.lblFruit.Size = new System.Drawing.Size(30, 13);
            this.lblFruit.TabIndex = 6;
            this.lblFruit.Text = "Fruit:";
            // 
            // EditJuiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 206);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEditBottle);
            this.Controls.Add(this.gbEditWine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditJuiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit juice";
            this.gbEditBottle.ResumeLayout(false);
            this.gbEditBottle.PerformLayout();
            this.gbEditWine.ResumeLayout(false);
            this.gbEditWine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbEditBottle;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.GroupBox gbEditWine;
        private System.Windows.Forms.TextBox tbFruit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPulpContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPulpContent;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbJuiceContent;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lblJuiceContent;
        private System.Windows.Forms.TextBox tbSugarContent;
        private System.Windows.Forms.Label lblSugarContent;
        private System.Windows.Forms.Label lblFruit;
    }
}