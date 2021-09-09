using ReadWrite.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace ReadWrite
{
    public class XmlTypeAdvertorial : IProcessType
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-JB75S8O\\SQLEXPRESS;Database=DataExample;Trusted_Connection=True;MultipleActiveResultSets=true");
        public IEntity Read()
        {
            TextReader reader = new StreamReader("C:/Users/ahmed/Desktop/DataExample/emlak.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Advertorial));
            Advertorial adv = (Advertorial)serializer.Deserialize(reader);
            return adv;
        }
        public void Save(IEntity entity)
        {
            Advertorial adv = (Advertorial)entity;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM Advertorial", connection);
                commandDelete.ExecuteNonQuery();
                connection.Close();

                foreach (var item in adv.Advs)
                {
                    connection.Open();
                    string save = "insert into Advertorial(Text, DefLink, Location, Price, Title, ImageName, Image, CityId, CityName) values (@Text, @DefLink, @Location, @Price, @Title, @ImageName, @Image, @CityId, @CityName)";
                    SqlCommand command = new SqlCommand(save, connection);
                    command.Parameters.AddWithValue("@Text", item.Text);
                    command.Parameters.AddWithValue("@DefLink", item.DefLink);
                    command.Parameters.AddWithValue("@Location", item.Location);
                    command.Parameters.AddWithValue("@Price", item.Price);
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@ImageName", item.ImageName);
                    command.Parameters.AddWithValue("@Image", item.Image);
                    command.Parameters.AddWithValue("@CityId", item.CityId);
                    command.Parameters.AddWithValue("@CityName", item.CityName);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Console.WriteLine("Xml-Emlak Okuma ve Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("İşlem Sırasında Hata Oluştu. =>> " + ex.Message);
            }
        }
    }
}
