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
        Me.btnJuly11 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnJuly08 = New System.Windows.Forms.Button()
        Me.btnJuly2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJuly11
        '
        Me.btnJuly11.Location = New System.Drawing.Point(34, 85)
        Me.btnJuly11.Name = "btnJuly11"
        Me.btnJuly11.Size = New System.Drawing.Size(75, 23)
        Me.btnJuly11.TabIndex = 0
        Me.btnJuly11.Text = "July11"
        Me.btnJuly11.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(183, 206)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnJuly08
        '
        Me.btnJuly08.Location = New System.Drawing.Point(34, 19)
        Me.btnJuly08.Name = "btnJuly08"
        Me.btnJuly08.Size = New System.Drawing.Size(75, 23)
        Me.btnJuly08.TabIndex = 2
        Me.btnJuly08.Text = "July08"
        Me.btnJuly08.UseVisualStyleBackColor = True
        '
        'btnJuly2
        '
        Me.btnJuly2.Location = New System.Drawing.Point(131, 85)
        Me.btnJuly2.Name = "btnJuly2"
        Me.btnJuly2.Size = New System.Drawing.Size(127, 23)
        Me.btnJuly2.TabIndex = 3
        Me.btnJuly2.Text = "Multiple Calcurate"
        Me.btnJuly2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "July 11"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Use Function"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnJuly2)
        Me.Controls.Add(Me.btnJuly08)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnJuly11)
        Me.Name = "TopForm"
        Me.Text = "TopForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJuly11 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnJuly08 As System.Windows.Forms.Button
    Friend WithEvents btnJuly2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
