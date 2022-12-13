namespace ArraysEnMethodes_FayaazAbdoel
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
            this.lbNames = new System.Windows.Forms.ListBox();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowArrayLength = new System.Windows.Forms.Button();
            this.txtNewArrayItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArrayLength = new System.Windows.Forms.Label();
            this.btnVulGetalArray = new System.Windows.Forms.Button();
            this.lstGetallen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 16;
            this.lbNames.Location = new System.Drawing.Point(12, 12);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(262, 340);
            this.lbNames.TabIndex = 0;
            // 
            // btnShowArray
            // 
            this.btnShowArray.Location = new System.Drawing.Point(295, 21);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(160, 30);
            this.btnShowArray.TabIndex = 1;
            this.btnShowArray.Text = "Toon Array";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Location = new System.Drawing.Point(295, 57);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(160, 30);
            this.btnSortAsc.TabIndex = 2;
            this.btnSortAsc.Text = "Sorteer Oplopend";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Location = new System.Drawing.Point(295, 93);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(160, 30);
            this.btnSortDesc.TabIndex = 3;
            this.btnSortDesc.Text = "Sorteer Aflopend";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(295, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Voeg Nieuw Item Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowArrayLength
            // 
            this.btnShowArrayLength.Location = new System.Drawing.Point(295, 193);
            this.btnShowArrayLength.Name = "btnShowArrayLength";
            this.btnShowArrayLength.Size = new System.Drawing.Size(160, 30);
            this.btnShowArrayLength.TabIndex = 5;
            this.btnShowArrayLength.Text = "Toon Lengte";
            this.btnShowArrayLength.UseVisualStyleBackColor = true;
            this.btnShowArrayLength.Click += new System.EventHandler(this.btnShowArrayLength_Click);
            // 
            // txtNewArrayItem
            // 
            this.txtNewArrayItem.Location = new System.Drawing.Point(297, 165);
            this.txtNewArrayItem.Name = "txtNewArrayItem";
            this.txtNewArrayItem.Size = new System.Drawing.Size(158, 22);
            this.txtNewArrayItem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Array Lengte:";
            // 
            // lblArrayLength
            // 
            this.lblArrayLength.AutoSize = true;
            this.lblArrayLength.Location = new System.Drawing.Point(386, 226);
            this.lblArrayLength.Name = "lblArrayLength";
            this.lblArrayLength.Size = new System.Drawing.Size(14, 16);
            this.lblArrayLength.TabIndex = 8;
            this.lblArrayLength.Text = "0";
            // 
            // btnVulGetalArray
            // 
            this.btnVulGetalArray.Location = new System.Drawing.Point(628, 23);
            this.btnVulGetalArray.Name = "btnVulGetalArray";
            this.btnVulGetalArray.Size = new System.Drawing.Size(160, 28);
            this.btnVulGetalArray.TabIndex = 9;
            this.btnVulGetalArray.Text = "Vul Getal Array";
            this.btnVulGetalArray.UseVisualStyleBackColor = true;
            this.btnVulGetalArray.Click += new System.EventHandler(this.btnVulGetalArray_Click);
            // 
            // lstGetallen
            // 
            this.lstGetallen.FormattingEnabled = true;
            this.lstGetallen.ItemHeight = 16;
            this.lstGetallen.Location = new System.Drawing.Point(461, 12);
            this.lstGetallen.Name = "lstGetallen";
            this.lstGetallen.Size = new System.Drawing.Size(160, 340);
            this.lstGetallen.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstGetallen);
            this.Controls.Add(this.btnVulGetalArray);
            this.Controls.Add(this.lblArrayLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewArrayItem);
            this.Controls.Add(this.btnShowArrayLength);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.lbNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Button btnShowArray;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowArrayLength;
        private System.Windows.Forms.TextBox txtNewArrayItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArrayLength;
        private System.Windows.Forms.Button btnVulGetalArray;
        private System.Windows.Forms.ListBox lstGetallen;
    }
}

