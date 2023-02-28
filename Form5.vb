Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet_Select_W_2_Koinov.DataTable1". При необходимости она может быть перемещена или удалена.
        FillWorkersList()
    End Sub
    Public Sub FillWorkersList()
        Me.DataTable1TableAdapter.Fill(Me.DataSet_Select_W_2_Koinov.DataTable1)
        Dim items(4) As String 'создаём массив для подэлементов элементов списка
        Dim TempRow_KSV As DataRow
        For Each Row As DataRow In
                Me.DataSet_Select_W_2_Koinov.DataTable1.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            items(3) = Row(3)
            items(4) = Row(4)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListView1.Items.Add(it)
        Next Row
    End Sub
End Class