using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject silverCubePrefab;
    public GameObject bronzeCubePrefab;
    public Vector3 cubePosition;
    public int score;
    int bronze, silver;
    int bronzeSupply, silverSupply;
    float mineNow;
    float miningSpeed;
    int xPos, yPos;
    // Start is called before the first frame update
    void Start()
    {
    
        bronze = 0;
        silver = 0;
        silverSupply = 3;
        bronzeSupply = 3;
        miningSpeed = 3;
        mineNow = miningSpeed;
        xPos = 0;
        yPos = 2;
        score = 0;
    }

    int ScorePoints(int pointsToScore)
    {
        score += pointsToScore;
        if ( pointsToScore == 1)
        {
            print("Way to go! You scored " + pointsToScore + " point! Your total score is: " + score); 
        }
        else if (pointsToScore > 1)
        {
            print("Way to go! You scored " + pointsToScore + " points! Your total score is: " + score);
        }
        
        return score;
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
                cubePosition = new Vector3(xPos, 0, 0);
                Instantiate(bronzeCubePrefab, cubePosition, Quaternion.identity);
                xPos += 2;

                ScorePoints(1);
            }
            else if(silverSupply>0)
                {
                xPos -= 2;
                silverSupply--;
                silver++;
                cubePosition = new Vector3(xPos,yPos, 0);
                Instantiate(silverCubePrefab, cubePosition, Quaternion.identity);

                ScorePoints(10);
            }


            print("Bronze: " + bronze + " ... Silver:" + silver);
            
        }
        
    }
}
