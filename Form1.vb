﻿Public Class FormKSV
    Dim LastSelectedItem As ListViewItem

    Private Sub FormKSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillWorkersList()
    End Sub

    Private Sub FillWorkersList()
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Workers_KSV". При необходимости она может быть перемещена или удалена.
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Posts_KSV". При необходимости она может быть перемещена или удалена.
        Me.Posts_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Posts_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Departments_KSV". При необходимости она может быть перемещена или удалена.
        Me.Departments_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Departments_KSV)
        For Each RowCB As DataRow In Me.Workers_KSVDataSet.Departments_KSV.Rows
            ComboBoxFilterDepartments.Items.Add(RowCB("Title"))
        Next RowCB
        For Each RowCB As DataRow In Me.Workers_KSVDataSet.Posts_KSV
            ComboBoxFilterPost.Items.Add(RowCB("Title"))
        Next RowCB
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
                Me.Workers_KSVDataSet.Workers_KSV.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow_KSV = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow_KSV(1)
            TempRow_KSV = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow_KSV(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView_KSV.Items.Add(it)
        Next Row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonNewKSV.Click
        With Dialog1
            .Text = "Добавление сотрудника"
            .FIOTextBox.Text = ""
            .BirthdayDateTimePicker.Value = DateTime.Now
            .PostComboBox.Text = ""
            .PostComboBox.Items.Clear()
            For Each Row As DataRow In Me.Workers_KSVDataSet.Posts_KSV.Rows
                .PostComboBox.Items.Add(Row("Title"))
            Next Row
            .DepartmentsComboBox.Text = ""
            .DepartmentsComboBox.Items.Clear()
            For Each Row As DataRow In Me.Workers_KSVDataSet.Departments_KSV.Rows
                .DepartmentsComboBox.Items.Add(Row("Title"))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillWorkersList()
            End If
        End With
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim Rows() As DataRow
        For Each Item As ListViewItem In WorkersListView_KSV.CheckedItems
            Rows = Workers_KSVDataSet.Workers_KSV.Select("ID='" & Item.Text & "'")
            Workers_KSVTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4))
            Item.Remove()
        Next Item
        Me.Workers_KSVTableAdapter.Fill(Workers_KSVDataSet.Workers_KSV)
    End Sub

    Private Sub WorkersListView_KSV_MouseClick(sender As Object, e As MouseEventArgs) Handles WorkersListView_KSV.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(sender, e.X, e.Y)
        End If
    End Sub

    Private Sub WorkersListView_KSV_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles WorkersListView_KSV.ItemSelectionChanged
        LastSelectedItem = e.Item
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click
        With Dialog1
            .Text = "Редактирование сотрудника"
            Dim CurrentWorkersRow As DataRow = Workers_KSVDataSet.Workers_KSV.Select("ID='" & LastSelectedItem.Text & "'")(0)
            .OldRowID = CurrentWorkersRow("ID")
            .AddOnChange = True
            .FIOTextBox.Text = CurrentWorkersRow("FIO")
            .BirthdayDateTimePicker.Value = CurrentWorkersRow("Birthday")
            .PostComboBox.Text = CurrentWorkersRow.GetParentRow("PostsWorkers")("Title")
            .PostComboBox.Items.Clear()
            For Each Row As DataRow In Workers_KSVDataSet.Posts_KSV.Rows
                .PostComboBox.Items.Add(Row("Title"))
            Next Row
            .DepartmentsComboBox.Text = CurrentWorkersRow.GetParentRow("DepartmentsWorkers")("Title")
            .DepartmentsComboBox.Items.Clear()
            For Each Row As DataRow In
                    Workers_KSVDataSet.Departments_KSV.Rows
                .DepartmentsComboBox.Items.Add(Row("Title"))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillWorkersList()
            End If
        End With
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        With Dialog2
            .Text = "Койнов. Добавление должности и отдела."
            .TextBoxDepartments.Text = ""
            .TextBoxPosts.Text = ""
            .ShowDialog()
            'If .DialogResult = DialogResult.OK Then
            'FillWorkersList()
            'End If
        End With
    End Sub

    Private Sub ComboBoxFilterPost_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxFilterPost.SelectionChangeCommitted
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        Dim RowFilterPost As DataRow = Workers_KSVDataSet.Posts_KSV.Select("Title ='" & ComboBoxFilterPost.SelectedItem & "'")(0)
        'MsgBox(ComboBoxFilterPost.SelectedItem)
        Dim RowID_Post As ULong
        RowID_Post = RowFilterPost("ID")
        For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Select("PostID ='" & RowID_Post.ToString & "'")
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow(1)
            TempRow = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView_KSV.Items.Add(it)
        Next Row
    End Sub

    Private Sub ClearFilterButton_Click(sender As Object, e As EventArgs) Handles ClearFilterButton.Click
        ComboBoxFilterDepartments.Text = ""
        ComboBoxFilterPost.Text = ""
        TBFilterFIO.Text = ""
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
                Me.Workers_KSVDataSet.Workers_KSV.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow_KSV = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow_KSV(1)
            TempRow_KSV = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow_KSV(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView_KSV.Items.Add(it)
        Next Row
    End Sub

    'Private Sub ComboBoxFilterDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilterDepartments.SelectedIndexChanged
    '    WorkersListView_KSV.Items.Clear()
    '    Dim items(4) As String
    '    Dim TempRow As DataRow
    '    For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Rows
    '        Dim RowFilterDepart As DataRow = Workers_KSVDataSet.Departments_KSV.Select("Title ='" & ComboBoxFilterDepartments.SelectedItem & "'")(0)
    '        If Row("DepartmentID") = RowFilterDepart("ID") Then
    '            'MsgBox(RowFilterDepart("ID"))
    '            items(1) = Row(1)
    '            items(2) = Row(2)
    '            TempRow = Row.GetParentRow("DepartmentsWorkers")
    '            items(3) = TempRow(1)
    '            TempRow = Row.GetParentRow("PostsWorkers")
    '            items(4) = TempRow(1)
    '            Dim it As New ListViewItem()
    '            it.Text = Row(0)
    '            it.SubItems.AddRange(items)
    '            WorkersListView_KSV.Items.Add(it)
    '        End If
    '    Next Row
    '    'MsgBox(ComboBoxFilterPost.SelectedItem)
    'End Sub

    Private Sub ComboBoxFilterPost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilterPost.SelectedIndexChanged
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Rows
            Dim RowFilterPost As DataRow = Workers_KSVDataSet.Posts_KSV.Select("Title ='" & ComboBoxFilterPost.SelectedItem & "'")(0)
            If Row("PostID") = RowFilterPost("ID") Then
                'MsgBox(RowFilterDepart("ID"))
                items(1) = Row(1)
                items(2) = Row(2)
                TempRow = Row.GetParentRow("DepartmentsWorkers")
                items(3) = TempRow(1)
                TempRow = Row.GetParentRow("PostsWorkers")
                items(4) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                WorkersListView_KSV.Items.Add(it)
            End If
        Next Row
        'MsgBox(ComboBoxFilterPost.SelectedItem)
        'Dim RowCB As DataRow
        'For Each RowCB In Me.Workers_KSVDataSet.Departments_KSV.Rows
        '    ComboBoxFilterDepartments.Items.Add(RowCB("Title"))
        'Next RowCB
    End Sub

    Private Sub ComboBoxFilterDepartments_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxFilterDepartments.SelectionChangeCommitted
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Rows
            Dim RowFilterDepart As DataRow = Workers_KSVDataSet.Departments_KSV.Select("Title ='" & ComboBoxFilterDepartments.SelectedItem & "'")(0)
            If Row("DepartmentID") = RowFilterDepart("ID") Then
                'MsgBox(RowFilterDepart("ID"))
                items(1) = Row(1)
                items(2) = Row(2)
                TempRow = Row.GetParentRow("DepartmentsWorkers")
                items(3) = TempRow(1)
                TempRow = Row.GetParentRow("PostsWorkers")
                items(4) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                WorkersListView_KSV.Items.Add(it)
            End If
        Next Row
        'MsgBox(ComboBoxFilterPost.SelectedItem)
    End Sub

    Private Sub TBFilterFIO_TextChanged(sender As Object, e As EventArgs) Handles TBFilterFIO.TextChanged
        WorkersListView_KSV.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        Dim strFindFIO As String
        If TBFilterFIO.Text = vbNullChar Then
            TBFilterFIO.Text = ""
        End If
        strFindFIO = TBFilterFIO.Text
        For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Select("FIO Like '" & strFindFIO & "*'")
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow(1)
            TempRow = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView_KSV.Items.Add(it)
        Next Row
    End Sub

    'Private Sub TextBoxPostFilter_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPostFilter.TextChanged
    '    WorkersListView_KSV.Items.Clear()
    '    Dim items(4) As String
    '    Dim TempRow As DataRow
    '    'Dim strFindFIO As String
    '    If TextBoxPostFilter.Text = vbNullChar Then
    '        TextBoxPostFilter.Text = ""
    '    End If
    '    Dim strFindPost As ULong
    '    For Each RowPost As DataRow In Workers_KSVDataSet.Posts_KSV.Select("Title Like'" & TextBoxPostFilter.Text & "*'")
    '        strFindPost = RowPost("ID")
    '        For Each Row As DataRow In Me.Workers_KSVDataSet.Workers_KSV.Select("PostId = '" & strFindPost & "'")
    '            items(1) = Row(1)
    '            items(2) = Row(2)
    '            TempRow = Row.GetParentRow("DepartmentsWorkers")
    '            items(3) = TempRow(1)
    '            TempRow = Row.GetParentRow("PostsWorkers")
    '            items(4) = TempRow(1)
    '            Dim it As New ListViewItem()
    '            it.Text = Row(0)
    '            it.SubItems.AddRange(items)
    '            WorkersListView_KSV.Items.Add(it)
    '        Next Row
    '    Next RowPost
    'End Sub
End Class