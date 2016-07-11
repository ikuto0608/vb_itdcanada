<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefForm
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
        Me.tbxFirst = New System.Windows.Forms.TextBox()
        Me.tbxSecond = New System.Windows.Forms.TextBox()
        Me.btnRef = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxFirst
        '
        Me.tbxFirst.Location = New System.Drawing.Point(107, 56)
        Me.tbxFirst.Name = "tbxFirst"
        Me.tbxFirst.Size = New System.Drawing.Size(100, 20)
        Me.tbxFirst.TabIndex = 0
        '
        'tbxSecond
        '
        Me.tbxSecond.Location = New System.Drawing.Point(107, 100)
        Me.tbxSecond.Name = "tbxSecond"
        Me.tbxSecond.Size = New System.Drawing.Size(100, 20)
        Me.tbxSecond.TabIndex = 1
        '
        'btnRef
        '
        Me.btnRef.Location = New System.Drawing.Point(33, 156)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(81, 23)
        Me.btnRef.TabIndex = 2
        Me.btnRef.Text = "ToUseByRef"
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Num:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Num:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(126, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'RefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 223)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.tbxSecond)
        Me.Controls.Add(Me.tbxFirst)
        Me.Name = "RefForm"
        Me.Text = "RefForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxFirst As System.Windows.Forms.TextBox
    Friend WithEvents tbxSecond As System.Windows.Forms.TextBox
    Friend WithEvents btnRef As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
