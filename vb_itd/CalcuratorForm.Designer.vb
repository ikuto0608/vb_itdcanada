<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcuratorForm
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
        Me.tbxMultipleForm = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxMultipleForm
        '
        Me.tbxMultipleForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxMultipleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMultipleForm.Location = New System.Drawing.Point(12, 27)
        Me.tbxMultipleForm.Name = "tbxMultipleForm"
        Me.tbxMultipleForm.Size = New System.Drawing.Size(260, 31)
        Me.tbxMultipleForm.TabIndex = 0
        Me.tbxMultipleForm.Text = "0"
        Me.tbxMultipleForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(12, 88)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 75)
        Me.btnPlus.TabIndex = 1
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(106, 88)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(75, 75)
        Me.btnMinus.TabIndex = 2
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.Location = New System.Drawing.Point(197, 174)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(75, 75)
        Me.btnEqual.TabIndex = 3
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(106, 174)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 75)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(12, 174)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 75)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'CalcuratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.tbxMultipleForm)
        Me.Name = "CalcuratorForm"
        Me.Text = "CalcuratorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxMultipleForm As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
End Class
