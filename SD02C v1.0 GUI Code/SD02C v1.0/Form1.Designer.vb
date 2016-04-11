<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblInitial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudInitialS = New System.Windows.Forms.NumericUpDown()
        Me.nudAccRate = New System.Windows.Forms.NumericUpDown()
        Me.nudFinalS = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrake = New System.Windows.Forms.Button()
        Me.gbCtrlPanel = New System.Windows.Forms.GroupBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCCW = New System.Windows.Forms.Button()
        Me.btnCW = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.gbAccelerate = New System.Windows.Forms.GroupBox()
        Me.btnAccelerate = New System.Windows.Forms.Button()
        Me.gbTrack = New System.Windows.Forms.GroupBox()
        Me.nudTrack = New System.Windows.Forms.NumericUpDown()
        Me.btnTrack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbEncoder = New System.Windows.Forms.GroupBox()
        Me.txtEncoder = New System.Windows.Forms.TextBox()
        Me.btnAcquire = New System.Windows.Forms.Button()
        Me.gbSpeed = New System.Windows.Forms.GroupBox()
        Me.hsbSpeed = New System.Windows.Forms.HScrollBar()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.plCOMPORT = New System.Windows.Forms.Panel()
        Me.btnSendBaud = New System.Windows.Forms.Button()
        Me.cbbBaud = New System.Windows.Forms.ComboBox()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.lblCONNECT = New System.Windows.Forms.Label()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cbbComPort = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        CType(Me.nudInitialS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAccRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFinalS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCtrlPanel.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        Me.gbAccelerate.SuspendLayout()
        Me.gbTrack.SuspendLayout()
        CType(Me.nudTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEncoder.SuspendLayout()
        Me.gbSpeed.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plCOMPORT.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInitial
        '
        Me.lblInitial.AutoSize = True
        Me.lblInitial.Location = New System.Drawing.Point(12, 27)
        Me.lblInitial.Name = "lblInitial"
        Me.lblInitial.Size = New System.Drawing.Size(65, 13)
        Me.lblInitial.TabIndex = 371
        Me.lblInitial.Text = "Initial Speed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Final Speed"
        '
        'nudInitialS
        '
        Me.nudInitialS.Location = New System.Drawing.Point(80, 24)
        Me.nudInitialS.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudInitialS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInitialS.Name = "nudInitialS"
        Me.nudInitialS.Size = New System.Drawing.Size(56, 20)
        Me.nudInitialS.TabIndex = 368
        Me.nudInitialS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudInitialS.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'nudAccRate
        '
        Me.nudAccRate.Location = New System.Drawing.Point(80, 76)
        Me.nudAccRate.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudAccRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccRate.Name = "nudAccRate"
        Me.nudAccRate.Size = New System.Drawing.Size(56, 20)
        Me.nudAccRate.TabIndex = 369
        Me.nudAccRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAccRate.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudFinalS
        '
        Me.nudFinalS.Location = New System.Drawing.Point(80, 50)
        Me.nudFinalS.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudFinalS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFinalS.Name = "nudFinalS"
        Me.nudFinalS.Size = New System.Drawing.Size(56, 20)
        Me.nudFinalS.TabIndex = 370
        Me.nudFinalS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFinalS.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "Accel. Rate"
        '
        'btnBrake
        '
        Me.btnBrake.Location = New System.Drawing.Point(79, 69)
        Me.btnBrake.Name = "btnBrake"
        Me.btnBrake.Size = New System.Drawing.Size(56, 30)
        Me.btnBrake.TabIndex = 352
        Me.btnBrake.Text = "BRAKE"
        Me.btnBrake.UseVisualStyleBackColor = True
        '
        'gbCtrlPanel
        '
        Me.gbCtrlPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.gbCtrlPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbCtrlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbCtrlPanel.Controls.Add(Me.btnBrake)
        Me.gbCtrlPanel.Controls.Add(Me.btnGo)
        Me.gbCtrlPanel.Controls.Add(Me.btnCCW)
        Me.gbCtrlPanel.Controls.Add(Me.btnCW)
        Me.gbCtrlPanel.Controls.Add(Me.btnOff)
        Me.gbCtrlPanel.Controls.Add(Me.btnOn)
        Me.gbCtrlPanel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbCtrlPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCtrlPanel.Location = New System.Drawing.Point(168, 12)
        Me.gbCtrlPanel.Name = "gbCtrlPanel"
        Me.gbCtrlPanel.Size = New System.Drawing.Size(150, 170)
        Me.gbCtrlPanel.TabIndex = 376
        Me.gbCtrlPanel.TabStop = False
        Me.gbCtrlPanel.Text = "Control Panel"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(14, 69)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(56, 30)
        Me.btnGo.TabIndex = 352
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCCW
        '
        Me.btnCCW.Location = New System.Drawing.Point(79, 110)
        Me.btnCCW.Name = "btnCCW"
        Me.btnCCW.Size = New System.Drawing.Size(56, 30)
        Me.btnCCW.TabIndex = 351
        Me.btnCCW.Text = "CCW"
        Me.btnCCW.UseVisualStyleBackColor = True
        '
        'btnCW
        '
        Me.btnCW.Location = New System.Drawing.Point(14, 110)
        Me.btnCW.Name = "btnCW"
        Me.btnCW.Size = New System.Drawing.Size(56, 30)
        Me.btnCW.TabIndex = 351
        Me.btnCW.Text = "CW"
        Me.btnCW.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(79, 28)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(56, 30)
        Me.btnOff.TabIndex = 350
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(14, 28)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(56, 30)
        Me.btnOn.TabIndex = 350
        Me.btnOn.Text = "ON"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'gbStatus
        '
        Me.gbStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbStatus.Controls.Add(Me.TextBox8)
        Me.gbStatus.Controls.Add(Me.btnStatus)
        Me.gbStatus.Controls.Add(Me.TextBox4)
        Me.gbStatus.Controls.Add(Me.txtStatus)
        Me.gbStatus.Controls.Add(Me.TextBox3)
        Me.gbStatus.Controls.Add(Me.TextBox1)
        Me.gbStatus.Controls.Add(Me.TextBox2)
        Me.gbStatus.Location = New System.Drawing.Point(480, 10)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(161, 209)
        Me.gbStatus.TabIndex = 381
        Me.gbStatus.TabStop = False
        Me.gbStatus.Text = "Status"
        '
        'btnStatus
        '
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.Location = New System.Drawing.Point(9, 167)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(146, 25)
        Me.btnStatus.TabIndex = 364
        Me.btnStatus.Text = "STATUS"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Black
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(9, 119)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(146, 20)
        Me.txtStatus.TabIndex = 354
        Me.txtStatus.Text = "DECIMAL"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbAccelerate
        '
        Me.gbAccelerate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbAccelerate.Controls.Add(Me.Label2)
        Me.gbAccelerate.Controls.Add(Me.lblInitial)
        Me.gbAccelerate.Controls.Add(Me.Label1)
        Me.gbAccelerate.Controls.Add(Me.nudInitialS)
        Me.gbAccelerate.Controls.Add(Me.btnAccelerate)
        Me.gbAccelerate.Controls.Add(Me.nudAccRate)
        Me.gbAccelerate.Controls.Add(Me.nudFinalS)
        Me.gbAccelerate.Location = New System.Drawing.Point(324, 12)
        Me.gbAccelerate.Name = "gbAccelerate"
        Me.gbAccelerate.Size = New System.Drawing.Size(150, 170)
        Me.gbAccelerate.TabIndex = 380
        Me.gbAccelerate.TabStop = False
        Me.gbAccelerate.Text = "Set Acceleration"
        '
        'btnAccelerate
        '
        Me.btnAccelerate.Location = New System.Drawing.Point(13, 105)
        Me.btnAccelerate.Name = "btnAccelerate"
        Me.btnAccelerate.Size = New System.Drawing.Size(124, 25)
        Me.btnAccelerate.TabIndex = 0
        Me.btnAccelerate.Text = "Accelerate"
        Me.btnAccelerate.UseVisualStyleBackColor = True
        '
        'gbTrack
        '
        Me.gbTrack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbTrack.Controls.Add(Me.nudTrack)
        Me.gbTrack.Controls.Add(Me.btnTrack)
        Me.gbTrack.Controls.Add(Me.btnReset)
        Me.gbTrack.Location = New System.Drawing.Point(12, 188)
        Me.gbTrack.Name = "gbTrack"
        Me.gbTrack.Size = New System.Drawing.Size(150, 88)
        Me.gbTrack.TabIndex = 378
        Me.gbTrack.TabStop = False
        Me.gbTrack.Text = "Track Encoder"
        '
        'nudTrack
        '
        Me.nudTrack.Location = New System.Drawing.Point(13, 24)
        Me.nudTrack.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nudTrack.Name = "nudTrack"
        Me.nudTrack.Size = New System.Drawing.Size(124, 20)
        Me.nudTrack.TabIndex = 357
        Me.nudTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudTrack.Value = New Decimal(New Integer() {1600, 0, 0, 0})
        '
        'btnTrack
        '
        Me.btnTrack.Location = New System.Drawing.Point(77, 50)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(60, 25)
        Me.btnTrack.TabIndex = 356
        Me.btnTrack.Text = "Track"
        Me.btnTrack.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 50)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(60, 25)
        Me.btnReset.TabIndex = 358
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'gbEncoder
        '
        Me.gbEncoder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbEncoder.Controls.Add(Me.txtEncoder)
        Me.gbEncoder.Controls.Add(Me.btnAcquire)
        Me.gbEncoder.Location = New System.Drawing.Point(168, 188)
        Me.gbEncoder.Name = "gbEncoder"
        Me.gbEncoder.Size = New System.Drawing.Size(150, 88)
        Me.gbEncoder.TabIndex = 379
        Me.gbEncoder.TabStop = False
        Me.gbEncoder.Text = "Request Encoder"
        '
        'txtEncoder
        '
        Me.txtEncoder.BackColor = System.Drawing.Color.Black
        Me.txtEncoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncoder.ForeColor = System.Drawing.Color.White
        Me.txtEncoder.Location = New System.Drawing.Point(13, 24)
        Me.txtEncoder.Name = "txtEncoder"
        Me.txtEncoder.Size = New System.Drawing.Size(124, 20)
        Me.txtEncoder.TabIndex = 354
        Me.txtEncoder.Text = "0"
        Me.txtEncoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAcquire
        '
        Me.btnAcquire.Location = New System.Drawing.Point(13, 50)
        Me.btnAcquire.Name = "btnAcquire"
        Me.btnAcquire.Size = New System.Drawing.Size(124, 25)
        Me.btnAcquire.TabIndex = 349
        Me.btnAcquire.Text = "Acquire Encoder"
        Me.btnAcquire.UseVisualStyleBackColor = True
        '
        'gbSpeed
        '
        Me.gbSpeed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbSpeed.Controls.Add(Me.hsbSpeed)
        Me.gbSpeed.Controls.Add(Me.txtSpeed)
        Me.gbSpeed.Location = New System.Drawing.Point(324, 189)
        Me.gbSpeed.Name = "gbSpeed"
        Me.gbSpeed.Size = New System.Drawing.Size(150, 87)
        Me.gbSpeed.TabIndex = 377
        Me.gbSpeed.TabStop = False
        Me.gbSpeed.Text = "Set Speed"
        '
        'hsbSpeed
        '
        Me.hsbSpeed.Location = New System.Drawing.Point(14, 50)
        Me.hsbSpeed.Maximum = 255
        Me.hsbSpeed.Minimum = 1
        Me.hsbSpeed.Name = "hsbSpeed"
        Me.hsbSpeed.Size = New System.Drawing.Size(121, 19)
        Me.hsbSpeed.TabIndex = 337
        Me.hsbSpeed.Value = 10
        '
        'txtSpeed
        '
        Me.txtSpeed.BackColor = System.Drawing.Color.Black
        Me.txtSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.Color.White
        Me.txtSpeed.Location = New System.Drawing.Point(14, 22)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(121, 20)
        Me.txtSpeed.TabIndex = 354
        Me.txtSpeed.Text = "0"
        Me.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(486, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 50)
        Me.PictureBox1.TabIndex = 383
        Me.PictureBox1.TabStop = False
        '
        'plCOMPORT
        '
        Me.plCOMPORT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.plCOMPORT.Controls.Add(Me.btnSendBaud)
        Me.plCOMPORT.Controls.Add(Me.cbbBaud)
        Me.plCOMPORT.Controls.Add(Me.lblProcess)
        Me.plCOMPORT.Controls.Add(Me.lblCONNECT)
        Me.plCOMPORT.Controls.Add(Me.lblComPort)
        Me.plCOMPORT.Controls.Add(Me.btnConnect)
        Me.plCOMPORT.Controls.Add(Me.cbbComPort)
        Me.plCOMPORT.Location = New System.Drawing.Point(12, 12)
        Me.plCOMPORT.Name = "plCOMPORT"
        Me.plCOMPORT.Size = New System.Drawing.Size(150, 170)
        Me.plCOMPORT.TabIndex = 375
        '
        'btnSendBaud
        '
        Me.btnSendBaud.Location = New System.Drawing.Point(12, 135)
        Me.btnSendBaud.Name = "btnSendBaud"
        Me.btnSendBaud.Size = New System.Drawing.Size(121, 22)
        Me.btnSendBaud.TabIndex = 98
        Me.btnSendBaud.Text = "Set New Baudrate"
        Me.btnSendBaud.UseVisualStyleBackColor = True
        '
        'cbbBaud
        '
        Me.cbbBaud.AccessibleName = ""
        Me.cbbBaud.FormattingEnabled = True
        Me.cbbBaud.Location = New System.Drawing.Point(12, 51)
        Me.cbbBaud.Name = "cbbBaud"
        Me.cbbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cbbBaud.TabIndex = 97
        Me.cbbBaud.Tag = ""
        Me.cbbBaud.Text = "9600"
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(17, 521)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(0, 13)
        Me.lblProcess.TabIndex = 96
        '
        'lblCONNECT
        '
        Me.lblCONNECT.AutoSize = True
        Me.lblCONNECT.ForeColor = System.Drawing.Color.Red
        Me.lblCONNECT.Location = New System.Drawing.Point(19, 103)
        Me.lblCONNECT.Name = "lblCONNECT"
        Me.lblCONNECT.Size = New System.Drawing.Size(105, 13)
        Me.lblCONNECT.TabIndex = 84
        Me.lblCONNECT.Text = "    Not connected!    "
        Me.lblCONNECT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(41, 7)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(58, 13)
        Me.lblComPort.TabIndex = 86
        Me.lblComPort.Text = "COM Ports"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 78)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(121, 22)
        Me.btnConnect.TabIndex = 82
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cbbComPort
        '
        Me.cbbComPort.AccessibleName = ""
        Me.cbbComPort.FormattingEnabled = True
        Me.cbbComPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbbComPort.Location = New System.Drawing.Point(12, 25)
        Me.cbbComPort.Name = "cbbComPort"
        Me.cbbComPort.Size = New System.Drawing.Size(121, 21)
        Me.cbbComPort.TabIndex = 81
        Me.cbbComPort.Tag = ""
        Me.cbbComPort.Text = "Port No."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(9, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 384
        Me.TextBox1.Text = "ON/OFF"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(9, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 385
        Me.TextBox2.Text = "GO/BRAKE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(9, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 386
        Me.TextBox3.Text = "CW/CCW"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(9, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(146, 20)
        Me.TextBox4.TabIndex = 387
        Me.TextBox4.Text = "STEPPING"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Black
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(9, 141)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(146, 20)
        Me.TextBox8.TabIndex = 391
        Me.TextBox8.Text = "BINARY"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 283)
        Me.Controls.Add(Me.gbCtrlPanel)
        Me.Controls.Add(Me.gbStatus)
        Me.Controls.Add(Me.gbAccelerate)
        Me.Controls.Add(Me.gbTrack)
        Me.Controls.Add(Me.gbEncoder)
        Me.Controls.Add(Me.gbSpeed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.plCOMPORT)
        Me.Name = "Form1"
        Me.Text = "SD02C V1.0"
        CType(Me.nudInitialS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAccRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFinalS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCtrlPanel.ResumeLayout(False)
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.gbAccelerate.ResumeLayout(False)
        Me.gbAccelerate.PerformLayout()
        Me.gbTrack.ResumeLayout(False)
        CType(Me.nudTrack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEncoder.ResumeLayout(False)
        Me.gbEncoder.PerformLayout()
        Me.gbSpeed.ResumeLayout(False)
        Me.gbSpeed.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plCOMPORT.ResumeLayout(False)
        Me.plCOMPORT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInitial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudInitialS As NumericUpDown
    Friend WithEvents nudAccRate As NumericUpDown
    Friend WithEvents nudFinalS As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrake As Button
    Friend WithEvents gbCtrlPanel As GroupBox
    Friend WithEvents btnGo As Button
    Friend WithEvents btnCCW As Button
    Friend WithEvents btnCW As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents btnStatus As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents gbAccelerate As GroupBox
    Friend WithEvents btnAccelerate As Button
    Friend WithEvents gbTrack As GroupBox
    Friend WithEvents nudTrack As NumericUpDown
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents gbEncoder As GroupBox
    Friend WithEvents txtEncoder As TextBox
    Friend WithEvents btnAcquire As Button
    Friend WithEvents gbSpeed As GroupBox
    Friend WithEvents hsbSpeed As HScrollBar
    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents plCOMPORT As Panel
    Friend WithEvents btnSendBaud As Button
    Friend WithEvents cbbBaud As ComboBox
    Friend WithEvents lblProcess As Label
    Friend WithEvents lblCONNECT As Label
    Friend WithEvents lblComPort As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents cbbComPort As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
