Imports System.Linq

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim input As String = TextBox1.Text
        Dim items = input.Split(","c)


        Dim result = items.Distinct().OrderByDescending(Function(x) x.Trim())


        Label1.Text = "Sorted Unique Products:" & vbCrLf & String.Join(vbCrLf, result)
    End Sub
End Class
