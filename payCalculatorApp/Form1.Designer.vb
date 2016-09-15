<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.homePage = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calulatorPage = New System.Windows.Forms.TabPage()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.minutesWorkedMini = New System.Windows.Forms.Label()
        Me.minutesWorkedEditbox = New System.Windows.Forms.TextBox()
        Me.hoursWorkedMini = New System.Windows.Forms.Label()
        Me.hoursWorkedEditbox = New System.Windows.Forms.TextBox()
        Me.hoursWorkedLabel = New System.Windows.Forms.Label()
        Me.nameEmployeeEditbox = New System.Windows.Forms.TextBox()
        Me.nameEmployeeLabel = New System.Windows.Forms.Label()
        Me.calculatorOutput = New System.Windows.Forms.Panel()
        Me.payRateDisplay = New System.Windows.Forms.Label()
        Me.payRateDisplayLabel = New System.Windows.Forms.Label()
        Me.maximumHoursDisplay = New System.Windows.Forms.Label()
        Me.maximumHoursDisplayLabel = New System.Windows.Forms.Label()
        Me.nameEmployeeDisplayLabel = New System.Windows.Forms.Label()
        Me.nameEmployeeDisplay = New System.Windows.Forms.Label()
        Me.netPayLabel = New System.Windows.Forms.Label()
        Me.netPayDisplay = New System.Windows.Forms.Label()
        Me.hoursWorkedDisplay = New System.Windows.Forms.Label()
        Me.grossPayDisplay = New System.Windows.Forms.Label()
        Me.hoursWorkedDisplayLabel = New System.Windows.Forms.Label()
        Me.grossPayLabel = New System.Windows.Forms.Label()
        Me.taxDisplay = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.editValuesPage = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maximumHoursEditbox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.payRateEditbox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.savedLabel = New System.Windows.Forms.Label()
        Me.defaultReset = New System.Windows.Forms.Button()
        Me.saveChanges = New System.Windows.Forms.Button()
        Me.taxEnabler = New System.Windows.Forms.CheckBox()
        Me.maximumHoursLabel = New System.Windows.Forms.Label()
        Me.maximumHoursEditbox = New System.Windows.Forms.TextBox()
        Me.payRateLabel = New System.Windows.Forms.Label()
        Me.payRateEditbox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1.SuspendLayout()
        Me.homePage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.calulatorPage.SuspendLayout()
        Me.calculatorOutput.SuspendLayout()
        Me.editValuesPage.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.homePage)
        Me.TabControl1.Controls.Add(Me.calulatorPage)
        Me.TabControl1.Controls.Add(Me.editValuesPage)
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(488, 232)
        Me.TabControl1.TabIndex = 0
        '
        'homePage
        '
        Me.homePage.Controls.Add(Me.PictureBox1)
        Me.homePage.Location = New System.Drawing.Point(4, 22)
        Me.homePage.Name = "homePage"
        Me.homePage.Size = New System.Drawing.Size(480, 206)
        Me.homePage.TabIndex = 0
        Me.homePage.Text = "Homepage"
        Me.homePage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.payCalculatorApp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(-57, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'calulatorPage
        '
        Me.calulatorPage.Controls.Add(Me.clearButton)
        Me.calulatorPage.Controls.Add(Me.calculateButton)
        Me.calulatorPage.Controls.Add(Me.minutesWorkedMini)
        Me.calulatorPage.Controls.Add(Me.minutesWorkedEditbox)
        Me.calulatorPage.Controls.Add(Me.hoursWorkedMini)
        Me.calulatorPage.Controls.Add(Me.hoursWorkedEditbox)
        Me.calulatorPage.Controls.Add(Me.hoursWorkedLabel)
        Me.calulatorPage.Controls.Add(Me.nameEmployeeEditbox)
        Me.calulatorPage.Controls.Add(Me.nameEmployeeLabel)
        Me.calulatorPage.Controls.Add(Me.calculatorOutput)
        Me.calulatorPage.Location = New System.Drawing.Point(4, 22)
        Me.calulatorPage.Name = "calulatorPage"
        Me.calulatorPage.Padding = New System.Windows.Forms.Padding(3)
        Me.calulatorPage.Size = New System.Drawing.Size(480, 206)
        Me.calulatorPage.TabIndex = 1
        Me.calulatorPage.Text = "Calculator"
        Me.calulatorPage.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(8, 176)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(96, 23)
        Me.clearButton.TabIndex = 20
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(8, 136)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(96, 39)
        Me.calculateButton.TabIndex = 19
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'minutesWorkedMini
        '
        Me.minutesWorkedMini.AutoSize = True
        Me.minutesWorkedMini.Location = New System.Drawing.Point(54, 94)
        Me.minutesWorkedMini.Name = "minutesWorkedMini"
        Me.minutesWorkedMini.Size = New System.Drawing.Size(30, 13)
        Me.minutesWorkedMini.TabIndex = 18
        Me.minutesWorkedMini.Text = "(Min)"
        '
        'minutesWorkedEditbox
        '
        Me.minutesWorkedEditbox.Location = New System.Drawing.Point(54, 72)
        Me.minutesWorkedEditbox.Name = "minutesWorkedEditbox"
        Me.minutesWorkedEditbox.Size = New System.Drawing.Size(40, 20)
        Me.minutesWorkedEditbox.TabIndex = 17
        '
        'hoursWorkedMini
        '
        Me.hoursWorkedMini.AutoSize = True
        Me.hoursWorkedMini.Location = New System.Drawing.Point(8, 94)
        Me.hoursWorkedMini.Name = "hoursWorkedMini"
        Me.hoursWorkedMini.Size = New System.Drawing.Size(24, 13)
        Me.hoursWorkedMini.TabIndex = 16
        Me.hoursWorkedMini.Text = "(Hr)"
        '
        'hoursWorkedEditbox
        '
        Me.hoursWorkedEditbox.Location = New System.Drawing.Point(8, 72)
        Me.hoursWorkedEditbox.Name = "hoursWorkedEditbox"
        Me.hoursWorkedEditbox.Size = New System.Drawing.Size(40, 20)
        Me.hoursWorkedEditbox.TabIndex = 15
        '
        'hoursWorkedLabel
        '
        Me.hoursWorkedLabel.AutoSize = True
        Me.hoursWorkedLabel.Location = New System.Drawing.Point(8, 56)
        Me.hoursWorkedLabel.Name = "hoursWorkedLabel"
        Me.hoursWorkedLabel.Size = New System.Drawing.Size(115, 13)
        Me.hoursWorkedLabel.TabIndex = 2
        Me.hoursWorkedLabel.Text = "Hours Worked Weekly"
        '
        'nameEmployeeEditbox
        '
        Me.nameEmployeeEditbox.Location = New System.Drawing.Point(8, 24)
        Me.nameEmployeeEditbox.Name = "nameEmployeeEditbox"
        Me.nameEmployeeEditbox.Size = New System.Drawing.Size(125, 20)
        Me.nameEmployeeEditbox.TabIndex = 1
        '
        'nameEmployeeLabel
        '
        Me.nameEmployeeLabel.AutoSize = True
        Me.nameEmployeeLabel.Location = New System.Drawing.Point(8, 8)
        Me.nameEmployeeLabel.Name = "nameEmployeeLabel"
        Me.nameEmployeeLabel.Size = New System.Drawing.Size(91, 13)
        Me.nameEmployeeLabel.TabIndex = 0
        Me.nameEmployeeLabel.Text = "Employee's Name"
        '
        'calculatorOutput
        '
        Me.calculatorOutput.Controls.Add(Me.payRateDisplay)
        Me.calculatorOutput.Controls.Add(Me.payRateDisplayLabel)
        Me.calculatorOutput.Controls.Add(Me.maximumHoursDisplay)
        Me.calculatorOutput.Controls.Add(Me.maximumHoursDisplayLabel)
        Me.calculatorOutput.Controls.Add(Me.nameEmployeeDisplayLabel)
        Me.calculatorOutput.Controls.Add(Me.nameEmployeeDisplay)
        Me.calculatorOutput.Controls.Add(Me.netPayLabel)
        Me.calculatorOutput.Controls.Add(Me.netPayDisplay)
        Me.calculatorOutput.Controls.Add(Me.hoursWorkedDisplay)
        Me.calculatorOutput.Controls.Add(Me.grossPayDisplay)
        Me.calculatorOutput.Controls.Add(Me.hoursWorkedDisplayLabel)
        Me.calculatorOutput.Controls.Add(Me.grossPayLabel)
        Me.calculatorOutput.Controls.Add(Me.taxDisplay)
        Me.calculatorOutput.Controls.Add(Me.taxLabel)
        Me.calculatorOutput.Location = New System.Drawing.Point(139, 0)
        Me.calculatorOutput.Name = "calculatorOutput"
        Me.calculatorOutput.Size = New System.Drawing.Size(341, 208)
        Me.calculatorOutput.TabIndex = 25
        '
        'payRateDisplay
        '
        Me.payRateDisplay.AutoSize = True
        Me.payRateDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.payRateDisplay.Location = New System.Drawing.Point(251, 109)
        Me.payRateDisplay.Name = "payRateDisplay"
        Me.payRateDisplay.Size = New System.Drawing.Size(35, 13)
        Me.payRateDisplay.TabIndex = 28
        Me.payRateDisplay.Text = "$--/Hr"
        Me.payRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'payRateDisplayLabel
        '
        Me.payRateDisplayLabel.AutoSize = True
        Me.payRateDisplayLabel.Location = New System.Drawing.Point(251, 96)
        Me.payRateDisplayLabel.Name = "payRateDisplayLabel"
        Me.payRateDisplayLabel.Size = New System.Drawing.Size(51, 13)
        Me.payRateDisplayLabel.TabIndex = 27
        Me.payRateDisplayLabel.Text = "Pay Rate"
        '
        'maximumHoursDisplay
        '
        Me.maximumHoursDisplay.AutoSize = True
        Me.maximumHoursDisplay.Location = New System.Drawing.Point(251, 75)
        Me.maximumHoursDisplay.Name = "maximumHoursDisplay"
        Me.maximumHoursDisplay.Size = New System.Drawing.Size(47, 13)
        Me.maximumHoursDisplay.TabIndex = 26
        Me.maximumHoursDisplay.Text = "-.- Hours"
        Me.maximumHoursDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maximumHoursDisplayLabel
        '
        Me.maximumHoursDisplayLabel.AutoSize = True
        Me.maximumHoursDisplayLabel.Location = New System.Drawing.Point(251, 59)
        Me.maximumHoursDisplayLabel.Name = "maximumHoursDisplayLabel"
        Me.maximumHoursDisplayLabel.Size = New System.Drawing.Size(82, 13)
        Me.maximumHoursDisplayLabel.TabIndex = 25
        Me.maximumHoursDisplayLabel.Text = "Maximum Hours"
        '
        'nameEmployeeDisplayLabel
        '
        Me.nameEmployeeDisplayLabel.AutoSize = True
        Me.nameEmployeeDisplayLabel.Location = New System.Drawing.Point(8, 8)
        Me.nameEmployeeDisplayLabel.Name = "nameEmployeeDisplayLabel"
        Me.nameEmployeeDisplayLabel.Size = New System.Drawing.Size(91, 13)
        Me.nameEmployeeDisplayLabel.TabIndex = 21
        Me.nameEmployeeDisplayLabel.Text = "Employee's Name"
        '
        'nameEmployeeDisplay
        '
        Me.nameEmployeeDisplay.AutoSize = True
        Me.nameEmployeeDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameEmployeeDisplay.Location = New System.Drawing.Point(8, 24)
        Me.nameEmployeeDisplay.Name = "nameEmployeeDisplay"
        Me.nameEmployeeDisplay.Size = New System.Drawing.Size(142, 29)
        Me.nameEmployeeDisplay.TabIndex = 22
        Me.nameEmployeeDisplay.Text = "John Smith"
        '
        'netPayLabel
        '
        Me.netPayLabel.AutoSize = True
        Me.netPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netPayLabel.Location = New System.Drawing.Point(185, 136)
        Me.netPayLabel.Name = "netPayLabel"
        Me.netPayLabel.Size = New System.Drawing.Size(52, 13)
        Me.netPayLabel.TabIndex = 8
        Me.netPayLabel.Text = "Net Pay"
        '
        'netPayDisplay
        '
        Me.netPayDisplay.AutoSize = True
        Me.netPayDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netPayDisplay.Location = New System.Drawing.Point(181, 148)
        Me.netPayDisplay.Name = "netPayDisplay"
        Me.netPayDisplay.Size = New System.Drawing.Size(66, 42)
        Me.netPayDisplay.TabIndex = 9
        Me.netPayDisplay.Text = "$--"
        Me.netPayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hoursWorkedDisplay
        '
        Me.hoursWorkedDisplay.AutoSize = True
        Me.hoursWorkedDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursWorkedDisplay.Location = New System.Drawing.Point(9, 88)
        Me.hoursWorkedDisplay.Name = "hoursWorkedDisplay"
        Me.hoursWorkedDisplay.Size = New System.Drawing.Size(92, 24)
        Me.hoursWorkedDisplay.TabIndex = 24
        Me.hoursWorkedDisplay.Text = "-.- Hours"
        '
        'grossPayDisplay
        '
        Me.grossPayDisplay.AutoSize = True
        Me.grossPayDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossPayDisplay.Location = New System.Drawing.Point(3, 160)
        Me.grossPayDisplay.Name = "grossPayDisplay"
        Me.grossPayDisplay.Size = New System.Drawing.Size(42, 29)
        Me.grossPayDisplay.TabIndex = 5
        Me.grossPayDisplay.Text = "$--"
        '
        'hoursWorkedDisplayLabel
        '
        Me.hoursWorkedDisplayLabel.AutoSize = True
        Me.hoursWorkedDisplayLabel.Location = New System.Drawing.Point(8, 72)
        Me.hoursWorkedDisplayLabel.Name = "hoursWorkedDisplayLabel"
        Me.hoursWorkedDisplayLabel.Size = New System.Drawing.Size(141, 13)
        Me.hoursWorkedDisplayLabel.TabIndex = 23
        Me.hoursWorkedDisplayLabel.Text = "Hours Worked for the Week"
        '
        'grossPayLabel
        '
        Me.grossPayLabel.AutoSize = True
        Me.grossPayLabel.Location = New System.Drawing.Point(3, 144)
        Me.grossPayLabel.Name = "grossPayLabel"
        Me.grossPayLabel.Size = New System.Drawing.Size(55, 13)
        Me.grossPayLabel.TabIndex = 4
        Me.grossPayLabel.Text = "Gross Pay"
        '
        'taxDisplay
        '
        Me.taxDisplay.AutoSize = True
        Me.taxDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxDisplay.Location = New System.Drawing.Point(92, 160)
        Me.taxDisplay.Name = "taxDisplay"
        Me.taxDisplay.Size = New System.Drawing.Size(42, 29)
        Me.taxDisplay.TabIndex = 7
        Me.taxDisplay.Text = "$--"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Location = New System.Drawing.Point(94, 144)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(25, 13)
        Me.taxLabel.TabIndex = 10
        Me.taxLabel.Text = "Tax"
        '
        'editValuesPage
        '
        Me.editValuesPage.Controls.Add(Me.Label3)
        Me.editValuesPage.Controls.Add(Me.maximumHoursEditbox2)
        Me.editValuesPage.Controls.Add(Me.Label2)
        Me.editValuesPage.Controls.Add(Me.payRateEditbox2)
        Me.editValuesPage.Controls.Add(Me.Label1)
        Me.editValuesPage.Controls.Add(Me.savedLabel)
        Me.editValuesPage.Controls.Add(Me.defaultReset)
        Me.editValuesPage.Controls.Add(Me.saveChanges)
        Me.editValuesPage.Controls.Add(Me.taxEnabler)
        Me.editValuesPage.Controls.Add(Me.maximumHoursLabel)
        Me.editValuesPage.Controls.Add(Me.maximumHoursEditbox)
        Me.editValuesPage.Controls.Add(Me.payRateLabel)
        Me.editValuesPage.Controls.Add(Me.payRateEditbox)
        Me.editValuesPage.Location = New System.Drawing.Point(4, 22)
        Me.editValuesPage.Name = "editValuesPage"
        Me.editValuesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.editValuesPage.Size = New System.Drawing.Size(480, 206)
        Me.editValuesPage.TabIndex = 2
        Me.editValuesPage.Text = "Edit Values"
        Me.editValuesPage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "(Min)"
        '
        'maximumHoursEditbox2
        '
        Me.maximumHoursEditbox2.Location = New System.Drawing.Point(80, 80)
        Me.maximumHoursEditbox2.Name = "maximumHoursEditbox2"
        Me.maximumHoursEditbox2.Size = New System.Drawing.Size(40, 20)
        Me.maximumHoursEditbox2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "(Hr)"
        '
        'payRateEditbox2
        '
        Me.payRateEditbox2.Location = New System.Drawing.Point(56, 24)
        Me.payRateEditbox2.Name = "payRateEditbox2"
        Me.payRateEditbox2.Size = New System.Drawing.Size(32, 20)
        Me.payRateEditbox2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "."
        '
        'savedLabel
        '
        Me.savedLabel.AutoSize = True
        Me.savedLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.savedLabel.Location = New System.Drawing.Point(395, 3)
        Me.savedLabel.Name = "savedLabel"
        Me.savedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.savedLabel.Size = New System.Drawing.Size(82, 13)
        Me.savedLabel.TabIndex = 8
        Me.savedLabel.Text = "Default Settings"
        Me.savedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'defaultReset
        '
        Me.defaultReset.Location = New System.Drawing.Point(8, 176)
        Me.defaultReset.Name = "defaultReset"
        Me.defaultReset.Size = New System.Drawing.Size(96, 23)
        Me.defaultReset.TabIndex = 7
        Me.defaultReset.Text = "Reset to Default"
        Me.defaultReset.UseVisualStyleBackColor = True
        '
        'saveChanges
        '
        Me.saveChanges.Location = New System.Drawing.Point(8, 136)
        Me.saveChanges.Name = "saveChanges"
        Me.saveChanges.Size = New System.Drawing.Size(96, 39)
        Me.saveChanges.TabIndex = 6
        Me.saveChanges.Text = "Save Changes"
        Me.saveChanges.UseVisualStyleBackColor = True
        '
        'taxEnabler
        '
        Me.taxEnabler.AutoSize = True
        Me.taxEnabler.Location = New System.Drawing.Point(8, 112)
        Me.taxEnabler.Name = "taxEnabler"
        Me.taxEnabler.Size = New System.Drawing.Size(86, 17)
        Me.taxEnabler.TabIndex = 5
        Me.taxEnabler.Text = "Tax Enabled"
        Me.taxEnabler.UseVisualStyleBackColor = True
        '
        'maximumHoursLabel
        '
        Me.maximumHoursLabel.AutoSize = True
        Me.maximumHoursLabel.Location = New System.Drawing.Point(8, 64)
        Me.maximumHoursLabel.Name = "maximumHoursLabel"
        Me.maximumHoursLabel.Size = New System.Drawing.Size(117, 13)
        Me.maximumHoursLabel.TabIndex = 3
        Me.maximumHoursLabel.Text = "Max Hours (Hours/Wk)"
        '
        'maximumHoursEditbox
        '
        Me.maximumHoursEditbox.Location = New System.Drawing.Point(8, 80)
        Me.maximumHoursEditbox.Name = "maximumHoursEditbox"
        Me.maximumHoursEditbox.Size = New System.Drawing.Size(40, 20)
        Me.maximumHoursEditbox.TabIndex = 2
        '
        'payRateLabel
        '
        Me.payRateLabel.AutoSize = True
        Me.payRateLabel.Location = New System.Drawing.Point(8, 8)
        Me.payRateLabel.Name = "payRateLabel"
        Me.payRateLabel.Size = New System.Drawing.Size(82, 13)
        Me.payRateLabel.TabIndex = 1
        Me.payRateLabel.Text = "Pay Rate ($/Hr)"
        '
        'payRateEditbox
        '
        Me.payRateEditbox.Location = New System.Drawing.Point(8, 24)
        Me.payRateEditbox.Name = "payRateEditbox"
        Me.payRateEditbox.Size = New System.Drawing.Size(40, 20)
        Me.payRateEditbox.TabIndex = 0
        Me.payRateEditbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(488, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripLabel1.Text = "Employee Pay Calculator "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = Global.payCalculatorApp.My.Resources.Resources.folder_open
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "ToolStripButton1"
        Me.OpenToolStripButton.ToolTipText = "Open Save File"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 256)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(488, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(127, 17)
        Me.ToolStripStatusLabel1.Text = "Brayden Konkel ©2016"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(488, 278)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Hanryo's Pay Calculator 2016"
        Me.TabControl1.ResumeLayout(False)
        Me.homePage.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.calulatorPage.ResumeLayout(False)
        Me.calulatorPage.PerformLayout()
        Me.calculatorOutput.ResumeLayout(False)
        Me.calculatorOutput.PerformLayout()
        Me.editValuesPage.ResumeLayout(False)
        Me.editValuesPage.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents homePage As TabPage
    Friend WithEvents calulatorPage As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents editValuesPage As TabPage
    Friend WithEvents payRateLabel As Label
    Friend WithEvents payRateEditbox As TextBox
    Friend WithEvents maximumHoursLabel As Label
    Friend WithEvents maximumHoursEditbox As TextBox
    Friend WithEvents taxEnabler As CheckBox
    Friend WithEvents defaultReset As Button
    Friend WithEvents saveChanges As Button
    Friend WithEvents savedLabel As Label
    Friend WithEvents hoursWorkedLabel As Label
    Friend WithEvents nameEmployeeEditbox As TextBox
    Friend WithEvents nameEmployeeLabel As Label
    Friend WithEvents payRateEditbox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents maximumHoursEditbox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents netPayDisplay As Label
    Friend WithEvents netPayLabel As Label
    Friend WithEvents taxDisplay As Label
    Friend WithEvents grossPayDisplay As Label
    Friend WithEvents grossPayLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents calculateButton As Button
    Friend WithEvents minutesWorkedMini As Label
    Friend WithEvents minutesWorkedEditbox As TextBox
    Friend WithEvents hoursWorkedMini As Label
    Friend WithEvents hoursWorkedEditbox As TextBox
    Friend WithEvents nameEmployeeDisplay As Label
    Friend WithEvents nameEmployeeDisplayLabel As Label
    Friend WithEvents hoursWorkedDisplay As Label
    Friend WithEvents hoursWorkedDisplayLabel As Label
    Friend WithEvents calculatorOutput As Panel
    Friend WithEvents payRateDisplay As Label
    Friend WithEvents payRateDisplayLabel As Label
    Friend WithEvents maximumHoursDisplay As Label
    Friend WithEvents maximumHoursDisplayLabel As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
