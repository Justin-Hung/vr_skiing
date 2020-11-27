using System.Collections;

using System.Collections.Generic;
using UnityEngine;


public class Generator : MonoBehaviour
{

    public GameObject objectToGenerate0;
    public GameObject objectToGenerate1;
    public GameObject objectToGenerate2;
    public GameObject objectToGenerate3;

    private int framecounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( (framecounter % 180) == 0 && Globals.gameRunning)
        {
            int rand = Random.Range(0,4);
            GameObject objectToGenerate = objectToGenerate0;
            Vector3 randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.654, (float)0.39);
            string name = "";
            if(rand == 0 )
            {
                //Square
                randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.654, (float)0.39);
                objectToGenerate = objectToGenerate0;
                name = "Cube";
            }
            else if( rand == 1 )
            {
                //Sphere
                randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.63, (float)0.39);
                objectToGenerate = objectToGenerate1;
                name = "Sphere";
            }
            else if( rand == 2 )
            {
                //Cylinder
                randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.881, (float)0.39);
                objectToGenerate = objectToGenerate2;
                name = "Cylinder";
            }
            else if( rand == 3 )
            {
                //Capsule
                randPosition = new Vector3(Random.Range((float)-1.6,  (float) 1.15), (float)0.855, (float)0.39);
                objectToGenerate = objectToGenerate3;
                name = "Capsule";
            }
            else
            {
                //Should not happen
            }
            GameObject obj = Instantiate(objectToGenerate, randPosition, Quaternion.identity);
            obj.name = name;    
            Destroy(obj, 10); //Destroy the obj in 10 seconds so we don't use up lots of hardware resources on it.
            framecounter = 0;
        }
        framecounter++;
    }
}
