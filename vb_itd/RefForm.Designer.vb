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
        Me.SuspendLayout()
        '
        'tbxFirst
        '
        Me.tbxFirst.Location = New System.Drawing.Point(101, 56)
        Me.tbxFirst.Name = "tbxFirst"
        Me.tbxFirst.Size = New System.Drawing.Size(100, 20)
        Me.tbxFirst.TabIndex = 0
        '
        'tbxSecond
        '
        Me.tbxSecond.Location = New System.Drawing.Point(101, 100)
        Me.tbxSecond.Name = "tbxSecond"
        Me.tbxSecond.Size = New System.Drawing.Size(100, 20)
        Me.tbxSecond.TabIndex = 1
        '
        'btnRef
        '
        Me.btnRef.Location = New System.Drawing.Point(101, 161)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(75, 23)
        Me.btnRef.TabIndex = 2
        Me.btnRef.Text = "Reference"
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'RefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
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
End Class
