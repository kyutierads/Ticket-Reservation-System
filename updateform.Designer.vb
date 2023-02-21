<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateform
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 284)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER'S DATA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(626, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.ID)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.username)
        Me.GroupBox2.Controls.Add(Me.email)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.Phone)
        Me.GroupBox2.Controls.Add(Me.Fname)
        Me.GroupBox2.Controls.Add(Me.Lname)
        Me.GroupBox2.Controls.Add(Me.pass)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(906, 470)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TRACK AND UPDATE CUSTOMERS INFO'S"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(113, 101)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(100, 22)
        Me.ID.TabIndex = 24
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(21, 420)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(192, 31)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "TRACK"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(268, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(183, 34)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "REFRESH DATA"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(713, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 31)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ID"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(480, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 34)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "SEE RECORDS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "CHANGE REGISTRATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(57, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(291, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "PERSONAL INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Lname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(113, 129)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 22)
        Me.username.TabIndex = 8
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(113, 380)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(100, 22)
        Me.email.TabIndex = 7
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(113, 352)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(100, 22)
        Me.address.TabIndex = 6
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(113, 324)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(100, 22)
        Me.Phone.TabIndex = 5
        '
        'Fname
        '
        Me.Fname.Location = New System.Drawing.Point(113, 294)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(100, 22)
        Me.Fname.TabIndex = 4
        '
        'Lname
        '
        Me.Lname.Location = New System.Drawing.Point(113, 262)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(100, 22)
        Me.Lname.TabIndex = 3
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(113, 157)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(100, 22)
        Me.pass.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(380, 368)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 92)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CHANGE INFORMATIONS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(65, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "REGISTRATION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "PERSONAL INFORMATIONS"
        '
        'updateform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 652)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updateform"
        Me.Text = "updateform"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents Fname As TextBox
    Friend WithEvents Lname As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
