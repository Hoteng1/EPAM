using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.model
{
    public class Clinic
    {
        private List<Departament> departamets;

        private string title;
        
        public  Clinic()
        {
            this.title = "Scrubs";
            this.departamets = new List<Departament>();
        }

        public Clinic(string title)
        {
            this.title = title;
            this.departamets = new List<Departament>();
        }

        public void CreateDepartament(Departament dep)
        {
            departamets.Add(dep);
        }

        public void DeleteDepartament(Departament dep)
        {
            departamets.Remove(dep);
        }

        public string toString()
        {
            return "Clinic -> " + title;
        }


    }
}
