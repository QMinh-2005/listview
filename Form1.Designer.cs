namespace Bai17_Listview
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Yonex As33",
            "17tr"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "02",
            "Yonex As5",
            "15tr",
            "1"}, -1);
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.lvMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvMa,
            this.lvTen,
            this.lvGia});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvSanPham.Location = new System.Drawing.Point(86, 150);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(397, 247);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSanPham_ColumnClick);
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvMa
            // 
            this.lvMa.Text = "Mã Sản Phẩm";
            this.lvMa.Width = 100;
            // 
            // lvTen
            // 
            this.lvTen.Text = "Tên Sản Phẩm";
            this.lvTen.Width = 100;
            // 
            // lvGia
            // 
            this.lvGia.Text = "Giá Sản Phẩm";
            this.lvGia.Width = 100;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(245, 23);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(245, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(245, 94);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 2;
            // 
            // lblMa
            // 
            this.lblMa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(100, 23);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(29, 16);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "Mã ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(100, 54);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(100, 100);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(31, 16);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(400, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(400, 52);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(83, 23);
            this.btnRemoveAt.TabIndex = 5;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 81);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lvSanPham);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader lvMa;
        private System.Windows.Forms.ColumnHeader lvTen;
        private System.Windows.Forms.ColumnHeader lvGia;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnRemove;
    }
}

