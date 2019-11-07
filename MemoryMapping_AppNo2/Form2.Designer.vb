<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Read = New System.Windows.Forms.Button()
        Me.Btn_Make = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Makes Data * 10    Shows data sent from diffrent application"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 109)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(304, 89)
        Me.TextBox1.TabIndex = 10
        '
        'Btn_Read
        '
        Me.Btn_Read.Location = New System.Drawing.Point(196, 20)
        Me.Btn_Read.Name = "Btn_Read"
        Me.Btn_Read.Size = New System.Drawing.Size(130, 45)
        Me.Btn_Read.TabIndex = 9
        Me.Btn_Read.Text = "Readfile"
        Me.Btn_Read.UseVisualStyleBackColor = True
        '
        'Btn_Make
        '
        Me.Btn_Make.Location = New System.Drawing.Point(22, 20)
        Me.Btn_Make.Name = "Btn_Make"
        Me.Btn_Make.Size = New System.Drawing.Size(130, 45)
        Me.Btn_Make.TabIndex = 8
        Me.Btn_Make.Text = "Makefile"
        Me.Btn_Make.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 218)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Read)
        Me.Controls.Add(Me.Btn_Make)
        Me.Name = "Form1"
        Me.Text = "Test Form No.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Read As System.Windows.Forms.Button
    Friend WithEvents Btn_Make As System.Windows.Forms.Button

End Class
