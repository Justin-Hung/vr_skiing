using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour
{

    public Text gameText;

    private int framecounter = 0;

    private int currentScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Globals.gameRunning)
        {
            gameText.text = "Dodge the Incoming Objects!\nScore: " + currentScore; 
        }
        else
        {
            gameText.text = "Touch the floor to start the game."; 
            currentScore = 0;
        }

        if(framecounter >= 180)
        {
            framecounter = 0;
            currentScore += 10;
        }
        framecounter++;
    }
}
