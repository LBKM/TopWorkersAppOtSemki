Imports System.Windows.Forms

Public Class Dialog1
    Public AddOnChange As Boolean
    Public OldRowID As ULong
    Public OldRowPost As ULong
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Rows() As DataRow
        Dim DepartmentID, PostsID As ULong
        Rows = FormKSV.Workers_KSVDataSet.Posts_KSV.Select("Title ='" & PostComboBox.Text & "'")

        If Rows.Length = 0 Then
            FormKSV.Posts_KSVTableAdapter.Insert(PostComboBox.Text)
            FormKSV.Posts_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Posts_KSV)
            Rows = FormKSV.Workers_KSVDataSet.Posts_KSV.Select("Title ='" & PostComboBox.Text & "'")
            PostsID = Rows(0)("ID")
        Else
            PostsID = Rows(0)("ID")
        End If

        Rows = FormKSV.Workers_KSVDataSet.Departments_KSV.Select("Title ='" & DepartmentsComboBox.Text & "'")

        If Rows.Length = 0 Then
            FormKSV.Departments_KSVTableAdapter.Insert(DepartmentsComboBox.Text)
            FormKSV.Departments_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Departments_KSV)
            Rows = FormKSV.Workers_KSVDataSet.Departments_KSV.Select("Title ='" & DepartmentsComboBox.Text & "'")
            DepartmentID = Rows(0)("ID")
        Else
            DepartmentID = Rows(0)("ID")
        End If

        If AddOnChange = False Then
            FormKSV.Workers_KSVTableAdapter.Insert(FIOTextBox.Text, BirthdayDateTimePicker.Value.Date, DepartmentID, PostsID, FileNamesTextBox.Text)
        End If
        FormKSV.Workers_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Workers_KSV)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        If AddOnChange = True Then
            Dim OldWorkerRow As DataRow = FormKSV.Workers_KSVDataSet.Workers_KSV.Select("ID='" & OldRowID.ToString & "'")(0)
            FormKSV.Workers_KSVTableAdapter.Update(FIOTextBox.Text, BirthdayDateTimePicker.Value.Date, DepartmentID, PostsID, FileNamesTextBox.Text, OldWorkerRow(0), OldWorkerRow(1), OldWorkerRow(2), OldWorkerRow(3), OldWorkerRow(4), OldWorkerRow(5))
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PicButton_Click(sender As Object, e As EventArgs) Handles PicButton.Click
        FileExplorer.ShowDialog()
    End Sub

    Private Sub PicBoxDialog_Click(sender As Object, e As EventArgs) Handles PicBoxDialog.Click

    End Sub
End Class