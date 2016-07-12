<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayForm
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
        Me.lbxArray = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lbxRandom = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEvenAndOdd = New System.Windows.Forms.Button()
        Me.lbxEven = New System.Windows.Forms.ListBox()
        Me.lbxOdd = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMaxMin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxArray
        '
        Me.lbxArray.FormattingEnabled = True
        Me.lbxArray.Location = New System.Drawing.Point(39, 193)
        Me.lbxArray.Name = "lbxArray"
        Me.lbxArray.Size = New System.Drawing.Size(120, 95)
        Me.lbxArray.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(179, 97)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 23)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Show Array"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lbxRandom
        '
        Me.lbxRandom.FormattingEnabled = True
        Me.lbxRandom.Location = New System.Drawing.Point(39, 25)
        Me.lbxRandom.Name = "lbxRandom"
        Me.lbxRandom.Size = New System.Drawing.Size(120, 95)
        Me.lbxRandom.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 141)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(39, 141)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(120, 23)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Random Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result Numbers"
        '
        'btnEvenAndOdd
        '
        Me.btnEvenAndOdd.Location = New System.Drawing.Point(179, 193)
        Me.btnEvenAndOdd.Name = "btnEvenAndOdd"
        Me.btnEvenAndOdd.Size = New System.Drawing.Size(120, 23)
        Me.btnEvenAndOdd.TabIndex = 7
        Me.btnEvenAndOdd.Text = "Divied Even and Odd"
        Me.btnEvenAndOdd.UseVisualStyleBackColor = True
        '
        'lbxEven
        '
        Me.lbxEven.FormattingEnabled = True
        Me.lbxEven.Location = New System.Drawing.Point(322, 25)
        Me.lbxEven.Name = "lbxEven"
        Me.lbxEven.Size = New System.Drawing.Size(120, 95)
        Me.lbxEven.TabIndex = 8
        '
        'lbxOdd
        '
        Me.lbxOdd.FormattingEnabled = True
        Me.lbxOdd.Location = New System.Drawing.Point(322, 193)
        Me.lbxOdd.Name = "lbxOdd"
        Me.lbxOdd.Size = New System.Drawing.Size(120, 95)
        Me.lbxOdd.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Even Numbers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Odd Numbers"
        '
        'btnMaxMin
        '
        Me.btnMaxMin.Location = New System.Drawing.Point(179, 231)
        Me.btnMaxMin.Name = "btnMaxMin"
        Me.btnMaxMin.Size = New System.Drawing.Size(120, 23)
        Me.btnMaxMin.TabIndex = 12
        Me.btnMaxMin.Text = "Show Max and Min"
        Me.btnMaxMin.UseVisualStyleBackColor = True
        '
        'ArrayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 332)
        Me.Controls.Add(Me.btnMaxMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbxOdd)
        Me.Controls.Add(Me.lbxEven)
        Me.Controls.Add(Me.btnEvenAndOdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbxRandom)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lbxArray)
        Me.Name = "ArrayForm"
        Me.Text = "ArrayForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxArray As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lbxRandom As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEvenAndOdd As System.Windows.Forms.Button
    Friend WithEvents lbxEven As System.Windows.Forms.ListBox
    Friend WithEvents lbxOdd As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMaxMin As System.Windows.Forms.Button
End Class
