Imports System.Data
Imports System.Data.OracleClient
Public Class Form2
    Dim con As OracleConnection
    Dim od As OracleDataReader
    Dim cmd As OracleCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New OracleConnection("user id=System;password=viva123")
            con.Open()
            cmd = New OracleCommand
            cmd.Connection = con
            cmd.CommandText = "select * from emp1"
            od = cmd.ExecuteReader

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd2 As New OracleCommand
        cmd2.Connection = con
        cmd2.CommandText = "select * from emp1 where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'"
        od = cmd2.ExecuteReader()
        If od.Read() Then
            form3.show()
        Else
            MessageBox.Show("Invaild")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class