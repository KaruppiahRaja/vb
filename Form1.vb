Public Class Form1
    Dim sl As SortedList = New SortedList()
    Dim oj As Object



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = 0 Then
            sl.Add(TextBox1.Text, TextBox2.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox3.Text = sl.ContainsKey(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox3.Text = sl.ContainsValue(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TextBox3.Text = sl.GetByIndex(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TextBox3.Text = sl.GetKey(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 5 Then
            TextBox3.Text = sl.IndexOfKey(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TextBox3.Text = sl.IndexOfValue(TextBox4.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 7 Then
            oj = TextBox4.Text
            sl.Remove(oj)
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("sorted list element cleared")
        ElseIf ComboBox1.SelectedIndex = 8 Then
            oj = TextBox4.Text
            sl.RemoveAt(oj)
            MsgBox("sorted list element cleared")
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 9 Then
            sl.Clear()
            MsgBox("sorted list cleared")
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf ComboBox1.SelectedIndex = 10 Then
            oj = sl.Count - 1
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            For i = 0 To oj
                TextBox3.Text = TextBox3.Text + "  " + sl.GetKey(i) + ":" + sl.GetByIndex(i)

            Next
        End If
    End Sub
 
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 1 Then
            Label5.Visible = True
            Label5.Text = "enter the key value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            TextBox4.Visible = False
            Label5.Visible = False
        ElseIf ComboBox1.SelectedIndex = 10 Then
            TextBox4.Visible = False
            Label5.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            TextBox4.Visible = False
            Label5.Visible = False


        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label5.Visible = True
            Label5.Text = "enter the  value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label5.Visible = True
            Label5.Text = "enter the  index value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Label5.Visible = True
            Label5.Text = "enter the  index value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Label5.Visible = True
            Label5.Text = "enter the  key value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Label5.Visible = True
            Label5.Text = "enter the   value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Label5.Visible = True
            Label5.Text = "enter the  key value"
            TextBox4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Label5.Visible = True
            Label5.Text = "enter the  index value"
            TextBox4.Visible = True
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox4.Visible = False
        Label5.Visible = False
    End Sub
End Class
