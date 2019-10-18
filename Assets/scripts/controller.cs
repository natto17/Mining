using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject silverCubePrefab;
    public GameObject bronzeCubePrefab;
    public GameObject goldCubePrefab;
    GameObject myCube;
    public Vector3 cubePosition;
    public static int points, bronzePoints, silverPoints, goldPoints; //were each of the points supposed to be seperated?
    public static int bronze, silver, gold;
    float mineNow;
    float miningSpeed;
    int xPos, yPos;
    bool justSpawnedGold;
    int cubeRow;

    Ore recentOre;
    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
        bronze = 0;
        silver = 0;
        miningSpeed = 3;
        mineNow = miningSpeed;
        xPos = -4;
        yPos = 2;
        points = 0;
        cubeRow = 0;
        justSpawnedGold = false;
        bronzePoints = 1;
        silverPoints = 10;
        goldPoints = 100;
    }




    // Update is called once per frame
    void Update()
    { if(Time.time > mineNow)
        {
            mineNow += miningSpeed;
            if (bronze == 2 && silver == 2 && justSpawnedGold == false)
            {
                recentOre = Ore.Gold;
                if (cubeRow <= 5)
                {  
                    gold++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                    myCube = Instantiate(goldCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    justSpawnedGold = true;
                    xPos += 2;
                    cubeRow++;
                }
                else if (cubeRow > 5)
                {
                    cubeRow = 0;
                    xPos = -4;
                    yPos += 2;
                    gold++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                    myCube = Instantiate(goldCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    justSpawnedGold = true;
                    xPos -= 2;
                    cubeRow++;
                }
            }
            else if (bronze < 4)
            {
                recentOre = Ore.Bronze;
                if (cubeRow <=5)
                {
                    bronze++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                    myCube = Instantiate(bronzeCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    xPos += 2;
                    justSpawnedGold = false;
                    cubeRow++;
                }
                else if( cubeRow > 5)
                {
                    cubeRow = 0;
                    xPos = -4;
                    yPos -=2;
                    bronze++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                   myCube = Instantiate(bronzeCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    xPos += 2;

                    justSpawnedGold = false;
                    cubeRow++;
                }
            }
            else if (bronze >= 4)
            {
                recentOre = Ore.Silver;
                if (cubeRow<=5)
                {
                    silver++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                    myCube = Instantiate(silverCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    xPos += 2;
                    cubeRow++;
                }
                else if (cubeRow >5)
                {
                    cubeRow = 0;
                    xPos = -4;
                    yPos -=2;
                    silver++;
                    cubePosition = new Vector3(xPos, yPos, 0);
                    myCube = Instantiate(silverCubePrefab, cubePosition, Quaternion.identity);
                    myCube.GetComponent<cubeCon>().myOre = recentOre;
                    xPos += 2;
                    cubeRow++;
                }
            }
          


            print("Bronze: " + bronze + " ... Silver: " + silver + " ... Gold: " + gold);
            print("Total Points: " + points);
            
        }
        
    }
}
