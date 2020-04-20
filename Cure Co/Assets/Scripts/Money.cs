// https://answers.unity.com/questions/134474/add-to-score-every-second.html
// script bassed off the above link

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    // The amount of money the player starts with
    public float StartingCash = 100000;
    // amount of income the player recieves
    public float income = 1000;

    void Start()
    {
        // repeats the AddToMoney function every 10 seconds
        InvokeRepeating("AddToMoney", 10, 10);
    }

    void AddToMoney()
    {
        //income is added to the players total cash
        StartingCash += income;
        //prints in the console the players cash after the income is added
        print(StartingCash);
    }
}
