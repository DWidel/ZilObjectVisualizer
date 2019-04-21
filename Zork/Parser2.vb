Public Class Parser2



    Public Sub ParseFile(Filename As String)

        Dim Lines() As String = IO.File.ReadAllLines(Filename)

    End Sub


    Public Sub Parse(txt)

        While True

            Dim o As Object = ParseNextThing(txt)

        End While

    End Sub

    'Read the next thing.
    Private Function ParseNextThing(txt) As Object



    End Function



End Class
