using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIRModel : MonoBehaviour
{
    // This script was going to be our controller for the virus, 
    // however we ran out of time to get it in full working order.
    [SerializeField] [Range(1, 3)] int difficulty = 1;
    [SerializeField] int population = 100;
    [Range(0f, 100f)] private float PercentSusceptible = 0f;
    [Range(0f, 100f)] private float PercentInfected = 0f;
    [Range(0f, 100f)] private float PercentDead = 0f;
    [Range(0f, 100f)] private float PercentImmune = 0f;
    private int susceptible = 0;
    private int infected = 0;
    private int dead = 0;
    private int immune = 0;
    private float infectiousness;
    // Start is called before the first frame update
    void Start()
    {
        if (difficulty == 1)
        {
            PercentImmune = Random.Range(5f, 10f);
            PercentInfected = Random.Range(1f, 2f);
            PercentSusceptible = 100 - (PercentImmune + PercentInfected);
            immune = (int)(population * (PercentImmune / 100));
            infected = (int)(population * (PercentInfected / 100));
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.025f;
        }
        else if (difficulty == 2)
        {
            PercentImmune = Random.Range(1f, 5f);
            PercentInfected = Random.Range(2f, 5f);
            PercentSusceptible = 100 - (PercentImmune + PercentInfected);
            immune = (int)(population * (PercentImmune / 100));
            infected = (int)(population * (PercentInfected / 100));
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.05f;
        }
        else if (difficulty == 3)
        {
            PercentImmune = 0f;
            PercentInfected = Random.Range(5f, 10f);
            PercentSusceptible = 100 - (PercentImmune + PercentInfected);
            immune = (int)(population * (PercentImmune / 100));
            infected = (int)(population * (PercentInfected / 100));
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}