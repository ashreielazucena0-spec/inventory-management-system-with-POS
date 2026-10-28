using System.Drawing;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    partial class frmManageReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used by the designer.
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

        // ---- Controls -----------------------------------------------------
        private Panel header;
        private Panel pnlHeaderBadge;
        private Label lblHeaderIcon;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;

        private Panel pageBody;

        private Panel topCard;
        private Panel filterRow;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnRun;
        private Button btnExport;

        private TableLayoutPanel kpiPanel;
        private Panel cardRevenue, cardTxns, cardItems, cardAvg;
        private Label lblRevenueTitle, lblRevenueValue, lblRevenueIcon;
        private Label lblTxnsTitle, lblTxnsValue, lblTxnsIcon;
        private Label lblItemsTitle, lblItemsValue, lblItemsIcon;
        private Label lblAvgTitle, lblAvgValue, lblAvgIcon;

        private TableLayoutPanel splitPanel;

        private Panel salesCard;
        private Panel salesCardHeader;
        private Label lblSalesIcon;
        private Label lblSalesTitle;
        private Panel salesGridHost;
        private DataGridView gridSales;
        private Panel pnlSalesEmpty;
        private Panel spacerSalesEmpty;
        private Label lblSalesEmptyIcon;
        private Label lblSalesEmptyTitle;
        private Label lblSalesEmptySubtitle;

        private Panel topBox;
        private Panel topBoxHeader;
        private Label lblTopIcon;
        private Label lblTopTitle;
        private Panel topGridHost;
        private DataGridView gridTopProducts;
        private Panel pnlProductsEmpty;
        private Panel spacerProductsEmpty;
        private Label lblProductsEmptyIcon;
        private Label lblProductsEmptyTitle;
        private Label lblProductsEmptySubtitle;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlHeaderBadge = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.pageBody = new System.Windows.Forms.Panel();
            this.splitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.salesCard = new System.Windows.Forms.Panel();
            this.salesGridHost = new System.Windows.Forms.Panel();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSalesEmpty = new System.Windows.Forms.Panel();
            this.lblSalesEmptySubtitle = new System.Windows.Forms.Label();
            this.lblSalesEmptyTitle = new System.Windows.Forms.Label();
            this.lblSalesEmptyIcon = new System.Windows.Forms.Label();
            this.spacerSalesEmpty = new System.Windows.Forms.Panel();
            this.salesCardHeader = new System.Windows.Forms.Panel();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.lblSalesIcon = new System.Windows.Forms.Label();
            this.topBox = new System.Windows.Forms.Panel();
            this.topGridHost = new System.Windows.Forms.Panel();
            this.gridTopProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductsEmpty = new System.Windows.Forms.Panel();
            this.lblProductsEmptySubtitle = new System.Windows.Forms.Label();
            this.lblProductsEmptyTitle = new System.Windows.Forms.Label();
            this.lblProductsEmptyIcon = new System.Windows.Forms.Label();
            this.spacerProductsEmpty = new System.Windows.Forms.Panel();
            this.topBoxHeader = new System.Windows.Forms.Panel();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.lblTopIcon = new System.Windows.Forms.Label();
            this.topCard = new System.Windows.Forms.Panel();
            this.kpiPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueIcon = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.cardTxns = new System.Windows.Forms.Panel();
            this.lblTxnsIcon = new System.Windows.Forms.Label();
            this.lblTxnsTitle = new System.Windows.Forms.Label();
            this.lblTxnsValue = new System.Windows.Forms.Label();
            this.cardItems = new System.Windows.Forms.Panel();
            this.lblItemsIcon = new System.Windows.Forms.Label();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.lblItemsValue = new System.Windows.Forms.Label();
            this.cardAvg = new System.Windows.Forms.Panel();
            this.lblAvgIcon = new System.Windows.Forms.Label();
            this.lblAvgTitle = new System.Windows.Forms.Label();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.filterRow = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.pnlHeaderBadge.SuspendLayout();
            this.pageBody.SuspendLayout();
            this.splitPanel.SuspendLayout();
            this.salesCard.SuspendLayout();
            this.salesGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.pnlSalesEmpty.SuspendLayout();
            this.salesCardHeader.SuspendLayout();
            this.topBox.SuspendLayout();
            this.topGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopProducts)).BeginInit();
            this.pnlProductsEmpty.SuspendLayout();
            this.topBoxHeader.SuspendLayout();
            this.topCard.SuspendLayout();
            this.kpiPanel.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardTxns.SuspendLayout();
            this.cardItems.SuspendLayout();
            this.cardAvg.SuspendLayout();
            this.filterRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.Controls.Add(this.lblHeaderSubtitle);
            this.header.Controls.Add(this.lblHeaderTitle);
            this.header.Controls.Add(this.pnlHeaderBadge);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.header.Size = new System.Drawing.Size(1200, 76);
            this.header.TabIndex = 1;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = Theme.Body;
            this.lblHeaderSubtitle.ForeColor = Theme.BorderStrong;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(83, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(391, 21);
            this.lblHeaderSubtitle.TabIndex = 0;
            this.lblHeaderSubtitle.Text = "View and analyze your sales and business performance";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = Theme.Title;
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(81, 7);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(208, 35);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Manage Reports";
            // 
            // pnlHeaderBadge
            // 
            this.pnlHeaderBadge.BackColor = Theme.PrimaryDark;
            this.pnlHeaderBadge.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderBadge.Location = new System.Drawing.Point(24, 16);
            this.pnlHeaderBadge.Name = "pnlHeaderBadge";
            this.pnlHeaderBadge.Size = new System.Drawing.Size(44, 44);
            this.pnlHeaderBadge.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIcon.Font = Theme.EmojiLarge;
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(44, 44);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "📈";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageBody
            // 
            this.pageBody.BackColor = Theme.Page;
            this.pageBody.Controls.Add(this.splitPanel);
            this.pageBody.Controls.Add(this.topCard);
            this.pageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageBody.Location = new System.Drawing.Point(0, 76);
            this.pageBody.Name = "pageBody";
            this.pageBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 24);
            this.pageBody.Size = new System.Drawing.Size(1200, 724);
            this.pageBody.TabIndex = 0;
            // 
            // splitPanel
            // 
            this.splitPanel.ColumnCount = 2;
            this.splitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.splitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.splitPanel.Controls.Add(this.salesCard, 0, 0);
            this.splitPanel.Controls.Add(this.topBox, 1, 0);
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.Location = new System.Drawing.Point(24, 210);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.RowCount = 1;
            this.splitPanel.Size = new System.Drawing.Size(1152, 490);
            this.splitPanel.TabIndex = 0;
            // 
            // salesCard
            // 
            this.salesCard.BackColor = System.Drawing.Color.White;
            this.salesCard.Controls.Add(this.salesGridHost);
            this.salesCard.Controls.Add(this.salesCardHeader);
            this.salesCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesCard.Location = new System.Drawing.Point(0, 0);
            this.salesCard.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.salesCard.Name = "salesCard";
            this.salesCard.Padding = new System.Windows.Forms.Padding(1);
            this.salesCard.Size = new System.Drawing.Size(681, 490);
            this.salesCard.TabIndex = 0;
            // 
            // salesGridHost
            // 
            this.salesGridHost.Controls.Add(this.gridSales);
            this.salesGridHost.Controls.Add(this.pnlSalesEmpty);
            this.salesGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGridHost.Location = new System.Drawing.Point(1, 53);
            this.salesGridHost.Name = "salesGridHost";
            this.salesGridHost.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.salesGridHost.Size = new System.Drawing.Size(679, 436);
            this.salesGridHost.TabIndex = 0;
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = Theme.SurfaceAlt;
            this.gridSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.gridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSales.BackgroundColor = System.Drawing.Color.White;
            this.gridSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Theme.SurfaceAlt;
            dataGridViewCellStyle20.Font = Theme.Body;
            dataGridViewCellStyle20.ForeColor = Theme.TextMuted;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gridSales.ColumnHeadersHeight = 38;
            this.gridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = Theme.Body;
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle21.SelectionBackColor = Theme.Page;
            dataGridViewCellStyle21.SelectionForeColor = Theme.NavyDark;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle21;
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.EnableHeadersVisualStyles = false;
            this.gridSales.GridColor = Theme.Page;
            this.gridSales.Location = new System.Drawing.Point(1, 0);
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.RowHeadersWidth = 51;
            this.gridSales.RowTemplate.Height = 34;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(677, 435);
            this.gridSales.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sale ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date/Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cashier";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // pnlSalesEmpty
            // 
            this.pnlSalesEmpty.BackColor = System.Drawing.Color.White;
            this.pnlSalesEmpty.Controls.Add(this.lblSalesEmptySubtitle);
            this.pnlSalesEmpty.Controls.Add(this.lblSalesEmptyTitle);
            this.pnlSalesEmpty.Controls.Add(this.lblSalesEmptyIcon);
            this.pnlSalesEmpty.Controls.Add(this.spacerSalesEmpty);
            this.pnlSalesEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesEmpty.Location = new System.Drawing.Point(1, 0);
            this.pnlSalesEmpty.Name = "pnlSalesEmpty";
            this.pnlSalesEmpty.Size = new System.Drawing.Size(677, 435);
            this.pnlSalesEmpty.TabIndex = 1;
            this.pnlSalesEmpty.Visible = false;
            // 
            // lblSalesEmptySubtitle
            // 
            this.lblSalesEmptySubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesEmptySubtitle.Font = Theme.Body;
            this.lblSalesEmptySubtitle.ForeColor = Theme.TextMuted;
            this.lblSalesEmptySubtitle.Location = new System.Drawing.Point(0, 146);
            this.lblSalesEmptySubtitle.Name = "lblSalesEmptySubtitle";
            this.lblSalesEmptySubtitle.Size = new System.Drawing.Size(677, 22);
            this.lblSalesEmptySubtitle.TabIndex = 0;
            this.lblSalesEmptySubtitle.Text = "Try adjusting the date range or run a new report.";
            this.lblSalesEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalesEmptyTitle
            // 
            this.lblSalesEmptyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesEmptyTitle.Font = Theme.LargeBold;
            this.lblSalesEmptyTitle.ForeColor = Theme.NavyDark;
            this.lblSalesEmptyTitle.Location = new System.Drawing.Point(0, 118);
            this.lblSalesEmptyTitle.Name = "lblSalesEmptyTitle";
            this.lblSalesEmptyTitle.Size = new System.Drawing.Size(677, 28);
            this.lblSalesEmptyTitle.TabIndex = 1;
            this.lblSalesEmptyTitle.Text = "No transactions found";
            this.lblSalesEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalesEmptyIcon
            // 
            this.lblSalesEmptyIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesEmptyIcon.Font = Theme.Emoji26;
            this.lblSalesEmptyIcon.ForeColor = Theme.BorderStrong;
            this.lblSalesEmptyIcon.Location = new System.Drawing.Point(0, 70);
            this.lblSalesEmptyIcon.Name = "lblSalesEmptyIcon";
            this.lblSalesEmptyIcon.Size = new System.Drawing.Size(677, 48);
            this.lblSalesEmptyIcon.TabIndex = 2;
            this.lblSalesEmptyIcon.Text = "🔍";
            this.lblSalesEmptyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacerSalesEmpty
            // 
            this.spacerSalesEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerSalesEmpty.Location = new System.Drawing.Point(0, 0);
            this.spacerSalesEmpty.Name = "spacerSalesEmpty";
            this.spacerSalesEmpty.Size = new System.Drawing.Size(677, 70);
            this.spacerSalesEmpty.TabIndex = 3;
            // 
            // salesCardHeader
            // 
            this.salesCardHeader.Controls.Add(this.lblSalesTitle);
            this.salesCardHeader.Controls.Add(this.lblSalesIcon);
            this.salesCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesCardHeader.Location = new System.Drawing.Point(1, 1);
            this.salesCardHeader.Name = "salesCardHeader";
            this.salesCardHeader.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.salesCardHeader.Size = new System.Drawing.Size(679, 52);
            this.salesCardHeader.TabIndex = 1;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = Theme.LargeBold;
            this.lblSalesTitle.ForeColor = Theme.NavyDark;
            this.lblSalesTitle.Location = new System.Drawing.Point(46, 15);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(123, 25);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "Transactions";
            // 
            // lblSalesIcon
            // 
            this.lblSalesIcon.AutoSize = true;
            this.lblSalesIcon.Font = Theme.Emoji;
            this.lblSalesIcon.Location = new System.Drawing.Point(18, 16);
            this.lblSalesIcon.Name = "lblSalesIcon";
            this.lblSalesIcon.Size = new System.Drawing.Size(39, 27);
            this.lblSalesIcon.TabIndex = 1;
            this.lblSalesIcon.Text = "🧾";
            // 
            // topBox
            // 
            this.topBox.BackColor = System.Drawing.Color.White;
            this.topBox.Controls.Add(this.topGridHost);
            this.topBox.Controls.Add(this.topBoxHeader);
            this.topBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBox.Location = new System.Drawing.Point(694, 3);
            this.topBox.Name = "topBox";
            this.topBox.Padding = new System.Windows.Forms.Padding(1);
            this.topBox.Size = new System.Drawing.Size(455, 484);
            this.topBox.TabIndex = 1;
            // 
            // topGridHost
            // 
            this.topGridHost.Controls.Add(this.gridTopProducts);
            this.topGridHost.Controls.Add(this.pnlProductsEmpty);
            this.topGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topGridHost.Location = new System.Drawing.Point(1, 53);
            this.topGridHost.Name = "topGridHost";
            this.topGridHost.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.topGridHost.Size = new System.Drawing.Size(453, 430);
            this.topGridHost.TabIndex = 0;
            // 
            // gridTopProducts
            // 
            this.gridTopProducts.AllowUserToAddRows = false;
            this.gridTopProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = Theme.SurfaceAlt;
            this.gridTopProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gridTopProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTopProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridTopProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTopProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridTopProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Theme.SurfaceAlt;
            dataGridViewCellStyle23.Font = Theme.Body;
            dataGridViewCellStyle23.ForeColor = Theme.TextMuted;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTopProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.gridTopProducts.ColumnHeadersHeight = 38;
            this.gridTopProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = Theme.Body;
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle24.SelectionBackColor = Theme.Page;
            dataGridViewCellStyle24.SelectionForeColor = Theme.NavyDark;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopProducts.DefaultCellStyle = dataGridViewCellStyle24;
            this.gridTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTopProducts.EnableHeadersVisualStyles = false;
            this.gridTopProducts.GridColor = Theme.Page;
            this.gridTopProducts.Location = new System.Drawing.Point(1, 0);
            this.gridTopProducts.Name = "gridTopProducts";
            this.gridTopProducts.ReadOnly = true;
            this.gridTopProducts.RowHeadersVisible = false;
            this.gridTopProducts.RowHeadersWidth = 51;
            this.gridTopProducts.RowTemplate.Height = 34;
            this.gridTopProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTopProducts.Size = new System.Drawing.Size(451, 429);
            this.gridTopProducts.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Product";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty sold";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Revenue";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // pnlProductsEmpty
            // 
            this.pnlProductsEmpty.BackColor = System.Drawing.Color.White;
            this.pnlProductsEmpty.Controls.Add(this.lblProductsEmptySubtitle);
            this.pnlProductsEmpty.Controls.Add(this.lblProductsEmptyTitle);
            this.pnlProductsEmpty.Controls.Add(this.lblProductsEmptyIcon);
            this.pnlProductsEmpty.Controls.Add(this.spacerProductsEmpty);
            this.pnlProductsEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsEmpty.Location = new System.Drawing.Point(1, 0);
            this.pnlProductsEmpty.Name = "pnlProductsEmpty";
            this.pnlProductsEmpty.Size = new System.Drawing.Size(451, 429);
            this.pnlProductsEmpty.TabIndex = 1;
            this.pnlProductsEmpty.Visible = false;
            // 
            // lblProductsEmptySubtitle
            // 
            this.lblProductsEmptySubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsEmptySubtitle.Font = Theme.Body;
            this.lblProductsEmptySubtitle.ForeColor = Theme.TextMuted;
            this.lblProductsEmptySubtitle.Location = new System.Drawing.Point(0, 146);
            this.lblProductsEmptySubtitle.Name = "lblProductsEmptySubtitle";
            this.lblProductsEmptySubtitle.Size = new System.Drawing.Size(451, 22);
            this.lblProductsEmptySubtitle.TabIndex = 0;
            this.lblProductsEmptySubtitle.Text = "There are no sales data for the selected period.";
            this.lblProductsEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductsEmptyTitle
            // 
            this.lblProductsEmptyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsEmptyTitle.Font = Theme.LargeBold;
            this.lblProductsEmptyTitle.ForeColor = Theme.NavyDark;
            this.lblProductsEmptyTitle.Location = new System.Drawing.Point(0, 118);
            this.lblProductsEmptyTitle.Name = "lblProductsEmptyTitle";
            this.lblProductsEmptyTitle.Size = new System.Drawing.Size(451, 28);
            this.lblProductsEmptyTitle.TabIndex = 1;
            this.lblProductsEmptyTitle.Text = "No products found";
            this.lblProductsEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductsEmptyIcon
            // 
            this.lblProductsEmptyIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsEmptyIcon.Font = Theme.Emoji26;
            this.lblProductsEmptyIcon.ForeColor = Theme.BorderStrong;
            this.lblProductsEmptyIcon.Location = new System.Drawing.Point(0, 70);
            this.lblProductsEmptyIcon.Name = "lblProductsEmptyIcon";
            this.lblProductsEmptyIcon.Size = new System.Drawing.Size(451, 48);
            this.lblProductsEmptyIcon.TabIndex = 2;
            this.lblProductsEmptyIcon.Text = "📭";
            this.lblProductsEmptyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacerProductsEmpty
            // 
            this.spacerProductsEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerProductsEmpty.Location = new System.Drawing.Point(0, 0);
            this.spacerProductsEmpty.Name = "spacerProductsEmpty";
            this.spacerProductsEmpty.Size = new System.Drawing.Size(451, 70);
            this.spacerProductsEmpty.TabIndex = 3;
            // 
            // topBoxHeader
            // 
            this.topBoxHeader.Controls.Add(this.lblTopTitle);
            this.topBoxHeader.Controls.Add(this.lblTopIcon);
            this.topBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBoxHeader.Location = new System.Drawing.Point(1, 1);
            this.topBoxHeader.Name = "topBoxHeader";
            this.topBoxHeader.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.topBoxHeader.Size = new System.Drawing.Size(453, 52);
            this.topBoxHeader.TabIndex = 1;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = Theme.LargeBold;
            this.lblTopTitle.ForeColor = Theme.NavyDark;
            this.lblTopTitle.Location = new System.Drawing.Point(46, 15);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(195, 25);
            this.lblTopTitle.TabIndex = 0;
            this.lblTopTitle.Text = "Top-selling products";
            // 
            // lblTopIcon
            // 
            this.lblTopIcon.AutoSize = true;
            this.lblTopIcon.Font = Theme.Emoji;
            this.lblTopIcon.Location = new System.Drawing.Point(18, 16);
            this.lblTopIcon.Name = "lblTopIcon";
            this.lblTopIcon.Size = new System.Drawing.Size(39, 27);
            this.lblTopIcon.TabIndex = 1;
            this.lblTopIcon.Text = "⭐";
            // 
            // topCard
            // 
            this.topCard.BackColor = System.Drawing.Color.White;
            this.topCard.Controls.Add(this.kpiPanel);
            this.topCard.Controls.Add(this.filterRow);
            this.topCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.topCard.Location = new System.Drawing.Point(24, 20);
            this.topCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.topCard.Name = "topCard";
            this.topCard.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.topCard.Size = new System.Drawing.Size(1152, 190);
            this.topCard.TabIndex = 1;
            // 
            // kpiPanel
            // 
            this.kpiPanel.ColumnCount = 4;
            this.kpiPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiPanel.Controls.Add(this.cardRevenue, 0, 0);
            this.kpiPanel.Controls.Add(this.cardTxns, 1, 0);
            this.kpiPanel.Controls.Add(this.cardItems, 2, 0);
            this.kpiPanel.Controls.Add(this.cardAvg, 3, 0);
            this.kpiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiPanel.Location = new System.Drawing.Point(20, 60);
            this.kpiPanel.Name = "kpiPanel";
            this.kpiPanel.RowCount = 1;
            this.kpiPanel.Size = new System.Drawing.Size(1112, 114);
            this.kpiPanel.TabIndex = 0;
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = Theme.SurfaceAlt;
            this.cardRevenue.Controls.Add(this.lblRevenueIcon);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.Controls.Add(this.lblRevenueValue);
            this.cardRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRevenue.Location = new System.Drawing.Point(0, 0);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Padding = new System.Windows.Forms.Padding(16, 14, 12, 12);
            this.cardRevenue.Size = new System.Drawing.Size(266, 114);
            this.cardRevenue.TabIndex = 0;
            // 
            // lblRevenueIcon
            // 
            this.lblRevenueIcon.AutoSize = true;
            this.lblRevenueIcon.Font = Theme.Emoji;
            this.lblRevenueIcon.Location = new System.Drawing.Point(14, 10);
            this.lblRevenueIcon.Name = "lblRevenueIcon";
            this.lblRevenueIcon.Size = new System.Drawing.Size(43, 30);
            this.lblRevenueIcon.TabIndex = 0;
            this.lblRevenueIcon.Text = "💰";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = Theme.Body;
            this.lblRevenueTitle.ForeColor = Theme.TextMuted;
            this.lblRevenueTitle.Location = new System.Drawing.Point(14, 40);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(98, 20);
            this.lblRevenueTitle.TabIndex = 1;
            this.lblRevenueTitle.Text = "Total revenue";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Font = Theme.Title;
            this.lblRevenueValue.ForeColor = Theme.NavyDark;
            this.lblRevenueValue.Location = new System.Drawing.Point(17, 62);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(29, 40);
            this.lblRevenueValue.TabIndex = 2;
            this.lblRevenueValue.Text = "-";
            // 
            // cardTxns
            // 
            this.cardTxns.BackColor = Theme.SurfaceAlt;
            this.cardTxns.Controls.Add(this.lblTxnsIcon);
            this.cardTxns.Controls.Add(this.lblTxnsTitle);
            this.cardTxns.Controls.Add(this.lblTxnsValue);
            this.cardTxns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTxns.Location = new System.Drawing.Point(278, 0);
            this.cardTxns.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardTxns.Name = "cardTxns";
            this.cardTxns.Padding = new System.Windows.Forms.Padding(16, 14, 12, 12);
            this.cardTxns.Size = new System.Drawing.Size(266, 114);
            this.cardTxns.TabIndex = 1;
            // 
            // lblTxnsIcon
            // 
            this.lblTxnsIcon.AutoSize = true;
            this.lblTxnsIcon.Font = Theme.Emoji;
            this.lblTxnsIcon.Location = new System.Drawing.Point(14, 10);
            this.lblTxnsIcon.Name = "lblTxnsIcon";
            this.lblTxnsIcon.Size = new System.Drawing.Size(43, 30);
            this.lblTxnsIcon.TabIndex = 0;
            this.lblTxnsIcon.Text = "🔁";
            // 
            // lblTxnsTitle
            // 
            this.lblTxnsTitle.AutoSize = true;
            this.lblTxnsTitle.Font = Theme.Body;
            this.lblTxnsTitle.ForeColor = Theme.TextMuted;
            this.lblTxnsTitle.Location = new System.Drawing.Point(14, 40);
            this.lblTxnsTitle.Name = "lblTxnsTitle";
            this.lblTxnsTitle.Size = new System.Drawing.Size(90, 20);
            this.lblTxnsTitle.TabIndex = 1;
            this.lblTxnsTitle.Text = "Transactions";
            // 
            // lblTxnsValue
            // 
            this.lblTxnsValue.AutoSize = true;
            this.lblTxnsValue.Font = Theme.Title;
            this.lblTxnsValue.ForeColor = Theme.NavyDark;
            this.lblTxnsValue.Location = new System.Drawing.Point(19, 60);
            this.lblTxnsValue.Name = "lblTxnsValue";
            this.lblTxnsValue.Size = new System.Drawing.Size(29, 40);
            this.lblTxnsValue.TabIndex = 2;
            this.lblTxnsValue.Text = "-";
            // 
            // cardItems
            // 
            this.cardItems.BackColor = Theme.SurfaceAlt;
            this.cardItems.Controls.Add(this.lblItemsIcon);
            this.cardItems.Controls.Add(this.lblItemsTitle);
            this.cardItems.Controls.Add(this.lblItemsValue);
            this.cardItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardItems.Location = new System.Drawing.Point(556, 0);
            this.cardItems.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardItems.Name = "cardItems";
            this.cardItems.Padding = new System.Windows.Forms.Padding(16, 14, 12, 12);
            this.cardItems.Size = new System.Drawing.Size(266, 114);
            this.cardItems.TabIndex = 2;
            // 
            // lblItemsIcon
            // 
            this.lblItemsIcon.AutoSize = true;
            this.lblItemsIcon.Font = Theme.Emoji;
            this.lblItemsIcon.Location = new System.Drawing.Point(14, 10);
            this.lblItemsIcon.Name = "lblItemsIcon";
            this.lblItemsIcon.Size = new System.Drawing.Size(43, 30);
            this.lblItemsIcon.TabIndex = 0;
            this.lblItemsIcon.Text = "📦";
            // 
            // lblItemsTitle
            // 
            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Font = Theme.Body;
            this.lblItemsTitle.ForeColor = Theme.TextMuted;
            this.lblItemsTitle.Location = new System.Drawing.Point(14, 40);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.Size = new System.Drawing.Size(77, 20);
            this.lblItemsTitle.TabIndex = 1;
            this.lblItemsTitle.Text = "Items sold";
            // 
            // lblItemsValue
            // 
            this.lblItemsValue.AutoSize = true;
            this.lblItemsValue.Font = Theme.Title;
            this.lblItemsValue.ForeColor = Theme.NavyDark;
            this.lblItemsValue.Location = new System.Drawing.Point(28, 60);
            this.lblItemsValue.Name = "lblItemsValue";
            this.lblItemsValue.Size = new System.Drawing.Size(29, 40);
            this.lblItemsValue.TabIndex = 2;
            this.lblItemsValue.Text = "-";
            // 
            // cardAvg
            // 
            this.cardAvg.BackColor = Theme.SurfaceAlt;
            this.cardAvg.Controls.Add(this.lblAvgIcon);
            this.cardAvg.Controls.Add(this.lblAvgTitle);
            this.cardAvg.Controls.Add(this.lblAvgValue);
            this.cardAvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAvg.Location = new System.Drawing.Point(834, 0);
            this.cardAvg.Margin = new System.Windows.Forms.Padding(0);
            this.cardAvg.Name = "cardAvg";
            this.cardAvg.Padding = new System.Windows.Forms.Padding(16, 14, 12, 12);
            this.cardAvg.Size = new System.Drawing.Size(278, 114);
            this.cardAvg.TabIndex = 3;
            // 
            // lblAvgIcon
            // 
            this.lblAvgIcon.AutoSize = true;
            this.lblAvgIcon.Font = Theme.Emoji;
            this.lblAvgIcon.Location = new System.Drawing.Point(14, 10);
            this.lblAvgIcon.Name = "lblAvgIcon";
            this.lblAvgIcon.Size = new System.Drawing.Size(43, 30);
            this.lblAvgIcon.TabIndex = 0;
            this.lblAvgIcon.Text = "📊";
            // 
            // lblAvgTitle
            // 
            this.lblAvgTitle.AutoSize = true;
            this.lblAvgTitle.Font = Theme.Body;
            this.lblAvgTitle.ForeColor = Theme.TextMuted;
            this.lblAvgTitle.Location = new System.Drawing.Point(14, 40);
            this.lblAvgTitle.Name = "lblAvgTitle";
            this.lblAvgTitle.Size = new System.Drawing.Size(94, 20);
            this.lblAvgTitle.TabIndex = 1;
            this.lblAvgTitle.Text = "Average sale";
            // 
            // lblAvgValue
            // 
            this.lblAvgValue.AutoSize = true;
            this.lblAvgValue.Font = Theme.Title;
            this.lblAvgValue.ForeColor = Theme.NavyDark;
            this.lblAvgValue.Location = new System.Drawing.Point(19, 60);
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.Size = new System.Drawing.Size(29, 40);
            this.lblAvgValue.TabIndex = 2;
            this.lblAvgValue.Text = "-";
            // 
            // filterRow
            // 
            this.filterRow.Controls.Add(this.lblFrom);
            this.filterRow.Controls.Add(this.dtpFrom);
            this.filterRow.Controls.Add(this.lblTo);
            this.filterRow.Controls.Add(this.dtpTo);
            this.filterRow.Controls.Add(this.btnRun);
            this.filterRow.Controls.Add(this.btnExport);
            this.filterRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterRow.Location = new System.Drawing.Point(20, 16);
            this.filterRow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.filterRow.Name = "filterRow";
            this.filterRow.Size = new System.Drawing.Size(1112, 44);
            this.filterRow.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = Theme.BodyBold;
            this.lblFrom.ForeColor = Theme.TextMuted;
            this.lblFrom.Location = new System.Drawing.Point(0, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(48, 8);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(140, 27);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = Theme.BodyBold;
            this.lblTo.ForeColor = Theme.TextMuted;
            this.lblTo.Location = new System.Drawing.Point(204, 13);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(232, 8);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(140, 27);
            this.dtpTo.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = Theme.Primary;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = Theme.BodyBold;
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(396, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 34);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "▶  Run report";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = Theme.NavyDark;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = Theme.BodyBold;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(540, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmManageReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Theme.Page;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.pageBody);
            this.Controls.Add(this.header);
            this.Font = Theme.Body;
            this.Name = "frmManageReports";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.pnlHeaderBadge.ResumeLayout(false);
            this.pageBody.ResumeLayout(false);
            this.splitPanel.ResumeLayout(false);
            this.salesCard.ResumeLayout(false);
            this.salesGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.pnlSalesEmpty.ResumeLayout(false);
            this.salesCardHeader.ResumeLayout(false);
            this.salesCardHeader.PerformLayout();
            this.topBox.ResumeLayout(false);
            this.topGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTopProducts)).EndInit();
            this.pnlProductsEmpty.ResumeLayout(false);
            this.topBoxHeader.ResumeLayout(false);
            this.topBoxHeader.PerformLayout();
            this.topCard.ResumeLayout(false);
            this.kpiPanel.ResumeLayout(false);
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardTxns.ResumeLayout(false);
            this.cardTxns.PerformLayout();
            this.cardItems.ResumeLayout(false);
            this.cardItems.PerformLayout();
            this.cardAvg.ResumeLayout(false);
            this.cardAvg.PerformLayout();
            this.filterRow.ResumeLayout(false);
            this.filterRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}