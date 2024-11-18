using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment18{


public class test : MonoBehaviour
{

    void Start()
    {
     Character[] arr = {
           new Soliders("fares", 100,new Position (5.1f, 5.2f, 5.3f)),
           new Officers("Nadem", 100,new Position (10.3f,10.3f, 10.3f))
     };

     for(int i=0 ;i<arr.Length; i++ ){
        arr[i].DisplayInfo();
     }
    Officers officer1 = (Officers)arr[0];
    Soliders solider1 = (Soliders)arr[1];
    Debug.Log("The Solider Health Befor the attac is"+solider1.Health );
    officer1.Attack(20,solider1,"BoooM");
     Debug.Log("The Solider Health After the attac is"+solider1.Health );

        
    }

}
}