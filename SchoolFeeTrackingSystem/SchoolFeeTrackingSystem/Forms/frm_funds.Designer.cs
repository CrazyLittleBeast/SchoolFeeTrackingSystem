namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_funds
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sy = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_STotal = new System.Windows.Forms.Label();
            this.chart_studentFee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFTS_DBDataSet = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_GTotal = new System.Windows.Forms.Label();
            this.chart_guardianFee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guardianFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_G_ALLO = new System.Windows.Forms.DataGridView();
            this.Fee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_GFeeCollection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_S_ALLO = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_SFeeCollection = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.guardian_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter();
            this.student_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter();
            this.school_YearTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter();
            this.g_Trans_LOGTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.G_Trans_LOGTableAdapter();
            this.s_Trans_LogTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.S_Trans_LogTableAdapter();
            this.cTE_GuardianFeeALLOTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.CTE_GuardianFeeALLOTableAdapter();
            this.ctE_StudentFeeALLOTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.CTE_StudentFeeALLOTableAdapter();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.shapeContainer5 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_studentFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFTS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_guardianFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianFeeBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_G_ALLO)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_S_ALLO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_SY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_sy);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.shapeContainer5);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lbl_total);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.shapeContainer4);
            this.panel5.Location = new System.Drawing.Point(434, 530);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(180, 75);
            this.panel5.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "TOTAL COLLECTION";
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(13, 34);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(113, 32);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "12750.75";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox3.Image = global::SchoolFeeTrackingSystem.Properties.Resources.total_plan_cost_32;
            this.pictureBox3.Location = new System.Drawing.Point(128, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(1, 1);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.rectangleShape3});
            this.shapeContainer4.Size = new System.Drawing.Size(178, 73);
            this.shapeContainer4.TabIndex = 18;
            this.shapeContainer4.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4.CornerRadius = 5;
            this.rectangleShape4.Location = new System.Drawing.Point(3, 25);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(173, 47);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.GreenYellow;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(40, 2);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(130, 39);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "School Year";
            // 
            // lbl_SY
            // 
            this.lbl_SY.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SY.Location = new System.Drawing.Point(437, 21);
            this.lbl_SY.Name = "lbl_SY";
            this.lbl_SY.Size = new System.Drawing.Size(176, 35);
            this.lbl_SY.TabIndex = 14;
            this.lbl_SY.Text = "2015-2016";
            this.lbl_SY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SY:";
            // 
            // cmb_sy
            // 
            this.cmb_sy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sy.FormattingEnabled = true;
            this.cmb_sy.Location = new System.Drawing.Point(850, 23);
            this.cmb_sy.Name = "cmb_sy";
            this.cmb_sy.Size = new System.Drawing.Size(166, 21);
            this.cmb_sy.TabIndex = 10;
            this.cmb_sy.SelectedIndexChanged += new System.EventHandler(this.cmb_sy_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_STotal);
            this.panel2.Controls.Add(this.chart_studentFee);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_GTotal);
            this.panel2.Controls.Add(this.chart_guardianFee);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(15, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 224);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolFeeTrackingSystem.Properties.Resources.total_plan_cost_32;
            this.pictureBox2.Location = new System.Drawing.Point(642, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_STotal
            // 
            this.lbl_STotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_STotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_STotal.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_STotal.Location = new System.Drawing.Point(616, 80);
            this.lbl_STotal.Name = "lbl_STotal";
            this.lbl_STotal.Size = new System.Drawing.Size(87, 24);
            this.lbl_STotal.TabIndex = 11;
            this.lbl_STotal.Text = "00";
            this.lbl_STotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_studentFee
            // 
            this.chart_studentFee.BackColor = System.Drawing.Color.Transparent;
            this.chart_studentFee.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 35F;
            chartArea3.Position.X = 8F;
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            this.chart_studentFee.ChartAreas.Add(chartArea3);
            this.chart_studentFee.DataSource = this.studentFeeBindingSource;
            legend3.Alignment = System.Drawing.StringAlignment.Far;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.DimGray;
            legend3.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend3.IsDockedInsideChartArea = false;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSpacing = 0;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.MaximumAutoSize = 100F;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.Transparent;
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend3.TextWrapThreshold = 0;
            legend3.Title = "Student Fee";
            legend3.TitleForeColor = System.Drawing.Color.DimGray;
            this.chart_studentFee.Legends.Add(legend3);
            this.chart_studentFee.Location = new System.Drawing.Point(534, 16);
            this.chart_studentFee.Margin = new System.Windows.Forms.Padding(0);
            this.chart_studentFee.Name = "chart_studentFee";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.CustomProperties = "PieLineColor=White, CollectedSliceExploded=True, DoughnutRadius=25, PieLabelStyle" +
    "=Disabled";
            series3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.LegendText = "#VALX   #VAL (#PERCENT{P0})";
            series3.Name = "Series1";
            series3.XValueMember = "Fee_name";
            series3.YValueMembers = "amount_req";
            this.chart_studentFee.Series.Add(series3);
            this.chart_studentFee.Size = new System.Drawing.Size(486, 151);
            this.chart_studentFee.TabIndex = 13;
            this.chart_studentFee.Text = "chart1";
            // 
            // studentFeeBindingSource
            // 
            this.studentFeeBindingSource.DataMember = "Student_Fee";
            this.studentFeeBindingSource.DataSource = this.sFTS_DBDataSet;
            // 
            // sFTS_DBDataSet
            // 
            this.sFTS_DBDataSet.DataSetName = "SFTS_DBDataSet";
            this.sFTS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolFeeTrackingSystem.Properties.Resources.total_plan_cost_32;
            this.pictureBox1.Location = new System.Drawing.Point(110, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_GTotal
            // 
            this.lbl_GTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_GTotal.Location = new System.Drawing.Point(83, 80);
            this.lbl_GTotal.Name = "lbl_GTotal";
            this.lbl_GTotal.Size = new System.Drawing.Size(87, 24);
            this.lbl_GTotal.TabIndex = 10;
            this.lbl_GTotal.Text = "00";
            this.lbl_GTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_guardianFee
            // 
            this.chart_guardianFee.BackColor = System.Drawing.Color.Transparent;
            this.chart_guardianFee.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 35F;
            chartArea4.Position.X = 8F;
            chartArea4.ShadowColor = System.Drawing.Color.Transparent;
            this.chart_guardianFee.ChartAreas.Add(chartArea4);
            this.chart_guardianFee.DataSource = this.guardianFeeBindingSource;
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.Color.DimGray;
            legend4.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend4.IsDockedInsideChartArea = false;
            legend4.IsTextAutoFit = false;
            legend4.ItemColumnSpacing = 0;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend4.MaximumAutoSize = 100F;
            legend4.Name = "Legend1";
            legend4.ShadowColor = System.Drawing.Color.Transparent;
            legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend4.TextWrapThreshold = 0;
            legend4.Title = "Guardian Fee";
            legend4.TitleForeColor = System.Drawing.Color.DimGray;
            this.chart_guardianFee.Legends.Add(legend4);
            this.chart_guardianFee.Location = new System.Drawing.Point(2, 16);
            this.chart_guardianFee.Margin = new System.Windows.Forms.Padding(0);
            this.chart_guardianFee.Name = "chart_guardianFee";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.CustomProperties = "PieLineColor=White, CollectedSliceExploded=True, DoughnutRadius=25, PieLabelStyle" +
    "=Disabled";
            series4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.LegendText = "#VALX   #VAL (#PERCENT{P0})";
            series4.Name = "Series1";
            series4.XValueMember = "Fee_name";
            series4.YValueMembers = "amount_req";
            this.chart_guardianFee.Series.Add(series4);
            this.chart_guardianFee.Size = new System.Drawing.Size(486, 151);
            this.chart_guardianFee.TabIndex = 7;
            this.chart_guardianFee.Text = "chart2";
            // 
            // guardianFeeBindingSource
            // 
            this.guardianFeeBindingSource.DataMember = "Guardian_Fee";
            this.guardianFeeBindingSource.DataSource = this.sFTS_DBDataSet;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1023, 224);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 510;
            this.lineShape1.X2 = 510;
            this.lineShape1.Y1 = 10;
            this.lineShape1.Y2 = 178;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_G_ALLO);
            this.panel3.Controls.Add(this.lbl_GFeeCollection);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(15, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 310);
            this.panel3.TabIndex = 12;
            // 
            // dgv_G_ALLO
            // 
            this.dgv_G_ALLO.AllowUserToAddRows = false;
            this.dgv_G_ALLO.AllowUserToDeleteRows = false;
            this.dgv_G_ALLO.AllowUserToResizeColumns = false;
            this.dgv_G_ALLO.AllowUserToResizeRows = false;
            this.dgv_G_ALLO.BackgroundColor = System.Drawing.Color.White;
            this.dgv_G_ALLO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_G_ALLO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_G_ALLO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_G_ALLO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_G_ALLO.ColumnHeadersHeight = 20;
            this.dgv_G_ALLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_G_ALLO.ColumnHeadersVisible = false;
            this.dgv_G_ALLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fee_name,
            this.tpercent});
            this.dgv_G_ALLO.EnableHeadersVisualStyles = false;
            this.dgv_G_ALLO.Location = new System.Drawing.Point(25, 79);
            this.dgv_G_ALLO.Name = "dgv_G_ALLO";
            this.dgv_G_ALLO.ReadOnly = true;
            this.dgv_G_ALLO.RowHeadersVisible = false;
            this.dgv_G_ALLO.RowTemplate.Height = 23;
            this.dgv_G_ALLO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_G_ALLO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_G_ALLO.Size = new System.Drawing.Size(437, 139);
            this.dgv_G_ALLO.TabIndex = 3;
            this.dgv_G_ALLO.SelectionChanged += new System.EventHandler(this.dgv_G_ALLO_SelectionChanged);
            // 
            // Fee_name
            // 
            this.Fee_name.DataPropertyName = "Fee_name";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            this.Fee_name.DefaultCellStyle = dataGridViewCellStyle8;
            this.Fee_name.HeaderText = "Fee_name";
            this.Fee_name.Name = "Fee_name";
            this.Fee_name.ReadOnly = true;
            this.Fee_name.Width = 225;
            // 
            // tpercent
            // 
            this.tpercent.DataPropertyName = "tpercent";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.tpercent.DefaultCellStyle = dataGridViewCellStyle9;
            this.tpercent.HeaderText = "Amount";
            this.tpercent.Name = "tpercent";
            this.tpercent.ReadOnly = true;
            this.tpercent.Width = 200;
            // 
            // lbl_GFeeCollection
            // 
            this.lbl_GFeeCollection.AutoSize = true;
            this.lbl_GFeeCollection.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GFeeCollection.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_GFeeCollection.Location = new System.Drawing.Point(316, 237);
            this.lbl_GFeeCollection.Name = "lbl_GFeeCollection";
            this.lbl_GFeeCollection.Size = new System.Drawing.Size(35, 29);
            this.lbl_GFeeCollection.TabIndex = 1;
            this.lbl_GFeeCollection.Text = "00";
            this.lbl_GFeeCollection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Guardian Fee Current Collection";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.AutoScroll = true;
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(511, 310);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 15);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(470, 278);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_S_ALLO);
            this.panel4.Controls.Add(this.lbl_SFeeCollection);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.shapeContainer3);
            this.panel4.Location = new System.Drawing.Point(549, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 310);
            this.panel4.TabIndex = 13;
            // 
            // dgv_S_ALLO
            // 
            this.dgv_S_ALLO.AllowUserToAddRows = false;
            this.dgv_S_ALLO.AllowUserToDeleteRows = false;
            this.dgv_S_ALLO.AllowUserToResizeColumns = false;
            this.dgv_S_ALLO.AllowUserToResizeRows = false;
            this.dgv_S_ALLO.BackgroundColor = System.Drawing.Color.White;
            this.dgv_S_ALLO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_S_ALLO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_S_ALLO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_S_ALLO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_S_ALLO.ColumnHeadersHeight = 20;
            this.dgv_S_ALLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_S_ALLO.ColumnHeadersVisible = false;
            this.dgv_S_ALLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_S_ALLO.EnableHeadersVisualStyles = false;
            this.dgv_S_ALLO.Location = new System.Drawing.Point(30, 79);
            this.dgv_S_ALLO.Name = "dgv_S_ALLO";
            this.dgv_S_ALLO.ReadOnly = true;
            this.dgv_S_ALLO.RowHeadersVisible = false;
            this.dgv_S_ALLO.RowTemplate.Height = 23;
            this.dgv_S_ALLO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_S_ALLO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_S_ALLO.Size = new System.Drawing.Size(437, 139);
            this.dgv_S_ALLO.TabIndex = 4;
            this.dgv_S_ALLO.SelectionChanged += new System.EventHandler(this.dgv_S_ALLO_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fee_name";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fee_name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tpercent";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // lbl_SFeeCollection
            // 
            this.lbl_SFeeCollection.AutoSize = true;
            this.lbl_SFeeCollection.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFeeCollection.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_SFeeCollection.Location = new System.Drawing.Point(337, 237);
            this.lbl_SFeeCollection.Name = "lbl_SFeeCollection";
            this.lbl_SFeeCollection.Size = new System.Drawing.Size(35, 29);
            this.lbl_SFeeCollection.TabIndex = 1;
            this.lbl_SFeeCollection.Text = "00";
            this.lbl_SFeeCollection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Fee Current Collection";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(486, 310);
            this.shapeContainer3.TabIndex = 2;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.CornerRadius = 5;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 15);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(470, 278);
            // 
            // guardian_FeeTableAdapter
            // 
            this.guardian_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // student_FeeTableAdapter
            // 
            this.student_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // school_YearTableAdapter
            // 
            this.school_YearTableAdapter.ClearBeforeFill = true;
            // 
            // g_Trans_LOGTableAdapter
            // 
            this.g_Trans_LOGTableAdapter.ClearBeforeFill = true;
            // 
            // s_Trans_LogTableAdapter
            // 
            this.s_Trans_LogTableAdapter.ClearBeforeFill = true;
            // 
            // cTE_GuardianFeeALLOTableAdapter
            // 
            this.cTE_GuardianFeeALLOTableAdapter.ClearBeforeFill = true;
            // 
            // ctE_StudentFeeALLOTableAdapter
            // 
            this.ctE_StudentFeeALLOTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(29, 14);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(89, 16);
            this.lbl_date.TabIndex = 20;
            this.lbl_date.Text = "January 1, 2016";
            // 
            // lbl_time
            // 
            this.lbl_time.BackColor = System.Drawing.Color.DimGray;
            this.lbl_time.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(200, 12);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(87, 21);
            this.lbl_time.TabIndex = 21;
            this.lbl_time.Text = "10:33 AM";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer5
            // 
            this.shapeContainer5.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer5.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer5.Name = "shapeContainer5";
            this.shapeContainer5.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6,
            this.rectangleShape5});
            this.shapeContainer5.Size = new System.Drawing.Size(1048, 640);
            this.shapeContainer5.TabIndex = 22;
            this.shapeContainer5.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.Color.DimGray;
            this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape5.CornerRadius = 3;
            this.rectangleShape5.Location = new System.Drawing.Point(173, 10);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(119, 23);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape6.CornerRadius = 3;
            this.rectangleShape6.Location = new System.Drawing.Point(23, 10);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(172, 23);
            // 
            // frm_funds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 666);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_funds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Funds Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_funds_FormClosing);
            this.Load += new System.EventHandler(this.frm_funds_Load);
            this.SizeChanged += new System.EventHandler(this.frm_funds_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_studentFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFTS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_guardianFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianFeeBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_G_ALLO)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_S_ALLO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DB.SFTS_DBDataSet sFTS_DBDataSet;
        private System.Windows.Forms.BindingSource guardianFeeBindingSource;
        private DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter guardian_FeeTableAdapter;
        private System.Windows.Forms.BindingSource studentFeeBindingSource;
        private DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter student_FeeTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_guardianFee;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox cmb_sy;
        private System.Windows.Forms.Label label1;
        private DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter school_YearTableAdapter;
        private System.Windows.Forms.Label lbl_GTotal;
        private System.Windows.Forms.Label lbl_STotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_studentFee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_GFeeCollection;
        private DB.SFTS_DBDataSetTableAdapters.G_Trans_LOGTableAdapter g_Trans_LOGTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_SFeeCollection;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private DB.SFTS_DBDataSetTableAdapters.S_Trans_LogTableAdapter s_Trans_LogTableAdapter;
        private DB.SFTS_DBDataSetTableAdapters.CTE_GuardianFeeALLOTableAdapter cTE_GuardianFeeALLOTableAdapter;
        private System.Windows.Forms.DataGridView dgv_G_ALLO;
        private System.Windows.Forms.DataGridView dgv_S_ALLO;
        private DB.SFTS_DBDataSetTableAdapters.CTE_StudentFeeALLOTableAdapter ctE_StudentFeeALLOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbl_SY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
    }
}