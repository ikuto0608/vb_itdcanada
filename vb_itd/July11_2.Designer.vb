<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class July11_2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxFirst = New System.Windows.Forms.TextBox()
        Me.tbxSecond = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnEvenAndOdd = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbxAll = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second:"
        '
        'tbxFirst
        '
        Me.tbxFirst.Location = New System.Drawing.Point(90, 17)
        Me.tbxFirst.Name = "tbxFirst"
        Me.tbxFirst.Size = New System.Drawing.Size(135, 20)
        Me.tbxFirst.TabIndex = 2
        '
        'tbxSecond
        '
        Me.tbxSecond.Location = New System.Drawing.Point(90, 51)
        Me.tbxSecond.Name = "tbxSecond"
        Me.tbxSecond.Size = New System.Drawing.Size(135, 20)
        Me.tbxSecond.TabIndex = 3
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(31, 104)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(87, 23)
        Me.btnPlus.TabIndex = 4
        Me.btnPlus.Text = "Multi"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnEvenAndOdd
        '
        Me.btnEvenAndOdd.Location = New System.Drawing.Point(138, 146)
        Me.btnEvenAndOdd.Name = "btnEvenAndOdd"
        Me.btnEvenAndOdd.Size = New System.Drawing.Size(87, 23)
        Me.btnEvenAndOdd.TabIndex = 5
        Me.btnEvenAndOdd.Text = "EvenAndOdd"
        Me.btnEvenAndOdd.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.Location = New System.Drawing.Point(31, 146)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(87, 23)
        Me.btnSquare.TabIndex = 7
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(138, 104)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(87, 23)
        Me.btnReverse.TabIndex = 6
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 193)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(31, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbxAll
        '
        Me.lbxAll.FormattingEnabled = True
        Me.lbxAll.Location = New System.Drawing.Point(293, 17)
        Me.lbxAll.Name = "lbxAll"
        Me.lbxAll.Size = New System.Drawing.Size(269, 199)
        Me.lbxAll.TabIndex = 10
        '
        'July11_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 432)
        Me.Controls.Add(Me.lbxAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnEvenAndOdd)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.tbxSecond)
        Me.Controls.Add(Me.tbxFirst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "July11_2"
        Me.Text = "July11_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxFirst As System.Windows.Forms.TextBox
    Friend WithEvents tbxSecond As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnEvenAndOdd As System.Windows.Forms.Button
    Friend WithEvents btnSquare As System.Windows.Forms.Button
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbxAll As System.Windows.Forms.ListBox
End Class
