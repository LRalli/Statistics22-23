Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RichTextBox4.BackColor = Color.White) Then
            RichTextBox1.BackColor = Color.Green
            RichTextBox4.BackColor = Color.Green
            RichTextBox2.BackColor = Color.White
            RichTextBox4.Text = "Green Light"
        ElseIf (RichTextBox4.BackColor = Color.Red) Then
            RichTextBox1.BackColor = Color.Green
            RichTextBox4.BackColor = Color.Green
            RichTextBox3.BackColor = Color.White
            RichTextBox2.BackColor = Color.White
            RichTextBox4.Text = "Green Light"
        ElseIf (RichTextBox4.BackColor = Color.Green) Then
            RichTextBox3.BackColor = Color.Red
            RichTextBox4.BackColor = Color.Red
            RichTextBox1.BackColor = Color.White
            RichTextBox2.BackColor = Color.White
            RichTextBox4.Text = "Red Light"
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        If (RichTextBox1.BackColor = Color.Green Or RichTextBox3.BackColor = Color.Red) Then
            RichTextBox2.BackColor = Color.Yellow
            RichTextBox1.BackColor = Color.White
            RichTextBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        If (RichTextBox2.BackColor = Color.Yellow) Then
            RichTextBox2.BackColor = Color.White
            RichTextBox1.BackColor = Color.White
            RichTextBox3.BackColor = Color.White
            RichTextBox4.BackColor = Color.White
            RichTextBox4.Text = ""
        End If
    End Sub
End Class
