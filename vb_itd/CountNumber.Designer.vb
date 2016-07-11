<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountNumber
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
        Me.lbxSmaller = New System.Windows.Forms.ListBox()
        Me.lbxGrater = New System.Windows.Forms.ListBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbxMulti = New System.Windows.Forms.ListBox()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.lbxPlus = New System.Windows.Forms.ListBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxSmaller
        '
        Me.lbxSmaller.FormattingEnabled = True
        Me.lbxSmaller.Location = New System.Drawing.Point(37, 31)
        Me.lbxSmaller.Name = "lbxSmaller"
        Me.lbxSmaller.Size = New System.Drawing.Size(101, 147)
        Me.lbxSmaller.TabIndex = 0
        '
        'lbxGrater
        '
        Me.lbxGrater.FormattingEnabled = True
        Me.lbxGrater.Location = New System.Drawing.Point(162, 31)
        Me.lbxGrater.Name = "lbxGrater"
        Me.lbxGrater.Size = New System.Drawing.Size(101, 147)
        Me.lbxGrater.TabIndex = 1
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(37, 202)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(112, 23)
        Me.btnCount.TabIndex = 2
        Me.btnCount.Text = "Wrtie down 100 - 1"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(161, 473)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lbxMulti
        '
        Me.lbxMulti.FormattingEnabled = True
        Me.lbxMulti.Location = New System.Drawing.Point(37, 270)
        Me.lbxMulti.Name = "lbxMulti"
        Me.lbxMulti.Size = New System.Drawing.Size(101, 147)
        Me.lbxMulti.TabIndex = 4
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(37, 433)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(101, 23)
        Me.btnMulti.TabIndex = 5
        Me.btnMulti.Text = "Multiply"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'lbxPlus
        '
        Me.lbxPlus.FormattingEnabled = True
        Me.lbxPlus.Location = New System.Drawing.Point(162, 270)
        Me.lbxPlus.Name = "lbxPlus"
        Me.lbxPlus.Size = New System.Drawing.Size(101, 147)
        Me.lbxPlus.TabIndex = 6
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(161, 433)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(101, 23)
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.Text = "Plus"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Multiply List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Plus List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "50 - 1 List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "100 - 51 List"
        '
        'CountNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 508)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lbxPlus)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.lbxMulti)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lbxGrater)
        Me.Controls.Add(Me.lbxSmaller)
        Me.Name = "CountNumber"
        Me.Text = "CountNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxSmaller As System.Windows.Forms.ListBox
    Friend WithEvents lbxGrater As System.Windows.Forms.ListBox
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbxMulti As System.Windows.Forms.ListBox
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents lbxPlus As System.Windows.Forms.ListBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
