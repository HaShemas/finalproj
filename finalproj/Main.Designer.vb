﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.txtdate = New System.Windows.Forms.Label()
        Me.btnmacc = New System.Windows.Forms.Button()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblutype = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HELLO AND WELCOME!"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbluser.Location = New System.Drawing.Point(42, 159)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(65, 17)
        Me.lbluser.TabIndex = 1
        Me.lbluser.Text = "username"
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTime.Location = New System.Drawing.Point(160, 144)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(37, 17)
        Me.txtTime.TabIndex = 2
        Me.txtTime.Text = "Time"
        '
        'btnproduct
        '
        Me.btnproduct.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnproduct.Location = New System.Drawing.Point(32, 196)
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.Size = New System.Drawing.Size(75, 36)
        Me.btnproduct.TabIndex = 3
        Me.btnproduct.Text = "Product"
        Me.btnproduct.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnlogout.Location = New System.Drawing.Point(32, 288)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 31)
        Me.btnlogout.TabIndex = 4
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'txtdate
        '
        Me.txtdate.AutoSize = True
        Me.txtdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtdate.Location = New System.Drawing.Point(363, 144)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(37, 17)
        Me.txtdate.TabIndex = 5
        Me.txtdate.Text = "Date"
        '
        'btnmacc
        '
        Me.btnmacc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnmacc.Location = New System.Drawing.Point(32, 238)
        Me.btnmacc.Name = "btnmacc"
        Me.btnmacc.Size = New System.Drawing.Size(75, 44)
        Me.btnmacc.TabIndex = 6
        Me.btnmacc.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Users"
        Me.btnmacc.UseVisualStyleBackColor = True
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblfname.Location = New System.Drawing.Point(260, 54)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(55, 21)
        Me.lblfname.TabIndex = 7
        Me.lblfname.Text = "fname"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbllname.Location = New System.Drawing.Point(308, 54)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(53, 21)
        Me.lbllname.TabIndex = 8
        Me.lbllname.Text = "lname"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblID.Location = New System.Drawing.Point(58, 142)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(49, 17)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "userID"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(149, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(5, 331)
        Me.Label10.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblutype
        '
        Me.lblutype.AutoSize = True
        Me.lblutype.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblutype.Location = New System.Drawing.Point(32, 176)
        Me.lblutype.Name = "lblutype"
        Me.lblutype.Size = New System.Drawing.Size(58, 17)
        Me.lblutype.TabIndex = 13
        Me.lblutype.Text = "usertype"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(463, 331)
        Me.Controls.Add(Me.lblutype)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.btnmacc)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnproduct)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents txtTime As Label
    Friend WithEvents btnproduct As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents txtdate As Label
    Friend WithEvents btnmacc As Button
    Friend WithEvents lblfname As Label
    Friend WithEvents lbllname As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblutype As Label
End Class
