﻿
Imports MySql.Data.MySqlClient
Public Class addEmployee

    Shared Property flag As Boolean
    Shared Property F As Boolean

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl


    End Sub
    Public Sub ClearComboBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearComboBox(ctrl)
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim date1 As String = dhired.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = bdate.Value.ToString("yyyy/MM/dd")


        If flag = True Then
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcEditEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("id1", Label9.Text)
                    .Parameters.AddWithValue("fname", txtFname.Text)
                    .Parameters.AddWithValue("lname", txtLname.Text)
                    .Parameters.AddWithValue("address", txtAddress.Text)
                    .Parameters.AddWithValue("bdate", date2)
                    .Parameters.AddWithValue("datehired", date1)
                    .Parameters.AddWithValue("gender", cmbGender.Text)
                    .Parameters.AddWithValue("dept", cmbDept.Text)
                    .Parameters.AddWithValue("contact", txtContact.Text)
                    .ExecuteNonQuery()
                    MessageBox.Show("Successfully updated Employee", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                End With

                F = False
                Me.Refresh()
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try
        Else

            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAddEmployee"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("fname", txtFname.Text)
                    .Parameters.AddWithValue("lname", txtLname.Text)
                    .Parameters.AddWithValue("address", txtAddress.Text)
                    .Parameters.AddWithValue("bdate", date2)
                    .Parameters.AddWithValue("datehired", date1)
                    .Parameters.AddWithValue("gender", cmbGender.Text)
                    .Parameters.AddWithValue("dept", cmbDept.Text)
                    .Parameters.AddWithValue("contact", txtContact.Text)
                    .ExecuteNonQuery()
                    MessageBox.Show("Successfully added Employee", "Add Employee", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                End With


                F = False
                Me.Refresh()
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try



        End If


        F = False


        Me.Hide()
        ClearComboBox(Me)
        ClearTextBox(Me)



    End Sub



    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        F = False



        Me.Refresh()

    End Sub



    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ClearComboBox(Me)
        ClearTextBox(Me)



        txtID.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtAddress.Clear()
        cmbGender.Items.Clear()
        cmbDept.Items.Clear()
        txtContact.Clear()
        Me.Hide()
    End Sub


End Class