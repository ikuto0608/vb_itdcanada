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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.tbxLastName = New System.Windows.Forms.TextBox()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxSeat = New System.Windows.Forms.TextBox()
        CType(Me.picPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 74
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(233, 22)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 76
        Me.lblFirstName.Text = "FirstName:"
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Location = New System.Drawing.Point(301, 19)
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbxFirstName.TabIndex = 75
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(233, 48)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 78
        Me.lblLastName.Text = "LastName:"
        '
        'tbxLastName
        '
        Me.tbxLastName.Location = New System.Drawing.Point(301, 45)
        Me.tbxLastName.Name = "tbxLastName"
        Me.tbxLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbxLastName.TabIndex = 77
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReserve.Enabled = False
        Me.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.Location = New System.Drawing.Point(236, 78)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(75, 23)
        Me.btnReserve.TabIndex = 79
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(326, 78)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxSeat)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.tbxFirstName)
        Me.GroupBox1.Controls.Add(Me.btnReserve)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.tbxLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 108)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ANA Reservation"
        '
        'tbxSeat
        '
        Me.tbxSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSeat.Location = New System.Drawing.Point(82, 58)
        Me.tbxSeat.Name = "tbxSeat"
        Me.tbxSeat.ReadOnly = True
        Me.tbxSeat.Size = New System.Drawing.Size(45, 29)
        Me.tbxSeat.TabIndex = 81
        Me.tbxSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Assignment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picWhite)
        Me.Controls.Add(Me.picPlane)
        Me.Name = "Assignment2"
        Me.Text = "Assignment2"
        CType(Me.picPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlane As PictureBox
    Friend WithEvents picWhite As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblFirstName As Label
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents tbxLastName As TextBox
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxSeat As TextBox
End Class
