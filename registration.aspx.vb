﻿Imports System.Data.OleDb

Partial Class registration
    Inherits System.Web.UI.Page

    Protected Sub RegisterButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegisterButton.Click
        Dim connect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\Home\Documents\Visual Studio 2012\WebSites\WebSite4\TeamA_WSC_Website_Database.accdb;User ID=Admin;Password=;"
        Dim strInsert As String
        'strInsert = "INSERT INTO Customer (FName, LName, [Address], PhoneNumber, UserName, [Password]) Values (@FName, @LName, @Address, @PhoneNumber, @UserName, @Password)"
        strInsert = "INSERT INTO Customer (FName, LName, [Address], PhoneNumber, UserName, [Password], IsAdmin) Values ('" + FirstName.Text + "','" + LastName.Text + "','" + testAddress.Text + "'," +
            PhoneNumber.Text + ",'" + UserName.Text + "','" + userPassword.Text + "',0)"
        Using conn As New OleDbConnection(connect)
            Using cmdInsert As New OleDbCommand(strInsert, conn)
                'cmdInsert.Parameters.AddWithValue("@FName", FirstName.Text)
                'cmdInsert.Parameters.AddWithValue("@LName", LastName.Text)
                'cmdInsert.Parameters.AddWithValue("@Address", Address.Text)
                'cmdInsert.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(PhoneNumber.Text))
                'cmdInsert.Parameters.AddWithValue("@UserName", UserName.Text)
                'cmdInsert.Parameters.AddWithValue("@Password", Password.Text)
                conn.Open()
                cmdInsert.ExecuteNonQuery()
                Response.Write("Updated Successfully!<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>")
                FirstName.Text = ""
                LastName.Text = ""
                testAddress.Text = ""
                PhoneNumber.Text = ""
                UserName.Text = ""
                userPassword.Text = ""
            End Using
        End Using
    End Sub

End Class
