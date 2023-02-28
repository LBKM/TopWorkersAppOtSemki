Public Class Form3
    Private Sub Departments_KSVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.Departments_KSVBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Workers_KSVDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Workers_KSV". При необходимости она может быть перемещена или удалена.
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Posts_KSV". При необходимости она может быть перемещена или удалена.
        Me.Posts_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Posts_KSV)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Workers_KSVDataSet.Departments_KSV". При необходимости она может быть перемещена или удалена.
        Me.Departments_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Departments_KSV)

    End Sub

    Private Sub UpDateButtonDep_Click(sender As Object, e As EventArgs) Handles UpDateButtonDep.Click
        Me.Validate()
        Me.Departments_KSVBindingSource.EndEdit()
        Me.Departments_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Departments_KSV)
        Me.Departments_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Departments_KSV)
    End Sub

    Private Sub UpDateButtonPos_Click(sender As Object, e As EventArgs) Handles UpDateButtonPos.Click
        Me.Validate()
        Me.Posts_KSVBindingSource.EndEdit()
        Me.Posts_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Posts_KSV)
        Me.Posts_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Posts_KSV)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Workers_KSVBindingSource.EndEdit()
        Me.Workers_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Workers_KSV)
        Me.Workers_KSVTableAdapter.Fill(Me.Workers_KSVDataSet.Workers_KSV)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Departments_KSVBindingSource.EndEdit()
        Me.Posts_KSVBindingSource.EndEdit()
        Me.Workers_KSVBindingSource.EndEdit()
        Me.Departments_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Departments_KSV)
        Me.Posts_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Posts_KSV)
        Me.Workers_KSVTableAdapter.Update(Me.Workers_KSVDataSet.Workers_KSV)
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormKSV.WorkersListView_KSV.Update()
    End Sub
End Class