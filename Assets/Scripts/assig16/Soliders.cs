using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment18
{
    

public class Soliders : Character
{
        private string v1;
        private int v2;
        private (float, float, float) value;

        public Soliders(string name , int health ,Position position):base(name , health , position)
  {

  }

        public Soliders(string v1, int v2, (float, float, float) value)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.value = value;
        }

        public override void DisplayInfo(){
    
    base.DisplayInfo();
    Debug.Log("Solider");
}
}
}