using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace domitiqueProject
{
    class ZoneServices
    {
        DataTable dataTable = new DataTable();
        private String parametres = "SERVER=127.0.0.1;DATABASE=domotique;UID=root;password=";
        private MySqlConnection maConnexion;

        public ArrayList findAll()
        {
            ArrayList zoneList = new ArrayList();
            dataTable.Clear();

            maConnexion = new MySqlConnection(parametres);
            maConnexion.Open();
            string request = "select * from zone";
            MySqlCommand cmd = new MySqlCommand(request, maConnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            int i = 0;
            Object[] myArray = new Object[3];
            foreach (DataRow row in dataTable.Rows)
            {
                Zone zone;
                i = 0;
                foreach (var item in row.ItemArray)
                {
                    myArray[i] = item;
                    i++;
                }
                zone = new Zone((int)myArray[0], (string)myArray[1], (string)myArray[2]);
                zoneList.Add(zone);

            }
            return zoneList;


        }

        public Zone findById(int id)
        {

            maConnexion = new MySqlConnection(parametres);
            maConnexion.Open();
            string request = "select from zone where id=" + id + " ";
            MySqlCommand cmd = new MySqlCommand(request, maConnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            int i = 0;
            Object[] myArray = new Object[3];

            foreach (DataRow row in dataTable.Rows)
            {

                Zone zone;
                i = 0;
                foreach (var item in row.ItemArray)
                {
                    myArray[i] = item;
                    i++;
                }
                zone = new Zone((int)myArray[0], (string)myArray[2], (string)myArray[2]);
                return zone;
            }
            return null;

        }
    }
}

