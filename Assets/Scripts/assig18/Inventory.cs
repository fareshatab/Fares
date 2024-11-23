using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assi18
{
  

public class Inventory : MonoBehaviour
{
  private List<String> names =new List<string>() ;
  public void AddItem(String item){
    names.Add(item);
  }
  public void ShowItem()
  {
    foreach (var item in names)
    {
      Debug.Log(item);
    }
  }

  public static Inventory  operator + (Inventory a , Inventory b){
    Inventory result = new Inventory();
    result.names.AddRange(a.names);
    result.names.AddRange(b.names);
    return result;
  }
  
}
}