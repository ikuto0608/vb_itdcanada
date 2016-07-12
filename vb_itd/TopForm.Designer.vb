<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.btnCount100 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMultipleCalcurate = New System.Windows.Forms.Button()
        Me.btnUseFunction = New System.Windows.Forms.Button()
        Me.btnRef = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Assignment1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcurator = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Assignment1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCount100
        '
        Me.btnCount100.Location = New System.Drawing.Point(18, 19)
        Me.btnCount100.Name = "btnCount100"
        Me.btnCount100.Size = New System.Drawing.Size(87, 23)
        Me.btnCount100.TabIndex = 0
        Me.btnCount100.Text = "Count100"
        Me.btnCount100.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(197, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMultipleCalcurate
        '
        Me.btnMultipleCalcurate.Location = New System.Drawing.Point(139, 19)
        Me.btnMultipleCalcurate.Name = "btnMultipleCalcurate"
        Me.btnMultipleCalcurate.Size = New System.Drawing.Size(103, 23)
        Me.btnMultipleCalcurate.TabIndex = 3
        Me.btnMultipleCalcurate.Text = "Multiple Calcurate"
        Me.btnMultipleCalcurate.UseVisualStyleBackColor = True
        '
        'btnUseFunction
        '
        Me.btnUseFunction.Location = New System.Drawing.Point(18, 62)
        Me.btnUseFunction.Name = "btnUseFunction"
        Me.btnUseFunction.Size = New System.Drawing.Size(87, 23)
        Me.btnUseFunction.TabIndex = 5
        Me.btnUseFunction.Text = "Use Function"
        Me.btnUseFunction.UseVisualStyleBackColor = True
        '
        'btnRef
        '
        Me.btnRef.Location = New System.Drawing.Point(139, 62)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(103, 23)
        Me.btnRef.TabIndex = 6
        Me.btnRef.Text = "UseByRef"
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCount100)
        Me.GroupBox1.Controls.Add(Me.btnRef)
        Me.GroupBox1.Controls.Add(Me.btnMultipleCalcurate)
        Me.GroupBox1.Controls.Add(Me.btnUseFunction)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "July 11"
        '
        'Assignment1
        '
        Me.Assignment1.Controls.Add(Me.btnCalcurator)
        Me.Assignment1.Location = New System.Drawing.Point(13, 130)
        Me.Assignment1.Name = "Assignment1"
        Me.Assignment1.Size = New System.Drawing.Size(259, 40)
        Me.Assignment1.TabIndex = 8
        Me.Assignment1.TabStop = False
        Me.Assignment1.Text = "Assignment1"
        '
        'btnCalcurator
        '
        Me.btnCalcurator.Location = New System.Drawing.Point(84, 11)
        Me.btnCalcurator.Name = "btnCalcurator"
        Me.btnCalcurator.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcurator.TabIndex = 0
        Me.btnCalcurator.Text = "Calculator"
        Me.btnCalcurator.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnArray)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 63)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "July 12"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Find numbers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnArray
        '
        Me.btnArray.Location = New System.Drawing.Point(138, 23)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(103, 23)
        Me.btnArray.TabIndex = 8
        Me.btnArray.Text = "How to Array"
        Me.btnArray.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 340)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Assignment1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "TopForm"
        Me.Text = "TopForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.Assignment1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCount100 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMultipleCalcurate As System.Windows.Forms.Button
    Friend WithEvents btnUseFunction As System.Windows.Forms.Button
    Friend WithEvents btnRef As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Assignment1 As GroupBox
    Friend WithEvents btnCalcurator As Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnArray As System.Windows.Forms.Button
End Class
