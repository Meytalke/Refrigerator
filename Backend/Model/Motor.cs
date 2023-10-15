using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Refrigerator_FinalProj
{
    public class Motor
    {
        private bool isOn;
        private int temperature; 
        private int ColdIntensity;
        private int lightIntensity;

        public bool IsOn { get => isOn; set => isOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public int ColdIntensity1 { get => ColdIntensity; set => ColdIntensity = value; }
        public int LightIntensity { get => lightIntensity; set => lightIntensity = value; }

        public Motor(bool isOn = false)
        {
            IsOn = isOn;
        }
        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public bool IsCooling()
        {
            return isOn;
        }
    }
}