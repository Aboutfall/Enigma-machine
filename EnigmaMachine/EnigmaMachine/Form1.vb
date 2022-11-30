Public Class Form1
    Dim count As Integer = 0
    Dim Alph As String = "abcdefghijklmnopqrstuvwxyz"
    Dim I As String = "    ekmflgdqvzntowyhxuspaibrcj"
    Dim II As String = "ajdksiruxblhwtmcqgznpyfvoe"
    Dim III As String = "bdfhjlcprtxvznyeiwgakmusqo"
    Dim IV As String = "esovpzjayquirhxlnftgkdcmwb"
    Dim V As String = "vzbrgityupsdnhlxawmjqofeck"
    Dim SetB As String = "YRUHQSLDPXNGOKMIEBFZCWVJAT".ToLower
    Dim SetC As String = "FVPJIAOYEDRZXWGCTKUQSBNMHL".ToLower
    Dim t As Boolean = True
    Dim r1 As Char = I
    Dim r2 As Char = I
    Dim r3 As Char = I
    Dim r4 As Char = I
    Dim r5 As Char = I
    Dim rs1 As Integer = 1
    Dim rs2 As Integer = 1
    Dim rs3 As Integer = 1
    Dim rs4 As Integer = 1
    Dim rs5 As Integer = 1

    Public Function rotor(a As String, b As Integer, c As Char)

        Dim cha As Integer
        Dim setting As String

        ' Finding the rotor setting 
        If c = I Then
            setting = "ekmflgdqvzntowyhxuspaibrcj"
        ElseIf c = II Then
            setting = "ajdksiruxblhwtmcqgznpyfvoe"
        ElseIf c = III Then
            setting = "bdfhjlcprtxvznyeiwgakmusqo"
        ElseIf c = IV Then
            setting = "esovpzjayquirhxlnftgkdcmwb"
        Else
            setting = "vzbrgityupsdnhlxawmjqofeck"
        End If



        For i As Integer = 1 To 26
            If t = True Then
                If a = Alph.Substring(i - 1, 1) Then

                    'shifts the letter
                    cha = ((i - 1) + b) Mod 26

                    ' Converts to setting 
                    a = setting.Substring(cha, 1)

                    'shift the letter back 
                    For j As Integer = 1 To 26
                        'finding what letter it is to shift it by one
                        If a = Alph.Substring(j - 1, 1) Then
                            'shifts the letter back
                            cha = ((26 + ((j - 1) - b)) Mod 26)
                            'assigns value
                            a = Alph.Substring(cha, 1)

                        End If

                    Next
                End If
            Else
                If a = Alph.Substring(i - 1, 1) Then

                    'shifts the letter
                    cha = ((i - 1) + b) Mod 26
                    a = Alph.Substring(cha, 1)
                    For l = 1 To 26
                        If a = setting.Substring(cha, 1) Then
                            ' Converts to setting 
                            a = Alph.Substring(l, 1)
                        End If
                    Next



                    'shift the letter back 
                    For j = 1 To 26
                        'finding what letter it is to shift it by one
                        If a = Alph.Substring(j - 1, 1) Then
                            'shifts the letter back
                            cha = ((26 + ((j - 1) - b)) Mod 26)
                            'assigns value
                            a = Alph.Substring(cha, 1)

                        End If
                    Next


                End If
            End If
        Next

        Return a
    End Function

    Public Function EnigmaMach(a As String)
        Dim rotorCount = 3 + count
        Dim c As String
        Dim b As String = ""
        Dim reflector As String
        If ComboBox1.Text = "B" Then
            reflector = SetB
        Else
            reflector = SetC
        End If
        For i As Integer = 0 To a.Length - 1
            c = a.Substring(i, 1)
            'Quick rotor
            c = rotor(c, rs1, r1)
            rs1 = rs1 + 1
            'Middle
            'rotating
            If rs1 = 26 Then
                rs1 = rs1 Mod 26
                rs2 = rs2 + 1
            End If
            c = rotor(c, rs2, r2)

            'rotating
            If rs2 = 26 Then
                rs2 = rs2 Mod 26
                rs3 = rs3 + 1
            End If

            'slow
            c = rotor(c, rs3, r3)

            'rotating
            If rs3 = 26 Then
                rs3 = rs3 Mod 26
                rs4 = rs4 + 1
            End If
            'rotating


            If rotorCount = 4 Then

                '4th rotor
                c = rotor(c, rs4, r4)

            ElseIf rotorCount = 5 Then
                '5th rotor
                'rotating 
                If rs4 = 26 Then
                    rs4 = rs4 Mod 26
                    rs5 = rs5 + 1
                End If
                c = rotor(c, rs5, r5)

            End If

            'Reflector
            For sp As Integer = 0 To 25

                If c = Alph.Substring(sp, 1) Then

                    c = reflector.Substring(sp, 1)

                End If
            Next

            'Coming back on the rotors
            If rotorCount = 5 Then
                '5th rotor
                c = rotor(c, rs5, r5)
            ElseIf rotorCount = 4 Then
                '4th rotor
                c = rotor(c, rs4, r4)
            End If
            '3rd
            c = rotor(c, rs3, r3)
            '2nd
            c = rotor(c, rs2, r2)
            '1st
            c = rotor(c, rs1, r1)

            b = b + c
        Next
        Return b

    End Function




    Private Sub Enigma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RotorI.Text = "I"
        RotorII.Text = "I"
        RotorIII.Text = "I"
        RotorIV.Text = "I"
        RotorV.Text = "I"
        ComboBox1.Text = "B"

        R1pos.Text = 0
        R2pos.Text = 0
        R3pos.Text = 0
        R4pos.Text = 0
        R5pos.Text = 0


    End Sub

    Private Sub Encrypt_Click(sender As Object, e As EventArgs) Handles Encrypt.Click
        Dim c As String = ""
        Dim d As String = ""
        Dim wordcount As Integer = 0


        'Initiates the enigma machine
        c = EnigmaMach(TextBox1.Text.ToLower)
        For i As Integer = 0 To c.Length - 1

            If wordcount = 5 Then
                d = d + " "
                d = d + c.Substring(i, 1)
                wordcount = 1

            Else
                wordcount = wordcount + 1
                d = d + c.Substring(i, 1)
            End If

        Next
        TextBox2.Text = d
    End Sub



    Private Sub addRotor_Click(sender As Object, e As EventArgs) Handles addRotor.Click

        If count = 0 Then
            RotorIV.Enabled = True
            R4pos.Enabled = True
            RemRotor.Enabled = True
        Else
            RotorV.Enabled = True
            R5pos.Enabled = True
            addRotor.Enabled = False
        End If
        count = count + 1

    End Sub

    Private Sub RemRotor_Click(sender As Object, e As EventArgs) Handles RemRotor.Click

        If count = 1 Then
            RotorIV.Enabled = False
            R4pos.Enabled = False
            RemRotor.Enabled = False

        Else
            RotorV.Enabled = False
            R5pos.Enabled = False
            addRotor.Enabled = True
        End If
        count = count - 1


    End Sub

    Private Sub RotorI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RotorI.SelectedIndexChanged
        r1 = RotorI.Text
    End Sub

    Private Sub RotorII_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RotorII.SelectedIndexChanged
        r2 = RotorII.Text
    End Sub

    Private Sub RotorIII_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RotorIII.SelectedIndexChanged
        r3 = RotorIII.Text
    End Sub

    Private Sub RotorIV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RotorIV.SelectedIndexChanged
        r4 = RotorIV.Text
    End Sub

    Private Sub RotorV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RotorV.SelectedIndexChanged
        r5 = RotorV.Text
    End Sub

    Private Sub R1pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R1pos.SelectedIndexChanged
        rs1 = R1pos.Text
    End Sub

    Private Sub R2pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R2pos.SelectedIndexChanged
        rs2 = R2pos.Text
    End Sub

    Private Sub R3pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R3pos.SelectedIndexChanged
        rs3 = R3pos.Text
    End Sub

    Private Sub R4pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R4pos.SelectedIndexChanged
        rs4 = R4pos.Text
    End Sub

    Private Sub R5pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R5pos.SelectedIndexChanged
        rs5 = R5pos.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 0 Then
            Encrypt.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class