using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplacationTable : MonoBehaviour
{
   
    void Start()
    {
         int Multi (int i , int num)
         {
           int value = i * num;
           return value ;
         }

         for(int i = 1 ;i<=10 ; i++){
          Debug.Log("5 *" + i +" =" + Multi(i,5));
         }


    }

   
}
