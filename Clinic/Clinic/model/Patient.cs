using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.model
{
    public class Patient
    {
        
        private List<string> diagnosis;

        private StatePatient state;

        private string name;

        public Patient()
        {
            this.name = "Tramp";
            this.diagnosis = new List<string>();
            this.state = StatePatient.HEALTHY;
        }

        public Patient(string diagnos)
        {
            this.name = "Tramp";
            this.diagnosis = new List<string>();
            this.diagnosis.Add(diagnos);
            this.state = StatePatient.SICK;
        }

        public Patient(string diagnos,string name)
        {
            this.name = name;
            this.diagnosis = new List<string>();
            this.diagnosis.Add(diagnos);
            this.state = StatePatient.SICK;
        }

        public void AddDiagnos(string diagnos)
        {
            this.diagnosis.Add(diagnos);
            this.state = StatePatient.SICK;
        }

        public StatePatient getState()
        {
            return state;
        }

        public void Kill()
        {
            this.state = StatePatient.DIED;
        }

        public void Healthier()
        {
            this.state = StatePatient.DIED;
        }

        public string getDiagnos(int index)
        {
            if (index >= diagnosis.Count || index <= 0)
                throw new Exception();

            return diagnosis.ElementAt(index);
        }

        public string getDiagnos(string title)
        {
            return diagnosis.Find(x => x == title);
        }

        public List<string> getDiagnos()
        {
            return diagnosis;
        }

        public string getName()
        {
            return name;
        }

        public string toString()
        {
            return "Patient -> " + this.name + " State ->  " + this.state ;
        }

    }

    public enum StatePatient
    {
        SICK,
        HEALTHY,
        DIED
    }
}
