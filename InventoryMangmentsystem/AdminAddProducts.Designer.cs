namespace InventoryMangmentsystem
{
    partial class AdminAddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProducts_addBtn = new System.Windows.Forms.Button();
            this.addProducts_updateBtn = new System.Windows.Forms.Button();
            this.addProducts_removeBtn = new System.Windows.Forms.Button();
            this.addProducts_clearBtn = new System.Windows.Forms.Button();
            this.addProducts_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addProducts_imageView = new System.Windows.Forms.PictureBox();
            this.addProducts_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProducts_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProducts_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProducts_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProducts_prodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProducts_prodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Prode);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 394);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(18, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // Prode
            // 
            this.Prode.AutoSize = true;
            this.Prode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prode.Location = new System.Drawing.Point(32, 19);
            this.Prode.Name = "Prode";
            this.Prode.Size = new System.Drawing.Size(128, 23);
            this.Prode.TabIndex = 1;
            this.Prode.Text = "All Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addProducts_addBtn);
            this.panel2.Controls.Add(this.addProducts_updateBtn);
            this.panel2.Controls.Add(this.addProducts_removeBtn);
            this.panel2.Controls.Add(this.addProducts_clearBtn);
            this.panel2.Controls.Add(this.addProducts_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addProducts_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProducts_stock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addProducts_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProducts_category);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addProducts_prodName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addProducts_prodID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 274);
            this.panel2.TabIndex = 1;
            // 
            // addProducts_addBtn
            // 
            this.addProducts_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProducts_addBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_addBtn.Location = new System.Drawing.Point(45, 212);
            this.addProducts_addBtn.Name = "addProducts_addBtn";
            this.addProducts_addBtn.Size = new System.Drawing.Size(157, 33);
            this.addProducts_addBtn.TabIndex = 17;
            this.addProducts_addBtn.Text = "Add";
            this.addProducts_addBtn.UseVisualStyleBackColor = false;
            this.addProducts_addBtn.Click += new System.EventHandler(this.addProducts_addBtn_Click);
            // 
            // addProducts_updateBtn
            // 
            this.addProducts_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProducts_updateBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_updateBtn.Location = new System.Drawing.Point(236, 212);
            this.addProducts_updateBtn.Name = "addProducts_updateBtn";
            this.addProducts_updateBtn.Size = new System.Drawing.Size(157, 33);
            this.addProducts_updateBtn.TabIndex = 16;
            this.addProducts_updateBtn.Text = "Update";
            this.addProducts_updateBtn.UseVisualStyleBackColor = false;
            this.addProducts_updateBtn.Click += new System.EventHandler(this.addProducts_updateBtn_Click);
            // 
            // addProducts_removeBtn
            // 
            this.addProducts_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProducts_removeBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_removeBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_removeBtn.Location = new System.Drawing.Point(432, 212);
            this.addProducts_removeBtn.Name = "addProducts_removeBtn";
            this.addProducts_removeBtn.Size = new System.Drawing.Size(157, 33);
            this.addProducts_removeBtn.TabIndex = 15;
            this.addProducts_removeBtn.Text = "Remove";
            this.addProducts_removeBtn.UseVisualStyleBackColor = false;
            // 
            // addProducts_clearBtn
            // 
            this.addProducts_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProducts_clearBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_clearBtn.Location = new System.Drawing.Point(644, 212);
            this.addProducts_clearBtn.Name = "addProducts_clearBtn";
            this.addProducts_clearBtn.Size = new System.Drawing.Size(157, 33);
            this.addProducts_clearBtn.TabIndex = 14;
            this.addProducts_clearBtn.Text = "Clear";
            this.addProducts_clearBtn.UseVisualStyleBackColor = false;
            this.addProducts_clearBtn.Click += new System.EventHandler(this.addProducts_clearBtn_Click);
            // 
            // addProducts_importBtn
            // 
            this.addProducts_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProducts_importBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_importBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_importBtn.Location = new System.Drawing.Point(850, 190);
            this.addProducts_importBtn.Name = "addProducts_importBtn";
            this.addProducts_importBtn.Size = new System.Drawing.Size(157, 33);
            this.addProducts_importBtn.TabIndex = 13;
            this.addProducts_importBtn.Text = "Import";
            this.addProducts_importBtn.UseVisualStyleBackColor = false;
            this.addProducts_importBtn.Click += new System.EventHandler(this.addProducts_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.addProducts_imageView);
            this.panel3.Location = new System.Drawing.Point(850, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 141);
            this.panel3.TabIndex = 12;
            // 
            // addProducts_imageView
            // 
            this.addProducts_imageView.Location = new System.Drawing.Point(0, 0);
            this.addProducts_imageView.Name = "addProducts_imageView";
            this.addProducts_imageView.Size = new System.Drawing.Size(157, 141);
            this.addProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addProducts_imageView.TabIndex = 0;
            this.addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            this.addProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_status.FormattingEnabled = true;
            this.addProducts_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addProducts_status.Location = new System.Drawing.Point(542, 142);
            this.addProducts_status.Name = "addProducts_status";
            this.addProducts_status.Size = new System.Drawing.Size(232, 33);
            this.addProducts_status.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status : ";
            // 
            // addProducts_stock
            // 
            this.addProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_stock.Location = new System.Drawing.Point(542, 86);
            this.addProducts_stock.Name = "addProducts_stock";
            this.addProducts_stock.Size = new System.Drawing.Size(232, 30);
            this.addProducts_stock.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock : ";
            // 
            // addProducts_price
            // 
            this.addProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_price.Location = new System.Drawing.Point(542, 34);
            this.addProducts_price.Name = "addProducts_price";
            this.addProducts_price.Size = new System.Drawing.Size(232, 30);
            this.addProducts_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price ($) : ";
            // 
            // addProducts_category
            // 
            this.addProducts_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_category.FormattingEnabled = true;
            this.addProducts_category.Location = new System.Drawing.Point(161, 140);
            this.addProducts_category.Name = "addProducts_category";
            this.addProducts_category.Size = new System.Drawing.Size(232, 33);
            this.addProducts_category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category : ";
            // 
            // addProducts_prodName
            // 
            this.addProducts_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_prodName.Location = new System.Drawing.Point(161, 86);
            this.addProducts_prodName.Name = "addProducts_prodName";
            this.addProducts_prodName.Size = new System.Drawing.Size(232, 30);
            this.addProducts_prodName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product name :";
            // 
            // addProducts_prodID
            // 
            this.addProducts_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_prodID.Location = new System.Drawing.Point(161, 29);
            this.addProducts_prodID.Name = "addProducts_prodID";
            this.addProducts_prodID.Size = new System.Drawing.Size(182, 30);
            this.addProducts_prodID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1085, 712);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Prode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addProducts_prodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addProducts_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addProducts_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProducts_prodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox addProducts_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addProducts_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addProducts_importBtn;
        private System.Windows.Forms.PictureBox addProducts_imageView;
        private System.Windows.Forms.Button addProducts_addBtn;
        private System.Windows.Forms.Button addProducts_updateBtn;
        private System.Windows.Forms.Button addProducts_removeBtn;
        private System.Windows.Forms.Button addProducts_clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
