using DomezyDomotique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace domitiqueProject
{

    class Objet
    {
        private int id;
        private rooms zone;
        private String nom;
        private int connecte;
        private int demarre;
        private String description;
        private int x;
        private int y;



        public Objet(rooms zone, string nom, int connecte, int demarre)
        {

            this.zone = zone;
            this.nom = nom;
            this.connecte = connecte;
            this.demarre = demarre;
           
        }

        public Objet(rooms zone, string nom, string description, int connecte, int demarre, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.zone = zone;
            this.nom = nom;
            this.connecte = connecte;
            this.demarre = demarre;
            this.description = description;
        }

        public Objet(int id, rooms zone, string nom, string description, int connecte, int demarre)
        {
            this.id = id;
            this.zone = zone;
            this.nom = nom;
            this.connecte = connecte;
            this.demarre = demarre;
            this.description = description;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public String getNom()
        {
            return this.nom;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public rooms getZone()
        {
            return this.zone;
        }
        public void setZone(rooms zone)
        {
            this.zone = zone;
        }

        public int getConnecte()
        {
            return this.connecte;
        }
        public void setConnect(int connecte)
        {
            this.connecte = connecte;
        }

        public int getDemarre()
        {
            return this.demarre;
        }
        public void setDemarre(int demarre)
        {
            this.demarre = demarre;
        }

        public String getDescription()
        {
            return this.description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


        override
        public String ToString()
        {
            return this.nom;
        }
    }

}
