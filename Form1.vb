Public Class FormKSV
    Dim LastSelectedItem As ListViewItem

    Private Sub FormKSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileExplorer.FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        FillWorkersList()
    End Sub

    Public Sub FillWorkersList()
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
        Dim items(5) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
                Me.Workers_KSVDataSet.Workers_KSV.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow_KSV = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow_KSV(1)
            TempRow_KSV = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow_KSV(1)
            items(5) = Row(5).ToString
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView_KSV.Items.Add(it)
        Next Row
        Me.WorkersListView_KSV.Items(0).Selected = True
        Me.WorkersListView_KSV.Focus()
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
            .FileNamesTextBox.Text = ""
            .PicBoxDialog.Image = Nothing
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
            Workers_KSVTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5))
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
        Dim CurrentWorkerRow As DataRow =
            Workers_KSVDataSet.Workers_KSV.Select("ID = '" & LastSelectedItem.Text & "'")(0)
        'MsgBox(CurrentWorkerRow("Picture"))
        'PicBox_PhotoWorkers.Image = Image.FromFile(
        '    IO.Directory.GetCurrentDirectory & "\Picture\" & CurrentWorkerRow("Picture"))
        Try
            PicBox_PhotoWorkers.Image = Image.FromFile(
                IO.Directory.GetCurrentDirectory & "\Picture\" & CurrentWorkerRow("Picture"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Обработк исключений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Stack trace: " & vbCrLf & ex.StackTrace, "Обработчик исключений")
        Finally
            'MessageBox.Show("Конечный блок")
        End Try
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
            Try
                .FileNamesTextBox.Text = CurrentWorkersRow("Picture")
                Dialog1.PicBoxDialog.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\Picture\" & CurrentWorkersRow("Picture"))
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Обработка исключений. Не загружается изображение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace, "Обработчик исключений")
            Finally
                'MessageBox.Show("Конечный блок")
            End Try
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
        Dim items(5) As String
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
            items(5) = Row(5).ToString
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
        Dim items(5) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
                Me.Workers_KSVDataSet.Workers_KSV.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow_KSV = Row.GetParentRow("DepartmentsWorkers")
            items(3) = TempRow_KSV(1)
            TempRow_KSV = Row.GetParentRow("PostsWorkers")
            items(4) = TempRow_KSV(1)
            items(5) = Row(5).ToString
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
        Dim items(5) As String
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
                items(5) = Row(5).ToString
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
        Dim items(5) As String
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
                items(5) = Row(5).ToString
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
        Dim items(5) As String
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
            items(5) = Row(5).ToString
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

    Private Sub OutSql()
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = My.Settings.Workers_KSVConnectionString2
        MsgBox(cn.ConnectionString)
        cn.Open()
        Dim sql As New OleDb.OleDbCommand("SELECT Workers_KSV.FIO, Departments_KSV.Title As DTitle, Posts_KSV.Title As PTitle FROM Posts_KSV INNER JOIN (Departments_KSV INNER JOIN Workers_KSV ON Departments_KSV.ID = Workers_KSV.DepartmentID) ON Posts_KSV.ID=Workers_KSV.PostId", cn)
        Dim da As New OleDb.OleDbDataAdapter
        Dim DataSqlTable As New DataTable
        da.SelectCommand = sql
        da.Fill(DataSqlTable)
        cn.Close()
        Dim RowCB As DataRow
        For Each RowCB In DataSqlTable.Rows
            MsgBox(RowCB("FIO") & ", " & (RowCB("DTitle") & ", " & (RowCB("PTitle"))))
        Next RowCB
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OutSql()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles GridSQLButton.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = My.Settings.Workers_KSVConnectionString2
        'MsgBox(cn.ConnectionString)
        cn.Open()
        Dim sql As New OleDb.OleDbCommand("SELECT Workers_KSV.FIO As ФИО, Departments_KSV.Title As Отдел, Posts_KSV.Title As Должность FROM Posts_KSV INNER JOIN (Departments_KSV INNER JOIN Workers_KSV ON Departments_KSV.ID = Workers_KSV.DepartmentID) ON Posts_KSV.ID=Workers_KSV.PostId", cn)
        Dim da As New OleDb.OleDbDataAdapter
        Dim DataSqlTable As New DataTable
        da.SelectCommand = sql
        da.Fill(DataSqlTable)
        cn.Close()
        'Dim RowCB As DataRow
        'For Each RowCB In DataSqlTable.Rows
        '    MsgBox(RowCB("FIO") & ", " & (RowCB("DTitle") & ", " & (RowCB("PTitle"))))
        'Next RowCB
        Form2.OutGridView.DataSource = DataSqlTable
        Form2.Show()
    End Sub

    Private Sub ButtonBuhg_Click(sender As Object, e As EventArgs) Handles ButtonBuhg.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = My.Settings.Workers_KSVConnectionString2
        cn.Open()
        Dim sql As New OleDb.OleDbCommand("SELECT Workers_KSV.FIO AS ФИО, Posts_KSV.Title, Departments_KSV.Title FROM Posts_KSV INNER JOIN (Departments_KSV INNER JOIN Workers_KSV ON Departments_KSV.ID = Workers_KSV.DepartmentID) ON (Posts_KSV.ID = Workers_KSV.PostId) AND (Posts_KSV.ID = Workers_KSV.PostId) WHERE (((Workers_KSV.[PostId]) Like '10'));", cn)
        Dim da As New OleDb.OleDbDataAdapter
        Dim DataSqlTable As New DataTable
        da.SelectCommand = sql
        da.Fill(DataSqlTable)
        cn.Close()
        Form2.OutGridView.DataSource = DataSqlTable
        Form2.Show()
    End Sub

    Private Sub ButtonBuhOk_Click(sender As Object, e As EventArgs) Handles ButtonBuhOk.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = My.Settings.Workers_KSVConnectionString2
        cn.Open()
        Dim sql As New OleDb.OleDbCommand("SELECT Workers_KSV.FIO AS ФИО, Posts_KSV.Title, Departments_KSV.Title FROM Posts_KSV INNER JOIN (Departments_KSV INNER JOIN Workers_KSV ON Departments_KSV.ID = Workers_KSV.DepartmentID) ON (Posts_KSV.ID = Workers_KSV.PostId) AND (Posts_KSV.ID = Workers_KSV.PostId) WHERE (((Workers_KSV.[PostId]) Like '10')) AND Workers_KSV.[DepartmentID] Like '6';", cn)
        Dim da As New OleDb.OleDbDataAdapter
        Dim DataSqlTable As New DataTable
        da.SelectCommand = sql
        da.Fill(DataSqlTable)
        cn.Close()
        Form2.OutGridView.DataSource = DataSqlTable
        Form2.Show()
    End Sub

    Private Sub ButtonBuhIvan_Click(sender As Object, e As EventArgs) Handles ButtonBuhIvan.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = My.Settings.Workers_KSVConnectionString2
        cn.Open()
        Dim sql As New OleDb.OleDbCommand("SELECT Workers_KSV.FIO AS ФИО, Posts_KSV.Title, Departments_KSV.Title FROM Posts_KSV INNER JOIN (Departments_KSV INNER JOIN Workers_KSV ON Departments_KSV.ID = Workers_KSV.DepartmentID) ON (Posts_KSV.ID = Workers_KSV.PostId) AND (Posts_KSV.ID = Workers_KSV.PostId) WHERE (((Workers_KSV.[PostId]) Like '10')) AND Workers_KSV.[FIO] Like '%Иван%';", cn)
        Dim da As New OleDb.OleDbDataAdapter
        Dim DataSqlTable As New DataTable
        da.SelectCommand = sql
        da.Fill(DataSqlTable)
        cn.Close()
        Form2.OutGridView.DataSource = DataSqlTable
        Form2.Show()
    End Sub

    Private Sub ПросмотрИИзменениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПросмотрИИзменениеToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub ДобавлениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавлениеToolStripMenuItem.Click
        Dialog1.Show()
    End Sub

    Private Sub ЗавершениеРаботыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗавершениеРаботыToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ДобавлениеToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДобавлениеToolStripMenuItem1.Click
        Dialog2.Show()
    End Sub

    Private Sub ЛToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЛToolStripMenuItem.Click
        Dialog2.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub


    Private Sub СвязанныеТаблицыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СвязанныеТаблицыToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub
End Class