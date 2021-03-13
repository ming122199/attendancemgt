﻿Imports MySql.Data.MySqlClient


Public Class EmpTimesheet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllTimesheet"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("tdate").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("ttime").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("status").ToString



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

    Private Sub EmpTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prcDisplayTimesheet()
        checkDatabaseConnection()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class