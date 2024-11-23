using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace assi18{



public class testGeneric : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     GameCountainer<String> x = new GameCountainer<string>() ;
        x.SetItem("Healing Potion .");
        string y = x.GetItem();
        Debug.Log(y);
        Debug.Log(GameUtils.DescribeItem(x));
    }

    void Update()
    {
        
    }
}
}