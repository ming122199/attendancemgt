Imports MySql.Data.MySqlClient



Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayEmployee()

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New adminDashboard

        oForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With addEmployee
            .ShowDialog()
            IntOperation = 0

        End With
        prcDisplayEmployee()




    End Sub

    Private Sub prcDisplayEmployee()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployees"
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
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("emp_ID").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("dept_id").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

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




    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim num As Integer

        Try
            num = MessageBox.Show("Delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If num = DialogResult.Yes Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcDeleteEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("emp_id", CInt(DataGridView1.CurrentRow.Cells(0).Value))
                    .ExecuteNonQuery()

                End With
            End If



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        prcDisplayBySearchType(txtSearch.Text)
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "EMPLOYEE ID" Then
            txtSearch.Enabled = True
            txtSearch.Clear()
        ElseIf ComboBox1.Text = "EMPLOYEE NAME" Then
            txtSearch.Enabled = True
            txtSearch.Clear()
        Else
            txtSearch.Enabled = False
            txtSearch.Clear()


        End If
    End Sub


    Private Sub prcDisplayByAutoSearch(ByVal searchType As String, ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSelAllEmployeeByAutoComplete"
                .Parameters.AddWithValue("@p_searchtype", searchType)
                .Parameters.AddWithValue("@p_value", strValue)
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

                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("emp_ID").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("dept_id").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

                        End With

                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No Record Found...")
                    DataGridView1.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub prcDisplayBySearchType(ByVal strSearch As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()

                If ComboBox1.Text = "EMPLOYEE ID" Then
                    .CommandText = "prcSelcEmpbyID"
                    .Parameters.AddWithValue("@empID", strSearch)

                ElseIf ComboBox1.Text = "EMPLOYEE NAME" Then
                    .CommandText = "prcSelcEmpbyName"
                    .Parameters.AddWithValue("@empName", strSearch)


                Else
                    .CommandText = "prcSelAllEmployee"

                End If
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

                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("emp_ID").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("dept_id").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

                        End With

                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No Record Found...")
                    DataGridView1.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub



    Private Sub chkAuto_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuto.CheckedChanged
        If chkAuto.Checked = True Then
            btnSearch.Enabled = False
            txtSearch.Clear()
            txtSearch.Enabled = True
        Else
            btnSearch.Enabled = True

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If chkAuto.Checked = True Then
            prcDisplayByAutoSearch(ComboBox1.Text, txtSearch.Text)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        With addEmployee

            IntOperation = 1

            id = CInt(DataGridView1.CurrentRow.Cells(0).Value.ToString)
            .txtID.Text = DataGridView1.CurrentRow.Cells(1).Value
            .cmbDept.Text = DataGridView1.CurrentRow.Cells(2).Value
            .txtFname.Text = DataGridView1.CurrentRow.Cells(3).Value
            .txtLname.Text = DataGridView1.CurrentRow.Cells(4).Value
            .txtAddress.Text = DataGridView1.CurrentRow.Cells(5).Value
            .bdate.Value = DataGridView1.CurrentRow.Cells(6).Value
            .cmbGender.Text = DataGridView1.CurrentRow.Cells(7).Value
            .dhired.Value = DataGridView1.CurrentRow.Cells(8).Value

            .txtContact.Text = DataGridView1.CurrentRow.Cells(9).Value
            .ShowDialog()

        End With


        prcDisplayEmployee()



    End Sub


    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick


    End Sub
End Class
