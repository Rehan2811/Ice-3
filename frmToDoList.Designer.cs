
namespace ToDoApp
{
    partial class formToDoList
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
            this.txbItem = new System.Windows.Forms.TextBox();
            this.cmbLevels = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbItem
            // 
            this.txbItem.Location = new System.Drawing.Point(12, 37);
            this.txbItem.Name = "txbItem";
            this.txbItem.Size = new System.Drawing.Size(201, 27);
            this.txbItem.TabIndex = 0;
            // 
            // cmbLevels
            // 
            this.cmbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevels.FormattingEnabled = true;
            this.cmbLevels.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbLevels.Location = new System.Drawing.Point(256, 37);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.Size = new System.Drawing.Size(243, 28);
            this.cmbLevels.TabIndex = 1;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(12, 126);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(487, 304);
            this.lstItems.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(537, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.cmbLevels);
            this.Controls.Add(this.txbItem);
            this.Name = "formToDoList";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbItem;
        private System.Windows.Forms.ComboBox cmbLevels;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
    }
}

