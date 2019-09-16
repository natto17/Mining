using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    int loopOnce = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(loopOnce == 0 && Time.time > 3.0)
        {
            print("It's been three seconds!");
            loopOnce += 1;
        }
        
    }
}
