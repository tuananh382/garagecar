using buttoncustom;

namespace GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBoxTraCuuChinh = new System.Windows.Forms.TextBox();
            this.lblTraCuuChinh = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonTimTuongDoi = new System.Windows.Forms.RadioButton();
            this.radioButtonTimChinhXac = new System.Windows.Forms.RadioButton();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnDatLaiTraCuu = new buttoncustom.RJButton();
            this.btnTimKiemTraCuu = new buttoncustom.RJButton();
            this.flowLayoutPanelTimChinhXac = new System.Windows.Forms.FlowLayoutPanel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtBoxBienSoTraCuu = new System.Windows.Forms.TextBox();
            this.lblBienSoTraCuu = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.comboBoxHieuXeTraCuu = new System.Windows.Forms.ComboBox();
            this.hIEUXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGarageDataSet = new GUI.QuanLyGarageDataSet1();
            this.lblHieuXeTraCuu = new System.Windows.Forms.Label();
            this.paneldtgvTCuu = new System.Windows.Forms.Panel();
            this.dataGridViewTraCuu = new System.Windows.Forms.DataGridView();
            this.menuStripCongCu = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialogPSC = new System.Windows.Forms.PrintDialog();
            this.printDialogPTT = new System.Windows.Forms.PrintDialog();
            this.printDialogPhieuNhapVTPT = new System.Windows.Forms.PrintDialog();
            this.tPQuyDinh = new System.Windows.Forms.TabPage();
            this.rjButton1 = new buttoncustom.RJButton();
            this.panelQuyDinhHienHanh = new System.Windows.Forms.Panel();
            this.labelQuyDinhHienHanh = new System.Windows.Forms.Label();
            this.dataGridViewQuyDinhHienHanh = new System.Windows.Forms.DataGridView();
            this.buttonLamMoiQuyDinh = new buttoncustom.RJButton();
            this.pnCapNhatQuyDinh = new System.Windows.Forms.Panel();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCapNhatSoLoaiTienCong = new buttoncustom.RJButton();
            this.lblSoLoaiTienCong = new System.Windows.Forms.Label();
            this.txtBoxSoLoaiTienCong = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCapNhatSoLoaiVatTu = new buttoncustom.RJButton();
            this.lblSoLoaiVatTu = new System.Windows.Forms.Label();
            this.txtBoxSoLoaiVatTu = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnCapNhatSoXeSuaToiDa = new buttoncustom.RJButton();
            this.lblSoXeSuaChuaToiDa = new System.Windows.Forms.Label();
            this.txtBoxSoXeSuaChuaToiDa = new System.Windows.Forms.TextBox();
            this.tPBaoCao = new System.Windows.Forms.TabPage();
            this.tCtrlBaoCao = new DotNetBarTabcontrol();
            this.tPDoanhSo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBaoCaoDoanhSo = new System.Windows.Forms.DataGridView();
            this.pnlThang = new System.Windows.Forms.Panel();
            this.textBoxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.pnlChonThoiDiem = new System.Windows.Forms.Panel();
            this.textBoxNamBaoCao = new System.Windows.Forms.TextBox();
            this.textBoxThangBaoCao = new System.Windows.Forms.TextBox();
            this.labelNamBaoCao = new System.Windows.Forms.Label();
            this.labelThangBaoCao = new System.Windows.Forms.Label();
            this.btnBaoCaoDoanhSoMoi = new buttoncustom.RJButton();
            this.lblChonThoiDiem = new System.Windows.Forms.Label();
            this.btnLapBaoCaoDoanhSo = new buttoncustom.RJButton();
            this.tPBaoCaoTon = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.pnChonThoiDiem = new System.Windows.Forms.Panel();
            this.btnBaoCaoTonMoi = new buttoncustom.RJButton();
            this.lblChonThoiDiemTon = new System.Windows.Forms.Label();
            this.dateTimePickerChonThoiDiemBaoCaoTon = new System.Windows.Forms.DateTimePicker();
            this.btnLapBaoCaoTon = new buttoncustom.RJButton();
            this.tPChucNang = new System.Windows.Forms.TabPage();
            this.tCtrlChucNang = new DotNetBarTabcontrol();
            this.tPTiepNhan = new System.Windows.Forms.TabPage();
            this.pnDanhSachTiepNhan = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new buttoncustom.RJButton();
            this.lblDanhSachTiepNhan = new System.Windows.Forms.Label();
            this.dataGridViewXeDaTiepNhan = new System.Windows.Forms.DataGridView();
            this.pnThemThongTinKHVaXe = new System.Windows.Forms.Panel();
            this.buttonClear = new buttoncustom.RJButton();
            this.buttonThemXe = new buttoncustom.RJButton();
            this.progressBarSoXeDaThem = new System.Windows.Forms.ProgressBar();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxHieuXe = new System.Windows.Forms.ComboBox();
            this.lblHieuXe = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBienSo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtBoxDienThoai = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTenKhachHang = new System.Windows.Forms.Label();
            this.txtBoxTenKH = new System.Windows.Forms.TextBox();
            this.tPPSC = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonNhapTienCongPhieuSuaChua = new buttoncustom.RJButton();
            this.comboBoxTienCongPhieuSuaChua = new System.Windows.Forms.ComboBox();
            this.tIENCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTienCongPhieuSuaChua = new System.Windows.Forms.Label();
            this.panelNhapPhieuSuaChua = new System.Windows.Forms.Panel();
            this.buttonNhapVTPTPhieuSuaChua = new buttoncustom.RJButton();
            this.buttonNhapPhieuSuaChua = new buttoncustom.RJButton();
            this.textBoxSoLuongVTPTPhieuSuaChua = new System.Windows.Forms.TextBox();
            this.labelSoLuongPhieuSuaChua = new System.Windows.Forms.Label();
            this.comboBoxVTPTPhieuSuaChua = new System.Windows.Forms.ComboBox();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelVTPTPhieuSuaChua = new System.Windows.Forms.Label();
            this.btnHoanTat = new buttoncustom.RJButton();
            this.textBoxTongTienPhieuSuaChua = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTaoMoiPCS = new buttoncustom.RJButton();
            this.btnInPhieuSuaChua = new buttoncustom.RJButton();
            this.btnLuuPSC = new buttoncustom.RJButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTienCongPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewVTPTPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.pnNgaySuaChua = new System.Windows.Forms.Panel();
            this.txtBoxNgaySuaChua = new System.Windows.Forms.TextBox();
            this.lblNgaySuaChua = new System.Windows.Forms.Label();
            this.pnlBienSoXe = new System.Windows.Forms.Panel();
            this.comboBoxBienSoXe1 = new System.Windows.Forms.ComboBox();
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBienSoXe = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPhieuSuaChua = new System.Windows.Forms.Label();
            this.tPPTT = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.buttonPhieuThuTienMoiPTT = new buttoncustom.RJButton();
            this.buttonInPhieuThuTienPTT = new buttoncustom.RJButton();
            this.buttonLapPhieuThuTienPTT = new buttoncustom.RJButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHoTenChuXePTT = new System.Windows.Forms.Panel();
            this.textBoxHoTenChuXePTT = new System.Windows.Forms.TextBox();
            this.labelHoTenChuXePTT = new System.Windows.Forms.Label();
            this.panelBienSoPTT = new System.Windows.Forms.Panel();
            this.comboBienSoXe2 = new System.Windows.Forms.ComboBox();
            this.labelBienSoPTT = new System.Windows.Forms.Label();
            this.panelDienThoaiPTT = new System.Windows.Forms.Panel();
            this.textBoxDienThoaiPTT = new System.Windows.Forms.TextBox();
            this.labelDienThoaiPTT = new System.Windows.Forms.Label();
            this.panelEmailPTT = new System.Windows.Forms.Panel();
            this.textBoxDiaChiPTT = new System.Windows.Forms.TextBox();
            this.labelEmailPTT = new System.Windows.Forms.Label();
            this.panelNgayThuTienPTT = new System.Windows.Forms.Panel();
            this.textBoxNgayThuTien = new System.Windows.Forms.TextBox();
            this.labelNgayThuTienPTT = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.labelSoTienThuPTT = new System.Windows.Forms.Label();
            this.textBoxSoTienThuPTT = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.lblPhieuThuTien = new System.Windows.Forms.Label();
            this.tPVTPT = new System.Windows.Forms.TabPage();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.labelGiaVTPT = new System.Windows.Forms.Label();
            this.textBoxGiaVTPT = new System.Windows.Forms.TextBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.labelTenVTPTMoi = new System.Windows.Forms.Label();
            this.textBoxTenVTPTMoi = new System.Windows.Forms.TextBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.labelSoLuongVTPT = new System.Windows.Forms.Label();
            this.textBoxSoLuongVTPT = new System.Windows.Forms.TextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.comboBoxTenVTPT = new System.Windows.Forms.ComboBox();
            this.labelTenVTPT = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.buttonTaoMoiVTPT = new buttoncustom.RJButton();
            this.buttonPhieuNhapVTPTMoi = new buttoncustom.RJButton();
            this.buttonInPhieuNhapVTPT = new buttoncustom.RJButton();
            this.buttonLapPhieuNhapVTPT = new buttoncustom.RJButton();
            this.panel25 = new System.Windows.Forms.Panel();
            this.labelPhieuNhapVTPT = new System.Windows.Forms.Label();
            this.tPTraCuu = new System.Windows.Forms.TabPage();
            this.tCtrlChinh = new DotNetBarTabcontrol();
            this.hIEUXETableAdapter = new GUI.QuanLyGarageDataSet1TableAdapters.HIEUXETableAdapter();
            this.xETableAdapter = new GUI.QuanLyGarageDataSet1TableAdapters.XETableAdapter();
            this.kHOTableAdapter = new GUI.QuanLyGarageDataSet1TableAdapters.KHOTableAdapter();
            this.tIENCONGTableAdapter = new GUI.QuanLyGarageDataSet1TableAdapters.TIENCONGTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel17.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel26.SuspendLayout();
            this.flowLayoutPanelTimChinhXac.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGarageDataSet)).BeginInit();
            this.paneldtgvTCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).BeginInit();
            this.menuStripCongCu.SuspendLayout();
            this.tPQuyDinh.SuspendLayout();
            this.panelQuyDinhHienHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyDinhHienHanh)).BeginInit();
            this.pnCapNhatQuyDinh.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tPBaoCao.SuspendLayout();
            this.tCtrlBaoCao.SuspendLayout();
            this.tPDoanhSo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).BeginInit();
            this.pnlThang.SuspendLayout();
            this.pnlChonThoiDiem.SuspendLayout();
            this.tPBaoCaoTon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoTon)).BeginInit();
            this.pnChonThoiDiem.SuspendLayout();
            this.tPChucNang.SuspendLayout();
            this.tCtrlChucNang.SuspendLayout();
            this.tPTiepNhan.SuspendLayout();
            this.pnDanhSachTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXeDaTiepNhan)).BeginInit();
            this.pnThemThongTinKHVaXe.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tPPSC.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIENCONGBindingSource)).BeginInit();
            this.panelNhapPhieuSuaChua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTienCongPhieuSuaChua)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVTPTPhieuSuaChua)).BeginInit();
            this.pnNgaySuaChua.SuspendLayout();
            this.pnlBienSoXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.tPPTT.SuspendLayout();
            this.panel23.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panelHoTenChuXePTT.SuspendLayout();
            this.panelBienSoPTT.SuspendLayout();
            this.panelDienThoaiPTT.SuspendLayout();
            this.panelEmailPTT.SuspendLayout();
            this.panelNgayThuTienPTT.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tPVTPT.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel25.SuspendLayout();
            this.tPTraCuu.SuspendLayout();
            this.tCtrlChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel26);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelTimChinhXac);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.paneldtgvTCuu);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1042, 512);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel5.Controls.Add(this.panel17);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(330, 162);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Controls.Add(this.textBoxTraCuuChinh);
            this.panel17.Controls.Add(this.lblTraCuuChinh);
            this.panel17.Location = new System.Drawing.Point(2, 2);
            this.panel17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(326, 36);
            this.panel17.TabIndex = 2;
            // 
            // textBoxTraCuuChinh
            // 
            this.textBoxTraCuuChinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxTraCuuChinh.Location = new System.Drawing.Point(87, 6);
            this.textBoxTraCuuChinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTraCuuChinh.Name = "textBoxTraCuuChinh";
            this.textBoxTraCuuChinh.Size = new System.Drawing.Size(202, 26);
            this.textBoxTraCuuChinh.TabIndex = 1;
            // 
            // lblTraCuuChinh
            // 
            this.lblTraCuuChinh.AutoSize = true;
            this.lblTraCuuChinh.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblTraCuuChinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTraCuuChinh.Location = new System.Drawing.Point(7, 8);
            this.lblTraCuuChinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTraCuuChinh.Name = "lblTraCuuChinh";
            this.lblTraCuuChinh.Size = new System.Drawing.Size(81, 22);
            this.lblTraCuuChinh.TabIndex = 0;
            this.lblTraCuuChinh.Text = "Từ khóa:";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel4.Controls.Add(this.radioButtonTimTuongDoi);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonTimChinhXac);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 42);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(188, 116);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // radioButtonTimTuongDoi
            // 
            this.radioButtonTimTuongDoi.AutoSize = true;
            this.radioButtonTimTuongDoi.Checked = true;
            this.radioButtonTimTuongDoi.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.radioButtonTimTuongDoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButtonTimTuongDoi.Location = new System.Drawing.Point(2, 2);
            this.radioButtonTimTuongDoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTimTuongDoi.Name = "radioButtonTimTuongDoi";
            this.radioButtonTimTuongDoi.Size = new System.Drawing.Size(141, 26);
            this.radioButtonTimTuongDoi.TabIndex = 2;
            this.radioButtonTimTuongDoi.TabStop = true;
            this.radioButtonTimTuongDoi.Text = "Tìm tương đối";
            this.radioButtonTimTuongDoi.UseVisualStyleBackColor = true;
            this.radioButtonTimTuongDoi.CheckedChanged += new System.EventHandler(this.RadioButtonTimTuongDoi_CheckedChanged);
            // 
            // radioButtonTimChinhXac
            // 
            this.radioButtonTimChinhXac.AutoSize = true;
            this.radioButtonTimChinhXac.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.radioButtonTimChinhXac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButtonTimChinhXac.Location = new System.Drawing.Point(2, 32);
            this.radioButtonTimChinhXac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTimChinhXac.Name = "radioButtonTimChinhXac";
            this.radioButtonTimChinhXac.Size = new System.Drawing.Size(139, 26);
            this.radioButtonTimChinhXac.TabIndex = 3;
            this.radioButtonTimChinhXac.TabStop = true;
            this.radioButtonTimChinhXac.Text = "Tìm chính xác";
            this.radioButtonTimChinhXac.UseVisualStyleBackColor = true;
            this.radioButtonTimChinhXac.CheckedChanged += new System.EventHandler(this.RadioButtonTimChinhXac_CheckedChanged);
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel26.Controls.Add(this.btnDatLaiTraCuu);
            this.panel26.Controls.Add(this.btnTimKiemTraCuu);
            this.panel26.Location = new System.Drawing.Point(5, 344);
            this.panel26.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(330, 162);
            this.panel26.TabIndex = 3;
            // 
            // btnDatLaiTraCuu
            // 
            this.btnDatLaiTraCuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatLaiTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatLaiTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDatLaiTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiTraCuu.Location = new System.Drawing.Point(68, 79);
            this.btnDatLaiTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatLaiTraCuu.Name = "btnDatLaiTraCuu";
            this.btnDatLaiTraCuu.Size = new System.Drawing.Size(181, 54);
            this.btnDatLaiTraCuu.TabIndex = 7;
            this.btnDatLaiTraCuu.Text = "Đặt lại";
            this.btnDatLaiTraCuu.UseVisualStyleBackColor = true;
            this.btnDatLaiTraCuu.Click += new System.EventHandler(this.BtnDatLaiTraCuu_Click);
            // 
            // btnTimKiemTraCuu
            // 
            this.btnTimKiemTraCuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiemTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnTimKiemTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTraCuu.Location = new System.Drawing.Point(68, 14);
            this.btnTimKiemTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemTraCuu.Name = "btnTimKiemTraCuu";
            this.btnTimKiemTraCuu.Size = new System.Drawing.Size(181, 52);
            this.btnTimKiemTraCuu.TabIndex = 6;
            this.btnTimKiemTraCuu.Text = "Tìm kiếm";
            this.btnTimKiemTraCuu.UseVisualStyleBackColor = true;
            this.btnTimKiemTraCuu.Click += new System.EventHandler(this.btnTimKiemTraCuu_Click);
            // 
            // flowLayoutPanelTimChinhXac
            // 
            this.flowLayoutPanelTimChinhXac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelTimChinhXac.Controls.Add(this.panel21);
            this.flowLayoutPanelTimChinhXac.Controls.Add(this.panel24);
            this.flowLayoutPanelTimChinhXac.Location = new System.Drawing.Point(5, 169);
            this.flowLayoutPanelTimChinhXac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelTimChinhXac.Name = "flowLayoutPanelTimChinhXac";
            this.flowLayoutPanelTimChinhXac.Size = new System.Drawing.Size(330, 171);
            this.flowLayoutPanelTimChinhXac.TabIndex = 2;
            this.flowLayoutPanelTimChinhXac.Visible = false;
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel21.Controls.Add(this.txtBoxBienSoTraCuu);
            this.panel21.Controls.Add(this.lblBienSoTraCuu);
            this.panel21.Location = new System.Drawing.Point(2, 2);
            this.panel21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(326, 79);
            this.panel21.TabIndex = 1;
            // 
            // txtBoxBienSoTraCuu
            // 
            this.txtBoxBienSoTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxBienSoTraCuu.Location = new System.Drawing.Point(87, 16);
            this.txtBoxBienSoTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxBienSoTraCuu.Name = "txtBoxBienSoTraCuu";
            this.txtBoxBienSoTraCuu.Size = new System.Drawing.Size(158, 26);
            this.txtBoxBienSoTraCuu.TabIndex = 4;
            // 
            // lblBienSoTraCuu
            // 
            this.lblBienSoTraCuu.AutoSize = true;
            this.lblBienSoTraCuu.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblBienSoTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBienSoTraCuu.Location = new System.Drawing.Point(7, 16);
            this.lblBienSoTraCuu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienSoTraCuu.Name = "lblBienSoTraCuu";
            this.lblBienSoTraCuu.Size = new System.Drawing.Size(81, 22);
            this.lblBienSoTraCuu.TabIndex = 0;
            this.lblBienSoTraCuu.Text = "Biển số :";
            // 
            // panel24
            // 
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel24.Controls.Add(this.comboBoxHieuXeTraCuu);
            this.panel24.Controls.Add(this.lblHieuXeTraCuu);
            this.panel24.Location = new System.Drawing.Point(2, 85);
            this.panel24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(326, 79);
            this.panel24.TabIndex = 4;
            // 
            // comboBoxHieuXeTraCuu
            // 
            this.comboBoxHieuXeTraCuu.DataSource = this.hIEUXEBindingSource;
            this.comboBoxHieuXeTraCuu.DisplayMember = "TenHieuXe";
            this.comboBoxHieuXeTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxHieuXeTraCuu.FormattingEnabled = true;
            this.comboBoxHieuXeTraCuu.Location = new System.Drawing.Point(87, 18);
            this.comboBoxHieuXeTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHieuXeTraCuu.Name = "comboBoxHieuXeTraCuu";
            this.comboBoxHieuXeTraCuu.Size = new System.Drawing.Size(158, 27);
            this.comboBoxHieuXeTraCuu.TabIndex = 5;
            this.comboBoxHieuXeTraCuu.ValueMember = "MaHX";
            // 
            // hIEUXEBindingSource
            // 
            this.hIEUXEBindingSource.DataMember = "HIEUXE";
            this.hIEUXEBindingSource.DataSource = this.quanLyGarageDataSet;
            // 
            // quanLyGarageDataSet
            // 
            this.quanLyGarageDataSet.DataSetName = "QuanLyGarageDataSet";
            this.quanLyGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHieuXeTraCuu
            // 
            this.lblHieuXeTraCuu.AutoSize = true;
            this.lblHieuXeTraCuu.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblHieuXeTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHieuXeTraCuu.Location = new System.Drawing.Point(7, 18);
            this.lblHieuXeTraCuu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHieuXeTraCuu.Name = "lblHieuXeTraCuu";
            this.lblHieuXeTraCuu.Size = new System.Drawing.Size(82, 22);
            this.lblHieuXeTraCuu.TabIndex = 0;
            this.lblHieuXeTraCuu.Text = "Hiệu xe :";
            // 
            // paneldtgvTCuu
            // 
            this.paneldtgvTCuu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldtgvTCuu.Controls.Add(this.dataGridViewTraCuu);
            this.paneldtgvTCuu.Location = new System.Drawing.Point(2, 5);
            this.paneldtgvTCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneldtgvTCuu.Name = "paneldtgvTCuu";
            this.paneldtgvTCuu.Size = new System.Drawing.Size(690, 505);
            this.paneldtgvTCuu.TabIndex = 0;
            // 
            // dataGridViewTraCuu
            // 
            this.dataGridViewTraCuu.AllowUserToAddRows = false;
            this.dataGridViewTraCuu.AllowUserToDeleteRows = false;
            this.dataGridViewTraCuu.AllowUserToResizeColumns = false;
            this.dataGridViewTraCuu.AllowUserToResizeRows = false;
            this.dataGridViewTraCuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewTraCuu.ColumnHeadersHeight = 29;
            this.dataGridViewTraCuu.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTraCuu.Name = "dataGridViewTraCuu";
            this.dataGridViewTraCuu.RowHeadersWidth = 51;
            this.dataGridViewTraCuu.RowTemplate.Height = 24;
            this.dataGridViewTraCuu.Size = new System.Drawing.Size(682, 498);
            this.dataGridViewTraCuu.TabIndex = 0;
            // 
            // menuStripCongCu
            // 
            this.menuStripCongCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStripCongCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripCongCu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStripCongCu.Location = new System.Drawing.Point(0, 0);
            this.menuStripCongCu.Name = "menuStripCongCu";
            this.menuStripCongCu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripCongCu.Size = new System.Drawing.Size(1256, 24);
            this.menuStripCongCu.TabIndex = 1;
            this.menuStripCongCu.Text = "Công cụ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.HướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.LiênHệToolStripMenuItem_Click);
            // 
            // printDialogPSC
            // 
            this.printDialogPSC.UseEXDialog = true;
            // 
            // printDialogPTT
            // 
            this.printDialogPTT.UseEXDialog = true;
            // 
            // printDialogPhieuNhapVTPT
            // 
            this.printDialogPhieuNhapVTPT.UseEXDialog = true;
            // 
            // tPQuyDinh
            // 
            this.tPQuyDinh.BackColor = System.Drawing.Color.White;
            this.tPQuyDinh.Controls.Add(this.panelQuyDinhHienHanh);
            this.tPQuyDinh.Controls.Add(this.pnCapNhatQuyDinh);
            this.tPQuyDinh.Location = new System.Drawing.Point(84, 4);
            this.tPQuyDinh.Margin = new System.Windows.Forms.Padding(0);
            this.tPQuyDinh.Name = "tPQuyDinh";
            this.tPQuyDinh.Size = new System.Drawing.Size(1150, 520);
            this.tPQuyDinh.TabIndex = 2;
            this.tPQuyDinh.Text = "Quy định";
            this.tPQuyDinh.Click += new System.EventHandler(this.tPQuyDinh_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(425, 465);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(109, 43);
            this.rjButton1.TabIndex = 10;
            this.rjButton1.Text = "Làm Mới";
            this.rjButton1.UseVisualStyleBackColor = true;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panelQuyDinhHienHanh
            // 
            this.panelQuyDinhHienHanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelQuyDinhHienHanh.Controls.Add(this.rjButton1);
            this.panelQuyDinhHienHanh.Controls.Add(this.labelQuyDinhHienHanh);
            this.panelQuyDinhHienHanh.Controls.Add(this.buttonLamMoiQuyDinh);
            this.panelQuyDinhHienHanh.Controls.Add(this.dataGridViewQuyDinhHienHanh);
            this.panelQuyDinhHienHanh.Location = new System.Drawing.Point(598, 3);
            this.panelQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelQuyDinhHienHanh.Name = "panelQuyDinhHienHanh";
            this.panelQuyDinhHienHanh.Size = new System.Drawing.Size(550, 515);
            this.panelQuyDinhHienHanh.TabIndex = 1;
            // 
            // labelQuyDinhHienHanh
            // 
            this.labelQuyDinhHienHanh.AutoSize = true;
            this.labelQuyDinhHienHanh.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.labelQuyDinhHienHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelQuyDinhHienHanh.Location = new System.Drawing.Point(80, 39);
            this.labelQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuyDinhHienHanh.Name = "labelQuyDinhHienHanh";
            this.labelQuyDinhHienHanh.Size = new System.Drawing.Size(385, 39);
            this.labelQuyDinhHienHanh.TabIndex = 1;
            this.labelQuyDinhHienHanh.Text = "QUY ĐỊNH HIỆN HÀNH";
            // 
            // dataGridViewQuyDinhHienHanh
            // 
            this.dataGridViewQuyDinhHienHanh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewQuyDinhHienHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyDinhHienHanh.Location = new System.Drawing.Point(0, 112);
            this.dataGridViewQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewQuyDinhHienHanh.Name = "dataGridViewQuyDinhHienHanh";
            this.dataGridViewQuyDinhHienHanh.RowHeadersWidth = 51;
            this.dataGridViewQuyDinhHienHanh.RowTemplate.Height = 24;
            this.dataGridViewQuyDinhHienHanh.Size = new System.Drawing.Size(544, 397);
            this.dataGridViewQuyDinhHienHanh.TabIndex = 0;
            // 
            // buttonLamMoiQuyDinh
            // 
            this.buttonLamMoiQuyDinh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonLamMoiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLamMoiQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLamMoiQuyDinh.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoiQuyDinh.Location = new System.Drawing.Point(300, 465);
            this.buttonLamMoiQuyDinh.Name = "buttonLamMoiQuyDinh";
            this.buttonLamMoiQuyDinh.Size = new System.Drawing.Size(119, 43);
            this.buttonLamMoiQuyDinh.TabIndex = 9;
            this.buttonLamMoiQuyDinh.Text = "Hoàn Tất";
            this.buttonLamMoiQuyDinh.UseVisualStyleBackColor = true;
            this.buttonLamMoiQuyDinh.Click += new System.EventHandler(this.ButtonLamMoiQuyDinh_Click);
            // 
            // pnCapNhatQuyDinh
            // 
            this.pnCapNhatQuyDinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCapNhatQuyDinh.Controls.Add(this.lblCapNhatQuyDinh);
            this.pnCapNhatQuyDinh.Controls.Add(this.panel11);
            this.pnCapNhatQuyDinh.Controls.Add(this.panel12);
            this.pnCapNhatQuyDinh.Controls.Add(this.panel13);
            this.pnCapNhatQuyDinh.Location = new System.Drawing.Point(4, 3);
            this.pnCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnCapNhatQuyDinh.Name = "pnCapNhatQuyDinh";
            this.pnCapNhatQuyDinh.Size = new System.Drawing.Size(590, 515);
            this.pnCapNhatQuyDinh.TabIndex = 0;
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(116, 39);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(368, 41);
            this.lblCapNhatQuyDinh.TabIndex = 11;
            this.lblCapNhatQuyDinh.Text = "CẬP NHẬT QUY ĐỊNH\r\n";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnCapNhatSoLoaiTienCong);
            this.panel11.Controls.Add(this.lblSoLoaiTienCong);
            this.panel11.Controls.Add(this.txtBoxSoLoaiTienCong);
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel11.Location = new System.Drawing.Point(2, 369);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(582, 72);
            this.panel11.TabIndex = 9;
            // 
            // btnCapNhatSoLoaiTienCong
            // 
            this.btnCapNhatSoLoaiTienCong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhatSoLoaiTienCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatSoLoaiTienCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCapNhatSoLoaiTienCong.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSoLoaiTienCong.Location = new System.Drawing.Point(439, 11);
            this.btnCapNhatSoLoaiTienCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatSoLoaiTienCong.Name = "btnCapNhatSoLoaiTienCong";
            this.btnCapNhatSoLoaiTienCong.Size = new System.Drawing.Size(124, 52);
            this.btnCapNhatSoLoaiTienCong.TabIndex = 12;
            this.btnCapNhatSoLoaiTienCong.Text = "Cập nhật";
            this.btnCapNhatSoLoaiTienCong.UseVisualStyleBackColor = true;
            this.btnCapNhatSoLoaiTienCong.Click += new System.EventHandler(this.btnCapNhatSoLoaiTienCong_Click);
            // 
            // lblSoLoaiTienCong
            // 
            this.lblSoLoaiTienCong.AutoSize = true;
            this.lblSoLoaiTienCong.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblSoLoaiTienCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSoLoaiTienCong.Location = new System.Drawing.Point(13, 25);
            this.lblSoLoaiTienCong.Name = "lblSoLoaiTienCong";
            this.lblSoLoaiTienCong.Size = new System.Drawing.Size(149, 22);
            this.lblSoLoaiTienCong.TabIndex = 2;
            this.lblSoLoaiTienCong.Text = "Số loại tiền công:";
            // 
            // txtBoxSoLoaiTienCong
            // 
            this.txtBoxSoLoaiTienCong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxSoLoaiTienCong.Location = new System.Drawing.Point(213, 25);
            this.txtBoxSoLoaiTienCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSoLoaiTienCong.Name = "txtBoxSoLoaiTienCong";
            this.txtBoxSoLoaiTienCong.Size = new System.Drawing.Size(192, 26);
            this.txtBoxSoLoaiTienCong.TabIndex = 1;
            this.txtBoxSoLoaiTienCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSoLoaiTienCong_KeyPress);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnCapNhatSoLoaiVatTu);
            this.panel12.Controls.Add(this.lblSoLoaiVatTu);
            this.panel12.Controls.Add(this.txtBoxSoLoaiVatTu);
            this.panel12.Location = new System.Drawing.Point(0, 234);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(584, 69);
            this.panel12.TabIndex = 8;
            // 
            // btnCapNhatSoLoaiVatTu
            // 
            this.btnCapNhatSoLoaiVatTu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhatSoLoaiVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatSoLoaiVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCapNhatSoLoaiVatTu.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSoLoaiVatTu.Location = new System.Drawing.Point(441, 13);
            this.btnCapNhatSoLoaiVatTu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatSoLoaiVatTu.Name = "btnCapNhatSoLoaiVatTu";
            this.btnCapNhatSoLoaiVatTu.Size = new System.Drawing.Size(124, 51);
            this.btnCapNhatSoLoaiVatTu.TabIndex = 12;
            this.btnCapNhatSoLoaiVatTu.Text = "Cập nhật";
            this.btnCapNhatSoLoaiVatTu.UseVisualStyleBackColor = true;
            this.btnCapNhatSoLoaiVatTu.Click += new System.EventHandler(this.btnCapNhatSoLoaiVatTu_Click);
            // 
            // lblSoLoaiVatTu
            // 
            this.lblSoLoaiVatTu.AutoSize = true;
            this.lblSoLoaiVatTu.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblSoLoaiVatTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSoLoaiVatTu.Location = new System.Drawing.Point(15, 26);
            this.lblSoLoaiVatTu.Name = "lblSoLoaiVatTu";
            this.lblSoLoaiVatTu.Size = new System.Drawing.Size(123, 22);
            this.lblSoLoaiVatTu.TabIndex = 2;
            this.lblSoLoaiVatTu.Text = "Số loại vật tư:";
            this.lblSoLoaiVatTu.Click += new System.EventHandler(this.lblSoLoaiVatTu_Click);
            // 
            // txtBoxSoLoaiVatTu
            // 
            this.txtBoxSoLoaiVatTu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxSoLoaiVatTu.Location = new System.Drawing.Point(215, 26);
            this.txtBoxSoLoaiVatTu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSoLoaiVatTu.Name = "txtBoxSoLoaiVatTu";
            this.txtBoxSoLoaiVatTu.Size = new System.Drawing.Size(192, 26);
            this.txtBoxSoLoaiVatTu.TabIndex = 1;
            this.txtBoxSoLoaiVatTu.TextChanged += new System.EventHandler(this.txtBoxSoLoaiVatTu_TextChanged);
            this.txtBoxSoLoaiVatTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSoLoaiVatTu_KeyPress);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnCapNhatSoXeSuaToiDa);
            this.panel13.Controls.Add(this.lblSoXeSuaChuaToiDa);
            this.panel13.Controls.Add(this.txtBoxSoXeSuaChuaToiDa);
            this.panel13.Location = new System.Drawing.Point(2, 109);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(582, 72);
            this.panel13.TabIndex = 7;
            // 
            // btnCapNhatSoXeSuaToiDa
            // 
            this.btnCapNhatSoXeSuaToiDa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhatSoXeSuaToiDa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatSoXeSuaToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCapNhatSoXeSuaToiDa.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSoXeSuaToiDa.Location = new System.Drawing.Point(439, 12);
            this.btnCapNhatSoXeSuaToiDa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatSoXeSuaToiDa.Name = "btnCapNhatSoXeSuaToiDa";
            this.btnCapNhatSoXeSuaToiDa.Size = new System.Drawing.Size(124, 50);
            this.btnCapNhatSoXeSuaToiDa.TabIndex = 12;
            this.btnCapNhatSoXeSuaToiDa.Text = "Cập nhật";
            this.btnCapNhatSoXeSuaToiDa.UseVisualStyleBackColor = true;
            this.btnCapNhatSoXeSuaToiDa.Click += new System.EventHandler(this.btnCapNhatSoXeSuaToiDa_Click);
            // 
            // lblSoXeSuaChuaToiDa
            // 
            this.lblSoXeSuaChuaToiDa.AutoSize = true;
            this.lblSoXeSuaChuaToiDa.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblSoXeSuaChuaToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSoXeSuaChuaToiDa.Location = new System.Drawing.Point(13, 20);
            this.lblSoXeSuaChuaToiDa.Name = "lblSoXeSuaChuaToiDa";
            this.lblSoXeSuaChuaToiDa.Size = new System.Drawing.Size(186, 22);
            this.lblSoXeSuaChuaToiDa.TabIndex = 2;
            this.lblSoXeSuaChuaToiDa.Text = "Số xe sửa chữa tối đa:";
            // 
            // txtBoxSoXeSuaChuaToiDa
            // 
            this.txtBoxSoXeSuaChuaToiDa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxSoXeSuaChuaToiDa.Location = new System.Drawing.Point(213, 19);
            this.txtBoxSoXeSuaChuaToiDa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSoXeSuaChuaToiDa.Name = "txtBoxSoXeSuaChuaToiDa";
            this.txtBoxSoXeSuaChuaToiDa.Size = new System.Drawing.Size(192, 26);
            this.txtBoxSoXeSuaChuaToiDa.TabIndex = 1;
            this.txtBoxSoXeSuaChuaToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSoXeSuaChuaToiDa_KeyPress);
            // 
            // tPBaoCao
            // 
            this.tPBaoCao.BackColor = System.Drawing.Color.White;
            this.tPBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tPBaoCao.Controls.Add(this.tCtrlBaoCao);
            this.tPBaoCao.Location = new System.Drawing.Point(84, 4);
            this.tPBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPBaoCao.Name = "tPBaoCao";
            this.tPBaoCao.Size = new System.Drawing.Size(1150, 520);
            this.tPBaoCao.TabIndex = 1;
            this.tPBaoCao.Text = "Báo cáo";
            this.tPBaoCao.Click += new System.EventHandler(this.tPBaoCao_Click);
            // 
            // tCtrlBaoCao
            // 
            this.tCtrlBaoCao.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tCtrlBaoCao.Controls.Add(this.tPDoanhSo);
            this.tCtrlBaoCao.Controls.Add(this.tPBaoCaoTon);
            this.tCtrlBaoCao.ItemSize = new System.Drawing.Size(40, 100);
            this.tCtrlBaoCao.Location = new System.Drawing.Point(0, 0);
            this.tCtrlBaoCao.Margin = new System.Windows.Forms.Padding(0);
            this.tCtrlBaoCao.Multiline = true;
            this.tCtrlBaoCao.Name = "tCtrlBaoCao";
            this.tCtrlBaoCao.SelectedIndex = 0;
            this.tCtrlBaoCao.Size = new System.Drawing.Size(1146, 516);
            this.tCtrlBaoCao.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tCtrlBaoCao.TabIndex = 0;
            // 
            // tPDoanhSo
            // 
            this.tPDoanhSo.BackColor = System.Drawing.Color.White;
            this.tPDoanhSo.Controls.Add(this.panel2);
            this.tPDoanhSo.Controls.Add(this.pnlChonThoiDiem);
            this.tPDoanhSo.Location = new System.Drawing.Point(104, 4);
            this.tPDoanhSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPDoanhSo.Name = "tPDoanhSo";
            this.tPDoanhSo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPDoanhSo.Size = new System.Drawing.Size(1038, 508);
            this.tPDoanhSo.TabIndex = 0;
            this.tPDoanhSo.Text = "Báo cáo doanh số";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewBaoCaoDoanhSo);
            this.panel2.Controls.Add(this.pnlThang);
            this.panel2.Location = new System.Drawing.Point(4, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 448);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewBaoCaoDoanhSo
            // 
            this.dataGridViewBaoCaoDoanhSo.AllowUserToAddRows = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToDeleteRows = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToResizeColumns = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToResizeRows = false;
            this.dataGridViewBaoCaoDoanhSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaoCaoDoanhSo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCaoDoanhSo.Location = new System.Drawing.Point(2, 48);
            this.dataGridViewBaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBaoCaoDoanhSo.Name = "dataGridViewBaoCaoDoanhSo";
            this.dataGridViewBaoCaoDoanhSo.ReadOnly = true;
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBaoCaoDoanhSo.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoDoanhSo.Size = new System.Drawing.Size(1026, 398);
            this.dataGridViewBaoCaoDoanhSo.TabIndex = 1;
            // 
            // pnlThang
            // 
            this.pnlThang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlThang.Controls.Add(this.textBoxTongDoanhThu);
            this.pnlThang.Controls.Add(this.lblTongDoanhThu);
            this.pnlThang.Location = new System.Drawing.Point(0, 2);
            this.pnlThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlThang.Name = "pnlThang";
            this.pnlThang.Size = new System.Drawing.Size(1028, 42);
            this.pnlThang.TabIndex = 0;
            // 
            // textBoxTongDoanhThu
            // 
            this.textBoxTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.textBoxTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxTongDoanhThu.Location = new System.Drawing.Point(388, 7);
            this.textBoxTongDoanhThu.Name = "textBoxTongDoanhThu";
            this.textBoxTongDoanhThu.ReadOnly = true;
            this.textBoxTongDoanhThu.Size = new System.Drawing.Size(185, 26);
            this.textBoxTongDoanhThu.TabIndex = 2;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(242, 11);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(141, 22);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "Tổng doanh thu :";
            // 
            // pnlChonThoiDiem
            // 
            this.pnlChonThoiDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChonThoiDiem.Controls.Add(this.textBoxNamBaoCao);
            this.pnlChonThoiDiem.Controls.Add(this.textBoxThangBaoCao);
            this.pnlChonThoiDiem.Controls.Add(this.labelNamBaoCao);
            this.pnlChonThoiDiem.Controls.Add(this.labelThangBaoCao);
            this.pnlChonThoiDiem.Controls.Add(this.btnBaoCaoDoanhSoMoi);
            this.pnlChonThoiDiem.Controls.Add(this.lblChonThoiDiem);
            this.pnlChonThoiDiem.Controls.Add(this.btnLapBaoCaoDoanhSo);
            this.pnlChonThoiDiem.Location = new System.Drawing.Point(4, 5);
            this.pnlChonThoiDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlChonThoiDiem.Name = "pnlChonThoiDiem";
            this.pnlChonThoiDiem.Size = new System.Drawing.Size(1030, 49);
            this.pnlChonThoiDiem.TabIndex = 0;
            // 
            // textBoxNamBaoCao
            // 
            this.textBoxNamBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNamBaoCao.Location = new System.Drawing.Point(546, 9);
            this.textBoxNamBaoCao.Name = "textBoxNamBaoCao";
            this.textBoxNamBaoCao.Size = new System.Drawing.Size(149, 26);
            this.textBoxNamBaoCao.TabIndex = 10;
            this.textBoxNamBaoCao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNamBaoCao_KeyPress);
            // 
            // textBoxThangBaoCao
            // 
            this.textBoxThangBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxThangBaoCao.Location = new System.Drawing.Point(291, 7);
            this.textBoxThangBaoCao.Name = "textBoxThangBaoCao";
            this.textBoxThangBaoCao.Size = new System.Drawing.Size(149, 26);
            this.textBoxThangBaoCao.TabIndex = 9;
            this.textBoxThangBaoCao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxThangBaoCao_KeyPress);
            // 
            // labelNamBaoCao
            // 
            this.labelNamBaoCao.AutoSize = true;
            this.labelNamBaoCao.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelNamBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelNamBaoCao.Location = new System.Drawing.Point(467, 9);
            this.labelNamBaoCao.Name = "labelNamBaoCao";
            this.labelNamBaoCao.Size = new System.Drawing.Size(58, 22);
            this.labelNamBaoCao.TabIndex = 8;
            this.labelNamBaoCao.Text = "Năm :";
            // 
            // labelThangBaoCao
            // 
            this.labelThangBaoCao.AutoSize = true;
            this.labelThangBaoCao.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelThangBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelThangBaoCao.Location = new System.Drawing.Point(216, 10);
            this.labelThangBaoCao.Name = "labelThangBaoCao";
            this.labelThangBaoCao.Size = new System.Drawing.Size(69, 22);
            this.labelThangBaoCao.TabIndex = 7;
            this.labelThangBaoCao.Text = "Tháng :";
            this.labelThangBaoCao.Click += new System.EventHandler(this.labelThangBaoCao_Click);
            // 
            // btnBaoCaoDoanhSoMoi
            // 
            this.btnBaoCaoDoanhSoMoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBaoCaoDoanhSoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoDoanhSoMoi.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoDoanhSoMoi.Location = new System.Drawing.Point(886, 3);
            this.btnBaoCaoDoanhSoMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaoCaoDoanhSoMoi.Name = "btnBaoCaoDoanhSoMoi";
            this.btnBaoCaoDoanhSoMoi.Size = new System.Drawing.Size(122, 39);
            this.btnBaoCaoDoanhSoMoi.TabIndex = 6;
            this.btnBaoCaoDoanhSoMoi.Text = "Báo cáo mới";
            this.btnBaoCaoDoanhSoMoi.UseVisualStyleBackColor = true;
            this.btnBaoCaoDoanhSoMoi.Click += new System.EventHandler(this.BtnBaoCaoDoanhSoMoi_Click);
            // 
            // lblChonThoiDiem
            // 
            this.lblChonThoiDiem.AutoSize = true;
            this.lblChonThoiDiem.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblChonThoiDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblChonThoiDiem.Location = new System.Drawing.Point(28, 11);
            this.lblChonThoiDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChonThoiDiem.Name = "lblChonThoiDiem";
            this.lblChonThoiDiem.Size = new System.Drawing.Size(143, 22);
            this.lblChonThoiDiem.TabIndex = 5;
            this.lblChonThoiDiem.Text = "Nhập thời điểm :";
            // 
            // btnLapBaoCaoDoanhSo
            // 
            this.btnLapBaoCaoDoanhSo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLapBaoCaoDoanhSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCaoDoanhSo.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoCaoDoanhSo.Location = new System.Drawing.Point(745, 2);
            this.btnLapBaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLapBaoCaoDoanhSo.Name = "btnLapBaoCaoDoanhSo";
            this.btnLapBaoCaoDoanhSo.Size = new System.Drawing.Size(110, 39);
            this.btnLapBaoCaoDoanhSo.TabIndex = 4;
            this.btnLapBaoCaoDoanhSo.Text = "Lập báo cáo";
            this.btnLapBaoCaoDoanhSo.UseVisualStyleBackColor = true;
            this.btnLapBaoCaoDoanhSo.Click += new System.EventHandler(this.BtnLapBaoCaoDoanhSo_Click);
            // 
            // tPBaoCaoTon
            // 
            this.tPBaoCaoTon.BackColor = System.Drawing.Color.White;
            this.tPBaoCaoTon.Controls.Add(this.panel1);
            this.tPBaoCaoTon.Controls.Add(this.pnChonThoiDiem);
            this.tPBaoCaoTon.Location = new System.Drawing.Point(104, 4);
            this.tPBaoCaoTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPBaoCaoTon.Name = "tPBaoCaoTon";
            this.tPBaoCaoTon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPBaoCaoTon.Size = new System.Drawing.Size(1038, 508);
            this.tPBaoCaoTon.TabIndex = 1;
            this.tPBaoCaoTon.Text = "Báo cáo tồn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewBaoCaoTon);
            this.panel1.Location = new System.Drawing.Point(4, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 422);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewBaoCaoTon
            // 
            this.dataGridViewBaoCaoTon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCaoTon.Location = new System.Drawing.Point(-4, 7);
            this.dataGridViewBaoCaoTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBaoCaoTon.Name = "dataGridViewBaoCaoTon";
            this.dataGridViewBaoCaoTon.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoTon.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoTon.Size = new System.Drawing.Size(1028, 409);
            this.dataGridViewBaoCaoTon.TabIndex = 1;
            // 
            // pnChonThoiDiem
            // 
            this.pnChonThoiDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChonThoiDiem.Controls.Add(this.btnBaoCaoTonMoi);
            this.pnChonThoiDiem.Controls.Add(this.lblChonThoiDiemTon);
            this.pnChonThoiDiem.Controls.Add(this.dateTimePickerChonThoiDiemBaoCaoTon);
            this.pnChonThoiDiem.Controls.Add(this.btnLapBaoCaoTon);
            this.pnChonThoiDiem.Location = new System.Drawing.Point(4, 8);
            this.pnChonThoiDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnChonThoiDiem.Name = "pnChonThoiDiem";
            this.pnChonThoiDiem.Size = new System.Drawing.Size(1026, 74);
            this.pnChonThoiDiem.TabIndex = 2;
            // 
            // btnBaoCaoTonMoi
            // 
            this.btnBaoCaoTonMoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBaoCaoTonMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoTonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBaoCaoTonMoi.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoTonMoi.Location = new System.Drawing.Point(885, 21);
            this.btnBaoCaoTonMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaoCaoTonMoi.Name = "btnBaoCaoTonMoi";
            this.btnBaoCaoTonMoi.Size = new System.Drawing.Size(122, 38);
            this.btnBaoCaoTonMoi.TabIndex = 6;
            this.btnBaoCaoTonMoi.Text = "Báo cáo mới";
            this.btnBaoCaoTonMoi.UseVisualStyleBackColor = true;
            this.btnBaoCaoTonMoi.Click += new System.EventHandler(this.BtnBaoCaoTonMoi_Click);
            // 
            // lblChonThoiDiemTon
            // 
            this.lblChonThoiDiemTon.AutoSize = true;
            this.lblChonThoiDiemTon.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblChonThoiDiemTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblChonThoiDiemTon.Location = new System.Drawing.Point(182, 29);
            this.lblChonThoiDiemTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChonThoiDiemTon.Name = "lblChonThoiDiemTon";
            this.lblChonThoiDiemTon.Size = new System.Drawing.Size(137, 22);
            this.lblChonThoiDiemTon.TabIndex = 5;
            this.lblChonThoiDiemTon.Text = "Chọn thời điểm:";
            // 
            // dateTimePickerChonThoiDiemBaoCaoTon
            // 
            this.dateTimePickerChonThoiDiemBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChonThoiDiemBaoCaoTon.Location = new System.Drawing.Point(335, 29);
            this.dateTimePickerChonThoiDiemBaoCaoTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerChonThoiDiemBaoCaoTon.Name = "dateTimePickerChonThoiDiemBaoCaoTon";
            this.dateTimePickerChonThoiDiemBaoCaoTon.Size = new System.Drawing.Size(228, 26);
            this.dateTimePickerChonThoiDiemBaoCaoTon.TabIndex = 1;
            // 
            // btnLapBaoCaoTon
            // 
            this.btnLapBaoCaoTon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLapBaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCaoTon.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoCaoTon.Location = new System.Drawing.Point(733, 21);
            this.btnLapBaoCaoTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLapBaoCaoTon.Name = "btnLapBaoCaoTon";
            this.btnLapBaoCaoTon.Size = new System.Drawing.Size(122, 38);
            this.btnLapBaoCaoTon.TabIndex = 4;
            this.btnLapBaoCaoTon.Text = "Lập báo cáo";
            this.btnLapBaoCaoTon.UseVisualStyleBackColor = true;
            this.btnLapBaoCaoTon.Click += new System.EventHandler(this.BtnLapBaoCaoTon_Click);
            // 
            // tPChucNang
            // 
            this.tPChucNang.BackColor = System.Drawing.Color.White;
            this.tPChucNang.Controls.Add(this.tCtrlChucNang);
            this.tPChucNang.Location = new System.Drawing.Point(84, 4);
            this.tPChucNang.Margin = new System.Windows.Forms.Padding(0);
            this.tPChucNang.Name = "tPChucNang";
            this.tPChucNang.Size = new System.Drawing.Size(1150, 520);
            this.tPChucNang.TabIndex = 0;
            this.tPChucNang.Text = "Chức năng";
            this.tPChucNang.Click += new System.EventHandler(this.tPChucNang_Click);
            // 
            // tCtrlChucNang
            // 
            this.tCtrlChucNang.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tCtrlChucNang.Controls.Add(this.tPTiepNhan);
            this.tCtrlChucNang.Controls.Add(this.tPPSC);
            this.tCtrlChucNang.Controls.Add(this.tPPTT);
            this.tCtrlChucNang.Controls.Add(this.tPVTPT);
            this.tCtrlChucNang.Controls.Add(this.tPTraCuu);
            this.tCtrlChucNang.Cursor = System.Windows.Forms.Cursors.Default;
            this.tCtrlChucNang.ItemSize = new System.Drawing.Size(40, 100);
            this.tCtrlChucNang.Location = new System.Drawing.Point(0, 0);
            this.tCtrlChucNang.Margin = new System.Windows.Forms.Padding(0);
            this.tCtrlChucNang.Multiline = true;
            this.tCtrlChucNang.Name = "tCtrlChucNang";
            this.tCtrlChucNang.SelectedIndex = 0;
            this.tCtrlChucNang.Size = new System.Drawing.Size(1150, 520);
            this.tCtrlChucNang.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tCtrlChucNang.TabIndex = 1;
            // 
            // tPTiepNhan
            // 
            this.tPTiepNhan.BackColor = System.Drawing.Color.White;
            this.tPTiepNhan.Controls.Add(this.pnDanhSachTiepNhan);
            this.tPTiepNhan.Controls.Add(this.pnThemThongTinKHVaXe);
            this.tPTiepNhan.Location = new System.Drawing.Point(104, 4);
            this.tPTiepNhan.Margin = new System.Windows.Forms.Padding(0);
            this.tPTiepNhan.Name = "tPTiepNhan";
            this.tPTiepNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tPTiepNhan.Size = new System.Drawing.Size(1042, 512);
            this.tPTiepNhan.TabIndex = 0;
            this.tPTiepNhan.Text = "Tiếp nhận xe";
            // 
            // pnDanhSachTiepNhan
            // 
            this.pnDanhSachTiepNhan.BackColor = System.Drawing.Color.White;
            this.pnDanhSachTiepNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDanhSachTiepNhan.Controls.Add(this.buttonLamMoi);
            this.pnDanhSachTiepNhan.Controls.Add(this.lblDanhSachTiepNhan);
            this.pnDanhSachTiepNhan.Controls.Add(this.dataGridViewXeDaTiepNhan);
            this.pnDanhSachTiepNhan.Location = new System.Drawing.Point(469, 2);
            this.pnDanhSachTiepNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDanhSachTiepNhan.Name = "pnDanhSachTiepNhan";
            this.pnDanhSachTiepNhan.Size = new System.Drawing.Size(571, 508);
            this.pnDanhSachTiepNhan.TabIndex = 1;
            this.pnDanhSachTiepNhan.TabStop = true;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(447, 443);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(107, 55);
            this.buttonLamMoi.TabIndex = 8;
            this.buttonLamMoi.Text = "Làm Mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // lblDanhSachTiepNhan
            // 
            this.lblDanhSachTiepNhan.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachTiepNhan.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDanhSachTiepNhan.Location = new System.Drawing.Point(114, 17);
            this.lblDanhSachTiepNhan.Name = "lblDanhSachTiepNhan";
            this.lblDanhSachTiepNhan.Size = new System.Drawing.Size(351, 27);
            this.lblDanhSachTiepNhan.TabIndex = 6;
            this.lblDanhSachTiepNhan.Text = "DANH SÁCH XE ĐÃ TIẾP NHẬN\r\n\r\n";
            // 
            // dataGridViewXeDaTiepNhan
            // 
            this.dataGridViewXeDaTiepNhan.AllowUserToAddRows = false;
            this.dataGridViewXeDaTiepNhan.AllowUserToDeleteRows = false;
            this.dataGridViewXeDaTiepNhan.AllowUserToResizeColumns = false;
            this.dataGridViewXeDaTiepNhan.AllowUserToResizeRows = false;
            this.dataGridViewXeDaTiepNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXeDaTiepNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewXeDaTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXeDaTiepNhan.Location = new System.Drawing.Point(2, 61);
            this.dataGridViewXeDaTiepNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewXeDaTiepNhan.Name = "dataGridViewXeDaTiepNhan";
            this.dataGridViewXeDaTiepNhan.ReadOnly = true;
            this.dataGridViewXeDaTiepNhan.RowHeadersWidth = 51;
            this.dataGridViewXeDaTiepNhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewXeDaTiepNhan.RowTemplate.Height = 24;
            this.dataGridViewXeDaTiepNhan.Size = new System.Drawing.Size(563, 440);
            this.dataGridViewXeDaTiepNhan.TabIndex = 9;
            this.dataGridViewXeDaTiepNhan.TabStop = false;
            // 
            // pnThemThongTinKHVaXe
            // 
            this.pnThemThongTinKHVaXe.BackColor = System.Drawing.Color.White;
            this.pnThemThongTinKHVaXe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnThemThongTinKHVaXe.Controls.Add(this.buttonClear);
            this.pnThemThongTinKHVaXe.Controls.Add(this.buttonThemXe);
            this.pnThemThongTinKHVaXe.Controls.Add(this.progressBarSoXeDaThem);
            this.pnThemThongTinKHVaXe.Controls.Add(this.labelTieuDe);
            this.pnThemThongTinKHVaXe.Controls.Add(this.panel7);
            this.pnThemThongTinKHVaXe.Controls.Add(this.panel6);
            this.pnThemThongTinKHVaXe.Controls.Add(this.panel5);
            this.pnThemThongTinKHVaXe.Controls.Add(this.panel4);
            this.pnThemThongTinKHVaXe.Controls.Add(this.panel3);
            this.pnThemThongTinKHVaXe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnThemThongTinKHVaXe.Location = new System.Drawing.Point(2, 2);
            this.pnThemThongTinKHVaXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnThemThongTinKHVaXe.Name = "pnThemThongTinKHVaXe";
            this.pnThemThongTinKHVaXe.Size = new System.Drawing.Size(467, 508);
            this.pnThemThongTinKHVaXe.TabIndex = 0;
            this.pnThemThongTinKHVaXe.TabStop = true;
            this.pnThemThongTinKHVaXe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThemThongTinKHVaXe_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(357, 446);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 52);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonThemXe
            // 
            this.buttonThemXe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonThemXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemXe.ForeColor = System.Drawing.Color.White;
            this.buttonThemXe.Location = new System.Drawing.Point(231, 446);
            this.buttonThemXe.Name = "buttonThemXe";
            this.buttonThemXe.Size = new System.Drawing.Size(109, 52);
            this.buttonThemXe.TabIndex = 6;
            this.buttonThemXe.Text = "Thêm Xe";
            this.buttonThemXe.UseVisualStyleBackColor = false;
            this.buttonThemXe.Click += new System.EventHandler(this.buttonThemXe_Click);
            // 
            // progressBarSoXeDaThem
            // 
            this.progressBarSoXeDaThem.BackColor = System.Drawing.Color.White;
            this.progressBarSoXeDaThem.Location = new System.Drawing.Point(52, 397);
            this.progressBarSoXeDaThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarSoXeDaThem.Maximum = 30;
            this.progressBarSoXeDaThem.Name = "progressBarSoXeDaThem";
            this.progressBarSoXeDaThem.Size = new System.Drawing.Size(355, 24);
            this.progressBarSoXeDaThem.TabIndex = 6;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelTieuDe.Location = new System.Drawing.Point(52, 17);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(375, 27);
            this.labelTieuDe.TabIndex = 5;
            this.labelTieuDe.Text = "THÊM THÔNG TIN KHÁCH HÀNG VÀ XE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.comBoxHieuXe);
            this.panel7.Controls.Add(this.lblHieuXe);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel7.Location = new System.Drawing.Point(52, 323);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(355, 40);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(0, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 2);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // comBoxHieuXe
            // 
            this.comBoxHieuXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comBoxHieuXe.DataSource = this.hIEUXEBindingSource;
            this.comBoxHieuXe.DisplayMember = "TenHieuXe";
            this.comBoxHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxHieuXe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comBoxHieuXe.FormattingEnabled = true;
            this.comBoxHieuXe.Location = new System.Drawing.Point(153, 7);
            this.comBoxHieuXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxHieuXe.Name = "comBoxHieuXe";
            this.comBoxHieuXe.Size = new System.Drawing.Size(195, 27);
            this.comBoxHieuXe.TabIndex = 5;
            this.comBoxHieuXe.ValueMember = "MaHX";
            // 
            // lblHieuXe
            // 
            this.lblHieuXe.AutoSize = true;
            this.lblHieuXe.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblHieuXe.Location = new System.Drawing.Point(36, 9);
            this.lblHieuXe.Name = "lblHieuXe";
            this.lblHieuXe.Size = new System.Drawing.Size(77, 22);
            this.lblHieuXe.TabIndex = 2;
            this.lblHieuXe.Text = "Hiệu xe:";
            this.lblHieuXe.Click += new System.EventHandler(this.lblHieuXe_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblBienSo);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtBoxBienSo);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel6.Location = new System.Drawing.Point(52, 250);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 41);
            this.panel6.TabIndex = 3;
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblBienSo.Location = new System.Drawing.Point(36, 9);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(76, 22);
            this.lblBienSo.TabIndex = 2;
            this.lblBienSo.Text = "Biển số:";
            this.lblBienSo.Click += new System.EventHandler(this.lblBienSo_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(0, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 2);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // txtBoxBienSo
            // 
            this.txtBoxBienSo.BackColor = System.Drawing.Color.White;
            this.txtBoxBienSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxBienSo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxBienSo.Location = new System.Drawing.Point(153, 10);
            this.txtBoxBienSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxBienSo.MaxLength = 10;
            this.txtBoxBienSo.Name = "txtBoxBienSo";
            this.txtBoxBienSo.Size = new System.Drawing.Size(197, 19);
            this.txtBoxBienSo.TabIndex = 4;
            this.txtBoxBienSo.TextChanged += new System.EventHandler(this.txtBoxBienSo_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblDiaChi);
            this.panel5.Controls.Add(this.txtBoxDiaChi);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Location = new System.Drawing.Point(52, 185);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 42);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 2);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblDiaChi.Location = new System.Drawing.Point(36, 9);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.Click += new System.EventHandler(this.lblDiaChi_Click);
            // 
            // txtBoxDiaChi
            // 
            this.txtBoxDiaChi.BackColor = System.Drawing.Color.White;
            this.txtBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxDiaChi.Location = new System.Drawing.Point(153, 12);
            this.txtBoxDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDiaChi.MaxLength = 100;
            this.txtBoxDiaChi.Name = "txtBoxDiaChi";
            this.txtBoxDiaChi.Size = new System.Drawing.Size(197, 19);
            this.txtBoxDiaChi.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblDienThoai);
            this.panel4.Controls.Add(this.txtBoxDienThoai);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(52, 120);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 43);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(-5, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 2);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblDienThoai.Location = new System.Drawing.Point(27, 10);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(98, 22);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại:";
            this.lblDienThoai.Click += new System.EventHandler(this.lblDienThoai_Click);
            // 
            // txtBoxDienThoai
            // 
            this.txtBoxDienThoai.BackColor = System.Drawing.Color.White;
            this.txtBoxDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxDienThoai.Location = new System.Drawing.Point(153, 10);
            this.txtBoxDienThoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDienThoai.MaxLength = 10;
            this.txtBoxDienThoai.Name = "txtBoxDienThoai";
            this.txtBoxDienThoai.Size = new System.Drawing.Size(197, 19);
            this.txtBoxDienThoai.TabIndex = 2;
            this.txtBoxDienThoai.TextChanged += new System.EventHandler(this.txtBoxDienThoai_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelTenKhachHang);
            this.panel3.Controls.Add(this.txtBoxTenKH);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(52, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 43);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(0, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 2);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // labelTenKhachHang
            // 
            this.labelTenKhachHang.AutoSize = true;
            this.labelTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelTenKhachHang.Location = new System.Drawing.Point(1, 7);
            this.labelTenKhachHang.Name = "labelTenKhachHang";
            this.labelTenKhachHang.Size = new System.Drawing.Size(152, 22);
            this.labelTenKhachHang.TabIndex = 2;
            this.labelTenKhachHang.Text = "Tên Khách Hàng: ";
            this.labelTenKhachHang.Click += new System.EventHandler(this.LabelTenKhachHang_Click);
            // 
            // txtBoxTenKH
            // 
            this.txtBoxTenKH.BackColor = System.Drawing.Color.White;
            this.txtBoxTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTenKH.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxTenKH.Location = new System.Drawing.Point(162, 9);
            this.txtBoxTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTenKH.MaxLength = 30;
            this.txtBoxTenKH.Name = "txtBoxTenKH";
            this.txtBoxTenKH.Size = new System.Drawing.Size(188, 19);
            this.txtBoxTenKH.TabIndex = 1;
            this.txtBoxTenKH.TextChanged += new System.EventHandler(this.txtBoxTenKH_TextChanged);
            // 
            // tPPSC
            // 
            this.tPPSC.BackColor = System.Drawing.Color.White;
            this.tPPSC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tPPSC.Controls.Add(this.panel9);
            this.tPPSC.Controls.Add(this.panelNhapPhieuSuaChua);
            this.tPPSC.Controls.Add(this.btnHoanTat);
            this.tPPSC.Controls.Add(this.textBoxTongTienPhieuSuaChua);
            this.tPPSC.Controls.Add(this.lblTongTien);
            this.tPPSC.Controls.Add(this.btnTaoMoiPCS);
            this.tPPSC.Controls.Add(this.btnInPhieuSuaChua);
            this.tPPSC.Controls.Add(this.btnLuuPSC);
            this.tPPSC.Controls.Add(this.flowLayoutPanel2);
            this.tPPSC.Controls.Add(this.flowLayoutPanel1);
            this.tPPSC.Controls.Add(this.pnNgaySuaChua);
            this.tPPSC.Controls.Add(this.pnlBienSoXe);
            this.tPPSC.Controls.Add(this.panel8);
            this.tPPSC.ForeColor = System.Drawing.Color.White;
            this.tPPSC.Location = new System.Drawing.Point(104, 4);
            this.tPPSC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPPSC.Name = "tPPSC";
            this.tPPSC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPPSC.Size = new System.Drawing.Size(1042, 512);
            this.tPPSC.TabIndex = 1;
            this.tPPSC.Text = "Lập phiếu sửa chữa";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.buttonNhapTienCongPhieuSuaChua);
            this.panel9.Controls.Add(this.comboBoxTienCongPhieuSuaChua);
            this.panel9.Controls.Add(this.labelTienCongPhieuSuaChua);
            this.panel9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel9.Location = new System.Drawing.Point(509, 68);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(529, 71);
            this.panel9.TabIndex = 12;
            // 
            // buttonNhapTienCongPhieuSuaChua
            // 
            this.buttonNhapTienCongPhieuSuaChua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNhapTienCongPhieuSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhapTienCongPhieuSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNhapTienCongPhieuSuaChua.ForeColor = System.Drawing.Color.White;
            this.buttonNhapTienCongPhieuSuaChua.Location = new System.Drawing.Point(407, 12);
            this.buttonNhapTienCongPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNhapTienCongPhieuSuaChua.Name = "buttonNhapTienCongPhieuSuaChua";
            this.buttonNhapTienCongPhieuSuaChua.Size = new System.Drawing.Size(104, 43);
            this.buttonNhapTienCongPhieuSuaChua.TabIndex = 12;
            this.buttonNhapTienCongPhieuSuaChua.Text = "Nhập tiền công";
            this.buttonNhapTienCongPhieuSuaChua.UseVisualStyleBackColor = true;
            this.buttonNhapTienCongPhieuSuaChua.Click += new System.EventHandler(this.ButtonNhapTienCongPhieuSuaChua_Click);
            // 
            // comboBoxTienCongPhieuSuaChua
            // 
            this.comboBoxTienCongPhieuSuaChua.DataSource = this.tIENCONGBindingSource;
            this.comboBoxTienCongPhieuSuaChua.DisplayMember = "TenTienCong";
            this.comboBoxTienCongPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxTienCongPhieuSuaChua.FormattingEnabled = true;
            this.comboBoxTienCongPhieuSuaChua.Location = new System.Drawing.Point(140, 22);
            this.comboBoxTienCongPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTienCongPhieuSuaChua.Name = "comboBoxTienCongPhieuSuaChua";
            this.comboBoxTienCongPhieuSuaChua.Size = new System.Drawing.Size(164, 27);
            this.comboBoxTienCongPhieuSuaChua.TabIndex = 11;
            this.comboBoxTienCongPhieuSuaChua.ValueMember = "MaTC";
            // 
            // tIENCONGBindingSource
            // 
            this.tIENCONGBindingSource.DataMember = "TIENCONG";
            this.tIENCONGBindingSource.DataSource = this.quanLyGarageDataSet;
            // 
            // labelTienCongPhieuSuaChua
            // 
            this.labelTienCongPhieuSuaChua.AutoSize = true;
            this.labelTienCongPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelTienCongPhieuSuaChua.Location = new System.Drawing.Point(43, 23);
            this.labelTienCongPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTienCongPhieuSuaChua.Name = "labelTienCongPhieuSuaChua";
            this.labelTienCongPhieuSuaChua.Size = new System.Drawing.Size(93, 22);
            this.labelTienCongPhieuSuaChua.TabIndex = 10;
            this.labelTienCongPhieuSuaChua.Text = "Tiền công:";
            this.labelTienCongPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTienCongPhieuSuaChua.Click += new System.EventHandler(this.labelTienCongPhieuSuaChua_Click);
            // 
            // panelNhapPhieuSuaChua
            // 
            this.panelNhapPhieuSuaChua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNhapPhieuSuaChua.Controls.Add(this.buttonNhapVTPTPhieuSuaChua);
            this.panelNhapPhieuSuaChua.Controls.Add(this.buttonNhapPhieuSuaChua);
            this.panelNhapPhieuSuaChua.Controls.Add(this.textBoxSoLuongVTPTPhieuSuaChua);
            this.panelNhapPhieuSuaChua.Controls.Add(this.labelSoLuongPhieuSuaChua);
            this.panelNhapPhieuSuaChua.Controls.Add(this.comboBoxVTPTPhieuSuaChua);
            this.panelNhapPhieuSuaChua.Controls.Add(this.labelVTPTPhieuSuaChua);
            this.panelNhapPhieuSuaChua.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panelNhapPhieuSuaChua.Location = new System.Drawing.Point(2, 69);
            this.panelNhapPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNhapPhieuSuaChua.Name = "panelNhapPhieuSuaChua";
            this.panelNhapPhieuSuaChua.Size = new System.Drawing.Size(504, 70);
            this.panelNhapPhieuSuaChua.TabIndex = 11;
            // 
            // buttonNhapVTPTPhieuSuaChua
            // 
            this.buttonNhapVTPTPhieuSuaChua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNhapVTPTPhieuSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhapVTPTPhieuSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNhapVTPTPhieuSuaChua.ForeColor = System.Drawing.Color.White;
            this.buttonNhapVTPTPhieuSuaChua.Location = new System.Drawing.Point(393, 11);
            this.buttonNhapVTPTPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNhapVTPTPhieuSuaChua.Name = "buttonNhapVTPTPhieuSuaChua";
            this.buttonNhapVTPTPhieuSuaChua.Size = new System.Drawing.Size(94, 44);
            this.buttonNhapVTPTPhieuSuaChua.TabIndex = 11;
            this.buttonNhapVTPTPhieuSuaChua.Text = "Nhập VTPT";
            this.buttonNhapVTPTPhieuSuaChua.UseVisualStyleBackColor = true;
            this.buttonNhapVTPTPhieuSuaChua.Click += new System.EventHandler(this.ButtonNhapVTPTPhieuSuaChua_Click);
            // 
            // buttonNhapPhieuSuaChua
            // 
            this.buttonNhapPhieuSuaChua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNhapPhieuSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhapPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonNhapPhieuSuaChua.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNhapPhieuSuaChua.Location = new System.Drawing.Point(853, 2);
            this.buttonNhapPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNhapPhieuSuaChua.Name = "buttonNhapPhieuSuaChua";
            this.buttonNhapPhieuSuaChua.Size = new System.Drawing.Size(104, 28);
            this.buttonNhapPhieuSuaChua.TabIndex = 10;
            this.buttonNhapPhieuSuaChua.Text = "Nhập";
            this.buttonNhapPhieuSuaChua.UseVisualStyleBackColor = true;
            // 
            // textBoxSoLuongVTPTPhieuSuaChua
            // 
            this.textBoxSoLuongVTPTPhieuSuaChua.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoLuongVTPTPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxSoLuongVTPTPhieuSuaChua.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSoLuongVTPTPhieuSuaChua.Location = new System.Drawing.Point(267, 30);
            this.textBoxSoLuongVTPTPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSoLuongVTPTPhieuSuaChua.Name = "textBoxSoLuongVTPTPhieuSuaChua";
            this.textBoxSoLuongVTPTPhieuSuaChua.Size = new System.Drawing.Size(92, 26);
            this.textBoxSoLuongVTPTPhieuSuaChua.TabIndex = 7;
            this.textBoxSoLuongVTPTPhieuSuaChua.TextChanged += new System.EventHandler(this.textBoxSoLuongVTPTPhieuSuaChua_TextChanged);
            this.textBoxSoLuongVTPTPhieuSuaChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSoLuongVTPTPhieuSuaChua_KeyPress);
            // 
            // labelSoLuongPhieuSuaChua
            // 
            this.labelSoLuongPhieuSuaChua.AutoSize = true;
            this.labelSoLuongPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelSoLuongPhieuSuaChua.Location = new System.Drawing.Point(271, 5);
            this.labelSoLuongPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoLuongPhieuSuaChua.Name = "labelSoLuongPhieuSuaChua";
            this.labelSoLuongPhieuSuaChua.Size = new System.Drawing.Size(88, 22);
            this.labelSoLuongPhieuSuaChua.TabIndex = 6;
            this.labelSoLuongPhieuSuaChua.Text = "Số lượng:";
            this.labelSoLuongPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxVTPTPhieuSuaChua
            // 
            this.comboBoxVTPTPhieuSuaChua.DataSource = this.kHOBindingSource;
            this.comboBoxVTPTPhieuSuaChua.DisplayMember = "TenVatTuPhuTung";
            this.comboBoxVTPTPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxVTPTPhieuSuaChua.FormattingEnabled = true;
            this.comboBoxVTPTPhieuSuaChua.Location = new System.Drawing.Point(4, 29);
            this.comboBoxVTPTPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVTPTPhieuSuaChua.Name = "comboBoxVTPTPhieuSuaChua";
            this.comboBoxVTPTPhieuSuaChua.Size = new System.Drawing.Size(215, 27);
            this.comboBoxVTPTPhieuSuaChua.TabIndex = 2;
            this.comboBoxVTPTPhieuSuaChua.ValueMember = "MaPhuTung";
            this.comboBoxVTPTPhieuSuaChua.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxVTPTPhieuSuaChua_SelectionChangeCommitted);
            // 
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.quanLyGarageDataSet;
            // 
            // labelVTPTPhieuSuaChua
            // 
            this.labelVTPTPhieuSuaChua.AutoSize = true;
            this.labelVTPTPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelVTPTPhieuSuaChua.Location = new System.Drawing.Point(43, 5);
            this.labelVTPTPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVTPTPhieuSuaChua.Name = "labelVTPTPhieuSuaChua";
            this.labelVTPTPhieuSuaChua.Size = new System.Drawing.Size(135, 22);
            this.labelVTPTPhieuSuaChua.TabIndex = 1;
            this.labelVTPTPhieuSuaChua.Text = "Vật tư phụ tùng:";
            this.labelVTPTPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(353, 416);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(109, 64);
            this.btnHoanTat.TabIndex = 7;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.BtnHoanTat_Click);
            // 
            // textBoxTongTienPhieuSuaChua
            // 
            this.textBoxTongTienPhieuSuaChua.BackColor = System.Drawing.Color.White;
            this.textBoxTongTienPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxTongTienPhieuSuaChua.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxTongTienPhieuSuaChua.Location = new System.Drawing.Point(162, 436);
            this.textBoxTongTienPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTongTienPhieuSuaChua.Name = "textBoxTongTienPhieuSuaChua";
            this.textBoxTongTienPhieuSuaChua.ReadOnly = true;
            this.textBoxTongTienPhieuSuaChua.Size = new System.Drawing.Size(169, 26);
            this.textBoxTongTienPhieuSuaChua.TabIndex = 6;
            this.textBoxTongTienPhieuSuaChua.TextChanged += new System.EventHandler(this.textBoxTongTienPhieuSuaChua_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblTongTien.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTongTien.Location = new System.Drawing.Point(26, 433);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(115, 27);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng tiền :";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // btnTaoMoiPCS
            // 
            this.btnTaoMoiPCS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTaoMoiPCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoiPCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaoMoiPCS.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoiPCS.Location = new System.Drawing.Point(868, 416);
            this.btnTaoMoiPCS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoMoiPCS.Name = "btnTaoMoiPCS";
            this.btnTaoMoiPCS.Size = new System.Drawing.Size(128, 64);
            this.btnTaoMoiPCS.TabIndex = 10;
            this.btnTaoMoiPCS.Text = "Nhập phiếu mới";
            this.btnTaoMoiPCS.UseVisualStyleBackColor = true;
            this.btnTaoMoiPCS.Click += new System.EventHandler(this.BtnTaoMoiPCS_Click);
            // 
            // btnInPhieuSuaChua
            // 
            this.btnInPhieuSuaChua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInPhieuSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieuSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInPhieuSuaChua.ForeColor = System.Drawing.Color.White;
            this.btnInPhieuSuaChua.Location = new System.Drawing.Point(689, 416);
            this.btnInPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInPhieuSuaChua.Name = "btnInPhieuSuaChua";
            this.btnInPhieuSuaChua.Size = new System.Drawing.Size(125, 64);
            this.btnInPhieuSuaChua.TabIndex = 9;
            this.btnInPhieuSuaChua.Text = "In phiếu sửa chữa";
            this.btnInPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnInPhieuSuaChua.Click += new System.EventHandler(this.BtnInPhieuSuaChua_Click);
            // 
            // btnLuuPSC
            // 
            this.btnLuuPSC.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuuPSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLuuPSC.ForeColor = System.Drawing.Color.White;
            this.btnLuuPSC.Location = new System.Drawing.Point(511, 416);
            this.btnLuuPSC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuPSC.Name = "btnLuuPSC";
            this.btnLuuPSC.Size = new System.Drawing.Size(136, 64);
            this.btnLuuPSC.TabIndex = 8;
            this.btnLuuPSC.Text = "Lưu phiếu sửa chữa";
            this.btnLuuPSC.UseVisualStyleBackColor = true;
            this.btnLuuPSC.Click += new System.EventHandler(this.BtnLuuPSC_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.dataGridViewTienCongPhieuSuaChua);
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(511, 143);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(527, 266);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // dataGridViewTienCongPhieuSuaChua
            // 
            this.dataGridViewTienCongPhieuSuaChua.AllowUserToAddRows = false;
            this.dataGridViewTienCongPhieuSuaChua.AllowUserToDeleteRows = false;
            this.dataGridViewTienCongPhieuSuaChua.AllowUserToResizeColumns = false;
            this.dataGridViewTienCongPhieuSuaChua.AllowUserToResizeRows = false;
            this.dataGridViewTienCongPhieuSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTienCongPhieuSuaChua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewTienCongPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTienCongPhieuSuaChua.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewTienCongPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTienCongPhieuSuaChua.Name = "dataGridViewTienCongPhieuSuaChua";
            this.dataGridViewTienCongPhieuSuaChua.ReadOnly = true;
            this.dataGridViewTienCongPhieuSuaChua.RowHeadersWidth = 51;
            this.dataGridViewTienCongPhieuSuaChua.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTienCongPhieuSuaChua.RowTemplate.Height = 24;
            this.dataGridViewTienCongPhieuSuaChua.Size = new System.Drawing.Size(519, 262);
            this.dataGridViewTienCongPhieuSuaChua.TabIndex = 10;
            this.dataGridViewTienCongPhieuSuaChua.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewVTPTPhieuSuaChua);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 143);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 269);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewVTPTPhieuSuaChua
            // 
            this.dataGridViewVTPTPhieuSuaChua.AllowUserToAddRows = false;
            this.dataGridViewVTPTPhieuSuaChua.AllowUserToDeleteRows = false;
            this.dataGridViewVTPTPhieuSuaChua.AllowUserToResizeColumns = false;
            this.dataGridViewVTPTPhieuSuaChua.AllowUserToResizeRows = false;
            this.dataGridViewVTPTPhieuSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVTPTPhieuSuaChua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewVTPTPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVTPTPhieuSuaChua.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewVTPTPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewVTPTPhieuSuaChua.Name = "dataGridViewVTPTPhieuSuaChua";
            this.dataGridViewVTPTPhieuSuaChua.ReadOnly = true;
            this.dataGridViewVTPTPhieuSuaChua.RowHeadersWidth = 51;
            this.dataGridViewVTPTPhieuSuaChua.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewVTPTPhieuSuaChua.RowTemplate.Height = 24;
            this.dataGridViewVTPTPhieuSuaChua.Size = new System.Drawing.Size(493, 262);
            this.dataGridViewVTPTPhieuSuaChua.TabIndex = 10;
            this.dataGridViewVTPTPhieuSuaChua.TabStop = false;
            // 
            // pnNgaySuaChua
            // 
            this.pnNgaySuaChua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnNgaySuaChua.Controls.Add(this.txtBoxNgaySuaChua);
            this.pnNgaySuaChua.Controls.Add(this.lblNgaySuaChua);
            this.pnNgaySuaChua.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.pnNgaySuaChua.Location = new System.Drawing.Point(2, 0);
            this.pnNgaySuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNgaySuaChua.Name = "pnNgaySuaChua";
            this.pnNgaySuaChua.Size = new System.Drawing.Size(504, 31);
            this.pnNgaySuaChua.TabIndex = 2;
            // 
            // txtBoxNgaySuaChua
            // 
            this.txtBoxNgaySuaChua.BackColor = System.Drawing.Color.White;
            this.txtBoxNgaySuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxNgaySuaChua.Location = new System.Drawing.Point(223, 2);
            this.txtBoxNgaySuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNgaySuaChua.Name = "txtBoxNgaySuaChua";
            this.txtBoxNgaySuaChua.ReadOnly = true;
            this.txtBoxNgaySuaChua.Size = new System.Drawing.Size(190, 26);
            this.txtBoxNgaySuaChua.TabIndex = 4;
            // 
            // lblNgaySuaChua
            // 
            this.lblNgaySuaChua.AutoSize = true;
            this.lblNgaySuaChua.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblNgaySuaChua.Location = new System.Drawing.Point(86, 3);
            this.lblNgaySuaChua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySuaChua.Name = "lblNgaySuaChua";
            this.lblNgaySuaChua.Size = new System.Drawing.Size(133, 22);
            this.lblNgaySuaChua.TabIndex = 3;
            this.lblNgaySuaChua.Text = "Ngày sửa chữa:";
            // 
            // pnlBienSoXe
            // 
            this.pnlBienSoXe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBienSoXe.Controls.Add(this.comboBoxBienSoXe1);
            this.pnlBienSoXe.Controls.Add(this.lblBienSoXe);
            this.pnlBienSoXe.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlBienSoXe.Location = new System.Drawing.Point(2, 35);
            this.pnlBienSoXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBienSoXe.Name = "pnlBienSoXe";
            this.pnlBienSoXe.Size = new System.Drawing.Size(504, 31);
            this.pnlBienSoXe.TabIndex = 1;
            // 
            // comboBoxBienSoXe1
            // 
            this.comboBoxBienSoXe1.DataSource = this.xEBindingSource;
            this.comboBoxBienSoXe1.DisplayMember = "BienSo";
            this.comboBoxBienSoXe1.FormattingEnabled = true;
            this.comboBoxBienSoXe1.Location = new System.Drawing.Point(213, 1);
            this.comboBoxBienSoXe1.Name = "comboBoxBienSoXe1";
            this.comboBoxBienSoXe1.Size = new System.Drawing.Size(146, 28);
            this.comboBoxBienSoXe1.TabIndex = 1;
            this.comboBoxBienSoXe1.ValueMember = "BienSo";
            // 
            // xEBindingSource
            // 
            this.xEBindingSource.DataMember = "XE";
            this.xEBindingSource.DataSource = this.quanLyGarageDataSet;
            // 
            // lblBienSoXe
            // 
            this.lblBienSoXe.AutoSize = true;
            this.lblBienSoXe.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblBienSoXe.Location = new System.Drawing.Point(104, 3);
            this.lblBienSoXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienSoXe.Name = "lblBienSoXe";
            this.lblBienSoXe.Size = new System.Drawing.Size(99, 22);
            this.lblBienSoXe.TabIndex = 0;
            this.lblBienSoXe.Text = "Biển số xe:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.lblPhieuSuaChua);
            this.panel8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel8.Location = new System.Drawing.Point(509, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(529, 66);
            this.panel8.TabIndex = 0;
            // 
            // lblPhieuSuaChua
            // 
            this.lblPhieuSuaChua.AutoSize = true;
            this.lblPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblPhieuSuaChua.Location = new System.Drawing.Point(204, 17);
            this.lblPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhieuSuaChua.Name = "lblPhieuSuaChua";
            this.lblPhieuSuaChua.Size = new System.Drawing.Size(159, 27);
            this.lblPhieuSuaChua.TabIndex = 0;
            this.lblPhieuSuaChua.Text = "Phiếu sửa chữa";
            // 
            // tPPTT
            // 
            this.tPPTT.BackColor = System.Drawing.Color.White;
            this.tPPTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tPPTT.Controls.Add(this.panel23);
            this.tPPTT.Controls.Add(this.flowLayoutPanel3);
            this.tPPTT.Controls.Add(this.panel22);
            this.tPPTT.Location = new System.Drawing.Point(104, 4);
            this.tPPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPPTT.Name = "tPPTT";
            this.tPPTT.Size = new System.Drawing.Size(1042, 512);
            this.tPPTT.TabIndex = 2;
            this.tPPTT.Text = "Lập phiếu thu tiền";
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel23.Controls.Add(this.buttonPhieuThuTienMoiPTT);
            this.panel23.Controls.Add(this.buttonInPhieuThuTienPTT);
            this.panel23.Controls.Add(this.buttonLapPhieuThuTienPTT);
            this.panel23.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel23.Location = new System.Drawing.Point(2, 340);
            this.panel23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(1034, 166);
            this.panel23.TabIndex = 2;
            // 
            // buttonPhieuThuTienMoiPTT
            // 
            this.buttonPhieuThuTienMoiPTT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPhieuThuTienMoiPTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhieuThuTienMoiPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonPhieuThuTienMoiPTT.ForeColor = System.Drawing.Color.White;
            this.buttonPhieuThuTienMoiPTT.Location = new System.Drawing.Point(360, 55);
            this.buttonPhieuThuTienMoiPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPhieuThuTienMoiPTT.Name = "buttonPhieuThuTienMoiPTT";
            this.buttonPhieuThuTienMoiPTT.Size = new System.Drawing.Size(178, 73);
            this.buttonPhieuThuTienMoiPTT.TabIndex = 4;
            this.buttonPhieuThuTienMoiPTT.Text = "Phiếu thu tiền mới";
            this.buttonPhieuThuTienMoiPTT.UseVisualStyleBackColor = true;
            this.buttonPhieuThuTienMoiPTT.Click += new System.EventHandler(this.ButtonPhieuThuTienMoiPTT_Click);
            // 
            // buttonInPhieuThuTienPTT
            // 
            this.buttonInPhieuThuTienPTT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInPhieuThuTienPTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInPhieuThuTienPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonInPhieuThuTienPTT.ForeColor = System.Drawing.Color.White;
            this.buttonInPhieuThuTienPTT.Location = new System.Drawing.Point(826, 55);
            this.buttonInPhieuThuTienPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInPhieuThuTienPTT.Name = "buttonInPhieuThuTienPTT";
            this.buttonInPhieuThuTienPTT.Size = new System.Drawing.Size(165, 73);
            this.buttonInPhieuThuTienPTT.TabIndex = 5;
            this.buttonInPhieuThuTienPTT.Text = "In phiếu thu tiền";
            this.buttonInPhieuThuTienPTT.UseVisualStyleBackColor = true;
            this.buttonInPhieuThuTienPTT.Click += new System.EventHandler(this.ButtonInPhieuThuTienPTT_Click);
            // 
            // buttonLapPhieuThuTienPTT
            // 
            this.buttonLapPhieuThuTienPTT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonLapPhieuThuTienPTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLapPhieuThuTienPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonLapPhieuThuTienPTT.ForeColor = System.Drawing.Color.White;
            this.buttonLapPhieuThuTienPTT.Location = new System.Drawing.Point(602, 55);
            this.buttonLapPhieuThuTienPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLapPhieuThuTienPTT.Name = "buttonLapPhieuThuTienPTT";
            this.buttonLapPhieuThuTienPTT.Size = new System.Drawing.Size(174, 73);
            this.buttonLapPhieuThuTienPTT.TabIndex = 3;
            this.buttonLapPhieuThuTienPTT.Text = "Lập phiếu thu tiền";
            this.buttonLapPhieuThuTienPTT.UseVisualStyleBackColor = true;
            this.buttonLapPhieuThuTienPTT.Click += new System.EventHandler(this.buttonLapPhieuThuTienPTT_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.panelHoTenChuXePTT);
            this.flowLayoutPanel3.Controls.Add(this.panelBienSoPTT);
            this.flowLayoutPanel3.Controls.Add(this.panelDienThoaiPTT);
            this.flowLayoutPanel3.Controls.Add(this.panelEmailPTT);
            this.flowLayoutPanel3.Controls.Add(this.panelNgayThuTienPTT);
            this.flowLayoutPanel3.Controls.Add(this.panel33);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 87);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1034, 250);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // panelHoTenChuXePTT
            // 
            this.panelHoTenChuXePTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHoTenChuXePTT.Controls.Add(this.textBoxHoTenChuXePTT);
            this.panelHoTenChuXePTT.Controls.Add(this.labelHoTenChuXePTT);
            this.panelHoTenChuXePTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panelHoTenChuXePTT.Location = new System.Drawing.Point(2, 2);
            this.panelHoTenChuXePTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHoTenChuXePTT.Name = "panelHoTenChuXePTT";
            this.panelHoTenChuXePTT.Size = new System.Drawing.Size(500, 84);
            this.panelHoTenChuXePTT.TabIndex = 0;
            // 
            // textBoxHoTenChuXePTT
            // 
            this.textBoxHoTenChuXePTT.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHoTenChuXePTT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxHoTenChuXePTT.Location = new System.Drawing.Point(151, 19);
            this.textBoxHoTenChuXePTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHoTenChuXePTT.MaxLength = 30;
            this.textBoxHoTenChuXePTT.Name = "textBoxHoTenChuXePTT";
            this.textBoxHoTenChuXePTT.ReadOnly = true;
            this.textBoxHoTenChuXePTT.Size = new System.Drawing.Size(247, 26);
            this.textBoxHoTenChuXePTT.TabIndex = 0;
            this.textBoxHoTenChuXePTT.TabStop = false;
            this.textBoxHoTenChuXePTT.TextChanged += new System.EventHandler(this.textBoxHoTenChuXePTT_TextChanged);
            // 
            // labelHoTenChuXePTT
            // 
            this.labelHoTenChuXePTT.AutoSize = true;
            this.labelHoTenChuXePTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelHoTenChuXePTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelHoTenChuXePTT.Location = new System.Drawing.Point(2, 20);
            this.labelHoTenChuXePTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoTenChuXePTT.Name = "labelHoTenChuXePTT";
            this.labelHoTenChuXePTT.Size = new System.Drawing.Size(128, 22);
            this.labelHoTenChuXePTT.TabIndex = 0;
            this.labelHoTenChuXePTT.Text = "Họ tên chủ xe :";
            // 
            // panelBienSoPTT
            // 
            this.panelBienSoPTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBienSoPTT.Controls.Add(this.comboBienSoXe2);
            this.panelBienSoPTT.Controls.Add(this.labelBienSoPTT);
            this.panelBienSoPTT.Location = new System.Drawing.Point(506, 2);
            this.panelBienSoPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBienSoPTT.Name = "panelBienSoPTT";
            this.panelBienSoPTT.Size = new System.Drawing.Size(513, 84);
            this.panelBienSoPTT.TabIndex = 1;
            // 
            // comboBienSoXe2
            // 
            this.comboBienSoXe2.DataSource = this.xEBindingSource;
            this.comboBienSoXe2.DisplayMember = "BienSo";
            this.comboBienSoXe2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBienSoXe2.FormattingEnabled = true;
            this.comboBienSoXe2.Location = new System.Drawing.Point(110, 20);
            this.comboBienSoXe2.Name = "comboBienSoXe2";
            this.comboBienSoXe2.Size = new System.Drawing.Size(264, 27);
            this.comboBienSoXe2.TabIndex = 1;
            this.comboBienSoXe2.ValueMember = "BienSo";
            this.comboBienSoXe2.SelectionChangeCommitted += new System.EventHandler(this.comboBienSoXe2_SelectionChangeCommitted);
            // 
            // labelBienSoPTT
            // 
            this.labelBienSoPTT.AutoSize = true;
            this.labelBienSoPTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelBienSoPTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelBienSoPTT.Location = new System.Drawing.Point(2, 20);
            this.labelBienSoPTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBienSoPTT.Name = "labelBienSoPTT";
            this.labelBienSoPTT.Size = new System.Drawing.Size(81, 22);
            this.labelBienSoPTT.TabIndex = 0;
            this.labelBienSoPTT.Text = "Biển số :";
            // 
            // panelDienThoaiPTT
            // 
            this.panelDienThoaiPTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDienThoaiPTT.Controls.Add(this.textBoxDienThoaiPTT);
            this.panelDienThoaiPTT.Controls.Add(this.labelDienThoaiPTT);
            this.panelDienThoaiPTT.Location = new System.Drawing.Point(2, 90);
            this.panelDienThoaiPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDienThoaiPTT.Name = "panelDienThoaiPTT";
            this.panelDienThoaiPTT.Size = new System.Drawing.Size(500, 81);
            this.panelDienThoaiPTT.TabIndex = 2;
            // 
            // textBoxDienThoaiPTT
            // 
            this.textBoxDienThoaiPTT.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDienThoaiPTT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxDienThoaiPTT.Location = new System.Drawing.Point(151, 19);
            this.textBoxDienThoaiPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDienThoaiPTT.MaxLength = 10;
            this.textBoxDienThoaiPTT.Name = "textBoxDienThoaiPTT";
            this.textBoxDienThoaiPTT.ReadOnly = true;
            this.textBoxDienThoaiPTT.Size = new System.Drawing.Size(247, 26);
            this.textBoxDienThoaiPTT.TabIndex = 0;
            this.textBoxDienThoaiPTT.TabStop = false;
            // 
            // labelDienThoaiPTT
            // 
            this.labelDienThoaiPTT.AutoSize = true;
            this.labelDienThoaiPTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelDienThoaiPTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelDienThoaiPTT.Location = new System.Drawing.Point(2, 20);
            this.labelDienThoaiPTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDienThoaiPTT.Name = "labelDienThoaiPTT";
            this.labelDienThoaiPTT.Size = new System.Drawing.Size(103, 22);
            this.labelDienThoaiPTT.TabIndex = 0;
            this.labelDienThoaiPTT.Text = "Điện thoại :";
            // 
            // panelEmailPTT
            // 
            this.panelEmailPTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmailPTT.Controls.Add(this.textBoxDiaChiPTT);
            this.panelEmailPTT.Controls.Add(this.labelEmailPTT);
            this.panelEmailPTT.Location = new System.Drawing.Point(506, 90);
            this.panelEmailPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEmailPTT.Name = "panelEmailPTT";
            this.panelEmailPTT.Size = new System.Drawing.Size(513, 81);
            this.panelEmailPTT.TabIndex = 3;
            // 
            // textBoxDiaChiPTT
            // 
            this.textBoxDiaChiPTT.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDiaChiPTT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxDiaChiPTT.Location = new System.Drawing.Point(110, 20);
            this.textBoxDiaChiPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDiaChiPTT.MaxLength = 100;
            this.textBoxDiaChiPTT.Name = "textBoxDiaChiPTT";
            this.textBoxDiaChiPTT.ReadOnly = true;
            this.textBoxDiaChiPTT.Size = new System.Drawing.Size(264, 26);
            this.textBoxDiaChiPTT.TabIndex = 0;
            this.textBoxDiaChiPTT.TabStop = false;
            // 
            // labelEmailPTT
            // 
            this.labelEmailPTT.AutoSize = true;
            this.labelEmailPTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelEmailPTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelEmailPTT.Location = new System.Drawing.Point(2, 20);
            this.labelEmailPTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailPTT.Name = "labelEmailPTT";
            this.labelEmailPTT.Size = new System.Drawing.Size(83, 22);
            this.labelEmailPTT.TabIndex = 0;
            this.labelEmailPTT.Text = "Địa Chỉ :";
            // 
            // panelNgayThuTienPTT
            // 
            this.panelNgayThuTienPTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNgayThuTienPTT.Controls.Add(this.textBoxNgayThuTien);
            this.panelNgayThuTienPTT.Controls.Add(this.labelNgayThuTienPTT);
            this.panelNgayThuTienPTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelNgayThuTienPTT.Location = new System.Drawing.Point(2, 175);
            this.panelNgayThuTienPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNgayThuTienPTT.Name = "panelNgayThuTienPTT";
            this.panelNgayThuTienPTT.Size = new System.Drawing.Size(500, 79);
            this.panelNgayThuTienPTT.TabIndex = 4;
            // 
            // textBoxNgayThuTien
            // 
            this.textBoxNgayThuTien.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNgayThuTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNgayThuTien.Location = new System.Drawing.Point(151, 20);
            this.textBoxNgayThuTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNgayThuTien.MaxLength = 10;
            this.textBoxNgayThuTien.Name = "textBoxNgayThuTien";
            this.textBoxNgayThuTien.ReadOnly = true;
            this.textBoxNgayThuTien.Size = new System.Drawing.Size(247, 26);
            this.textBoxNgayThuTien.TabIndex = 0;
            this.textBoxNgayThuTien.TabStop = false;
            // 
            // labelNgayThuTienPTT
            // 
            this.labelNgayThuTienPTT.AutoSize = true;
            this.labelNgayThuTienPTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelNgayThuTienPTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNgayThuTienPTT.Location = new System.Drawing.Point(2, 20);
            this.labelNgayThuTienPTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayThuTienPTT.Name = "labelNgayThuTienPTT";
            this.labelNgayThuTienPTT.Size = new System.Drawing.Size(124, 22);
            this.labelNgayThuTienPTT.TabIndex = 0;
            this.labelNgayThuTienPTT.Text = "Ngày thu tiền :";
            // 
            // panel33
            // 
            this.panel33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel33.Controls.Add(this.labelSoTienThuPTT);
            this.panel33.Controls.Add(this.textBoxSoTienThuPTT);
            this.panel33.Location = new System.Drawing.Point(506, 175);
            this.panel33.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(513, 79);
            this.panel33.TabIndex = 5;
            // 
            // labelSoTienThuPTT
            // 
            this.labelSoTienThuPTT.AutoSize = true;
            this.labelSoTienThuPTT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelSoTienThuPTT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelSoTienThuPTT.Location = new System.Drawing.Point(2, 22);
            this.labelSoTienThuPTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoTienThuPTT.Name = "labelSoTienThuPTT";
            this.labelSoTienThuPTT.Size = new System.Drawing.Size(104, 22);
            this.labelSoTienThuPTT.TabIndex = 0;
            this.labelSoTienThuPTT.Text = "Số tiền thu :";
            // 
            // textBoxSoTienThuPTT
            // 
            this.textBoxSoTienThuPTT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxSoTienThuPTT.Location = new System.Drawing.Point(110, 22);
            this.textBoxSoTienThuPTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSoTienThuPTT.Name = "textBoxSoTienThuPTT";
            this.textBoxSoTienThuPTT.Size = new System.Drawing.Size(264, 26);
            this.textBoxSoTienThuPTT.TabIndex = 2;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel22.Controls.Add(this.lblPhieuThuTien);
            this.panel22.Location = new System.Drawing.Point(4, 4);
            this.panel22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1032, 83);
            this.panel22.TabIndex = 0;
            // 
            // lblPhieuThuTien
            // 
            this.lblPhieuThuTien.AutoSize = true;
            this.lblPhieuThuTien.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.lblPhieuThuTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPhieuThuTien.Location = new System.Drawing.Point(351, 13);
            this.lblPhieuThuTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhieuThuTien.Name = "lblPhieuThuTien";
            this.lblPhieuThuTien.Size = new System.Drawing.Size(202, 39);
            this.lblPhieuThuTien.TabIndex = 0;
            this.lblPhieuThuTien.Text = "Phiếu thu tiền";
            // 
            // tPVTPT
            // 
            this.tPVTPT.BackColor = System.Drawing.Color.White;
            this.tPVTPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tPVTPT.Controls.Add(this.panel28);
            this.tPVTPT.Controls.Add(this.panel27);
            this.tPVTPT.Controls.Add(this.panel25);
            this.tPVTPT.Location = new System.Drawing.Point(104, 4);
            this.tPVTPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPVTPT.Name = "tPVTPT";
            this.tPVTPT.Size = new System.Drawing.Size(1042, 512);
            this.tPVTPT.TabIndex = 3;
            this.tPVTPT.Text = "Nhập VTPT";
            // 
            // panel28
            // 
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel28.Controls.Add(this.panel32);
            this.panel28.Controls.Add(this.panel31);
            this.panel28.Controls.Add(this.panel30);
            this.panel28.Controls.Add(this.panel29);
            this.panel28.Location = new System.Drawing.Point(3, 110);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(1032, 243);
            this.panel28.TabIndex = 2;
            // 
            // panel32
            // 
            this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel32.Controls.Add(this.labelGiaVTPT);
            this.panel32.Controls.Add(this.textBoxGiaVTPT);
            this.panel32.Location = new System.Drawing.Point(491, 118);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(534, 118);
            this.panel32.TabIndex = 3;
            // 
            // labelGiaVTPT
            // 
            this.labelGiaVTPT.AutoSize = true;
            this.labelGiaVTPT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelGiaVTPT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelGiaVTPT.Location = new System.Drawing.Point(8, 41);
            this.labelGiaVTPT.Name = "labelGiaVTPT";
            this.labelGiaVTPT.Size = new System.Drawing.Size(50, 22);
            this.labelGiaVTPT.TabIndex = 3;
            this.labelGiaVTPT.Text = "Giá :";
            this.labelGiaVTPT.Click += new System.EventHandler(this.labelGiaVTPT_Click);
            // 
            // textBoxGiaVTPT
            // 
            this.textBoxGiaVTPT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxGiaVTPT.Location = new System.Drawing.Point(168, 41);
            this.textBoxGiaVTPT.Name = "textBoxGiaVTPT";
            this.textBoxGiaVTPT.Size = new System.Drawing.Size(283, 26);
            this.textBoxGiaVTPT.TabIndex = 4;
            this.textBoxGiaVTPT.TextChanged += new System.EventHandler(this.TextBoxGiaVTPT_TextChanged);
            // 
            // panel31
            // 
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel31.Controls.Add(this.labelTenVTPTMoi);
            this.panel31.Controls.Add(this.textBoxTenVTPTMoi);
            this.panel31.Location = new System.Drawing.Point(491, 3);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(534, 109);
            this.panel31.TabIndex = 2;
            // 
            // labelTenVTPTMoi
            // 
            this.labelTenVTPTMoi.AutoSize = true;
            this.labelTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelTenVTPTMoi.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelTenVTPTMoi.Location = new System.Drawing.Point(8, 41);
            this.labelTenVTPTMoi.Name = "labelTenVTPTMoi";
            this.labelTenVTPTMoi.Size = new System.Drawing.Size(143, 22);
            this.labelTenVTPTMoi.TabIndex = 2;
            this.labelTenVTPTMoi.Text = "Tên VTPT Mới :";
            // 
            // textBoxTenVTPTMoi
            // 
            this.textBoxTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxTenVTPTMoi.Location = new System.Drawing.Point(168, 37);
            this.textBoxTenVTPTMoi.MaxLength = 30;
            this.textBoxTenVTPTMoi.Name = "textBoxTenVTPTMoi";
            this.textBoxTenVTPTMoi.Size = new System.Drawing.Size(283, 26);
            this.textBoxTenVTPTMoi.TabIndex = 3;
            this.textBoxTenVTPTMoi.TextChanged += new System.EventHandler(this.TextBoxTenVTPTMoi_TextChanged);
            // 
            // panel30
            // 
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel30.Controls.Add(this.labelSoLuongVTPT);
            this.panel30.Controls.Add(this.textBoxSoLuongVTPT);
            this.panel30.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panel30.Location = new System.Drawing.Point(3, 118);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(483, 118);
            this.panel30.TabIndex = 1;
            // 
            // labelSoLuongVTPT
            // 
            this.labelSoLuongVTPT.AutoSize = true;
            this.labelSoLuongVTPT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelSoLuongVTPT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelSoLuongVTPT.Location = new System.Drawing.Point(3, 41);
            this.labelSoLuongVTPT.Name = "labelSoLuongVTPT";
            this.labelSoLuongVTPT.Size = new System.Drawing.Size(98, 22);
            this.labelSoLuongVTPT.TabIndex = 1;
            this.labelSoLuongVTPT.Text = "Số Lượng :";
            // 
            // textBoxSoLuongVTPT
            // 
            this.textBoxSoLuongVTPT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxSoLuongVTPT.Location = new System.Drawing.Point(111, 37);
            this.textBoxSoLuongVTPT.Name = "textBoxSoLuongVTPT";
            this.textBoxSoLuongVTPT.Size = new System.Drawing.Size(284, 26);
            this.textBoxSoLuongVTPT.TabIndex = 2;
            // 
            // panel29
            // 
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel29.Controls.Add(this.comboBoxTenVTPT);
            this.panel29.Controls.Add(this.labelTenVTPT);
            this.panel29.Location = new System.Drawing.Point(3, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(483, 109);
            this.panel29.TabIndex = 0;
            // 
            // comboBoxTenVTPT
            // 
            this.comboBoxTenVTPT.DataSource = this.kHOBindingSource;
            this.comboBoxTenVTPT.DisplayMember = "TenVatTuPhuTung";
            this.comboBoxTenVTPT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxTenVTPT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxTenVTPT.Location = new System.Drawing.Point(111, 41);
            this.comboBoxTenVTPT.Name = "comboBoxTenVTPT";
            this.comboBoxTenVTPT.Size = new System.Drawing.Size(284, 27);
            this.comboBoxTenVTPT.TabIndex = 1;
            this.comboBoxTenVTPT.ValueMember = "MaPhuTung";
            this.comboBoxTenVTPT.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxTenVTPT_SelectionChangeCommitted);
            // 
            // labelTenVTPT
            // 
            this.labelTenVTPT.AutoSize = true;
            this.labelTenVTPT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelTenVTPT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelTenVTPT.Location = new System.Drawing.Point(1, 42);
            this.labelTenVTPT.Name = "labelTenVTPT";
            this.labelTenVTPT.Size = new System.Drawing.Size(104, 22);
            this.labelTenVTPT.TabIndex = 0;
            this.labelTenVTPT.Text = "Tên VTPT :";
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel27.Controls.Add(this.buttonTaoMoiVTPT);
            this.panel27.Controls.Add(this.buttonPhieuNhapVTPTMoi);
            this.panel27.Controls.Add(this.buttonInPhieuNhapVTPT);
            this.panel27.Controls.Add(this.buttonLapPhieuNhapVTPT);
            this.panel27.Location = new System.Drawing.Point(3, 358);
            this.panel27.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(1033, 148);
            this.panel27.TabIndex = 3;
            // 
            // buttonTaoMoiVTPT
            // 
            this.buttonTaoMoiVTPT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonTaoMoiVTPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaoMoiVTPT.ForeColor = System.Drawing.Color.White;
            this.buttonTaoMoiVTPT.Location = new System.Drawing.Point(281, 39);
            this.buttonTaoMoiVTPT.Name = "buttonTaoMoiVTPT";
            this.buttonTaoMoiVTPT.Size = new System.Drawing.Size(181, 75);
            this.buttonTaoMoiVTPT.TabIndex = 6;
            this.buttonTaoMoiVTPT.Text = "Nhập Mới VTPT";
            this.buttonTaoMoiVTPT.UseVisualStyleBackColor = true;
            this.buttonTaoMoiVTPT.Click += new System.EventHandler(this.buttonTaoMoiVTPT_Click);
            // 
            // buttonPhieuNhapVTPTMoi
            // 
            this.buttonPhieuNhapVTPTMoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPhieuNhapVTPTMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhieuNhapVTPTMoi.ForeColor = System.Drawing.Color.White;
            this.buttonPhieuNhapVTPTMoi.Location = new System.Drawing.Point(518, 39);
            this.buttonPhieuNhapVTPTMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPhieuNhapVTPTMoi.Name = "buttonPhieuNhapVTPTMoi";
            this.buttonPhieuNhapVTPTMoi.Size = new System.Drawing.Size(178, 75);
            this.buttonPhieuNhapVTPTMoi.TabIndex = 7;
            this.buttonPhieuNhapVTPTMoi.Text = "Phiếu nhập VTPT mới";
            this.buttonPhieuNhapVTPTMoi.UseVisualStyleBackColor = true;
            this.buttonPhieuNhapVTPTMoi.Click += new System.EventHandler(this.ButtonPhieuNhapVTPTMoi_Click);
            // 
            // buttonInPhieuNhapVTPT
            // 
            this.buttonInPhieuNhapVTPT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInPhieuNhapVTPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInPhieuNhapVTPT.ForeColor = System.Drawing.Color.White;
            this.buttonInPhieuNhapVTPT.Location = new System.Drawing.Point(761, 40);
            this.buttonInPhieuNhapVTPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInPhieuNhapVTPT.Name = "buttonInPhieuNhapVTPT";
            this.buttonInPhieuNhapVTPT.Size = new System.Drawing.Size(183, 75);
            this.buttonInPhieuNhapVTPT.TabIndex = 8;
            this.buttonInPhieuNhapVTPT.Text = "In phiếu nhập VTPT";
            this.buttonInPhieuNhapVTPT.UseVisualStyleBackColor = true;
            this.buttonInPhieuNhapVTPT.Click += new System.EventHandler(this.ButtonInPhieuNhapVTPT_Click);
            // 
            // buttonLapPhieuNhapVTPT
            // 
            this.buttonLapPhieuNhapVTPT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonLapPhieuNhapVTPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLapPhieuNhapVTPT.ForeColor = System.Drawing.Color.White;
            this.buttonLapPhieuNhapVTPT.Location = new System.Drawing.Point(43, 39);
            this.buttonLapPhieuNhapVTPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLapPhieuNhapVTPT.Name = "buttonLapPhieuNhapVTPT";
            this.buttonLapPhieuNhapVTPT.Size = new System.Drawing.Size(171, 76);
            this.buttonLapPhieuNhapVTPT.TabIndex = 5;
            this.buttonLapPhieuNhapVTPT.Text = "Lập phiếu nhập VTPT";
            this.buttonLapPhieuNhapVTPT.UseVisualStyleBackColor = true;
            this.buttonLapPhieuNhapVTPT.Click += new System.EventHandler(this.buttonLapPhieuNhapVTPT_Click);
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel25.Controls.Add(this.labelPhieuNhapVTPT);
            this.panel25.Location = new System.Drawing.Point(1, 3);
            this.panel25.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1034, 102);
            this.panel25.TabIndex = 0;
            this.panel25.TabStop = true;
            // 
            // labelPhieuNhapVTPT
            // 
            this.labelPhieuNhapVTPT.AutoSize = true;
            this.labelPhieuNhapVTPT.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.labelPhieuNhapVTPT.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPhieuNhapVTPT.Location = new System.Drawing.Point(288, 37);
            this.labelPhieuNhapVTPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhieuNhapVTPT.Name = "labelPhieuNhapVTPT";
            this.labelPhieuNhapVTPT.Size = new System.Drawing.Size(378, 39);
            this.labelPhieuNhapVTPT.TabIndex = 0;
            this.labelPhieuNhapVTPT.Text = "Phiếu nhập vật tư phụ tùng";
            this.labelPhieuNhapVTPT.Click += new System.EventHandler(this.labelPhieuNhapVTPT_Click);
            // 
            // tPTraCuu
            // 
            this.tPTraCuu.BackColor = System.Drawing.Color.White;
            this.tPTraCuu.Controls.Add(this.splitContainer1);
            this.tPTraCuu.Location = new System.Drawing.Point(104, 4);
            this.tPTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPTraCuu.Name = "tPTraCuu";
            this.tPTraCuu.Size = new System.Drawing.Size(1042, 512);
            this.tPTraCuu.TabIndex = 4;
            this.tPTraCuu.Text = "Tra cứu";
            // 
            // tCtrlChinh
            // 
            this.tCtrlChinh.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tCtrlChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tCtrlChinh.Controls.Add(this.tPChucNang);
            this.tCtrlChinh.Controls.Add(this.tPBaoCao);
            this.tCtrlChinh.Controls.Add(this.tPQuyDinh);
            this.tCtrlChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tCtrlChinh.ItemSize = new System.Drawing.Size(44, 80);
            this.tCtrlChinh.Location = new System.Drawing.Point(9, 42);
            this.tCtrlChinh.Margin = new System.Windows.Forms.Padding(0);
            this.tCtrlChinh.Multiline = true;
            this.tCtrlChinh.Name = "tCtrlChinh";
            this.tCtrlChinh.Padding = new System.Drawing.Point(0, 0);
            this.tCtrlChinh.SelectedIndex = 0;
            this.tCtrlChinh.Size = new System.Drawing.Size(1238, 528);
            this.tCtrlChinh.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tCtrlChinh.TabIndex = 0;
            // 
            // hIEUXETableAdapter
            // 
            this.hIEUXETableAdapter.ClearBeforeFill = true;
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // tIENCONGTableAdapter
            // 
            this.tIENCONGTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1216, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1256, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tCtrlChinh);
            this.Controls.Add(this.menuStripCongCu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripCongCu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý garage";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.flowLayoutPanelTimChinhXac.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGarageDataSet)).EndInit();
            this.paneldtgvTCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).EndInit();
            this.menuStripCongCu.ResumeLayout(false);
            this.menuStripCongCu.PerformLayout();
            this.tPQuyDinh.ResumeLayout(false);
            this.panelQuyDinhHienHanh.ResumeLayout(false);
            this.panelQuyDinhHienHanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyDinhHienHanh)).EndInit();
            this.pnCapNhatQuyDinh.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tPBaoCao.ResumeLayout(false);
            this.tCtrlBaoCao.ResumeLayout(false);
            this.tPDoanhSo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).EndInit();
            this.pnlThang.ResumeLayout(false);
            this.pnlThang.PerformLayout();
            this.pnlChonThoiDiem.ResumeLayout(false);
            this.pnlChonThoiDiem.PerformLayout();
            this.tPBaoCaoTon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoTon)).EndInit();
            this.pnChonThoiDiem.ResumeLayout(false);
            this.pnChonThoiDiem.PerformLayout();
            this.tPChucNang.ResumeLayout(false);
            this.tCtrlChucNang.ResumeLayout(false);
            this.tPTiepNhan.ResumeLayout(false);
            this.pnDanhSachTiepNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXeDaTiepNhan)).EndInit();
            this.pnThemThongTinKHVaXe.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tPPSC.ResumeLayout(false);
            this.tPPSC.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIENCONGBindingSource)).EndInit();
            this.panelNhapPhieuSuaChua.ResumeLayout(false);
            this.panelNhapPhieuSuaChua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTienCongPhieuSuaChua)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVTPTPhieuSuaChua)).EndInit();
            this.pnNgaySuaChua.ResumeLayout(false);
            this.pnNgaySuaChua.PerformLayout();
            this.pnlBienSoXe.ResumeLayout(false);
            this.pnlBienSoXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tPPTT.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panelHoTenChuXePTT.ResumeLayout(false);
            this.panelHoTenChuXePTT.PerformLayout();
            this.panelBienSoPTT.ResumeLayout(false);
            this.panelBienSoPTT.PerformLayout();
            this.panelDienThoaiPTT.ResumeLayout(false);
            this.panelDienThoaiPTT.PerformLayout();
            this.panelEmailPTT.ResumeLayout(false);
            this.panelEmailPTT.PerformLayout();
            this.panelNgayThuTienPTT.ResumeLayout(false);
            this.panelNgayThuTienPTT.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.tPVTPT.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.tPTraCuu.ResumeLayout(false);
            this.tCtrlChinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripCongCu;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialogPSC;
        private System.Windows.Forms.PrintDialog printDialogPTT;
        private System.Windows.Forms.PrintDialog printDialogPhieuNhapVTPT;
        private System.Windows.Forms.TabPage tPQuyDinh;
        private System.Windows.Forms.Panel pnCapNhatQuyDinh;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.Panel panel11;
        private buttoncustom.RJButton btnCapNhatSoLoaiTienCong;
        private System.Windows.Forms.Label lblSoLoaiTienCong;
        private System.Windows.Forms.TextBox txtBoxSoLoaiTienCong;
        private System.Windows.Forms.Panel panel12;
        private buttoncustom.RJButton btnCapNhatSoLoaiVatTu;
        private System.Windows.Forms.Label lblSoLoaiVatTu;
        private System.Windows.Forms.TextBox txtBoxSoLoaiVatTu;
        private System.Windows.Forms.Panel panel13;
        private buttoncustom.RJButton btnCapNhatSoXeSuaToiDa;
        private System.Windows.Forms.Label lblSoXeSuaChuaToiDa;
        private System.Windows.Forms.TextBox txtBoxSoXeSuaChuaToiDa;
        private System.Windows.Forms.TabPage tPBaoCao;
        private DotNetBarTabcontrol tCtrlBaoCao;
        private System.Windows.Forms.TabPage tPDoanhSo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewBaoCaoDoanhSo;
        private System.Windows.Forms.Panel pnlThang;
        private System.Windows.Forms.TextBox textBoxTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Panel pnlChonThoiDiem;
        private System.Windows.Forms.TextBox textBoxNamBaoCao;
        private System.Windows.Forms.TextBox textBoxThangBaoCao;
        private System.Windows.Forms.Label labelNamBaoCao;
        private System.Windows.Forms.Label labelThangBaoCao;
        private buttoncustom.RJButton btnBaoCaoDoanhSoMoi;
        private System.Windows.Forms.Label lblChonThoiDiem;
        private buttoncustom.RJButton btnLapBaoCaoDoanhSo;
        private System.Windows.Forms.TabPage tPBaoCaoTon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewBaoCaoTon;
        private System.Windows.Forms.Panel pnChonThoiDiem;
        private buttoncustom.RJButton btnBaoCaoTonMoi;
        private System.Windows.Forms.Label lblChonThoiDiemTon;
        private System.Windows.Forms.DateTimePicker dateTimePickerChonThoiDiemBaoCaoTon;
        private buttoncustom.RJButton btnLapBaoCaoTon;
        private System.Windows.Forms.TabPage tPChucNang;
        private QuanLyGarageDataSet1 quanLyGarageDataSet;
        private System.Windows.Forms.BindingSource hIEUXEBindingSource;
        private QuanLyGarageDataSet1TableAdapters.HIEUXETableAdapter hIEUXETableAdapter;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private QuanLyGarageDataSet1TableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private QuanLyGarageDataSet1TableAdapters.KHOTableAdapter kHOTableAdapter;
        private System.Windows.Forms.BindingSource tIENCONGBindingSource;
        private QuanLyGarageDataSet1TableAdapters.TIENCONGTableAdapter tIENCONGTableAdapter;
        private System.Windows.Forms.Panel panelQuyDinhHienHanh;
        private System.Windows.Forms.Label labelQuyDinhHienHanh;
        private System.Windows.Forms.DataGridView dataGridViewQuyDinhHienHanh;
        private buttoncustom.RJButton buttonLamMoiQuyDinh;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private DotNetBarTabcontrol tCtrlChucNang;
        private System.Windows.Forms.TabPage tPTiepNhan;
        private System.Windows.Forms.Panel pnDanhSachTiepNhan;
        private buttoncustom.RJButton buttonLamMoi;
        private System.Windows.Forms.Label lblDanhSachTiepNhan;
        private System.Windows.Forms.DataGridView dataGridViewXeDaTiepNhan;
        private System.Windows.Forms.Panel pnThemThongTinKHVaXe;
        private System.Windows.Forms.Label label1;
        private buttoncustom.RJButton buttonClear;
        private buttoncustom.RJButton buttonThemXe;
        private System.Windows.Forms.ProgressBar progressBarSoXeDaThem;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxHieuXe;
        private System.Windows.Forms.Label lblHieuXe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxBienSo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtBoxDiaChi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtBoxDienThoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTenKhachHang;
        private System.Windows.Forms.TextBox txtBoxTenKH;
        private System.Windows.Forms.TabPage tPPSC;
        private System.Windows.Forms.Panel panel9;
        private buttoncustom.RJButton buttonNhapTienCongPhieuSuaChua;
        private System.Windows.Forms.ComboBox comboBoxTienCongPhieuSuaChua;
        private System.Windows.Forms.Label labelTienCongPhieuSuaChua;
        private System.Windows.Forms.Panel panelNhapPhieuSuaChua;
        private buttoncustom.RJButton buttonNhapVTPTPhieuSuaChua;
        private buttoncustom.RJButton buttonNhapPhieuSuaChua;
        private System.Windows.Forms.TextBox textBoxSoLuongVTPTPhieuSuaChua;
        private System.Windows.Forms.Label labelSoLuongPhieuSuaChua;
        private System.Windows.Forms.ComboBox comboBoxVTPTPhieuSuaChua;
        private System.Windows.Forms.Label labelVTPTPhieuSuaChua;
        private buttoncustom.RJButton btnHoanTat;
        private System.Windows.Forms.TextBox textBoxTongTienPhieuSuaChua;
        private System.Windows.Forms.Label lblTongTien;
        private buttoncustom.RJButton btnTaoMoiPCS;
        private buttoncustom.RJButton btnInPhieuSuaChua;
        private buttoncustom.RJButton btnLuuPSC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewTienCongPhieuSuaChua;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewVTPTPhieuSuaChua;
        private System.Windows.Forms.Panel pnNgaySuaChua;
        private System.Windows.Forms.TextBox txtBoxNgaySuaChua;
        private System.Windows.Forms.Label lblNgaySuaChua;
        private System.Windows.Forms.Panel pnlBienSoXe;
        private System.Windows.Forms.ComboBox comboBoxBienSoXe1;
        private System.Windows.Forms.Label lblBienSoXe;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPhieuSuaChua;
        private System.Windows.Forms.TabPage tPPTT;
        private System.Windows.Forms.Panel panel23;
        private buttoncustom.RJButton buttonPhieuThuTienMoiPTT;
        private buttoncustom.RJButton buttonInPhieuThuTienPTT;
        private buttoncustom.RJButton buttonLapPhieuThuTienPTT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panelHoTenChuXePTT;
        private System.Windows.Forms.TextBox textBoxHoTenChuXePTT;
        private System.Windows.Forms.Label labelHoTenChuXePTT;
        private System.Windows.Forms.Panel panelBienSoPTT;
        private System.Windows.Forms.ComboBox comboBienSoXe2;
        private System.Windows.Forms.Label labelBienSoPTT;
        private System.Windows.Forms.Panel panelDienThoaiPTT;
        private System.Windows.Forms.TextBox textBoxDienThoaiPTT;
        private System.Windows.Forms.Label labelDienThoaiPTT;
        private System.Windows.Forms.Panel panelEmailPTT;
        private System.Windows.Forms.TextBox textBoxDiaChiPTT;
        private System.Windows.Forms.Label labelEmailPTT;
        private System.Windows.Forms.Panel panelNgayThuTienPTT;
        private System.Windows.Forms.TextBox textBoxNgayThuTien;
        private System.Windows.Forms.Label labelNgayThuTienPTT;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Label labelSoTienThuPTT;
        private System.Windows.Forms.TextBox textBoxSoTienThuPTT;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label lblPhieuThuTien;
        private System.Windows.Forms.TabPage tPVTPT;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label labelGiaVTPT;
        private System.Windows.Forms.TextBox textBoxGiaVTPT;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label labelTenVTPTMoi;
        private System.Windows.Forms.TextBox textBoxTenVTPTMoi;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label labelSoLuongVTPT;
        private System.Windows.Forms.TextBox textBoxSoLuongVTPT;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.ComboBox comboBoxTenVTPT;
        private System.Windows.Forms.Label labelTenVTPT;
        private System.Windows.Forms.Panel panel27;
        private buttoncustom.RJButton buttonTaoMoiVTPT;
        private buttoncustom.RJButton buttonPhieuNhapVTPTMoi;
        private buttoncustom.RJButton buttonInPhieuNhapVTPT;
        private buttoncustom.RJButton buttonLapPhieuNhapVTPT;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label labelPhieuNhapVTPT;
        private System.Windows.Forms.TabPage tPTraCuu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox textBoxTraCuuChinh;
        private System.Windows.Forms.Label lblTraCuuChinh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonTimTuongDoi;
        private System.Windows.Forms.RadioButton radioButtonTimChinhXac;
        private System.Windows.Forms.Panel panel26;
        private buttoncustom.RJButton btnDatLaiTraCuu;
        private buttoncustom.RJButton btnTimKiemTraCuu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTimChinhXac;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.ComboBox comboBoxHieuXeTraCuu;
        private System.Windows.Forms.Label lblHieuXeTraCuu;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtBoxBienSoTraCuu;
        private System.Windows.Forms.Label lblBienSoTraCuu;
        private System.Windows.Forms.Panel paneldtgvTCuu;
        private System.Windows.Forms.DataGridView dataGridViewTraCuu;
        public DotNetBarTabcontrol tCtrlChinh;
        private System.Windows.Forms.Button button1;
        private RJButton rjButton1;
    }
}