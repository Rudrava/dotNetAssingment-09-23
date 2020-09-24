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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.userName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EnterName = New System.Windows.Forms.Label()
        Me.Greet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(281, 218)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(230, 20)
        Me.userName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Greet Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EnterName
        '
        Me.EnterName.AutoSize = True
        Me.EnterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterName.Location = New System.Drawing.Point(277, 176)
        Me.EnterName.Name = "EnterName"
        Me.EnterName.Size = New System.Drawing.Size(139, 20)
        Me.EnterName.TabIndex = 1
        Me.EnterName.Text = "Whats Your Name"
        '
        'Greet
        '
        Me.Greet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Greet.AutoSize = True
        Me.Greet.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Greet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Greet.Location = New System.Drawing.Point(187, 154)
        Me.Greet.Margin = New System.Windows.Forms.Padding(3)
        Me.Greet.Name = "Greet"
        Me.Greet.Padding = New System.Windows.Forms.Padding(3)
        Me.Greet.Size = New System.Drawing.Size(90, 79)
        Me.Greet.TabIndex = 0
        Me.Greet.Text = "hi"
        Me.Greet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Greet.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.EnterName)
        Me.Controls.Add(Me.Greet)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "RudravaAssingment_09_23"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EnterName As Label
    Friend WithEvents Greet As Label
End Class
