Public Class ControlStructures

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        ' Define variables
        Dim CounterInteger As Integer
        Dim TestString As String

        ' Initialize counter variable
        CounterInteger = 1

        ' Perform loop until CounterInteger >= 10
        Do Until CounterInteger > 10
            ' Append counter integer to OutputLabel.Text,
            ' only append a space if we are not at the
            ' end of the loop (no trailing space)
            OutputLabel.Text &= CounterInteger.ToString
            If CounterInteger <> 10 Then
                OutputLabel.Text &= " "
            End If

            ' Increment Counter variable by one
            CounterInteger += 1
        Loop

        ' Reset Integer
        CounterInteger = 1

        ' Do While loop example
        Do While CounterInteger < 10
            OutputLabel2.Text &= CounterInteger.ToString
            If CounterInteger <> 9 Then
                OutputLabel2.Text &= " "
            End If

            CounterInteger += 1
        Loop

        ' Reset Integer
        CounterInteger = 1

        ' Do Loop While example
        Do
            OutputLabel3.Text &= CounterInteger.ToString
            If CounterInteger <> 9 Then
                OutputLabel3.Text &= " "
            End If

            CounterInteger += 1
        Loop While CounterInteger < 10

        ' For Next loop example
        For CounterInteger = 1 To 10 Step 1
            ' Add counter value to label
            OutputLabel4.Text &= CounterInteger.ToString
            ' Test if counter is at last value, if not, append a space
            ' to the label value
            If CounterInteger <> 10 Then
                OutputLabel4.Text &= " "
            End If
        Next CounterInteger

        ' For Next loop example
        For CounterInteger = 1 To 10 Step 1
            ' Add counter value to label
            OutputLabel5.Text &= CounterInteger.ToString
            ' Test if counter is at last value, if not, append a space
            ' to the label value
            If CounterInteger <> 10 Then
                OutputLabel5.Text &= " "
            End If

            If CounterInteger = 3 Then
                Exit For
            End If
        Next CounterInteger

        ' For Next loop example
        For CounterInteger = 1 To 10 Step 1
            ' Add counter value to label
            OutputLabel6.Text &= CounterInteger.ToString

            If CounterInteger = 3 Then
                Continue For
            End If

            ' Test if counter is at last value, if not, append a space
            ' to the label value
            If CounterInteger <> 10 Then
                OutputLabel6.Text &= " "
            End If
        Next CounterInteger

        TestString = "A"

        Select Case TestString
            Case "A"
                MessageBox.Show("Super")
            Case "B"
                MessageBox.Show("Good")
            Case "C"
                MessageBox.Show("Average")
            Case "D", "F"
                MessageBox.Show("Better luck next time")
            Case Else
                MessageBox.Show("Error determining grade")
        End Select

    End Sub

    Private Sub DentalButton_Click(sender As Object, e As EventArgs) Handles DentalButton.Click
        ' Calculate the bill

        ' Initialize variables
        Dim TempCounterInteger As Integer

        Dim CLEANING_COST_INTEGER As Integer = 135
        Dim FILLING_COST_INTEGER As Integer = 195
        Dim XRAY_COST_INTEGER As Integer = 150

        ' Check if name was entered
        ' #1. Inequality test
        If PatientNameTextBox.Text <> String.Empty Then
            If (CleaningCheckBox.Checked = True) OrElse
                (FillingCheckBox.Checked = True) Then
                (XRayCheckBox.Checked = True) Then

                If (CleaningCheckBox.Checked = True) Then
                    TempCounterInteger += CLEANING_COST_INTEGER
                End If
                If (FillingCheckBox.Checked = True) Then
                    TempCounterInteger += FILLING_COST_INTEGER
                End If
                If (XRayCheckBox.Checked = True) Then
                    TempCounterInteger += XRAY_COST_INTEGER
                End If

                TotalTextBox.Text = TempCounterInteger.ToString("c")
            Else
                MessageBox.Show("Please make at least one selection",
                                "Proceduce selection error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Please enter your name",
                            "Name entry error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End If

        ' #2. Equality test
        'If PatientNameTextBox.Text = String.Empty Then
        '   Display warning
        'Else
        '   Proceed
        'End If

        ' #3. Negation test
        'If Not (PatientNameTextBox.Text = String.Empty) Then
        '   Proceed
        'Else
        '   Display warning
        'End If

    End Sub
End Class
