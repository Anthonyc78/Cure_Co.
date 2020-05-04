using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infection : MonoBehaviour
{
    [SerializeField] [Range(1, 3)] int difficulty = 1;
    [SerializeField] int population = 1000000;
    [Range(0f, 100f)] private float PercentSusceptible = 0f;
    [Range(0f, 100f)] private float PercentInfected = 0f;
    [Range(0f, 100f)] private float PercentDead = 0f;
    [Range(0f, 100f)] private float PercentCured = 0f;
    private int susceptible = 0;
    private int infected = 0;
    private float infectedBuildUp = 0f;
    private int dead = 0;
    private int cured = 0;
    private float infectiousness;
    // Start is called before the first frame update
    void Start()
    {
        if (difficulty == 1)
        {
            PercentInfected = Random.Range(1f, 2f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.025f;
        }
        else if (difficulty == 2)
        {
            PercentInfected = Random.Range(2f, 5f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.05f;
        }
        else if (difficulty == 3)
        {
            PercentInfected = Random.Range(5f, 10f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        infectedBuildUp += infected * infectiousness;
        infected = (int)infectedBuildUp;
    }
}
