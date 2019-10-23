using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCon : MonoBehaviour
{
    public Ore myOre;

    // Start is called before the first frame update
    void Start()
    { }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);

        if (myOre== Ore.Bronze)
        {
            controller.bronze--;
            controller.points += controller.bronzePoints;
            print("You scored 1 point!");
        }
        else if(myOre == Ore.Silver)
        {
            controller.silver--;
            controller.points += controller.silverPoints;
            print("You scored 10 points!");
        }
        else if (myOre == Ore.Gold)
        {
            controller.gold--;
            controller.points += controller.goldPoints;
            print("You scored 100 points!");
        }
        }
    }
