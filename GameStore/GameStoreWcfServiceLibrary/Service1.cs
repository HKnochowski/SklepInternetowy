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
                comm.CommandText = "INSERT INTO TGame VALUES";
                comm.Parameters.AddWithValue("ID", G.GameId);
                comm.Parameters.AddWithValue("Name", G.GameName);
                comm.Parameters.AddWithValue("Description", G.GameDescription);
                comm.Parameters.AddWithValue("Premiere", G.GamePremiere);
                comm.Parameters.AddWithValue("Rating", G.GameRating);
                comm.Parameters.AddWithValue("Type", G.GameType);
                comm.Parameters.AddWithValue("TypeId", G.GameTypeId);

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
    }
}
