
namespace Project.PL
{
    partial class SaleUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addbillbtn = new System.Windows.Forms.Button();
            this.deleteinbillbtn = new System.Windows.Forms.Button();
            this.addtobillbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.billdgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productdgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdgv)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addbillbtn);
            this.panel1.Controls.Add(this.deleteinbillbtn);
            this.panel1.Controls.Add(this.addtobillbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(50, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 673);
            this.panel1.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "All"});
            this.cbbType.Location = new System.Drawing.Point(417, 74);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 21);
            this.cbbType.TabIndex = 22;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(351, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 20);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tìm kiếm hàng hóa";
            // 
            // addbillbtn
            // 
            this.addbillbtn.Location = new System.Drawing.Point(556, 412);
            this.addbillbtn.Name = "addbillbtn";
            this.addbillbtn.Size = new System.Drawing.Size(129, 39);
            this.addbillbtn.TabIndex = 17;
            this.addbillbtn.Text = "Tạo hóa đơn";
            this.addbillbtn.UseVisualStyleBackColor = true;
            this.addbillbtn.Click += new System.EventHandler(this.addbillbtn_Click_1);
            // 
            // deleteinbillbtn
            // 
            this.deleteinbillbtn.Location = new System.Drawing.Point(556, 339);
            this.deleteinbillbtn.Name = "deleteinbillbtn";
            this.deleteinbillbtn.Size = new System.Drawing.Size(129, 39);
            this.deleteinbillbtn.TabIndex = 16;
            this.deleteinbillbtn.Text = "Xóa sản phẩm";
            this.deleteinbillbtn.UseVisualStyleBackColor = true;
            this.deleteinbillbtn.Click += new System.EventHandler(this.deleteinbillbtn_Click_1);
            // 
            // addtobillbtn
            // 
            this.addtobillbtn.Location = new System.Drawing.Point(556, 274);
            this.addtobillbtn.Name = "addtobillbtn";
            this.addtobillbtn.Size = new System.Drawing.Size(129, 39);
            this.addtobillbtn.TabIndex = 12;
            this.addtobillbtn.Text = "Thêm sản phẩm";
            this.addtobillbtn.UseVisualStyleBackColor = true;
            this.addtobillbtn.Click += new System.EventHandler(this.addtobillbtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(865, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hàng hóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.billdgv);
            this.panel2.Location = new System.Drawing.Point(705, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 528);
            this.panel2.TabIndex = 13;
            // 
            // billdgv
            // 
            this.billdgv.AllowUserToAddRows = false;
            this.billdgv.AllowUserToDeleteRows = false;
            this.billdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ten,
            this.Gia,
            this.SoLuong,
            this.KhoId,
            this.DanhMuc});
            this.billdgv.Location = new System.Drawing.Point(0, 0);
            this.billdgv.Name = "billdgv";
            this.billdgv.Size = new System.Drawing.Size(445, 528);
            this.billdgv.TabIndex = 0;
            this.billdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billdgv_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id Mặt Hàng";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên Sản Phẩm";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // KhoId
            // 
            this.KhoId.HeaderText = "Kho";
            this.KhoId.Name = "KhoId";
            this.KhoId.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productdgv);
            this.panel3.Location = new System.Drawing.Point(34, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 528);
            this.panel3.TabIndex = 11;
            // 
            // productdgv
            // 
            this.productdgv.AllowUserToAddRows = false;
            this.productdgv.AllowUserToDeleteRows = false;
            this.productdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdgv.Location = new System.Drawing.Point(-3, 3);
            this.productdgv.Name = "productdgv";
            this.productdgv.Size = new System.Drawing.Size(503, 546);
            this.productdgv.TabIndex = 0;
            this.productdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdgv_CellClick);
            // 
            // SaleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.mid_season_sale_252613;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panel1);
            this.Name = "SaleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleUI";
            this.Load += new System.EventHandler(this.SaleUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billdgv)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbillbtn;
        private System.Windows.Forms.Button deleteinbillbtn;
        private System.Windows.Forms.Button addtobillbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView billdgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView productdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.ComboBox cbbType;
    }
}