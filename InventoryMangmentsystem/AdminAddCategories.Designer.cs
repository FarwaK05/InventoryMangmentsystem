namespace InventoryMangmentsystem
{
    partial class AdminAddCategories
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCatagories_clearBtn = new System.Windows.Forms.Button();
            this.addCatagories_removeBtn = new System.Windows.Forms.Button();
            this.addCatagories_updateBtn = new System.Windows.Forms.Button();
            this.addCatagories_addBtn = new System.Windows.Forms.Button();
            this.addCatagories_catagory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(385, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 707);
            this.panel2.TabIndex = 5;
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
            this.dataGridView1.Location = new System.Drawing.Point(17, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 604);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "All Catagories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addCatagories_clearBtn);
            this.panel1.Controls.Add(this.addCatagories_removeBtn);
            this.panel1.Controls.Add(this.addCatagories_updateBtn);
            this.panel1.Controls.Add(this.addCatagories_addBtn);
            this.panel1.Controls.Add(this.addCatagories_catagory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 707);
            this.panel1.TabIndex = 4;
            // 
            // addCatagories_clearBtn
            // 
            this.addCatagories_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCatagories_clearBtn.FlatAppearance.BorderSize = 0;
            this.addCatagories_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatagories_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagories_clearBtn.Location = new System.Drawing.Point(195, 222);
            this.addCatagories_clearBtn.Name = "addCatagories_clearBtn";
            this.addCatagories_clearBtn.Size = new System.Drawing.Size(106, 37);
            this.addCatagories_clearBtn.TabIndex = 11;
            this.addCatagories_clearBtn.Text = "Clear";
            this.addCatagories_clearBtn.UseVisualStyleBackColor = false;
            this.addCatagories_clearBtn.Click += new System.EventHandler(this.addCatagories_clearBtn_Click);
            // 
            // addCatagories_removeBtn
            // 
            this.addCatagories_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCatagories_removeBtn.FlatAppearance.BorderSize = 0;
            this.addCatagories_removeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatagories_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagories_removeBtn.Location = new System.Drawing.Point(45, 222);
            this.addCatagories_removeBtn.Name = "addCatagories_removeBtn";
            this.addCatagories_removeBtn.Size = new System.Drawing.Size(116, 37);
            this.addCatagories_removeBtn.TabIndex = 10;
            this.addCatagories_removeBtn.Text = "Remove";
            this.addCatagories_removeBtn.UseVisualStyleBackColor = false;
            this.addCatagories_removeBtn.Click += new System.EventHandler(this.addCatagories_removeBtn_Click);
            // 
            // addCatagories_updateBtn
            // 
            this.addCatagories_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCatagories_updateBtn.FlatAppearance.BorderSize = 0;
            this.addCatagories_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatagories_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagories_updateBtn.Location = new System.Drawing.Point(195, 151);
            this.addCatagories_updateBtn.Name = "addCatagories_updateBtn";
            this.addCatagories_updateBtn.Size = new System.Drawing.Size(106, 37);
            this.addCatagories_updateBtn.TabIndex = 9;
            this.addCatagories_updateBtn.Text = "Update";
            this.addCatagories_updateBtn.UseVisualStyleBackColor = false;
            this.addCatagories_updateBtn.Click += new System.EventHandler(this.addCatagories_updateBtn_Click);
            // 
            // addCatagories_addBtn
            // 
            this.addCatagories_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCatagories_addBtn.FlatAppearance.BorderSize = 0;
            this.addCatagories_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCatagories_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatagories_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagories_addBtn.Location = new System.Drawing.Point(45, 151);
            this.addCatagories_addBtn.Name = "addCatagories_addBtn";
            this.addCatagories_addBtn.Size = new System.Drawing.Size(106, 37);
            this.addCatagories_addBtn.TabIndex = 8;
            this.addCatagories_addBtn.Text = "Add";
            this.addCatagories_addBtn.UseVisualStyleBackColor = false;
            this.addCatagories_addBtn.Click += new System.EventHandler(this.addCatagories_addBtn_Click);
            // 
            // addCatagories_catagory
            // 
            this.addCatagories_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagories_catagory.Location = new System.Drawing.Point(45, 83);
            this.addCatagories_catagory.Name = "addCatagories_catagory";
            this.addCatagories_catagory.Size = new System.Drawing.Size(260, 34);
            this.addCatagories_catagory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory";
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1107, 756);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCatagories_clearBtn;
        private System.Windows.Forms.Button addCatagories_removeBtn;
        private System.Windows.Forms.Button addCatagories_updateBtn;
        private System.Windows.Forms.Button addCatagories_addBtn;
        private System.Windows.Forms.TextBox addCatagories_catagory;
        private System.Windows.Forms.Label label1;
    }
}
