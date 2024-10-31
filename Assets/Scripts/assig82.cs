using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assig82 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] sentences = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int i = 0;
        string result = "";  
    while (i < 7)
    {
        int randomNumber = Random.Range(0, sentences.Length);
        result += sentences[randomNumber] + " "; // إضافة كل كلمة عشوائية للمجموعة
        i++;
    }

    Debug.Log(result.Trim());     
}
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
