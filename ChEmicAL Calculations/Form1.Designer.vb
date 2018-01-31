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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageIntro = New System.Windows.Forms.TabPage()
        Me.TabPageFenskeCalc = New System.Windows.Forms.TabPage()
        Me.TabPageFenskeDisplay = New System.Windows.Forms.TabPage()
        Me.TabPageMcCabeThiele = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBoxy = New System.Windows.Forms.ListBox()
        Me.LabelHint = New System.Windows.Forms.Label()
        Me.ListBoxx = New System.Windows.Forms.ListBox()
        Me.TextBoxRelVola = New System.Windows.Forms.TextBox()
        Me.TextBoxq = New System.Windows.Forms.TextBox()
        Me.TextBoxZf = New System.Windows.Forms.TextBox()
        Me.TextBoxR = New System.Windows.Forms.TextBox()
        Me.TextBoxXad = New System.Windows.Forms.TextBox()
        Me.TextBoxXab = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelEquilibriumData = New System.Windows.Forms.Panel()
        Me.RadioButtonxy = New System.Windows.Forms.RadioButton()
        Me.RadioButtonrv = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageMcCabeThiele.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEquilibriumData.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageIntro)
        Me.TabControl1.Controls.Add(Me.TabPageFenskeCalc)
        Me.TabControl1.Controls.Add(Me.TabPageFenskeDisplay)
        Me.TabControl1.Controls.Add(Me.TabPageMcCabeThiele)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1273, 578)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageIntro
        '
        Me.TabPageIntro.Location = New System.Drawing.Point(4, 22)
        Me.TabPageIntro.Name = "TabPageIntro"
        Me.TabPageIntro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageIntro.Size = New System.Drawing.Size(1265, 552)
        Me.TabPageIntro.TabIndex = 1
        Me.TabPageIntro.Text = "Intro"
        Me.TabPageIntro.UseVisualStyleBackColor = True
        '
        'TabPageFenskeCalc
        '
        Me.TabPageFenskeCalc.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFenskeCalc.Name = "TabPageFenskeCalc"
        Me.TabPageFenskeCalc.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFenskeCalc.Size = New System.Drawing.Size(1265, 552)
        Me.TabPageFenskeCalc.TabIndex = 0
        Me.TabPageFenskeCalc.Text = "Fenske "
        Me.TabPageFenskeCalc.UseVisualStyleBackColor = True
        '
        'TabPageFenskeDisplay
        '
        Me.TabPageFenskeDisplay.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFenskeDisplay.Name = "TabPageFenskeDisplay"
        Me.TabPageFenskeDisplay.Size = New System.Drawing.Size(1265, 552)
        Me.TabPageFenskeDisplay.TabIndex = 2
        Me.TabPageFenskeDisplay.Text = "TabPage1"
        Me.TabPageFenskeDisplay.UseVisualStyleBackColor = True
        '
        'TabPageMcCabeThiele
        '
        Me.TabPageMcCabeThiele.Controls.Add(Me.Button2)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label9)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Button1)
        Me.TabPageMcCabeThiele.Controls.Add(Me.ListBoxy)
        Me.TabPageMcCabeThiele.Controls.Add(Me.LabelHint)
        Me.TabPageMcCabeThiele.Controls.Add(Me.ListBoxx)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxRelVola)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxq)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxZf)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxR)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxXad)
        Me.TabPageMcCabeThiele.Controls.Add(Me.TextBoxXab)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label6)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label8)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label7)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label5)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label4)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Label3)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Panel1)
        Me.TabPageMcCabeThiele.Controls.Add(Me.PanelEquilibriumData)
        Me.TabPageMcCabeThiele.Controls.Add(Me.Chart1)
        Me.TabPageMcCabeThiele.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMcCabeThiele.Name = "TabPageMcCabeThiele"
        Me.TabPageMcCabeThiele.Size = New System.Drawing.Size(1265, 552)
        Me.TabPageMcCabeThiele.TabIndex = 3
        Me.TabPageMcCabeThiele.Text = "McCabe Thiele"
        Me.TabPageMcCabeThiele.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Label9"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBoxy
        '
        Me.ListBoxy.FormattingEnabled = True
        Me.ListBoxy.Location = New System.Drawing.Point(141, 340)
        Me.ListBoxy.Name = "ListBoxy"
        Me.ListBoxy.Size = New System.Drawing.Size(67, 186)
        Me.ListBoxy.TabIndex = 8
        '
        'LabelHint
        '
        Me.LabelHint.AutoSize = True
        Me.LabelHint.Location = New System.Drawing.Point(10, 529)
        Me.LabelHint.Name = "LabelHint"
        Me.LabelHint.Size = New System.Drawing.Size(52, 13)
        Me.LabelHint.TabIndex = 8
        Me.LabelHint.Text = "LabelHint"
        '
        'ListBoxx
        '
        Me.ListBoxx.FormattingEnabled = True
        Me.ListBoxx.Location = New System.Drawing.Point(61, 340)
        Me.ListBoxx.Name = "ListBoxx"
        Me.ListBoxx.Size = New System.Drawing.Size(67, 186)
        Me.ListBoxx.TabIndex = 8
        '
        'TextBoxRelVola
        '
        Me.TextBoxRelVola.Location = New System.Drawing.Point(88, 273)
        Me.TextBoxRelVola.Name = "TextBoxRelVola"
        Me.TextBoxRelVola.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxRelVola.TabIndex = 7
        '
        'TextBoxq
        '
        Me.TextBoxq.Location = New System.Drawing.Point(88, 239)
        Me.TextBoxq.Name = "TextBoxq"
        Me.TextBoxq.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxq.TabIndex = 7
        '
        'TextBoxZf
        '
        Me.TextBoxZf.Location = New System.Drawing.Point(88, 205)
        Me.TextBoxZf.Name = "TextBoxZf"
        Me.TextBoxZf.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxZf.TabIndex = 7
        '
        'TextBoxR
        '
        Me.TextBoxR.Location = New System.Drawing.Point(88, 171)
        Me.TextBoxR.Name = "TextBoxR"
        Me.TextBoxR.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxR.TabIndex = 7
        '
        'TextBoxXad
        '
        Me.TextBoxXad.Location = New System.Drawing.Point(88, 137)
        Me.TextBoxXad.Name = "TextBoxXad"
        Me.TextBoxXad.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxXad.TabIndex = 7
        '
        'TextBoxXab
        '
        Me.TextBoxXab.Location = New System.Drawing.Point(88, 103)
        Me.TextBoxXab.Name = "TextBoxXab"
        Me.TextBoxXab.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxXab.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Zf"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 26)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Relative" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volatilty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "q"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "R"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Xad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Xab"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(252, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 326)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnX, Me.ColumnY})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(181, 311)
        Me.DataGridView1.TabIndex = 8
        '
        'ColumnX
        '
        Me.ColumnX.Frozen = True
        Me.ColumnX.HeaderText = "X"
        Me.ColumnX.MaxInputLength = 20
        Me.ColumnX.Name = "ColumnX"
        Me.ColumnX.Width = 70
        '
        'ColumnY
        '
        Me.ColumnY.Frozen = True
        Me.ColumnY.HeaderText = "Y"
        Me.ColumnY.MaxInputLength = 20
        Me.ColumnY.Name = "ColumnY"
        Me.ColumnY.Width = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(0, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Click to Edit or Delete Selected Item"
        '
        'PanelEquilibriumData
        '
        Me.PanelEquilibriumData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEquilibriumData.Controls.Add(Me.RadioButtonxy)
        Me.PanelEquilibriumData.Controls.Add(Me.RadioButtonrv)
        Me.PanelEquilibriumData.Controls.Add(Me.Label1)
        Me.PanelEquilibriumData.Location = New System.Drawing.Point(4, 9)
        Me.PanelEquilibriumData.Name = "PanelEquilibriumData"
        Me.PanelEquilibriumData.Size = New System.Drawing.Size(230, 73)
        Me.PanelEquilibriumData.TabIndex = 3
        '
        'RadioButtonxy
        '
        Me.RadioButtonxy.AutoSize = True
        Me.RadioButtonxy.Location = New System.Drawing.Point(18, 49)
        Me.RadioButtonxy.Name = "RadioButtonxy"
        Me.RadioButtonxy.Size = New System.Drawing.Size(73, 17)
        Me.RadioButtonxy.TabIndex = 1
        Me.RadioButtonxy.TabStop = True
        Me.RadioButtonxy.Text = "x,y Values"
        Me.RadioButtonxy.UseVisualStyleBackColor = True
        '
        'RadioButtonrv
        '
        Me.RadioButtonrv.AutoSize = True
        Me.RadioButtonrv.Location = New System.Drawing.Point(18, 26)
        Me.RadioButtonrv.Name = "RadioButtonrv"
        Me.RadioButtonrv.Size = New System.Drawing.Size(105, 17)
        Me.RadioButtonrv.TabIndex = 1
        Me.RadioButtonrv.TabStop = True
        Me.RadioButtonrv.Text = "Relative Volatility"
        Me.RadioButtonrv.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data for plotting Equilibrium Line"
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.DarkRed
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(441, 2)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(819, 549)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(285, 411)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageMcCabeThiele.ResumeLayout(False)
        Me.TabPageMcCabeThiele.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEquilibriumData.ResumeLayout(False)
        Me.PanelEquilibriumData.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageIntro As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFenskeCalc As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFenskeDisplay As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMcCabeThiele As System.Windows.Forms.TabPage
    Friend WithEvents PanelEquilibriumData As System.Windows.Forms.Panel
    Friend WithEvents RadioButtonxy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonrv As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBoxx As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxy As System.Windows.Forms.ListBox
    Friend WithEvents LabelHint As System.Windows.Forms.Label
    Friend WithEvents TextBoxRelVola As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxq As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxZf As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxR As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxXad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxXab As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
