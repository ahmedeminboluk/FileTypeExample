using Newtonsoft.Json;
using ReadWrite.Interfaces;
using ReadWrite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ReadWrite
{
    public class JsonTypeBigPara : IFileType
    {

        SqlConnection connection = new SqlConnection("Server=DESKTOP-JB75S8O\\SQLEXPRESS;Database=DataExample;Trusted_Connection=True;MultipleActiveResultSets=true");
        public IEntity Read()
        {
            StreamReader r = new StreamReader("C:/Users/ahmed/Desktop/DataExample/bigpara.json");
            string json = r.ReadToEnd();
            List<BigPara> items = JsonConvert.DeserializeObject<List<BigPara>>(json);
            AllBigPara allBigPara = new AllBigPara();
            allBigPara.BigParas = items;
            return allBigPara;
        }

        public void Create(IEntity entity)
        {
            AllBigPara allBigPara = new AllBigPara();
            allBigPara = (AllBigPara)entity;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM BigPara", connection);
                commandDelete.ExecuteNonQuery();
                connection.Close();

                foreach (var item in allBigPara.BigParas)
                {
                    connection.Open();
                    string save = "insert into BigPara(Title, Spot, Description, Link, ImagePath, Category, Orderr) values (@Title,@Spot,@Description,@Link, @ImagePath, @Category, @Orderr)";
                    SqlCommand command = new SqlCommand(save, connection);
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Spot", item.Spot);
                    command.Parameters.AddWithValue("@Description", DBNull.Value);
                    command.Parameters.AddWithValue("@Link", item.Link);
                    command.Parameters.AddWithValue("@ImagePath", item.ImagePath);
                    command.Parameters.AddWithValue("@Category", item.Category);
                    command.Parameters.AddWithValue("@Orderr", item.Order);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Json-BigPara Okuma ve Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("İşlem Sırasında Hata Oluştu. =>> " + ex.Message);
            }
        }        
    }
}
