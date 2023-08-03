using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;

namespace AniChat
{
    public static class Info
    {
        public static string ConStr { get; set; }
        public static int idUser { get; set; }
        public static string nameUser { get; set; }
        public static string Rank { get; set; }
        public static string GitLink { get; set; }
        public static string InLink { get; set; }
        //public static BindingSource bs1 { get; set; }
        public static string pathToFoto { get; set; }

        public static DataTable SelectFromDB(string commandString)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Info.ConStr))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(commandString, connection))
                {
                    try
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо з'єднатися з SQL-сервером!",
                            "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return dataTable;
        }

        public static int InsertToDB(string commandString)
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(Info.ConStr))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(commandString, connection))
                {
                    try
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо з'єднатися з SQL-сервером!",
                            "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return id;
        }

        public static void DeleteFromDB(string commandString)
        {
            using (MySqlConnection connection = new MySqlConnection(Info.ConStr))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(commandString, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо з'єднатися з SQL-сервером!",
                            "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void UploadFileToDB(string path, string commandString)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                byte[] rawData;

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    int fileSize = (int)fs.Length;
                    rawData = new byte[fileSize];
                    fs.Read(rawData, 0, fileSize);
                }

                using (MySqlConnection connection = new MySqlConnection(Info.ConStr))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(commandString, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@File", rawData);
                            command.Parameters.AddWithValue("@Filename", Path.GetFileNameWithoutExtension(path));
                            command.Parameters.AddWithValue("@Extension", Path.GetExtension(path));

                            command.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Неможливо з'єднатися з SQL-сервером!",
                                "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public static byte[] DownloadFileFromDB(string commandString)
        {
            byte[] data = null;

            using (MySqlConnection connection = new MySqlConnection(Info.ConStr))
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                data = (byte[])reader.GetValue(0);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо з'єднатися з SQL-сервером!",
                            "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return data;
        }
        
        public static string EncriptedPassword(string sPass)
        {
            if (string.Compare(sPass, "null", true) == 0)
                return "NULL";
            byte[] bytes = Encoding.Unicode.GetBytes(sPass);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHach = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHach)
                hash += String.Format("{0:x2}", b);
            return hash;
        }
    }
}
