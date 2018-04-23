Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows
Imports System.ComponentModel

Namespace WpfApplication1
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
    Public Class CustomEventProvider
        Private Shared ReadOnly Rnd As New Random()
        Private Shared Users() As String = {"Peter Dolan", "Ryan Fischer", "Andrew Miller", _
                                            "Tom Hamlett", "Jerry Campbell", "Carl Lucas", _
                                            "Mark Hamilton", "Steve Lee"}

        Public Shared Function GetCustomEvents() As BindingList(Of CustomEvent)
            Dim result As BindingList(Of CustomEvent) = New BindingList(Of CustomEvent)()
            Dim count As Integer = Users.Count()
            For i As Integer = 0 To count - 1
                Dim subjPrefix As String = Users(i) & "'s "
                result.Add(CreateEvent(subjPrefix & "meeting", 2, 5))
                result.Add(CreateEvent(subjPrefix & "travel", 3, 6))
                result.Add(CreateEvent(subjPrefix & "phone call", 0, 10))
            Next i
            Return result
        End Function

        Private Shared Function CreateEvent(ByVal subject As String, _
                                            ByVal status As Integer, ByVal label As Integer) As CustomEvent
            Dim apt As New CustomEvent()
            apt.Subject = subject
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(Rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(Rnd.Next(0, rangeInMinutes \ 4))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function
    End Class
End Namespace