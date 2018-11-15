Imports System.ComponentModel

Public Class Personne
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub


    Private _nom As String
    Private _prenom As String
    Private _date_nais As Date
    Private _age As Integer

    Public Property Nom As String
        Get
            Return _nom
        End Get

        Set(ByVal value As String)
            If Not value.Equals(_nom) Then
                _nom = value
                NotifyPropertyChanged("Nom")
            End If
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return _prenom
        End Get

        Set(ByVal value As String)
            If Not value.Equals(_prenom) Then
                _prenom = value
                NotifyPropertyChanged("Prenom")
            End If
        End Set
    End Property


    Public Property Date_nais As Date
        Get
            Return _date_nais
        End Get

        Set(ByVal value As Date)
            If Not value.Equals(_date_nais) Then
                _date_nais = value
                NotifyPropertyChanged("Date_nais")
            End If
        End Set
    End Property


    Public Property Age As Integer
        Get
            Return _age
        End Get

        Set(ByVal value As Integer)
            If Not value.Equals(_age) Then
                _age = value
                NotifyPropertyChanged("Age")
            End If
        End Set
    End Property

    Public Sub New()
        Init()
    End Sub

    Friend Sub CpPersonne(pPersonne As Personne)
        Nom = pPersonne.Nom
        Age = pPersonne.Age
        Date_nais = pPersonne.Date_nais
        Prenom = pPersonne.Prenom
    End Sub

    Public Sub Init()
        Nom = ""
        Age = 0
        Date_nais = Date.Now
        Prenom = ""
    End Sub
End Class
