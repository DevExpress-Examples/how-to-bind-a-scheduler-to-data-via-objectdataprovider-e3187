Imports Microsoft.VisualBasic
Imports System

Namespace WpfApplication1
	Public Class CustomEvent
		Private start As DateTime
        Private [end] As DateTime
		Private subject_Renamed As String
		Private status_Renamed As Integer
		Private description_Renamed As String
		Private label_Renamed As Long
		Private location_Renamed As String
		Private allday_Renamed As Boolean
		Private eventType_Renamed As Integer
		Private recurrenceInfo_Renamed As String
		Private reminderInfo_Renamed As String

		Public Property StartTime() As DateTime
			Get
				Return start
			End Get
			Set(ByVal value As DateTime)
				start = value
			End Set
		End Property
		Public Property EndTime() As DateTime
			Get
				Return [end]
			End Get
			Set(ByVal value As DateTime)
				[end] = value
			End Set
		End Property
		Public Property Subject() As String
			Get
				Return subject_Renamed
			End Get
			Set(ByVal value As String)
				subject_Renamed = value
			End Set
		End Property
		Public Property Status() As Integer
			Get
				Return status_Renamed
			End Get
			Set(ByVal value As Integer)
				status_Renamed = value
			End Set
		End Property
		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				description_Renamed = value
			End Set
		End Property
		Public Property Label() As Long
			Get
				Return label_Renamed
			End Get
			Set(ByVal value As Long)
				label_Renamed = value
			End Set
		End Property
		Public Property Location() As String
			Get
				Return location_Renamed
			End Get
			Set(ByVal value As String)
				location_Renamed = value
			End Set
		End Property
		Public Property AllDay() As Boolean
			Get
				Return allday_Renamed
			End Get
			Set(ByVal value As Boolean)
				allday_Renamed = value
			End Set
		End Property
		Public Property EventType() As Integer
			Get
				Return eventType_Renamed
			End Get
			Set(ByVal value As Integer)
				eventType_Renamed = value
			End Set
		End Property
		Public Property RecurrenceInfo() As String
			Get
				Return recurrenceInfo_Renamed
			End Get
			Set(ByVal value As String)
				recurrenceInfo_Renamed = value
			End Set
		End Property
		Public Property ReminderInfo() As String
			Get
				Return reminderInfo_Renamed
			End Get
			Set(ByVal value As String)
				reminderInfo_Renamed = value
			End Set
		End Property
	End Class
End Namespace
