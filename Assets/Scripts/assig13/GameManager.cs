using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    { 
        Player player1 = new Player();
        Player player2 = new Player();
        player1.initilizePlayer("fares", 10);
        player2.initilizePlayer("Nadem", 100);
        player1.Heal(50);
        player2.Heal(90);
        player1.Heal(true);
        Player.ShowPlayerCount();

    }

   
}
