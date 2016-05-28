Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.todo(0, Form1.nextindex) = TextBox1.Text
        Form1.newdate = DateTimePicker1.Value
        Form1.newdate = Form1.newdate.Remove(Form1.newdate.Length - 11, 11)
        Form1.todo(1, Form1.nextindex) = Form1.newdate
        Form1.go = True
        Me.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Form1.DateTimePicker1.Value
    End Sub
End Class