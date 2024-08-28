using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CatColor("");
        int x = 7;
        int y = 7;

        if(x == y)
        {
            Debug.Log("wow your numbers are the same value omg");
        }
    }

   void CatColor(string catName)
    {
        switch(catName)
        {
            case "black":
            Debug.Log("you got a black cat!");
                break;

            case "ginger":
                Debug.Log("you got a ginger cat!");
                break;

            case "white":
                Debug.Log("you got a white cat!");
                break;

            default:
                Debug.Log("you got a lot of cats!");
                break;

        }
    }
}
