using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.model
{
    public class Departament
    {
        private List<Patient> listPatient;

        private string Title;

        public Departament()
        {
            this.Title = "NoName";
            this.listPatient = new List<Patient>();
        }

        public Departament(string title)
        {
            this.Title = title;
            this.listPatient = new List<Patient>();
        }

        public void JoinPatient(Patient patient)
        {
            
            listPatient.Add(patient);
        }

        public bool KickPatient(Patient patient)
        {
            patient.Healthier();
            return listPatient.Remove(patient);
        }
        public int SearchDiagnos(string title)
        {
           int count = 0;

           foreach(var item in listPatient )
            {
                if(item.getDiagnos(title)!=null)
                {
                    count++;
                }
            }

            return count;
        }

        public string toString()
        {
            return "Departament -> " + this.Title;
        }

        
    }
}
