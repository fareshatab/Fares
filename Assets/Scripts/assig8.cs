using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int randomNumber = Random.Range(1,21);
            if (randomNumber != 5 && randomNumber!=15)
            {
                Debug.Log(randomNumber);
            }
            else if (randomNumber ==5) continue;
            else if (randomNumber==15) break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
