Public Class FileExplorer
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ListFiles(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    Private Sub ListFiles(ByVal FolderPath As String)
        FileListBox.Items.Clear()
        Dim FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.jp*g")
        For Each FileName As String In FileNames
            FileListBox.Items.Add(FileName)
        Next
        FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.gif")
        For Each FileName As String In FileNames
            FileListBox.Items.Add(FileName)
        Next
        FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
        For Each FileName As String In FileNames
            FileListBox.Items.Add(FileName)
        Next
        FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.bmp")
        For Each FileName As String In FileNames
            FileListBox.Items.Add(FileName)
        Next
    End Sub

    Private Sub SetPictureButton_Click(sender As Object, e As EventArgs) Handles SetPictureButton.Click
        If FileListBox.SelectedItem Is Nothing Then
            MessageBox.Show("Пожалуйста, выберите файл")
            Exit Sub
        End If
        Dim FilePath = FileListBox.SelectedItem.ToString
        MessageBox.Show(FilePath)
        If My.Computer.FileSystem.FileExists(FilePath) = False Then
            MessageBox.Show("Файл не найден: " & FilePath)
        End If
        Dim sNameFile As String = My.Computer.FileSystem.GetFileInfo(FilePath).Name
        'MessageBox.Show("Имя файла: " & sNameFile)
        Dim sFolderPic As String = IO.Directory.GetCurrentDirectory & "\Picture\"
        'MessageBox.Show("Путь к Picture: " & sFolderPic)
        'Dim sNewFilePath As String = sFolderPic & "Дата" & sNameFile
        'MessageBox.Show("Путь + новое имя файла: " & sNewFilePath)
        Dim sNewFilePath As String = sFolderPic & Format(DateTime.Now, "dd.MM.yyyy_HH.mm.ss") & "_" & sNameFile
        'MessageBox.Show("Путь + новое имя файла: " & sNewFilePath)
        'MessageBox.Show("Текущее время: " & Format(DateTime.Now, "dd.MM.yyyy_HH.mm.ss") & "_" & sNameFile)
        Try
            My.Computer.FileSystem.CopyFile(FilePath, sNewFilePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Обработка исключений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        'ProgressBar.Visible = True
        'ProgressBar.Value += 100
        'If ProgressBar.Value = 100 Then
        '    MessageBox.Show("Копирование завершено")
        '    ProgressBar.Visible = False
        '    ProgressBar.Value = 0
        'End If
        Try
            Dialog1.FileNamesTextBox.Text = My.Computer.FileSystem.GetFileInfo(sNewFilePath).Name
            Dialog1.PicBoxDialog.Image = Nothing
            Dialog1.PicBoxDialog.Image = Image.FromFile(sNewFilePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Обработчик исключений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Dialog1.Refresh()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub FileListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileListBox.SelectedIndexChanged

    End Sub
End Class