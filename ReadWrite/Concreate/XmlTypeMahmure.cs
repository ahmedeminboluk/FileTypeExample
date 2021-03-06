using ReadWrite.Interfaces;
using ReadWrite.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace ReadWrite
{
    public class XmlTypeMahmure : IProcessType
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-PPUQGQU\\SQLEXPRESS;Database=DataExample;Trusted_Connection=True;MultipleActiveResultSets=true");
        public IEntity Read()
        {
            

            TextReader reader = new StreamReader("C:/Users/ahmed/Desktop/DataExample/mahmure.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(AllNews));
            AllNews news = (AllNews)serializer.Deserialize(reader);
            return news;
        }

        public void Save(IEntity entity)
        {
            AllNews news = (AllNews)entity;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM News", connection);
                commandDelete.ExecuteNonQuery();
                connection.Close();

                foreach (var item in news.News)
                {
                    connection.Open();
                    string save = "insert into News(Title, Text, ImageName, Image, Link, Date) values (@Title,@Text,@ImageName,@Image, @Link, @Date)";
                    SqlCommand command = new SqlCommand(save, connection);
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Text", item.Text);
                    command.Parameters.AddWithValue("@ImageName", item.ImageName);
                    command.Parameters.AddWithValue("@Image", item.Image);
                    command.Parameters.AddWithValue("@Link", item.Link);
                    command.Parameters.AddWithValue("@Date", item.Date);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Xml-Mahmure Okuma ve Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("İşlem Sırasında Hata Oluştu. =>> " + ex.Message);
            }
        }

        
    }
}
