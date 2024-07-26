<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        lblNum1 = New Label()
        lblNum2 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(228, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "CLICK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Location = New Point(135, 125)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(83, 25)
        lblNum1.TabIndex = 1
        lblNum1.Text = "first num"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Location = New Point(135, 190)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(110, 25)
        lblNum2.TabIndex = 2
        lblNum2.Text = "second num"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(310, 122)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(150, 31)
        txtNum1.TabIndex = 3
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(310, 190)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(150, 31)
        txtNum2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(lblNum2)
        Controls.Add(lblNum1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox

End Class
