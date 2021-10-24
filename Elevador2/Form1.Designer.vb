<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pic_elevator = New System.Windows.Forms.PictureBox()
        Me.pic_piso1 = New System.Windows.Forms.PictureBox()
        Me.pic_piso2 = New System.Windows.Forms.PictureBox()
        Me.pic_piso3 = New System.Windows.Forms.PictureBox()
        Me.Pic_piso4 = New System.Windows.Forms.PictureBox()
        Me.chk_pb = New System.Windows.Forms.CheckBox()
        Me.chk_piso1 = New System.Windows.Forms.CheckBox()
        Me.chk_piso2 = New System.Windows.Forms.CheckBox()
        Me.chk_piso3 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chk_up = New System.Windows.Forms.CheckBox()
        Me.chk_down = New System.Windows.Forms.CheckBox()
        CType(Me.pic_elevator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_piso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_piso2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_piso3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_piso4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_elevator
        '
        Me.pic_elevator.BackColor = System.Drawing.Color.SpringGreen
        Me.pic_elevator.Location = New System.Drawing.Point(513, 350)
        Me.pic_elevator.Name = "pic_elevator"
        Me.pic_elevator.Size = New System.Drawing.Size(31, 54)
        Me.pic_elevator.TabIndex = 5
        Me.pic_elevator.TabStop = False
        '
        'pic_piso1
        '
        Me.pic_piso1.BackColor = System.Drawing.Color.White
        Me.pic_piso1.Location = New System.Drawing.Point(513, 350)
        Me.pic_piso1.Name = "pic_piso1"
        Me.pic_piso1.Size = New System.Drawing.Size(31, 54)
        Me.pic_piso1.TabIndex = 9
        Me.pic_piso1.TabStop = False
        '
        'pic_piso2
        '
        Me.pic_piso2.BackColor = System.Drawing.Color.White
        Me.pic_piso2.Location = New System.Drawing.Point(513, 250)
        Me.pic_piso2.Name = "pic_piso2"
        Me.pic_piso2.Size = New System.Drawing.Size(31, 54)
        Me.pic_piso2.TabIndex = 10
        Me.pic_piso2.TabStop = False
        '
        'pic_piso3
        '
        Me.pic_piso3.BackColor = System.Drawing.Color.White
        Me.pic_piso3.Location = New System.Drawing.Point(513, 150)
        Me.pic_piso3.Name = "pic_piso3"
        Me.pic_piso3.Size = New System.Drawing.Size(31, 54)
        Me.pic_piso3.TabIndex = 11
        Me.pic_piso3.TabStop = False
        '
        'Pic_piso4
        '
        Me.Pic_piso4.BackColor = System.Drawing.Color.White
        Me.Pic_piso4.Location = New System.Drawing.Point(513, 50)
        Me.Pic_piso4.Name = "Pic_piso4"
        Me.Pic_piso4.Size = New System.Drawing.Size(31, 54)
        Me.Pic_piso4.TabIndex = 12
        Me.Pic_piso4.TabStop = False
        '
        'chk_pb
        '
        Me.chk_pb.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_pb.AutoSize = True
        Me.chk_pb.Location = New System.Drawing.Point(12, 383)
        Me.chk_pb.Name = "chk_pb"
        Me.chk_pb.Size = New System.Drawing.Size(32, 27)
        Me.chk_pb.TabIndex = 13
        Me.chk_pb.Text = "PB"
        Me.chk_pb.UseVisualStyleBackColor = True
        '
        'chk_piso1
        '
        Me.chk_piso1.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_piso1.AutoSize = True
        Me.chk_piso1.Location = New System.Drawing.Point(12, 350)
        Me.chk_piso1.Name = "chk_piso1"
        Me.chk_piso1.Size = New System.Drawing.Size(25, 27)
        Me.chk_piso1.TabIndex = 14
        Me.chk_piso1.Text = "1"
        Me.chk_piso1.UseVisualStyleBackColor = True
        '
        'chk_piso2
        '
        Me.chk_piso2.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_piso2.AutoSize = True
        Me.chk_piso2.Location = New System.Drawing.Point(12, 317)
        Me.chk_piso2.Name = "chk_piso2"
        Me.chk_piso2.Size = New System.Drawing.Size(25, 27)
        Me.chk_piso2.TabIndex = 15
        Me.chk_piso2.Text = "2"
        Me.chk_piso2.UseVisualStyleBackColor = True
        '
        'chk_piso3
        '
        Me.chk_piso3.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_piso3.AutoSize = True
        Me.chk_piso3.Location = New System.Drawing.Point(12, 284)
        Me.chk_piso3.Name = "chk_piso3"
        Me.chk_piso3.Size = New System.Drawing.Size(25, 27)
        Me.chk_piso3.TabIndex = 16
        Me.chk_piso3.Text = "3"
        Me.chk_piso3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'chk_up
        '
        Me.chk_up.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_up.AutoSize = True
        Me.chk_up.Location = New System.Drawing.Point(65, 317)
        Me.chk_up.Name = "chk_up"
        Me.chk_up.Size = New System.Drawing.Size(24, 27)
        Me.chk_up.TabIndex = 17
        Me.chk_up.Text = "↑"
        Me.chk_up.UseVisualStyleBackColor = True
        '
        'chk_down
        '
        Me.chk_down.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_down.AutoSize = True
        Me.chk_down.Location = New System.Drawing.Point(65, 350)
        Me.chk_down.Name = "chk_down"
        Me.chk_down.Size = New System.Drawing.Size(24, 27)
        Me.chk_down.TabIndex = 18
        Me.chk_down.Text = "↓"
        Me.chk_down.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 427)
        Me.Controls.Add(Me.pic_elevator)
        Me.Controls.Add(Me.chk_down)
        Me.Controls.Add(Me.chk_up)
        Me.Controls.Add(Me.chk_piso3)
        Me.Controls.Add(Me.chk_piso2)
        Me.Controls.Add(Me.chk_piso1)
        Me.Controls.Add(Me.chk_pb)
        Me.Controls.Add(Me.Pic_piso4)
        Me.Controls.Add(Me.pic_piso3)
        Me.Controls.Add(Me.pic_piso2)
        Me.Controls.Add(Me.pic_piso1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic_elevator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_piso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_piso2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_piso3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_piso4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_elevator As PictureBox
    Friend WithEvents pic_piso1 As PictureBox
    Friend WithEvents pic_piso2 As PictureBox
    Friend WithEvents pic_piso3 As PictureBox
    Friend WithEvents Pic_piso4 As PictureBox
    Friend WithEvents chk_pb As CheckBox
    Friend WithEvents chk_piso1 As CheckBox
    Friend WithEvents chk_piso2 As CheckBox
    Friend WithEvents chk_piso3 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chk_up As CheckBox
    Friend WithEvents chk_down As CheckBox
End Class
