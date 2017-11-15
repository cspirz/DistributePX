
Public Class DistributePX
    Public names As String()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Me.BackgroundWorker1.Visible = True
            Me.BackgroundWorker1.StartProcessing(TextBox1.Text)
            Button1.Enabled = False
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '        OpenFileDialog1.Multiselect = True
        '        OpenFileDialog1.Filter = "All Files | *.*"
        '       If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '       names = OpenFileDialog1.FileNames
        '        End If
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BackgroundWorker1_FinishAsyncEvent(asyncEventText As String) Handles BackgroundWorker1.FinishAsyncEvent
        Button1.Enabled = True
        Me.BackgroundWorker1.Visible = False
        Me.Close()
    End Sub
End Class
