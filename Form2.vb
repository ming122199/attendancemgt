Public Class adminDashboard
    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        date1.Text = Date.Now.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        With Form1
            .ShowDialog()


        End With



    End Sub

    Private Sub btnTimesheet_Click(sender As Object, e As EventArgs) Handles btnTimesheet.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New login

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeToolStripMenuItem1.Click

        With addEmployee
            .ShowDialog()

        End With


    End Sub

    Private Sub DisplayEmployeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisplayEmployeeToolStripMenuItem1.Click
        With Form1
            .ShowDialog()

        End With
    End Sub

    Private Sub EmployeeTimeSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeTimeSheetToolStripMenuItem.Click
        With EmpTimesheet

            .ShowDialog()

        End With
    End Sub

    Private Sub ViewReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReportsToolStripMenuItem.Click
        With timesheet

            .ShowDialog()

        End With
    End Sub

    Private Sub AddNewUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem1.Click
        With addUser
            .ShowDialog()

        End With
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

        Dim ans As Integer

        ans = MessageBox.Show("Are you sure you want to logout?", "Logged Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Me.Dispose()
            login.Show()


        End If


    End Sub
End Class