using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour
{

    public Text gameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Globals.gameRunning)
        {
            gameText.text = "Dodge the Incoming Objects!"; 
        }
        else
        {
            gameText.text = "Touch the floor to start the game."; 
        }
    }
}
