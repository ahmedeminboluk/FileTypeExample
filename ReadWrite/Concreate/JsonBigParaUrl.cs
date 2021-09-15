using Newtonsoft.Json;
using ReadWrite.Interfaces;
using ReadWrite.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace ReadWrite.Concreate
{
    public class JsonBigParaUrl : IProcessType
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-PPUQGQU\\SQLEXPRESS;Database=DataExample;Trusted_Connection=True;MultipleActiveResultSets=true");
        public void Save(IEntity entity)
        {
            AllBigPara allBigPara = new AllBigPara();
            allBigPara = (AllBigPara)entity;
            try
            {
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
                    Console.WriteLine("Json-BigPara-Url Okuma ve Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("İşlem Sırasında Hata Oluştu. =>> " + ex.Message);
            }
        }

        public IEntity Read()
        {
            var url = "https://s.hurriyet.com.tr/dinamik/mainpageservices/bigpara.json";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Credentials = CredentialCache.DefaultCredentials;
            var httpResponse = httpRequest.GetResponse();
            string result = null;

            using (var stream = ((HttpWebResponse)httpResponse).GetResponseStream())
            {
                result = stream != null ? new StreamReader(stream).ReadToEnd() : null;
            }

            var items = JsonConvert.DeserializeObject<List<BigPara>>(result);
            AllBigPara allBigPara = new AllBigPara();
            allBigPara.BigParas = items;
            return allBigPara;
        }
    }
}
