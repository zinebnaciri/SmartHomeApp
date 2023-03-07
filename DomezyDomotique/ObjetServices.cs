
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domitiqueProject
{
    class ObjetServices
    {
        ZoneServices zoneServe = new ZoneServices();
        DataTable dataTable = new DataTable();
        private String parametres = "SERVER=localhost;DATABASE=domezy;UID=root;password=";
        private MySqlConnection maConnexion;

        public void create(Objet o)
        {
            maConnexion = new MySqlConnection(parametres);
            maConnexion.Open();
            MySqlCommand command = maConnexion.CreateCommand();
            command.CommandText = "INSERT INTO items VALUES ('',@zoneId,@objetNom,@connect,@x,@y)";
            command.Parameters.AddWithValue("@zoneId", o.getZone().getId());
            command.Parameters.AddWithValue("@objetNom", o.getNom());
          
            command.Parameters.AddWithValue("@connect", o.getConnecte());
           
            command.Parameters.AddWithValue("@x", o.X);
            command.Parameters.AddWithValue("@y", o.Y);
            command.ExecuteNonQuery();
            maConnexion.Close();





        }


        public void delete(int id)
        {
            maConnexion = new MySqlConnection(parametres);
            maConnexion.Open();
            MySqlCommand command = maConnexion.CreateCommand();
            command.CommandText = "DELETE FROM objet WHERE id=@id ";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            maConnexion.Close();
        }

      /*  public Objet findById(int id)
        {
            Objet objet;
            maConnexion = new MySqlConnection(parametres);
            maConnexion.Open();
            string request = "select from objet where id=" + id + " ";
            MySqlCommand cmd = new MySqlCommand(request, maConnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            int i = 0;
            Object[] myArray = new Object[6];
            foreach (DataRow row in dataTable.Rows)
            {

                i = 0;
                foreach (var item in row.ItemArray)
                {
                    myArray[i] = item;
                    i++;
                }
                objet = new Objet((int)myArray[0], zoneServe.findById((int)myArray[1]), (string)myArray[2], (string)myArray[3], (int)myArray[4], (int)myArray[5]);
                return objet;
            }
            return null;
        }*/
    }
}
