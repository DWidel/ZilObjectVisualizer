Public Class Parser

    Public Event LogText(txt As String)
    Public Directions As clsDirections
    Public Rooms As New List(Of clsRoom)
    Public Objects As New List(Of clsObject)
    Public Globals As New List(Of clsGlobal)
    Public Routines As New List(Of clsRoutine)
    Public Syntaxes As New List(Of clsSyntax)
    Public Synonyms As New List(Of clsSynonym)
    Public Macros As New List(Of clsMacro)
    Public Path As String = ""
    Public InsertFile As String = ""

    Public LogTextLst As New List(Of String)
    Public LastFileInserted As String
    Public LastCmd As String

    Private Enum Mode
        None
        Text
        Command
    End Enum


    Public Sub ParseFile(Filename As String)
        Path = IO.Path.GetDirectoryName(Filename)
        LastFileInserted = IO.Path.GetFileName(Filename)
        Dim Mode As Mode

        Dim txt As String = IO.File.ReadAllText(Filename)

        Dim Garbage As String = ""
        Dim CurrentTxt As String = ""
        Dim BracketCount As Integer = 0
        Dim InQuotes As Boolean = False
        Dim PrevC As String = ""
        Dim PrevPrevC As String = ""
        Dim i As Integer = 0

        Do

            Dim C As String = txt.Substring(i, 1)

            Select Case Mode
                Case Mode.None
                    If C = """" Then
                        Mode = Mode.Text
                        CurrentTxt = C
                    ElseIf C = "<" Then
                        Mode = Mode.Command
                        BracketCount = 1
                        CurrentTxt = C
                    ElseIf C = "(" And PrevC = ";" Then
                        'advance to next ")"
                        Dim ParenCtr As Integer = 1
                        Do
                            i += 1
                            PrevPrevC = PrevC
                            PrevC = C
                            C = txt.Substring(i, 1)
                            If C = ")" Then ParenCtr -= 1
                            If C = "(" Then ParenCtr += 1

                        Loop Until ParenCtr = 0
                        Dim ii As Integer = 0
                    Else

                        Garbage &= C
                    End If

                Case Mode.Command
                    CurrentTxt &= C

                    If CurrentTxt.Contains("OBJECT TUBE") Then
                        Dim ii As Integer = 0
                    End If

                    If InQuotes Then
                        If C = """" Then
                            ' Not a quote if it's escaped, but it is if the escape was escaped.
                            ' Not, right but seems to work.
                            If PrevC <> "\" OrElse (PrevC = "\" AndAlso PrevPrevC = "\") Then
                                InQuotes = False
                            End If
                        End If

                    Else
                        If C = """" Then
                            If PrevC <> "\" OrElse (PrevC = "\" AndAlso PrevPrevC = "\") Then
                                InQuotes = True
                            End If
                        End If

                        'Missing angle bracket in Arthur.    My parsing must be completely wrong .
                        If LastFileInserted.ToUpper = "PASSWORD.ZIL" Then
                            If CurrentTxt.Contains("ROUTINE RT-PS-STONE-TOWER") Then
                                If C = vbLf AndAlso PrevC = vbLf Then
                                    C = ">"
                                End If

                            End If
                        End If





                        If C = ">" Then
                                BracketCount -= 1
                                If BracketCount <= 0 Then
                                Mode = Mode.None



                                If Garbage.EndsWith(";") Then
                                        'this is commented out?
                                        Dim ii As Integer = 0
                                    Else
                                        NewCommand(CurrentTxt)

                                    End If
                                    If InsertFile <> "" Then
                                        'We want to insert text from a file.
                                        Dim NewFilename As String = IO.Path.Combine(Path, InsertFile & ".zil")
                                        InsertFile = ""
                                        If IO.File.Exists(NewFilename) Then

                                            Dim NewText As String = IO.File.ReadAllText(NewFilename)
                                        txt = txt.Insert(i + 1, NewText)
                                        LastFileInserted = IO.Path.GetFileName(NewFilename)
                                            Me.LogTextLst.Add("######################################################################")
                                            Me.LogTextLst.Add("######                                       Inserted File: " & NewFilename)
                                            Me.LogTextLst.Add("######################################################################")
                                        Else
                                            Me.LogTextLst.Add("######################################################################")
                                            Me.LogTextLst.Add("######                                       Missing File: " & NewFilename)
                                            Me.LogTextLst.Add("######################################################################")
                                            ' Throw New Exception("Missing File: " & NewFilename)
                                        End If

                                    End If
                                    Garbage = ""
                                    CurrentTxt = ""
                                End If
                            End If
                            If C = "<" Then
                                BracketCount += 1
                            End If

                        End If


                        Case Mode.Text
                    CurrentTxt &= C
                    If C = """" Then
                        Mode = Mode.None
                        NewText(CurrentTxt)
                        Garbage = ""
                        CurrentTxt = ""
                    End If
            End Select



            PrevPrevC = PrevC
            PrevC = C
            i += 1
        Loop Until i >= txt.Length

        Me.LogTextLst.Add("Last File Inserted: " & LastFileInserted)

    End Sub

    Public Sub Finish()
        SetDirections
        GetFlagsDic()
        GeRoutineDic()
        GetObjRefDic()
    End Sub
    Public Sub NewText(txt As String)
        If txt.Length > 500 Then
            Dim ii As Integer = 0
        End If
        LogTextLst.Add(txt)
        RaiseEvent LogText(txt)
    End Sub

    Public Sub SetDirections()
        If Directions IsNot Nothing Then
            For Each R As clsRoom In Rooms
                R.SetDirections(Directions)


            Next


        End If



    End Sub


    Public Sub NewCommand(txt As String)

        If txt.Length > 400 Then
            Dim ii As Integer = 0
        End If

        Dim command As String = ""
        'Dim i As Integer = txt.IndexOf(" ")
        'If i < 0 Then
        '    Throw New Exception("Invalid Command:" & txt)
        'End If
        txt = TrimTxt(txt)


        command = GetFirstWord(txt)

        Dim secondword As String = ""

        secondword = GetSecondWord(txt, True)



        LogTextLst.Add("CMD " & command & " " & secondword)



        Select Case command
            Case "DIRECTIONS"
                Directions = New clsDirections(txt)
            Case "ROOM"
                Dim R As New clsRoom(txt)
                Rooms.Add(R)
            Case "OBJECT"
                Dim O As New clsObject(txt)
                Objects.Add(O)
            Case "GLOBAL"
                Dim G As New clsGlobal(txt, clsGlobal.VarType.Global)
                Globals.Add(G)
            Case "ROUTINE"
                If secondword = "RT-RM-PARADE-AREA" Then
                    Dim ii As Integer = 0
                End If
                Dim R As New clsRoutine(txt)
                Routines.Add(R)
            Case "SYNTAX"
                Dim R As New clsSyntax(txt)
                Syntaxes.Add(R)
            Case "SYNONYM"
                Dim R As New clsSynonym(txt)
                Synonyms.Add(R)
            Case "GDECL"
                'GDECL (WATER-LEVEL) FIX
                'GDECL (LIGHT-SHAFT) FIX
                'GDECL (BEACH-DIG) FIX
                'TODO
                Dim ii As Integer = 0
            Case "CONSTANT"
                'CONSTANT F-BUSY? 1
                'CONSTANT F-DEAD 2
                'CONSTANT F-UNCONSCIOUS 3
                'CONSTANT F-CONSCIOUS 4
                'CONSTANT F-FIRST? 5
                'TODO
                Dim G As New clsGlobal(txt, clsGlobal.VarType.Constant)
                Globals.Add(G)
            Case "COND"
                'TODO
                Dim ii As Integer = 0
            Case "BUZZ"
                '       <BUZZ AGAIN G OOPS>

                '<BUZZ A AN THE IS AND OF THEN ALL ONE BUT EXCEPT \. \, \" YES NO Y HERE>
                'TODO
                Dim ii As Integer = 0
            Case "SETG"
                'TODO:
            Case "DEFMAC"
                Dim R As New clsMacro(txt)
                Macros.Add(R)
            Case "DEFINE"
                'TRY ROUTINE for Bureaucracy
                Dim R As New clsRoutine(txt)
                Routines.Add(R)


            Case "VERSION"
                'todo
            Case "SET"
            Case "OR"
            Case "PRINC"
            Case "FREQUENT-WORDS?"
            Case "INSERT-FILE", "IFILE", "INCLUDE"
                InsertFile = TrimQuotes(GetSecondWord(txt))
                If InsertFile = "CHURCH" Then
                    Dim ii As Integer = 0
                End If
            Case "PROPDEF"

            Case "SNAME" 'HHGTTG
            Case "BLOAT" 'deadfall
            Case "ENDLOAD" 'deadfall
            Case "INSERT-CRUFTY" 'deadfall
            Case "GC-MON" 'deadfall
            Case "GC" 'deadfall

            Case "ZSTR-OFF" 'starcross
            Case "IMAGE"
            Case "LONG-WORDS?" 'Lurking Horror
            Case "TELL-TOKENS"
            Case "DEBUG-CODE"
            Case "PREP-SYNONYM"
                Dim R As New clsSynonym(txt)
                R.Type = "PREP"
                Synonyms.Add(R)
            Case "VERB-SYNONYM"
                Dim R As New clsSynonym(txt)
                R.Type = "VERB"
                Synonyms.Add(R)
            Case "ADJ-SYNONYM"
                Dim R As New clsSynonym(txt)
                R.Type = "ADJ"
                Synonyms.Add(R)
            Case "ZSTART"
            Case "VOC" 'LeatherGoddesses
            Case "DIR-SYNONYM"
                Dim R As New clsSynonym(txt)
                R.Type = "DIR"
                Synonyms.Add(R)
            Case "READ" 'moonmist
            Case "PUT" 'moonmist
            Case "PUT-PURE-HERE" 'nordandbert
            Case "GETP"
            Case "SCREEN"
            Case "HLIGHT"
            Case "DIROUT"
            Case "FILE-FLAGS"
            Case "ZIP-OPTIONS" 'Journey
            Case "COMPILATION-FLAG"
            Case "DEFINE-SEGMENT" 'journey
            Case "BEGIN-SEGMENT" 'journey
            Case "END-SEGMENT" 'journey
            Case "IF-DEBUGGING" 'journey 'TODO
            Case "COMMAND"
            Case "GDEF"
            Case "ZSTR-ON" 'cutthroats
            Case "FUNNY-GLOBALS?"
            Case "ZZSECTION", "ZSECTION"
            Case "ENDSECTION"
            Case "USE"
            Case "SET-DEFSTRUCT-FILE-DEFAULTS"
            Case "MSETG"
            Case "DEFSTRUCT"
            Case "DEFINE20"
            Case "BUILD-FORM"
            Case "DEFINE-GLOBALS"
            Case "LINK" 'HollywoodHijinx  'TODO?


            Case "ROUTINE-FLAGS"
                LogTextLst.Add(txt)

            Case Else
                LogTextLst.Add("###################    UNKNOWN COMMAND: " & command & "#################")
        End Select




    End Sub

    Public Function GetRoutine(Name As String) As clsRoutine
        For Each R As clsRoutine In Routines
            If R.Name = Name Then Return R
        Next

        Return Nothing

    End Function
    Public Function GetRoom(Name As String) As clsRoom
        For Each R As clsRoom In Rooms
            If R.Name = Name Then Return R
        Next

        Return Nothing

    End Function

    Public Function GetObject(Name As String) As clsObject
        For Each R As clsObject In Objects
            If R.Name = Name Then Return R
        Next

        Return Nothing

    End Function



    Public Function GetObjectsInRoomOrObject(Name As String) As List(Of clsObject)
        Dim lst As New List(Of clsObject)
        For Each R As clsObject In Objects
            If R.IsIn = Name OrElse R.Location = Name Then lst.Add(R)
        Next

        Return lst

    End Function

    Public FlagDic As Dictionary(Of String, List(Of String))


    Private Sub GetFlagsDic()

        FlagDic = New Dictionary(Of String, List(Of String))


        For Each R As clsRoom In Rooms
            For Each flag As String In R.Flags
                If Not FlagDic.ContainsKey(flag) Then
                    FlagDic.Add(flag, New Generic.List(Of String))
                End If
                FlagDic(flag).Add("R-" & R.Name)
            Next
        Next

        For Each R As clsObject In Objects
            For Each flag As String In R.Flags
                If Not FlagDic.ContainsKey(flag) Then
                    FlagDic.Add(flag, New Generic.List(Of String))
                End If
                FlagDic(flag).Add("O-" & R.Name)
            Next
        Next

        For Each flag As String In FlagDic.Keys
            For Each act As clsRoutine In Routines
                If act.Value.Contains(flag) Then
                    FlagDic(flag).Add("A-" & act.Name)
                End If
            Next

        Next


    End Sub

    Public RoutineDic As Dictionary(Of String, List(Of String))

    'This is a list of where a routine is used.  Checks Room, objects and does text search in other routines
    Private Sub GeRoutineDic()

        RoutineDic = New Dictionary(Of String, List(Of String))


        For Each R As clsRoom In Rooms
            If R.Action IsNot Nothing Then
                Dim Act As String = R.Action

                If Not RoutineDic.ContainsKey(Act) Then
                    RoutineDic.Add(Act, New Generic.List(Of String))
                End If
                Dim val As String = "R-" & R.Name
                If Not RoutineDic(act).Contains(val) Then RoutineDic(act).Add(val)
            End If

            For Each act As String In R.Pseudos.Values
                If Not RoutineDic.ContainsKey(act) Then
                    RoutineDic.Add(act, New Generic.List(Of String))
                End If
                Dim val As String = "R-" & R.Name
                If Not RoutineDic(act).Contains(val) Then RoutineDic(act).Add(val)
            Next
        Next

        For Each R As clsObject In Objects
            If R.Action IsNot Nothing Then

                Dim Act As String = R.Action
                If Not RoutineDic.ContainsKey(Act) Then
                    RoutineDic.Add(Act, New Generic.List(Of String))
                End If
                Dim val As String = "O-" & R.Name
                If Not RoutineDic(Act).Contains(val) Then RoutineDic(Act).Add(val)
            End If

            If R.DESCFCN IsNot Nothing Then
                Dim Act As String = R.DESCFCN
                If Not RoutineDic.ContainsKey(Act) Then
                    RoutineDic.Add(Act, New Generic.List(Of String))
                End If
                Dim val As String = "O-" & R.Name
                If Not RoutineDic(Act).Contains(val) Then RoutineDic(Act).Add(val)
            End If

        Next

        For Each flag As String In RoutineDic.Keys
            For Each act As clsRoutine In Routines
                If act.Value.Contains(flag) Then
                    RoutineDic(flag).Add("A-" & act.Name)
                End If
            Next

        Next


    End Sub


    Public ObjRefDic As Dictionary(Of String, List(Of String))
    'This is a list of where an object is used.  Checks Room, objects and does text search in   routines
    Private Sub GetObjRefDic()

        ObjRefDic = New Dictionary(Of String, List(Of String))


        For Each R As clsRoom In Rooms
            For Each ObjName As String In R.Objects
                If Not ObjRefDic.ContainsKey(ObjName) Then
                    ObjRefDic.Add(ObjName, New Generic.List(Of String))
                End If
                Dim val As String = "R-" & R.Name
                If Not ObjRefDic(ObjName).Contains(val) Then ObjRefDic(ObjName).Add(val)
            Next
        Next

        For Each R As clsObject In Objects
            For Each ObjName As String In R.Objects
                If Not ObjRefDic.ContainsKey(ObjName) Then
                    ObjRefDic.Add(ObjName, New Generic.List(Of String))
                End If
                Dim val As String = "O-" & R.Name
                If Not ObjRefDic(ObjName).Contains(val) Then ObjRefDic(ObjName).Add(val)
            Next
        Next


        For Each ObjName As String In RoutineDic.Keys
            For Each Rtn As clsRoutine In Routines
                If Rtn.Value.Contains(ObjName) Then
                    RoutineDic(ObjName).Add("A-" & Rtn.Name)
                End If
            Next

        Next


    End Sub



    Public Function GetSyn(Name As String) As clsSynonym
        For Each R As clsSynonym In Synonyms
            If R.Name = Name Then Return R
        Next

        Return Nothing

    End Function
End Class
