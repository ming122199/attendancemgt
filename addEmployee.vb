
Imports MySql.Data.MySqlClient
Public Class addEmployee
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            With command

                .Parameters.Clear()
                If IntOperation = 0 Then


                    .CommandText = "prcAddEmployee"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@emp_id", txtID.Text)
                    .Parameters.AddWithValue("@fname", txtFname.Text)
                    .Parameters.AddWithValue("@lname", txtLname.Text)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@bdate", bdate.Value)
                    .Parameters.AddWithValue("@datehired", dhired.Value)
                    .Parameters.AddWithValue("@gender", cmbGender.Text)
                    .Parameters.AddWithValue("@dept", cmbDept.Text)
                    .Parameters.AddWithValue("@contact", txtContact.Text)



                Else
                    .CommandText = "prcEditEmployee"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@emp_id", txtID.Text)
                    .Parameters.AddWithValue("@fname", txtFname.Text)
                    .Parameters.AddWithValue("@lname", txtLname.Text)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@bdate", bdate.Value)
                    .Parameters.AddWithValue("@datehired", dhired.Value)
                    .Parameters.AddWithValue("@gender", cmbGender.Text)
                    .Parameters.AddWithValue("@dept", cmbDept.Text)
                    .Parameters.AddWithValue("@contact", txtContact.Text)



                End If
                .ExecuteNonQuery()
                MessageBox.Show("Record successfully saved!", " Record Saved!", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information)
                txtID.Clear()
                txtFname.Clear()
                txtLname.Clear()
                txtAddress.Clear()
                cmbGender.Items.Clear()
                cmbDept.Items.Clear()
                txtContact.Clear()





            End With
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try




        Me.Hide()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub




End Class