using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infection : MonoBehaviour
{
    [SerializeField] [Range(1, 3)] int difficulty = 1;
    [SerializeField] int population = 1000000;
    [SerializeField] private SubInfector[] Regions;
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
    private float severity;
    // Start is called before the first frame update
    void Start()
    {
        int startRegion = Random.Range(0, 4);
        if (difficulty == 1)
        {
            // Starting stats of normal
            PercentInfected = Random.Range(1f, 2f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.025f;
            severity = 0.01f;
        }
        else if (difficulty == 2)
        {
            // Starting stats of hard
            PercentInfected = Random.Range(2f, 5f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.05f;
            severity = 0.02f;
        }
        else if (difficulty == 3)
        {
            // Starting stats of epidemic
            PercentInfected = Random.Range(5f, 10f);
            PercentSusceptible = 100 - PercentInfected;
            infected = (int)(population * (PercentInfected / 100));
            infectedBuildUp = infected;
            susceptible = (int)(population * (PercentSusceptible / 100));
            infectiousness = 0.1f;
            severity = 0.04f;
            for (int i = 0; i < Regions.Length; i++)
            {
                Regions[i].StartValues(infectiousness, severity);
            }
        }
        Regions[startRegion].SetValues(PercentInfected);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
