Imports System.Collections.ObjectModel
Imports System.ComponentModel

Public Class DemoVueModel
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub


    Public Property CommandeAjouter As ICommand
    Public Property CommandeModifier As ICommand
    Public Property CommandeSupprimer As ICommand

    Public Property Liste As ObservableCollection(Of Personne)
    Public _PersonneActuel As Personne
    Public _index As Integer

    Public Property PersonneActuel As Personne
        Get
            Return _PersonneActuel
        End Get

        Set(ByVal value As Personne)
            If Not value.Equals(_PersonneActuel) Then
                _PersonneActuel = value
                NotifyPropertyChanged("PersonneActuel")
            End If
        End Set
    End Property

    Public Property index As Integer
        Get
            Return _index
        End Get

        Set(ByVal value As Integer)
            If Not value.Equals(_index) Then
                _index = value
                NotifyPropertyChanged("index")
            End If
        End Set
    End Property

    Sub New()
        PersonneActuel = New Personne
        Liste = New ObservableCollection(Of Personne)
        CommandeAjouter = New SimpleCommand(AddressOf Ajouter)
        CommandeModifier = New SimpleCommand(AddressOf Modifier)
        CommandeSupprimer = New SimpleCommand(AddressOf Supprimer)

    End Sub

    Private Sub Ajouter()
        Dim P = New Personne
        P.CpPersonne(PersonneActuel)
        Liste.Add(P)
        PersonneActuel.Init()
    End Sub

    Private Sub Modifier()
        Liste.RemoveAt(index)
        Liste.Add(PersonneActuel)
        PersonneActuel = New Personne

    End Sub

    Private Sub Supprimer()
        Liste.RemoveAt(index)
        PersonneActuel = New Personne
    End Sub
End Class
