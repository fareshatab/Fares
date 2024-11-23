using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assi18
{
    

public class GameInventoryTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            Inventory potition = new Inventory();
            Inventory elixirs = new Inventory();
            potition.AddItem("Healing Potion");
            potition.AddItem("Strength Potion");
            elixirs.AddItem("Dark Elixir");
            elixirs.AddItem("Elixir");
            Inventory combainList = new Inventory();
            combainList = potition + elixirs ;
            combainList.ShowItem();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}