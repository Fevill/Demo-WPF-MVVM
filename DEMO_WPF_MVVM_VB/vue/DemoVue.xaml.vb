Public Class DemoVue
    Private Sub DataGrid_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim G As DataGrid = sender
        Dim Context As DemoVueModel = DataContext
        Context.index = G.SelectedIndex
        If G.SelectedIndex <> -1 Then
            Context.PersonneActuel.CpPersonne(G.SelectedItem)
        End If

    End Sub
End Class
