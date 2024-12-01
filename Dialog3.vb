Imports System.Windows.Forms

Public Class Dialog3

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim Rows() As DataRow
        Dim PictureID

        Rows = OpenFileDialog.Workers_KSVDataSet.Picture.Select("ID_Worker ='" & ComboBox1.Text & "'")

        If Rows.Length = 0 Then
            OpenFileDialog.PictureTableAdapter.Insert(TextBoxPhotoName.Text, ComboBox1.Text)
            OpenFileDialog.PictureTableAdapter.Fill(OpenFileDialog.Workers_KSVDataSet.Picture)
            Rows = OpenFileDialog.Workers_KSVDataSet.Picture.Select("ID_Worker ='" & ComboBox1.Text & "'")
            PictureID = Rows(0)("ID_Worker")
        Else
            PictureID = Rows(0)("ID_Worker")
        End If
        'OpenFileDialog.PictureTableAdapter.Insert(TextBoxPhotoName.Text, ComboBox1.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Workers_KSV". При необходимости она может быть перемещена или удалена.
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSelectFile.Click
        FileExplorer.ShowDialog()
    End Sub

    Private Sub Workers_KSVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers_KSVBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Workers_KSVDataSet)

    End Sub
End Class
