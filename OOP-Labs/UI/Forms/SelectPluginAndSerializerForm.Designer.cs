namespace UI.Forms
{
    partial class SelectPluginAndSerializerForm
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
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.cbFileFormat = new System.Windows.Forms.ComboBox();
            this.lblPlugin = new System.Windows.Forms.Label();
            this.cbPlugin = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.Location = new System.Drawing.Point(12, 9);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(58, 13);
            this.lblFileFormat.TabIndex = 0;
            this.lblFileFormat.Text = "File format:";
            // 
            // cbFileFormat
            // 
            this.cbFileFormat.FormattingEnabled = true;
            this.cbFileFormat.Location = new System.Drawing.Point(15, 25);
            this.cbFileFormat.Name = "cbFileFormat";
            this.cbFileFormat.Size = new System.Drawing.Size(211, 21);
            this.cbFileFormat.TabIndex = 1;
            this.cbFileFormat.SelectedIndexChanged += new System.EventHandler(this.cbFileFormat_SelectedIndexChanged);
            // 
            // lblPlugin
            // 
            this.lblPlugin.AutoSize = true;
            this.lblPlugin.Location = new System.Drawing.Point(12, 59);
            this.lblPlugin.Name = "lblPlugin";
            this.lblPlugin.Size = new System.Drawing.Size(39, 13);
            this.lblPlugin.TabIndex = 2;
            this.lblPlugin.Text = "Plugin:";
            // 
            // cbPlugin
            // 
            this.cbPlugin.FormattingEnabled = true;
            this.cbPlugin.Location = new System.Drawing.Point(16, 75);
            this.cbPlugin.Name = "cbPlugin";
            this.cbPlugin.Size = new System.Drawing.Size(211, 21);
            this.cbPlugin.TabIndex = 3;
            this.cbPlugin.SelectedIndexChanged += new System.EventHandler(this.cbPlugin_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SelectPluginAndSerializerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 146);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPlugin);
            this.Controls.Add(this.lblPlugin);
            this.Controls.Add(this.cbFileFormat);
            this.Controls.Add(this.lblFileFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectPluginAndSerializerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select plugin and serializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.ComboBox cbFileFormat;
        private System.Windows.Forms.Label lblPlugin;
        private System.Windows.Forms.ComboBox cbPlugin;
        private System.Windows.Forms.Button btnSave;
    }
}