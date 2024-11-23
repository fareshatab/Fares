using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assi18{


public class GameCountainer <T>
{
    private T x ;

    public void SetItem(T value){
        x =value;
    }
    public T GetItem(){
        return x;
    }

}
}