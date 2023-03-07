using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domitiqueProject
{
    class Zone
    {
        private int id;
        private String nom;
        private String description;

        public Zone(int id, String nom, String description)
        {
            this.id = id;
            this.nom = nom;
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

        public String getDescription()
        {
            return this.description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }

        override
        public string ToString()
        {
            return this.nom;
        }
    }
}