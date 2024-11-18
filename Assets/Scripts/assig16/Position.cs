using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assigment18
{
public struct Position
{
public float x,y,z;
public Position(float x, float y , float z){
    this.x = x;
    this.y = y;
    this.z = z;
} 
public void printPosition(){
    Debug.Log(x);
    Debug.Log(y);
    Debug.Log(z);

}







}
}