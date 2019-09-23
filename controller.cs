using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
 
    int bronze, silver;
    int bronzeSupply, silverSupply;
    float mineNow;
    float miningSpeed;

    // Start is called before the first frame update
    void Start()
    {
    
        bronze = 0;
        silver = 0;
        silverSupply = 3;
        bronzeSupply = 3;
        miningSpeed = 3;
        mineNow = miningSpeed;

    }

    // Update is called once per frame
    void Update()
    { if(Time.time > mineNow)
        {
            mineNow += miningSpeed;
            if (bronzeSupply>0)
            {
                bronzeSupply--;
                bronze++;
            }
            else if(silverSupply>0)
                {  
                silverSupply--;
                silver++;
            }


            print("Bronze: " + bronze + " ... Silver:" + silver);

        }
        
    }
}
