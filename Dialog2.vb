Imports System.Windows.Forms

Public Class Dialog2
    Public Check As Long
    Private Sub FillDeparListView()

        Dim Item(4) As String
        For Each Row As DataRow In FormKSV.Workers_KSVDataSet.Departments_KSV.Rows
            Item(1) = Row("Title")
            Dim It As New ListViewItem()
            It.Text = Row("ID")
            It.SubItems.AddRange(Item)
            ListViewDepartments.Items.Add(It)
        Next Row
        'ListViewDepartments.Items.Clear()
    End Sub
    Private Sub FillPostsListView()

        Dim Item(4) As String
        For Each Row As DataRow In FormKSV.Workers_KSVDataSet.Posts_KSV.Rows
            Item(1) = Row("Title")
            Dim It As New ListViewItem()
            It.Text = Row("ID")
            It.SubItems.AddRange(Item)
            ListViewPosts.Items.Add(It)
        Next Row
        'ListViewPosts.Items.Clear()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Rows() As DataRow
        Dim DepartmentID, PostsID As ULong
        Rows = FormKSV.Workers_KSVDataSet.Posts_KSV.Select("Title='" & TextBoxPosts.Text & "'")
        If Rows.Length = 0 Then
            FormKSV.Posts_KSVTableAdapter.Insert(TextBoxPosts.Text)
            FormKSV.Posts_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Posts_KSV)
            Rows = FormKSV.Workers_KSVDataSet.Posts_KSV.Select("Title = '" & TextBoxPosts.Text & "'")
            PostsID = Rows(0)("ID")
        Else
            PostsID = Rows(0)("ID")
        End If
        Rows = FormKSV.Workers_KSVDataSet.Departments_KSV.Select("Title='" & TextBoxDepartments.Text & "'")
        If Rows.Length = 0 Then
            FormKSV.Departments_KSVTableAdapter.Insert(TextBoxDepartments.Text)
            FormKSV.Departments_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Departments_KSV)
            Rows = FormKSV.Workers_KSVDataSet.Departments_KSV.Select("Title = '" & TextBoxDepartments.Text & "'")
            DepartmentID = Rows(0)("ID")
        Else
            DepartmentID = Rows(0)("ID")
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ListViewPosts.Items.Clear()
        ListViewDepartments.Items.Clear()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDeparListView()
        FillPostsListView()
    End Sub

    Private Sub ButtonDropDepartments_Click(sender As Object, e As EventArgs) Handles ButtonDropDepartments.Click
        Dim Rows() As DataRow
        For Each Item As ListViewItem In ListViewDepartments.CheckedItems
            Rows = FormKSV.Workers_KSVDataSet.Departments_KSV.Select("ID='" & Item.Text & "'")
            FormKSV.Departments_KSVTableAdapter.Delete(Rows(0)(0), Rows(0)(1))
            Check = MsgBox("Вы действительно хотите удалить выбранное?")
            Item.Remove()
        Next Item
        FormKSV.Departments_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Departments_KSV)
    End Sub

    Private Sub ButtonDropPosts_Click(sender As Object, e As EventArgs) Handles ButtonDropPosts.Click
        Dim Rows() As DataRow
        For Each Item As ListViewItem In ListViewPosts.CheckedItems
            Rows = FormKSV.Workers_KSVDataSet.Posts_KSV.Select("ID='" & Item.Text & "'")
            FormKSV.Posts_KSVTableAdapter.Delete(Rows(0)(0), Rows(0)(1))
            Check = MsgBox("Вы действительно хотите удалить выбранное?")
            Item.Remove()
        Next Item
        FormKSV.Posts_KSVTableAdapter.Fill(FormKSV.Workers_KSVDataSet.Posts_KSV)
    End Sub
End Class