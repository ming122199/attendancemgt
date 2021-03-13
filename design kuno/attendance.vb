﻿Imports System.DateTime
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class attendance


    Shared Property userDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim user As String = Label1.Text
        Dim dateNow As String = Date.Now.ToString("dd/MM/yyyy")
        Dim timeNow As String = Date.Now.ToString("HH:ss:tt")
        Dim statt As String = "IN"
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcEntryTImesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("currTime", timeNow)
                .Parameters.AddWithValue("currDate", dateNow)

                .ExecuteNonQuery()
                MessageBox.Show("Time-in, successful", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        Me.Refresh()
    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Timer1.Enabled = True

        Label1.Text = userDashboard

        Dim user As String = Label1.Text

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmpTimesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    dgrid_emp_time_history.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With dgrid_emp_time_history
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("tdate").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("ttime").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("status").ToString

                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No record found...")



                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try







    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oForm As New login
        oForm.Show()
        Me.Dispose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyy")
        Label3.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Dim user As String = Label1.Text
        Dim dateNow As String = Date.Now.ToString("dd/MM/yyyy")
        Dim timeNow As String = Date.Now.ToString("HH:ss:tt")
        Dim statt As String = "OUT"
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcEntryTImesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("currTime", timeNow)
                .Parameters.AddWithValue("currDate", dateNow)

                .ExecuteNonQuery()
                MessageBox.Show("Time-out, successful", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        Me.Refresh()
    End Sub

    Private Sub dgrid_emp_time_history_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_emp_time_history.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class