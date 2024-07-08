<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextUser = New TextBox()
        TextPass = New TextBox()
        BtnLogin = New Button()
        BtnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(127, 22)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 23)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(10, 68)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 21)
        Label2.TabIndex = 1
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 99)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextUser
        ' 
        TextUser.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextUser.Location = New Point(98, 66)
        TextUser.Margin = New Padding(2, 2, 2, 2)
        TextUser.Name = "TextUser"
        TextUser.Size = New Size(121, 29)
        TextUser.TabIndex = 3
        ' 
        ' TextPass
        ' 
        TextPass.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPass.Location = New Point(98, 97)
        TextPass.Margin = New Padding(2, 2, 2, 2)
        TextPass.Name = "TextPass"
        TextPass.Size = New Size(121, 29)
        TextPass.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLogin.Location = New Point(10, 156)
        BtnLogin.Margin = New Padding(2, 2, 2, 2)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(90, 27)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Klik"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLogout.Location = New Point(198, 156)
        BtnLogout.Margin = New Padding(2, 2, 2, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(90, 27)
        BtnLogout.TabIndex = 6
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(322, 217)
        Controls.Add(BtnLogout)
        Controls.Add(BtnLogin)
        Controls.Add(TextPass)
        Controls.Add(TextUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "FormLogin"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents TextPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnLogout As Button
End Class
