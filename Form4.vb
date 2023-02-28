Public Class Form4
    Private Sub Workers_KSVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers_KSVBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Workers_KSVDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Departments_KSV". При необходимости она может быть перемещена или удалена.
        Me.Departments_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Departments_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Posts_KSV". При необходимости она может быть перемещена или удалена.
        Me.Posts_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Posts_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Workers_KSV". При необходимости она может быть перемещена или удалена.
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)

    End Sub
End Class