Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Dim savedata0 As String = Application.StartupPath & "/myarray0.txt"
    Dim savedata1 As String = Application.StartupPath & "/myarray1.txt"
    Dim savedata2 As String = Application.StartupPath & "/myarray2.txt"
    Dim load0() As String = File.ReadAllLines(savedata0)
    Dim load1() As String = File.ReadAllLines(savedata1)
    Dim load2() As String = File.ReadAllLines(savedata1)
    Dim save0(1000000) As String
    Dim save1(1000000) As String
    Dim save2(1000001) As String
    Dim selecteddate As String
    Public todo(2, 1000000)
    Dim itemstoday As Integer
    Public newdate As String
    Public go As Boolean = False
    Public nextindex As Integer = 0
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        go = True
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For i As Integer = 0 To 100000
            save0(i) = todo(0, i)
            save1(i) = todo(1, i)
            save2(i) = todo(2, i)
        Next
        IO.File.WriteAllLines(savedata0, save0)
        IO.File.WriteAllLines(savedata1, save1)
        IO.File.WriteAllLines(savedata2, save2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 1000000
            todo(0, i) = load0(i)
            todo(1, i) = load1(i)
            todo(2, i) = load2(i)
        Next
        Dim testing As Integer = 0
        While todo(1, testing) <> ""
            nextindex += 1
            testing += 1
        End While
        go = True
        PictureBox1.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If go = True Then
            selecteddate = DateTimePicker1.Value
            CheckedListBox1.Items.Clear()
            itemstoday = 0
            selecteddate = selecteddate.Remove(selecteddate.Length - 11, 11)
            For i As Integer = 0 To 1000000
                If todo(1, i) = selecteddate Then
                    CheckedListBox1.Items.Add(todo(0, i) & " -- " & todo(1, i))
                    itemstoday += 1
                End If
            Next
            Label2.Text = "You have " & itemstoday & " things to do."
            go = False
        End If
        If itemstoday = 0 Then
            PictureBox1.Show()
        Else
            PictureBox1.Hide()
        End If
    End Sub
End Class