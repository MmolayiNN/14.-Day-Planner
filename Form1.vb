Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then


            MsgBox("Hi since the weather is sunny today. Here are your daily activities:")

            Activities.Items.Add("Go for a walk")
            Activities.Items.Add("Have a picnic with friends")
            Activities.Items.Add("Play outdoor sport like soccer or netball")

            MsgBox("Hi, Since it is sunny outside, I suggest you go for a walk, have a picnic with friends or play an outdoor sport")

        ElseIf RadioButton2.Checked = True Then
            Activities.Items.Clear()

            MsgBox("Hi,since the weather is cloudy today. Here are your daily activities:")

            Activities.Items.Add("Read a book at a cozy cafe.")
            Activities.Items.Add("Watch a movie at home or in a theater")
            Activities.Items.Add("Visit a museum or art gallery.")

            MsgBox("Hi, Since it is cloudy outside, I suggest you Read a book at a cozy cafe,Watch a movie at home or in a theater or Visit a museum or art gallery.")

        ElseIf RadioButton3.Checked = True Then

            MsgBox("Hi,since the weather is rainy today. Here are your daily activities:")

            Activities.Items.Add("Stay indoors and watch movies")
            Activities.Items.Add("Read a book by the fireplace ")
            Activities.Items.Add(" Play board games with friends or family")

            MsgBox("Hi, since it is rainy outside. Here are your daily activities: Stay indoors and watch movies, Read a book by the fireplace or Play board games with friends or family.")

        Else
            MsgBox("ghy ")

        End If



    End Sub
End Class
