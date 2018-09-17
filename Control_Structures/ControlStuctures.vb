Public Class ControlStructures

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        ' Define variables
        Dim CounterInteger As Integer

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

    End Sub
End Class
