<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.TxtRegisterPassword = New System.Windows.Forms.TextBox()
        Me.TxtRegisterUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLogin = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegister.Location = New System.Drawing.Point(389, 247)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(297, 44)
        Me.BtnRegister.TabIndex = 15
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'TxtRegisterPassword
        '
        Me.TxtRegisterPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtRegisterPassword.Location = New System.Drawing.Point(217, 181)
        Me.TxtRegisterPassword.Name = "TxtRegisterPassword"
        Me.TxtRegisterPassword.Size = New System.Drawing.Size(469, 39)
        Me.TxtRegisterPassword.TabIndex = 12
        '
        'TxtRegisterUsername
        '
        Me.TxtRegisterUsername.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtRegisterUsername.Location = New System.Drawing.Point(217, 113)
        Me.TxtRegisterUsername.Name = "TxtRegisterUsername"
        Me.TxtRegisterUsername.Size = New System.Drawing.Size(469, 39)
        Me.TxtRegisterUsername.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(52, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(52, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(306, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "REGISTER"
        '
        'LinkLogin
        '
        Me.LinkLogin.AutoSize = True
        Me.LinkLogin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLogin.Location = New System.Drawing.Point(615, 305)
        Me.LinkLogin.Name = "LinkLogin"
        Me.LinkLogin.Size = New System.Drawing.Size(73, 32)
        Me.LinkLogin.TabIndex = 17
        Me.LinkLogin.TabStop = True
        Me.LinkLogin.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(386, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sudah Punya Akun ?"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 386)
        Me.Controls.Add(Me.LinkLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.TxtRegisterPassword)
        Me.Controls.Add(Me.TxtRegisterUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtRegisterPassword As TextBox
    Friend WithEvents TxtRegisterUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLogin As LinkLabel
    Friend WithEvents Label4 As Label
End Class
