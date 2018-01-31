using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameStoreWcfServiceLibrary
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-B4P8S8M";
            connStringBuilder.InitialCatalog = "GameStore.Data_Access_Layer.StoreGameContext";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertGame(Game G)
        {
            try
            {
                comm.CommandText = ("SET IDENTITY_INSERT Game ON");
                comm.CommandText = ("INSERT INTO Game VALUES(@TypeId, @Name, @Description, @Premiere, @Rating, @OrToBuy, @NameFileNews, @NameFileBestseller, @NameFileRecomended, @OrRecommended)");
                //comm.CommandText = ("INSERT INTO Game VALUES(@ID, @TypeId, @Name, @Description, @Premiere, @Rating, @OrToBuy, @NameFileNews, @NameFileBestseller, @NameFileRecomended, @OrRecommended)");
                //comm.CommandText = ("INSERT INTO Game (GameId, GameTypeId, GameName, GameDescription, GamePremiere, GameRating, OrToBuy, NameFileNews, NameFileBestseller, NameFileRecomended, OrRecommended) VALUES(@ID, @TypeId, @Name, @Description, @Premiere, @Rating, @OrToBuy, @NameFileNews, @NameFileBestseller, @NameFileRecomended, @OrRecommended)");
                //comm.Parameters.AddWithValue("ID", G.GameId);
                comm.Parameters.AddWithValue("TypeId", G.GameTypeId);
                comm.Parameters.AddWithValue("Name", G.GameName);
                comm.Parameters.AddWithValue("Description", G.GameDescription);
                comm.Parameters.AddWithValue("Premiere", G.GamePremiere);
                comm.Parameters.AddWithValue("Rating", G.GameRating);
                comm.Parameters.AddWithValue("OrToBuy", G.OrToBuy);
                comm.Parameters.AddWithValue("NameFileNews", G.NameFileNews);
                comm.Parameters.AddWithValue("NameFileBestseller", G.NameFileBestseller);
                comm.Parameters.AddWithValue("NameFileRecomended", G.NameFileRecomended);
                comm.Parameters.AddWithValue("OrRecommended", G.OrRecommended);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int UpdateGame(Game G)
        {
            try
            {
                //comm.CommandText = "UPDATE Game SET TypeId='"+ G.GameTypeId + "', Name='" + G.GameName + "', Description='" + G.GameDescription + "', Premiere='" + G.GamePremiere + "', Rating='" + G.GameRating + "', OrToBuy='" + G.OrToBuy + "', NameFileNews='" + G.NameFileNews + "', NameFileBestseller='" + G.NameFileBestseller + "', NameFileRecomended='" + G.NameFileRecomended + "', OrRecommended='" + G.OrRecommended + "' WHERE GameId= '" + G.GameId + "'";
                comm.CommandText = "UPDATE Game SET GameTypeId=@GameTypeId, GameName=@GameName, GameDescription=@GameDescription, GamePremiere=@GamePremiere, GameRating=@GameRating, OrToBuy=@OrToBuy, NameFileNews=@NameFileNews, NameFileBestseller=@NameFileBestseller, NameFileRecomended=@NameFileRecomended, OrRecommended=@OrRecommended WHERE GameId= '" + G.GameId + "'";

                //comm.Parameters.AddWithValue("ID", G.GameId);
                comm.Parameters.AddWithValue("@GameTypeId", G.GameTypeId);
                comm.Parameters.AddWithValue("@GameName", G.GameName);
                comm.Parameters.AddWithValue("@GameDescription", G.GameDescription);
                comm.Parameters.AddWithValue("@GamePremiere", G.GamePremiere);
                comm.Parameters.AddWithValue("@GameRating", G.GameRating);
                comm.Parameters.AddWithValue("@OrToBuy", G.OrToBuy);
                comm.Parameters.AddWithValue("@NameFileNews", G.NameFileNews);
                comm.Parameters.AddWithValue("@NameFileBestseller", G.NameFileBestseller);
                comm.Parameters.AddWithValue("@NameFileRecomended", G.NameFileRecomended);
                comm.Parameters.AddWithValue("@OrRecommended", G.OrRecommended);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int DeleteGame(Game G)
        {
            try
            {
                comm.CommandText = "DELETE from Game WHERE GameId= '"+G.GameId+"'";
                //comm.Parameters.AddWithValue("ID", G.GameId);

                //comm.CommandText = "DELETE Game WHERE Name=@Name";
                //comm.Parameters.AddWithValue("Name", G.GameName);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Game GetGame(Game G)
        {
            Game game = new Game();

            try
            {

                //comm.CommandText = "SELECT Game WHERE GameId= '" + G.GameId + "'";
                //comm.Parameters.AddWithValue("ID", G.GameId);

                comm.CommandText = "SELECT * from Game";
                //comm.Parameters.AddWithValue("Name", G.GameName);

                comm.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    game.GameId = Convert.ToInt32(reader[0]);
                    game.GameTypeId = Convert.ToInt32(reader[1]);
                    game.GameName = reader[2].ToString();
                    game.GameDescription = reader[3].ToString();
                    game.GamePremiere = Convert.ToDateTime(reader[4]);
                    game.GameRating = Convert.ToInt32(reader[5]);
                    game.OrToBuy = Convert.ToBoolean(reader[6]);
                    game.NameFileNews = reader[7].ToString();
                    game.NameFileBestseller = reader[8].ToString();
                    game.NameFileRecomended = reader[9].ToString();
                    game.OrRecommended = Convert.ToBoolean(reader[10]);
                }
                return game;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<Game> GetAllGame()
        {
            List<Game> gameL = new List<Game>();
            try
            {
                comm.CommandText = "SELECT * FROM Game";
                comm.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Game game = new Game()
                    {
                        GameId = Convert.ToInt32(reader[0]),
                        GameTypeId = Convert.ToInt32(reader[1]),
                        GameName = reader[2].ToString(),
                        GameDescription = reader[3].ToString(),
                        GamePremiere = Convert.ToDateTime(reader[4]),
                        GameRating = Convert.ToInt32(reader[5]),
                        OrToBuy = Convert.ToBoolean(reader[6]),
                        NameFileNews = reader[7].ToString(),
                        NameFileBestseller = reader[8].ToString(),
                        NameFileRecomended = reader[9].ToString(),
                        OrRecommended = Convert.ToBoolean(reader[10]),
                    };
                    gameL.Add(game);


                }
                return gameL;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}
