﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provider_Profile_page
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
        profilepic_pb = New PictureBox()
        Panel1 = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Edit_profile_btn = New Button()
        rate_label = New Label()
        location_label = New Label()
        email_label = New Label()
        Service_label = New Label()
        Name_label = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        changepic_pb = New PictureBox()
        CType(profilepic_pb, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(changepic_pb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' profilepic_pb
        ' 
        profilepic_pb.BackgroundImage = My.Resources.Resources._default
        profilepic_pb.BackgroundImageLayout = ImageLayout.Stretch
        profilepic_pb.Location = New Point(59, 29)
        profilepic_pb.Name = "profilepic_pb"
        profilepic_pb.Size = New Size(198, 197)
        profilepic_pb.SizeMode = PictureBoxSizeMode.StretchImage
        profilepic_pb.TabIndex = 0
        profilepic_pb.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(33, 234)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 43)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(193, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(43, 43)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 6
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(146, 0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(43, 43)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(97, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 43)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(48, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 43)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Edit_profile_btn)
        Panel2.Controls.Add(rate_label)
        Panel2.Controls.Add(location_label)
        Panel2.Controls.Add(email_label)
        Panel2.Controls.Add(Service_label)
        Panel2.Controls.Add(Name_label)
        Panel2.Location = New Point(361, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(411, 265)
        Panel2.TabIndex = 2
        ' 
        ' Edit_profile_btn
        ' 
        Edit_profile_btn.BackColor = Color.FromArgb(CByte(173), CByte(103), CByte(200))
        Edit_profile_btn.BackgroundImageLayout = ImageLayout.Stretch
        Edit_profile_btn.FlatStyle = FlatStyle.Flat
        Edit_profile_btn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Edit_profile_btn.ForeColor = Color.White
        Edit_profile_btn.Location = New Point(39, 207)
        Edit_profile_btn.Name = "Edit_profile_btn"
        Edit_profile_btn.Size = New Size(114, 36)
        Edit_profile_btn.TabIndex = 5
        Edit_profile_btn.Text = "Edit Button"
        Edit_profile_btn.UseVisualStyleBackColor = False
        ' 
        ' rate_label
        ' 
        rate_label.Font = New Font("Segoe UI", 11F)
        rate_label.Location = New Point(38, 158)
        rate_label.Name = "rate_label"
        rate_label.Size = New Size(394, 34)
        rate_label.TabIndex = 4
        rate_label.Text = "Label1"
        ' 
        ' location_label
        ' 
        location_label.Font = New Font("Segoe UI", 11F)
        location_label.Location = New Point(38, 123)
        location_label.Name = "location_label"
        location_label.Size = New Size(391, 34)
        location_label.TabIndex = 3
        location_label.Text = "Label1"
        ' 
        ' email_label
        ' 
        email_label.Font = New Font("Segoe UI", 11F)
        email_label.Location = New Point(38, 91)
        email_label.Name = "email_label"
        email_label.Size = New Size(391, 34)
        email_label.TabIndex = 2
        email_label.Text = "Label1"
        ' 
        ' Service_label
        ' 
        Service_label.Font = New Font("Segoe UI", 11F)
        Service_label.Location = New Point(38, 58)
        Service_label.Name = "Service_label"
        Service_label.Size = New Size(427, 34)
        Service_label.TabIndex = 1
        Service_label.Text = "Label1"
        ' 
        ' Name_label
        ' 
        Name_label.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Name_label.Location = New Point(33, 16)
        Name_label.Name = "Name_label"
        Name_label.Size = New Size(427, 34)
        Name_label.TabIndex = 0
        Name_label.Text = "Label1"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Location = New Point(33, 332)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(760, 283)
        Panel3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(33, 295)
        Label1.Name = "Label1"
        Label1.Size = New Size(739, 34)
        Label1.TabIndex = 4
        Label1.Text = "Past Appointments"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' changepic_pb
        ' 
        changepic_pb.BackgroundImage = My.Resources.Resources.more_horiz
        changepic_pb.BackgroundImageLayout = ImageLayout.Stretch
        changepic_pb.Location = New Point(224, 33)
        changepic_pb.Name = "changepic_pb"
        changepic_pb.Size = New Size(30, 30)
        changepic_pb.TabIndex = 5
        changepic_pb.TabStop = False
        ' 
        ' Provider_Profile_page
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(825, 619)
        Controls.Add(changepic_pb)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(profilepic_pb)
        Name = "Provider_Profile_page"
        Text = "Provider_Profile_page"
        CType(profilepic_pb, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(changepic_pb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents profilepic_pb As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rate_label As Label
    Friend WithEvents location_label As Label
    Friend WithEvents email_label As Label
    Friend WithEvents Service_label As Label
    Friend WithEvents Name_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents changepic_pb As PictureBox
    Friend WithEvents Edit_profile_btn As Button
End Class
