Partial Class Workers_KSVDataSet
    Partial Public Class PictureDataTable
        Private Sub PictureDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ID_PictureColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class
End Class
