Public Class frmLoader

    Public SelectedFile As String

    Private Sub frmLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LastFileLoaded.Trim <> "" Then
            txtFilename.Text = My.Settings.LastFileLoaded.Trim
        End If
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        '  C:\Temp\infocom\abyss-master\abyss.zil 
        ' C:\Temp\infocom\amfv-master\s5.zil
        ' C:\Temp\infocom\arthur-master\narthur.zil 
        ' C:\Temp\infocom\ballyhoo-master\m4.zil
        ' C:\Temp\infocom\beyondzork-master\beyond.zil  
        ' C:\Temp\infocom\borderzone-master\spy.zil
        ' C:\Temp\infocom\bureaucracy-master\b.zil  
        ' C:\Temp\infocom\checkpoint-master\spy.zil
        ' C:\Temp\infocom\cutthroats-master\toa.zil
        '  C:\Temp\infocom\deadline-master\deadline.zil
        ' C:\Temp\infocom\enchanter-master\enchanter.zil  
        ' C:\Temp\infocom\hitchhikersguide-master\s4.zil 
        ' C:\Temp\infocom\hollywoodhijinx-master\anthill.zil
        ' C:\Temp\infocom\infidel-master\infidel.zil
        ' C:\Temp\infocom\journey-master\journey.zil  'not good
        ' C:\Temp\infocom\leathergoddesses-master\x1.zil
        ' C:\Temp\infocom\lurkinghorror-master\h1.zil
        ' C:\Temp\infocom\minizork-1987-master\mini.zil
        ' C:\Temp\infocom\moonmist-master\m5.zil
        ' C:\Temp\infocom\nordandbert-master\j3.zil
        ' C:\Temp\infocom\planetfall-master\planetfall.zil
        ' C:\Temp\infocom\plunderedhearts-master\r1.zil
        ' C:\Temp\infocom\restaurant-master\h2.zil
        ' C:\Temp\infocom\seastalker-master\seastalker.zil   
        ' C:\Temp\infocom\sherlock-master\gamesound.zil  
        ' C:\Temp\infocom\shogun-master\a5.zil
        ' C:\Temp\infocom\sorcerer-master\sorcerer.zil
        ' C:\Temp\infocom\spellbreaker-master\z6.zil
        ' C:\Temp\infocom\starcross-master\starcross.zil
        ' C:\Temp\infocom\stationfall-master\s6.zil
        ' C:\Temp\infocom\suspended-master\suspended.zil
        ' C:\Temp\infocom\trinity-master\tr.zil 'no rooms
        ' C:\Temp\infocom\wishbringer-master\j2.zil
        ' C:\Temp\infocom\witness-master\witness.zil
        ' C:\Temp\infocom\zork1-master\zork1.zil
        ' C:\Temp\infocom\zork2-master\zork2.zil
        ' C:\Temp\infocom\zork3-master\zork3.zil
        ' C:\Temp\infocom\zorkzero-master\zork0.zil

        If Not IO.File.Exists(txtFilename.Text) Then
            MsgBox("Unable to load file.")
            Exit Sub
        End If
        My.Settings.LastFileLoaded = txtFilename.Text
        SelectedFile = txtFilename.Text
        Game = New Parser
        Game.ParseFile(txtFilename.Text)
        Game.Finish()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class