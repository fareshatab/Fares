using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player
{
    public string name = "";
    public int helth ;
   public static int playerCount = 0;
     public void initilizePlayer(string name, int helth){
        playerCount++;
        this.name = name;
        this.helth = helth;
     }
     public void Heal(int amount){
      if (amount + helth>=100){
         helth = 100;
      }
      else if (amount + helth <=0){
         helth = 0;
      }
      else{
         helth = helth+amount;
      }
      Debug.Log("The Player Helth Is =" + " "+helth);
     }
     public void Heal(bool fullRestore){
      if(fullRestore ==true){
         helth = 100;
         Debug.Log("The Player Helth Is =" + " "+helth);
      }
     }
     public static void ShowPlayerCount(){
       Debug.Log("The player Count is"+ " " +playerCount );

     }
}
