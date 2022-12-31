Imports System.Data.OleDb

Public Class Form2

    Dim con As New OleDbConnection
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.Database2DataSet1.Table1)
        'TODO: This line of code loads data into the 'Database2DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database2DataSet.Table1)

    End Sub

    ' To Insert Data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\GAD Project\Database2.accdb")
        con.Open()

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox6.Text = "") Then
            MsgBox("Please fill all fields", , "Required")
        Else
            Dim InsertString As String
            InsertString = "Insert into Table1( ID, Name, Price, MFG_Date, EXP_Date) values('" + TextBox6.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
            Dim cmd As New OleDbCommand(InsertString, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Inserted Successfully", , "Success")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
            con.Close()
        End If

    End Sub

    'To Show Data
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\GAD Project\Database2.accdb")
        con.Open()
        Dim cmd As New OleDbCommand("Select * from Table1", con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Table1")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Table1"
        con.Close()

    End Sub

    ' To Delete Data
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\GAD Project\Database2.accdb")
        con.Open()

        If (TextBox5.Text = "") Then
            MsgBox("Please enter the medicine ID to delete data", , "Required")
        Else
            Dim DeleteString As String
            DeleteString = "Delete from Table1 where ID = '" + TextBox5.Text + "'"
            Dim cmd As New OleDbCommand(DeleteString, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data deleted successfully", , "Success")
            TextBox5.Clear()
            TextBox5.Focus()
            con.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox7.Text = "" Then
            MsgBox("Please enter a medicine ID or NAME to Search")
        Else

            Table1BindingSource.Filter = "(Convert (ID, 'System.String') LIKE '" & TextBox7.Text & "')" & "OR (Name LIKE  '" & TextBox7.Text & "')"

            If Table1BindingSource.Count <> 0 Then
                With DataGridView2
                    .DataSource = Table1BindingSource
                End With
            Else
                MsgBox("Search result is not found", , "")
                Table1BindingSource.Filter = Nothing
            End If


        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox7.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form3.Show()

    End Sub

End Class