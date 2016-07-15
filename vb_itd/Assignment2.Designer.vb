<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assignment2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assignment2))
        Me.picPlane = New System.Windows.Forms.PictureBox()
        Me.picWhite = New System.Windows.Forms.PictureBox()
        CType(Me.picPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlane
        '
        Me.picPlane.Image = CType(resources.GetObject("picPlane.Image"), System.Drawing.Image)
        Me.picPlane.Location = New System.Drawing.Point(12, 24)
        Me.picPlane.Name = "picPlane"
        Me.picPlane.Size = New System.Drawing.Size(1017, 379)
        Me.picPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlane.TabIndex = 0
        Me.picPlane.TabStop = False
        '
        'picWhite
        '
        Me.picWhite.BackColor = System.Drawing.Color.White
        Me.picWhite.Location = New System.Drawing.Point(664, 194)
        Me.picWhite.Name = "picWhite"
        Me.picWhite.Size = New System.Drawing.Size(100, 102)
        Me.picWhite.TabIndex = 73
        Me.picWhite.TabStop = False
        '
        'Assignment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 408)
        Me.Controls.Add(Me.picWhite)
        Me.Controls.Add(Me.picPlane)
        Me.Name = "Assignment2"
        Me.Text = "Assignment2"
        CType(Me.picPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlane As PictureBox
    Friend WithEvents picWhite As PictureBox
End Class
