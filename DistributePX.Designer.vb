<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistributePX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DistributePX))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New MultithreadedControl.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Distribute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(408, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Directory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundWorker1.BackgroundColor = -2147483633
        Me.BackgroundWorker1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundWorker1.ForegroundColor = -2147483630
        Me.BackgroundWorker1.Location = New System.Drawing.Point(0, 40)
        Me.BackgroundWorker1.Name = "BackgroundWorker1"
        Me.BackgroundWorker1.Size = New System.Drawing.Size(501, 56)
        Me.BackgroundWorker1.TabIndex = 0
        Me.BackgroundWorker1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 152)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackgroundWorker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Bulk Distribute"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As MultithreadedControl.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
