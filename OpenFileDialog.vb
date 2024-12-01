Imports System.Windows.Forms

Public Class OpenFileDialog
    Dim LastSelectedItem As ListViewItem
    Private Sub OpenFileDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillWorkersList()
    End Sub
    Public Sub FillWorkersList()
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Workers_KSV". При необходимости она может быть перемещена или удалена.
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Posts_KSV". При необходимости она может быть перемещена или удалена.
        Me.Posts_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Posts_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Departments_KSV". При необходимости она может быть перемещена или удалена.
        Me.Departments_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Departments_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Picture". При необходимости она может быть перемещена или удалена.
        Me.PictureTableAdapter.Fill(Me.Workers_KSVDataSet.Picture)
        ListView1.Items.Clear()
        Dim items(2) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
            Me.Workers_KSVDataSet.Picture.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListView1.Items.Add(it)
        Next Row
        Me.ListView1.Items(0).Selected = True
        Me.ListView1.Focus()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        LastSelectedItem = e.Item
        Dim CurrentWorkerRow As DataRow =
            Workers_KSVDataSet.Picture.Select("ID_Picture = '" & LastSelectedItem.Text & "'")(0)
        'MsgBox(CurrentWorkerRow("Picture"))
        'PicBox_PhotoWorkers.Image = Image.FromFile(
        '    IO.Directory.GetCurrentDirectory & "\Picture\" & CurrentWorkerRow("Picture"))
        Try
            PictureBox1.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\Picture\" & CurrentWorkerRow("NameFile"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Обработк исключений", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Stack trace: " & vbCrLf & ex.StackTrace, "Обработчик исключений")
        Finally
            'MessageBox.Show("Конечный блок")
        End Try
    End Sub

    Private Sub PictureBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PictureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Workers_KSVDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dialog3.ShowDialog()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        ListView1.Update()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    End Sub
End Class
