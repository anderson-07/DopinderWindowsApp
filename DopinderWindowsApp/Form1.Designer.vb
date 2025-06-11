<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentDate = New System.Windows.Forms.Label()
        Me.currentTime = New System.Windows.Forms.Label()
        Me.panel_background = New System.Windows.Forms.Panel()
        Me.panel_navbar = New System.Windows.Forms.Panel()
        Me.btn_permits = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_baranggay_clearance = New System.Windows.Forms.Button()
        Me.btn_blotter_reports = New System.Windows.Forms.Button()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.btn_sms = New System.Windows.Forms.Button()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_resident_info = New System.Windows.Forms.Button()
        Me.panel_resident_info = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.resident_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resident_purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resident_population = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.panel_home = New System.Windows.Forms.Panel()
        Me.panel_blotter_reports = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.blotter_sent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blotter_today = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blotter_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panel_permits = New System.Windows.Forms.Panel()
        Me.lbl_permits = New System.Windows.Forms.Label()
        Me.panel_reports = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_settings = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panel_sms = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_baranggay_clearance = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.resident_information_display = New System.Windows.Forms.Button()
        Me.blotter_reports_display = New System.Windows.Forms.Button()
        Me.permits_display = New System.Windows.Forms.Button()
        Me.baranggay_clearance_display = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panel_background.SuspendLayout()
        Me.panel_navbar.SuspendLayout()
        Me.panel_resident_info.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_home.SuspendLayout()
        Me.panel_blotter_reports.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_permits.SuspendLayout()
        Me.panel_reports.SuspendLayout()
        Me.panel_settings.SuspendLayout()
        Me.panel_sms.SuspendLayout()
        Me.panel_baranggay_clearance.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(349, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 39)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BARANGAY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(351, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "DIGITAL ASSISTANCE SYSTEM"
        '
        'currentDate
        '
        Me.currentDate.AutoSize = True
        Me.currentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.currentDate.Location = New System.Drawing.Point(1076, 58)
        Me.currentDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentDate.Name = "currentDate"
        Me.currentDate.Size = New System.Drawing.Size(89, 17)
        Me.currentDate.TabIndex = 14
        Me.currentDate.Text = "Current Date"
        '
        'currentTime
        '
        Me.currentTime.AutoSize = True
        Me.currentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.currentTime.Location = New System.Drawing.Point(1076, 79)
        Me.currentTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentTime.Name = "currentTime"
        Me.currentTime.Size = New System.Drawing.Size(0, 17)
        Me.currentTime.TabIndex = 15
        '
        'panel_background
        '
        Me.panel_background.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panel_background.Controls.Add(Me.panel_navbar)
        Me.panel_background.Location = New System.Drawing.Point(-4, -2)
        Me.panel_background.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel_background.Name = "panel_background"
        Me.panel_background.Size = New System.Drawing.Size(234, 665)
        Me.panel_background.TabIndex = 16
        '
        'panel_navbar
        '
        Me.panel_navbar.Controls.Add(Me.btn_permits)
        Me.panel_navbar.Controls.Add(Me.btn_home)
        Me.panel_navbar.Controls.Add(Me.btn_baranggay_clearance)
        Me.panel_navbar.Controls.Add(Me.btn_blotter_reports)
        Me.panel_navbar.Controls.Add(Me.btn_settings)
        Me.panel_navbar.Controls.Add(Me.btn_sms)
        Me.panel_navbar.Controls.Add(Me.btn_reports)
        Me.panel_navbar.Controls.Add(Me.btn_resident_info)
        Me.panel_navbar.Location = New System.Drawing.Point(12, 115)
        Me.panel_navbar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel_navbar.Name = "panel_navbar"
        Me.panel_navbar.Size = New System.Drawing.Size(213, 390)
        Me.panel_navbar.TabIndex = 18
        '
        'btn_permits
        '
        Me.btn_permits.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_permits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_permits.FlatAppearance.BorderSize = 0
        Me.btn_permits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_permits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_permits.ForeColor = System.Drawing.Color.White
        Me.btn_permits.Image = CType(resources.GetObject("btn_permits.Image"), System.Drawing.Image)
        Me.btn_permits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_permits.Location = New System.Drawing.Point(13, 200)
        Me.btn_permits.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_permits.Name = "btn_permits"
        Me.btn_permits.Size = New System.Drawing.Size(199, 46)
        Me.btn_permits.TabIndex = 4
        Me.btn_permits.Text = "   Permits and Certifications"
        Me.btn_permits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_permits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_permits.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.White
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(13, 3)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_home.Size = New System.Drawing.Size(199, 47)
        Me.btn_home.TabIndex = 0
        Me.btn_home.Text = "   Home"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_baranggay_clearance
        '
        Me.btn_baranggay_clearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_baranggay_clearance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_baranggay_clearance.FlatAppearance.BorderSize = 0
        Me.btn_baranggay_clearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baranggay_clearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_baranggay_clearance.ForeColor = System.Drawing.Color.White
        Me.btn_baranggay_clearance.Image = CType(resources.GetObject("btn_baranggay_clearance.Image"), System.Drawing.Image)
        Me.btn_baranggay_clearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_baranggay_clearance.Location = New System.Drawing.Point(13, 150)
        Me.btn_baranggay_clearance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_baranggay_clearance.Name = "btn_baranggay_clearance"
        Me.btn_baranggay_clearance.Size = New System.Drawing.Size(199, 50)
        Me.btn_baranggay_clearance.TabIndex = 3
        Me.btn_baranggay_clearance.Text = "   Baranggay Clearance"
        Me.btn_baranggay_clearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_baranggay_clearance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_baranggay_clearance.UseVisualStyleBackColor = False
        '
        'btn_blotter_reports
        '
        Me.btn_blotter_reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_blotter_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_blotter_reports.FlatAppearance.BorderSize = 0
        Me.btn_blotter_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_blotter_reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_blotter_reports.ForeColor = System.Drawing.Color.White
        Me.btn_blotter_reports.Image = CType(resources.GetObject("btn_blotter_reports.Image"), System.Drawing.Image)
        Me.btn_blotter_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_blotter_reports.Location = New System.Drawing.Point(13, 100)
        Me.btn_blotter_reports.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_blotter_reports.Name = "btn_blotter_reports"
        Me.btn_blotter_reports.Size = New System.Drawing.Size(199, 50)
        Me.btn_blotter_reports.TabIndex = 2
        Me.btn_blotter_reports.Text = "   Blotter Reports"
        Me.btn_blotter_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_blotter_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_blotter_reports.UseVisualStyleBackColor = False
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_settings.FlatAppearance.BorderSize = 0
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.ForeColor = System.Drawing.Color.White
        Me.btn_settings.Image = CType(resources.GetObject("btn_settings.Image"), System.Drawing.Image)
        Me.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_settings.Location = New System.Drawing.Point(13, 338)
        Me.btn_settings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(199, 46)
        Me.btn_settings.TabIndex = 7
        Me.btn_settings.Text = "   Settings"
        Me.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'btn_sms
        '
        Me.btn_sms.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_sms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sms.FlatAppearance.BorderSize = 0
        Me.btn_sms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sms.ForeColor = System.Drawing.Color.White
        Me.btn_sms.Image = CType(resources.GetObject("btn_sms.Image"), System.Drawing.Image)
        Me.btn_sms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sms.Location = New System.Drawing.Point(13, 246)
        Me.btn_sms.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_sms.Name = "btn_sms"
        Me.btn_sms.Size = New System.Drawing.Size(199, 46)
        Me.btn_sms.TabIndex = 5
        Me.btn_sms.Text = "   SMS Notification"
        Me.btn_sms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sms.UseVisualStyleBackColor = False
        '
        'btn_reports
        '
        Me.btn_reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reports.FlatAppearance.BorderSize = 0
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.White
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.Location = New System.Drawing.Point(13, 292)
        Me.btn_reports.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(199, 46)
        Me.btn_reports.TabIndex = 6
        Me.btn_reports.Text = "   Reports"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_reports.UseVisualStyleBackColor = False
        '
        'btn_resident_info
        '
        Me.btn_resident_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn_resident_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_resident_info.FlatAppearance.BorderSize = 0
        Me.btn_resident_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resident_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resident_info.ForeColor = System.Drawing.Color.White
        Me.btn_resident_info.Image = CType(resources.GetObject("btn_resident_info.Image"), System.Drawing.Image)
        Me.btn_resident_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resident_info.Location = New System.Drawing.Point(13, 50)
        Me.btn_resident_info.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_resident_info.Name = "btn_resident_info"
        Me.btn_resident_info.Size = New System.Drawing.Size(199, 50)
        Me.btn_resident_info.TabIndex = 1
        Me.btn_resident_info.Text = "   Resident Info"
        Me.btn_resident_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resident_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_resident_info.UseVisualStyleBackColor = False
        '
        'panel_resident_info
        '
        Me.panel_resident_info.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_resident_info.Controls.Add(Me.DataGridView1)
        Me.panel_resident_info.Location = New System.Drawing.Point(236, 201)
        Me.panel_resident_info.Name = "panel_resident_info"
        Me.panel_resident_info.Size = New System.Drawing.Size(940, 453)
        Me.panel_resident_info.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.resident_name, Me.resident_purok, Me.resident_population})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(934, 447)
        Me.DataGridView1.TabIndex = 1
        '
        'resident_name
        '
        Me.resident_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.resident_name.HeaderText = "Name"
        Me.resident_name.Name = "resident_name"
        Me.resident_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'resident_purok
        '
        Me.resident_purok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.resident_purok.HeaderText = "Purok"
        Me.resident_purok.Name = "resident_purok"
        '
        'resident_population
        '
        Me.resident_population.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.resident_population.HeaderText = "Population"
        Me.resident_population.Name = "resident_population"
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_location.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lbl_location.Location = New System.Drawing.Point(250, 144)
        Me.lbl_location.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(112, 39)
        Me.lbl_location.TabIndex = 17
        Me.lbl_location.Text = "Home"
        '
        'panel_home
        '
        Me.panel_home.BackColor = System.Drawing.Color.LightGray
        Me.panel_home.Controls.Add(Me.Label11)
        Me.panel_home.Controls.Add(Me.Label10)
        Me.panel_home.Controls.Add(Me.Label9)
        Me.panel_home.Controls.Add(Me.Label3)
        Me.panel_home.Controls.Add(Me.permits_display)
        Me.panel_home.Controls.Add(Me.baranggay_clearance_display)
        Me.panel_home.Controls.Add(Me.blotter_reports_display)
        Me.panel_home.Controls.Add(Me.resident_information_display)
        Me.panel_home.Location = New System.Drawing.Point(236, 201)
        Me.panel_home.Name = "panel_home"
        Me.panel_home.Size = New System.Drawing.Size(940, 460)
        Me.panel_home.TabIndex = 18
        '
        'panel_blotter_reports
        '
        Me.panel_blotter_reports.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_blotter_reports.Controls.Add(Me.DataGridView2)
        Me.panel_blotter_reports.Location = New System.Drawing.Point(236, 201)
        Me.panel_blotter_reports.Name = "panel_blotter_reports"
        Me.panel_blotter_reports.Size = New System.Drawing.Size(940, 453)
        Me.panel_blotter_reports.TabIndex = 20
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.blotter_sent, Me.blotter_today, Me.blotter_total})
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(932, 445)
        Me.DataGridView2.TabIndex = 1
        '
        'blotter_sent
        '
        Me.blotter_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.blotter_sent.HeaderText = "Blotter Report (Past)"
        Me.blotter_sent.Name = "blotter_sent"
        Me.blotter_sent.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'blotter_today
        '
        Me.blotter_today.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.blotter_today.HeaderText = "Blotter Report (Today)"
        Me.blotter_today.Name = "blotter_today"
        Me.blotter_today.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'blotter_total
        '
        Me.blotter_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.blotter_total.HeaderText = "Blotter Report (Sum)"
        Me.blotter_total.Name = "blotter_total"
        Me.blotter_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'panel_permits
        '
        Me.panel_permits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_permits.Controls.Add(Me.lbl_permits)
        Me.panel_permits.Location = New System.Drawing.Point(236, 201)
        Me.panel_permits.Name = "panel_permits"
        Me.panel_permits.Size = New System.Drawing.Size(940, 453)
        Me.panel_permits.TabIndex = 22
        '
        'lbl_permits
        '
        Me.lbl_permits.AutoSize = True
        Me.lbl_permits.Location = New System.Drawing.Point(22, 27)
        Me.lbl_permits.Name = "lbl_permits"
        Me.lbl_permits.Size = New System.Drawing.Size(158, 13)
        Me.lbl_permits.TabIndex = 0
        Me.lbl_permits.Text = "This is Permits and Certifications"
        '
        'panel_reports
        '
        Me.panel_reports.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_reports.Controls.Add(Me.Label6)
        Me.panel_reports.Location = New System.Drawing.Point(236, 201)
        Me.panel_reports.Name = "panel_reports"
        Me.panel_reports.Size = New System.Drawing.Size(940, 453)
        Me.panel_reports.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "This is Reports"
        '
        'panel_settings
        '
        Me.panel_settings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_settings.Controls.Add(Me.Label7)
        Me.panel_settings.Location = New System.Drawing.Point(236, 201)
        Me.panel_settings.Name = "panel_settings"
        Me.panel_settings.Size = New System.Drawing.Size(940, 453)
        Me.panel_settings.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "This is Settings"
        '
        'panel_sms
        '
        Me.panel_sms.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_sms.Controls.Add(Me.Label4)
        Me.panel_sms.Location = New System.Drawing.Point(236, 201)
        Me.panel_sms.Name = "panel_sms"
        Me.panel_sms.Size = New System.Drawing.Size(940, 453)
        Me.panel_sms.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "This is SMS"
        '
        'panel_baranggay_clearance
        '
        Me.panel_baranggay_clearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_baranggay_clearance.Controls.Add(Me.Label8)
        Me.panel_baranggay_clearance.Location = New System.Drawing.Point(236, 201)
        Me.panel_baranggay_clearance.Name = "panel_baranggay_clearance"
        Me.panel_baranggay_clearance.Size = New System.Drawing.Size(940, 453)
        Me.panel_baranggay_clearance.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "This is Baranggay Clearance"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_close
        '
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Location = New System.Drawing.Point(1117, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(56, 26)
        Me.btn_close.TabIndex = 26
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1059, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 26)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Minimize"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(257, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'resident_information_display
        '
        Me.resident_information_display.BackColor = System.Drawing.Color.White
        Me.resident_information_display.FlatAppearance.BorderSize = 0
        Me.resident_information_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resident_information_display.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resident_information_display.Image = CType(resources.GetObject("resident_information_display.Image"), System.Drawing.Image)
        Me.resident_information_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.resident_information_display.Location = New System.Drawing.Point(24, 79)
        Me.resident_information_display.Name = "resident_information_display"
        Me.resident_information_display.Size = New System.Drawing.Size(445, 97)
        Me.resident_information_display.TabIndex = 1
        Me.resident_information_display.Text = "Resident Information"
        Me.resident_information_display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.resident_information_display.UseVisualStyleBackColor = False
        '
        'blotter_reports_display
        '
        Me.blotter_reports_display.BackColor = System.Drawing.Color.White
        Me.blotter_reports_display.FlatAppearance.BorderSize = 0
        Me.blotter_reports_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blotter_reports_display.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blotter_reports_display.Image = CType(resources.GetObject("blotter_reports_display.Image"), System.Drawing.Image)
        Me.blotter_reports_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.blotter_reports_display.Location = New System.Drawing.Point(475, 79)
        Me.blotter_reports_display.Name = "blotter_reports_display"
        Me.blotter_reports_display.Size = New System.Drawing.Size(445, 97)
        Me.blotter_reports_display.TabIndex = 2
        Me.blotter_reports_display.Text = "Blotter Reports"
        Me.blotter_reports_display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.blotter_reports_display.UseVisualStyleBackColor = False
        '
        'permits_display
        '
        Me.permits_display.BackColor = System.Drawing.Color.White
        Me.permits_display.FlatAppearance.BorderSize = 0
        Me.permits_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.permits_display.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permits_display.Image = CType(resources.GetObject("permits_display.Image"), System.Drawing.Image)
        Me.permits_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.permits_display.Location = New System.Drawing.Point(475, 192)
        Me.permits_display.Name = "permits_display"
        Me.permits_display.Size = New System.Drawing.Size(445, 97)
        Me.permits_display.TabIndex = 4
        Me.permits_display.Text = "Permits && Certifications"
        Me.permits_display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.permits_display.UseVisualStyleBackColor = False
        '
        'baranggay_clearance_display
        '
        Me.baranggay_clearance_display.BackColor = System.Drawing.Color.White
        Me.baranggay_clearance_display.FlatAppearance.BorderSize = 0
        Me.baranggay_clearance_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.baranggay_clearance_display.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baranggay_clearance_display.Image = CType(resources.GetObject("baranggay_clearance_display.Image"), System.Drawing.Image)
        Me.baranggay_clearance_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.baranggay_clearance_display.Location = New System.Drawing.Point(24, 192)
        Me.baranggay_clearance_display.Name = "baranggay_clearance_display"
        Me.baranggay_clearance_display.Size = New System.Drawing.Size(445, 97)
        Me.baranggay_clearance_display.TabIndex = 3
        Me.baranggay_clearance_display.Text = "Baranggay Clearance"
        Me.baranggay_clearance_display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.baranggay_clearance_display.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "158"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 29)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "97"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(851, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 29)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "50"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(851, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 29)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "67"
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panel_home)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.panel_blotter_reports)
        Me.Controls.Add(Me.panel_resident_info)
        Me.Controls.Add(Me.panel_baranggay_clearance)
        Me.Controls.Add(Me.panel_sms)
        Me.Controls.Add(Me.panel_permits)
        Me.Controls.Add(Me.panel_settings)
        Me.Controls.Add(Me.panel_reports)
        Me.Controls.Add(Me.lbl_location)
        Me.Controls.Add(Me.currentTime)
        Me.Controls.Add(Me.currentDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_background)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.panel_background.ResumeLayout(False)
        Me.panel_navbar.ResumeLayout(False)
        Me.panel_resident_info.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_home.ResumeLayout(False)
        Me.panel_home.PerformLayout()
        Me.panel_blotter_reports.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_permits.ResumeLayout(False)
        Me.panel_permits.PerformLayout()
        Me.panel_reports.ResumeLayout(False)
        Me.panel_reports.PerformLayout()
        Me.panel_settings.ResumeLayout(False)
        Me.panel_settings.PerformLayout()
        Me.panel_sms.ResumeLayout(False)
        Me.panel_sms.PerformLayout()
        Me.panel_baranggay_clearance.ResumeLayout(False)
        Me.panel_baranggay_clearance.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentDate As Label
    Friend WithEvents currentTime As Label
    Friend WithEvents panel_background As Panel
    Friend WithEvents lbl_location As Label
    Friend WithEvents panel_home As Panel
    Friend WithEvents panel_navbar As Panel
    Friend WithEvents btn_permits As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_baranggay_clearance As Button
    Friend WithEvents btn_blotter_reports As Button
    Friend WithEvents btn_settings As Button
    Friend WithEvents btn_sms As Button
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_resident_info As Button
    Friend WithEvents panel_resident_info As Panel
    Friend WithEvents panel_blotter_reports As Panel
    Friend WithEvents panel_permits As Panel
    Friend WithEvents lbl_permits As Label
    Friend WithEvents panel_reports As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents panel_settings As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents panel_sms As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents panel_baranggay_clearance As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents resident_name As DataGridViewTextBoxColumn
    Friend WithEvents resident_purok As DataGridViewTextBoxColumn
    Friend WithEvents resident_population As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents blotter_sent As DataGridViewTextBoxColumn
    Friend WithEvents blotter_today As DataGridViewTextBoxColumn
    Friend WithEvents blotter_total As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_close As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents resident_information_display As Button
    Friend WithEvents permits_display As Button
    Friend WithEvents baranggay_clearance_display As Button
    Friend WithEvents blotter_reports_display As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
