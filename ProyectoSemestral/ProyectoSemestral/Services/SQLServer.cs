using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoSemestral.Services
{
    public enum NoteType
    {
        ALL,
        ACTIVE,
        ARCHIVED
    }

    public class SQLServer
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SQLServer()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void SelectNotes(NoteType type = NoteType.ALL)
        {
            string query = "SELECT Id, Title, Content, CreatedAt, UpdatedAt, IsArchived FROM Notes WHERE 1=1";

            switch (type)
            {
                case NoteType.ACTIVE:
                    query += " AND IsArchived = 0";
                    break;
                case NoteType.ARCHIVED:
                    query += " AND IsArchived = 1";
                    break;
            }

            query += " ORDER BY CreatedAt DESC";

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
        }

        public void SearchNotes(string keyword)
        {
            string query = "SELECT Id, Title, Content, CreatedAt, UpdatedAt, IsArchived FROM Notes WHERE (Title LIKE @keyword OR Content LIKE @keyword) ORDER BY CreatedAt DESC";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            reader = command.ExecuteReader();
        }

        public long InsertNote(string title, string content)
        {
            string query = "INSERT INTO Notes (Title, Content, CreatedAt, IsArchived) OUTPUT INSERTED.Id VALUES (@title, @content, GETDATE(), 0)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@content", content);
            return (long)command.ExecuteScalar();
        }

        public bool UpdateNote(long id, string title, string content)
        {
            string query = "UPDATE Notes SET Title = @title, Content = @content, UpdatedAt = GETDATE() WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@content", content);
            return command.ExecuteNonQuery() > 0;
        }

        public bool ToggleArchiveNote(long id, bool archive)
        {
            string query = "UPDATE Notes SET IsArchived = @archive, UpdatedAt = GETDATE() WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@archive", archive);
            return command.ExecuteNonQuery() > 0;
        }

        public bool DeleteNote(long id)
        {
            string query = "DELETE FROM Notes WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public Dictionary<string, object> List()
        {
            var dict = new Dictionary<string, object>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                dict.Add(reader.GetName(i), reader.GetValue(i));
            }
            return dict;
        }

        public bool Read()
        {
            return reader?.Read() ?? false;
        }

        public void Close()
        {
            reader?.Close();
            command?.Dispose();
            connection?.Close();
        }
    }
}