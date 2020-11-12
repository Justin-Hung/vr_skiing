using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generator : MonoBehaviour
{

    public GameObject boxToGenerate;

    public float itemXSpread = 2;

    private int framecounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(framecounter == 180 && Globals.gameRunning)
        {
            Vector3 randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.505, (float)0.39);
            Instantiate(boxToGenerate, randPosition, Quaternion.identity);
            framecounter = 0;
        }
        framecounter++;
    }
}
