<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registerbutton = New FontAwesome.Sharp.IconButton()
        Me.loginbutton = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strpassword = New System.Windows.Forms.TextBox()
        Me.strusername = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 30)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel14)
        Me.Panel2.Controls.Add(Me.Panel13)
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1133, 571)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.registerbutton)
        Me.GroupBox2.Controls.Add(Me.loginbutton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.strpassword)
        Me.GroupBox2.Controls.Add(Me.strusername)
        Me.GroupBox2.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(199, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 411)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SIGN UP / SIGN IN"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(144, 210)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 21)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Agree terms"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(539, 68)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'registerbutton
        '
        Me.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerbutton.IconChar = FontAwesome.Sharp.IconChar.Registered
        Me.registerbutton.IconColor = System.Drawing.Color.Black
        Me.registerbutton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.registerbutton.IconSize = 20
        Me.registerbutton.Location = New System.Drawing.Point(403, 155)
        Me.registerbutton.Name = "registerbutton"
        Me.registerbutton.Size = New System.Drawing.Size(150, 37)
        Me.registerbutton.TabIndex = 5
        Me.registerbutton.Text = "REGISTER"
        Me.registerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.registerbutton.UseVisualStyleBackColor = True
        '
        'loginbutton
        '
        Me.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbutton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.loginbutton.IconColor = System.Drawing.Color.Black
        Me.loginbutton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.loginbutton.IconSize = 20
        Me.loginbutton.Location = New System.Drawing.Point(262, 155)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(135, 37)
        Me.loginbutton.TabIndex = 4
        Me.loginbutton.Text = "LOGIN"
        Me.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(141, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(141, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "username"
        '
        'strpassword
        '
        Me.strpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strpassword.Location = New System.Drawing.Point(262, 111)
        Me.strpassword.Name = "strpassword"
        Me.strpassword.Size = New System.Drawing.Size(291, 23)
        Me.strpassword.TabIndex = 1
        '
        'strusername
        '
        Me.strusername.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strusername.Location = New System.Drawing.Point(262, 74)
        Me.strusername.Name = "strusername"
        Me.strusername.Size = New System.Drawing.Size(291, 23)
        Me.strusername.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Location = New System.Drawing.Point(187, 488)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(28, 52)
        Me.Panel14.TabIndex = 12
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Gray
        Me.Panel13.Location = New System.Drawing.Point(136, 455)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(28, 85)
        Me.Panel13.TabIndex = 11
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Gray
        Me.Panel12.Location = New System.Drawing.Point(83, 418)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(28, 122)
        Me.Panel12.TabIndex = 10
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Gray
        Me.Panel11.Location = New System.Drawing.Point(675, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(28, 25)
        Me.Panel11.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Location = New System.Drawing.Point(726, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(28, 38)
        Me.Panel10.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Location = New System.Drawing.Point(774, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(28, 52)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Location = New System.Drawing.Point(152, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(28, 52)
        Me.Panel9.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Location = New System.Drawing.Point(105, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(28, 122)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Location = New System.Drawing.Point(60, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(28, 228)
        Me.Panel6.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1102, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(31, 488)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(28, 488)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1105, 83)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 571)
        Me.Panel3.TabIndex = 1
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1133, 601)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customer"
        Me.Text = "customer"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents registerbutton As FontAwesome.Sharp.IconButton
    Friend WithEvents loginbutton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents strpassword As TextBox
    Friend WithEvents strusername As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
End Class
