Imports MyClassLibrary
Public Class MoreStringOperations
    Inherits AdvancedStringOperations
    Public Overrides Function Palindrome(ByVal s As String) As String
        Dim str As String
        str = StrReverse(s)
        If str.Equals(s) Then
            Return "String is Palindrome."
        Else
            Return "String is not Palindrome."
        End If
    End Function
End Class
Module Module1

    Sub Main()

        Dim strobj As MoreStringOperations

        strobj = New MoreStringOperations()
        Console.WriteLine(strobj.Palindrome("M G M"))

        Console.ReadLine()

    End Sub
End Module
