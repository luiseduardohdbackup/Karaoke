namespace Karaoke.MDIForms
{
    partial class frmQuanLyLoaiVanDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLoaiVanDe));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlLoaiVanDe = new DevExpress.XtraGrid.GridControl();
            this.gridViewLoaiVanDe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDLoaiVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteLoaiVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemcboTenNguyenLieu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiVanDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiVanDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemcboTenNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(138, 285);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 53);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridControlLoaiVanDe
            // 
            this.gridControlLoaiVanDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlLoaiVanDe.EmbeddedNavigator.Name = "";
            this.gridControlLoaiVanDe.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridControlLoaiVanDe.FormsUseDefaultLookAndFeel = false;
            this.gridControlLoaiVanDe.Location = new System.Drawing.Point(1, 1);
            this.gridControlLoaiVanDe.MainView = this.gridViewLoaiVanDe;
            this.gridControlLoaiVanDe.Name = "gridControlLoaiVanDe";
            this.gridControlLoaiVanDe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemcboTenNguyenLieu,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControlLoaiVanDe.Size = new System.Drawing.Size(396, 269);
            this.gridControlLoaiVanDe.TabIndex = 4;
            this.gridControlLoaiVanDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoaiVanDe});
            // 
            // gridViewLoaiVanDe
            // 
            this.gridViewLoaiVanDe.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLoaiVanDe.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewLoaiVanDe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDLoaiVD,
            this.TenVD,
            this.Ghichu,
            this.colDeleteLoaiVD});
            this.gridViewLoaiVanDe.GridControl = this.gridControlLoaiVanDe;
            this.gridViewLoaiVanDe.Name = "gridViewLoaiVanDe";
            this.gridViewLoaiVanDe.NewItemRowText = "Chọn Sản phẩm, Click vào đây để thêm mới";
            this.gridViewLoaiVanDe.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewLoaiVanDe.OptionsView.ShowGroupPanel = false;
            this.gridViewLoaiVanDe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewLoaiVanDe_FocusedRowChanged);
            this.gridViewLoaiVanDe.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewLoaiVanDe_CellValueChanged);
            this.gridViewLoaiVanDe.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewLoaiVanDe_CellValueChanging);
            this.gridViewLoaiVanDe.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewLoaiVanDe_RowUpdated);
            // 
            // IDLoaiVD
            // 
            this.IDLoaiVD.Caption = "IDLoaiVD";
            this.IDLoaiVD.FieldName = "IDLoaiVD";
            this.IDLoaiVD.Name = "IDLoaiVD";
            // 
            // TenVD
            // 
            this.TenVD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TenVD.AppearanceCell.Options.UseFont = true;
            this.TenVD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TenVD.AppearanceHeader.Options.UseFont = true;
            this.TenVD.Caption = "Tên vấn đề";
            this.TenVD.FieldName = "TenVD";
            this.TenVD.Name = "TenVD";
            this.TenVD.Visible = true;
            this.TenVD.VisibleIndex = 0;
            this.TenVD.Width = 108;
            // 
            // Ghichu
            // 
            this.Ghichu.Caption = "Ghi chú";
            this.Ghichu.FieldName = "Ghichu";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Visible = true;
            this.Ghichu.VisibleIndex = 1;
            this.Ghichu.Width = 108;
            // 
            // colDeleteLoaiVD
            // 
            this.colDeleteLoaiVD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colDeleteLoaiVD.AppearanceCell.Options.UseFont = true;
            this.colDeleteLoaiVD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colDeleteLoaiVD.AppearanceHeader.Options.UseFont = true;
            this.colDeleteLoaiVD.Caption = "Xóa";
            this.colDeleteLoaiVD.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colDeleteLoaiVD.FieldName = "DeleteLoaiVD";
            this.colDeleteLoaiVD.Name = "colDeleteLoaiVD";
            this.colDeleteLoaiVD.Visible = true;
            this.colDeleteLoaiVD.VisibleIndex = 2;
            this.colDeleteLoaiVD.Width = 70;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.PictureChecked = global::Karaoke.Properties.Resources._1325149327_recycle_bin;
            this.repositoryItemCheckEdit1.PictureGrayed = global::Karaoke.Properties.Resources._1325149327_recycle_bin;
            this.repositoryItemCheckEdit1.PictureUnchecked = global::Karaoke.Properties.Resources._1325149282_button_ok;
            // 
            // repositoryItemcboTenNguyenLieu
            // 
            this.repositoryItemcboTenNguyenLieu.AutoHeight = false;
            this.repositoryItemcboTenNguyenLieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemcboTenNguyenLieu.Name = "repositoryItemcboTenNguyenLieu";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmQuanLyLoaiVanDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridControlLoaiVanDe);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyLoaiVanDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các loại vấn đề thường gặp";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiVanDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiVanDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiVanDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemcboTenNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl gridControlLoaiVanDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiVanDe;
        private DevExpress.XtraGrid.Columns.GridColumn IDLoaiVD;
        private DevExpress.XtraGrid.Columns.GridColumn TenVD;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemcboTenNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteLoaiVD;
        private DevExpress.XtraGrid.Columns.GridColumn Ghichu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}