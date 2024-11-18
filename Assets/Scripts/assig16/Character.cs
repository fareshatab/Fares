using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
namespace assigment18
{
public class Character
{
    public string name;
    private int health;
    protected Position position;
    
    public Character(string name , int health, Position position){
        this.name = name;
        this.health = health;
        this.position = position;
    } 
    public Character(): this("No Name", 100 , new Position(0,0,0))
    {

    }

    public int Health{
        get => health;
        set{
            if(value <0){
                health =0;
            }
            else if(value>100){
                health = 100;
            }
            else health=value;
        }

    }
public virtual void DisplayInfo(){
    
    UnityEngine.Debug.Log(name );
    UnityEngine.Debug.Log(Health );
    position.printPosition();
}

public void Attack(int damage , Character target){
   target.health = health -damage;

}
public void Attack(int damage , Character target, string attacktype){
   target.health = health -damage;
   UnityEngine.Debug.Log(attacktype);

}
}
}
