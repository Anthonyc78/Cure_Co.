using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubInfector : MonoBehaviour
{
    [SerializeField] int population = 200000;
    [Range(0f, 1f)] private float PercentSusceptible = 0f;
    [SerializeField] [Range(0f, 1f)] private float PercentInfected = 0f;
    [SerializeField] GameObject InfectedFilter;
    [SerializeField] [Range(0f, 1f)] private float PercentDead = 0f;
    [SerializeField] GameObject DeadFilter;
    [Range(0f, 1f)] private float PercentCured = 0f;
    [SerializeField] private int susceptible = 0;
    [SerializeField] private int infected = 0;
    private float infectedBuildUp = 0f;
    [SerializeField] private int dead = 0;
    private float deadBuildUp = 0f;
    [SerializeField] private int cured = 0;
    private float infectiousness;
    private float decay;
    private float decayBuildUp = 0f;
    private float severity;
    void Start()
    {
        susceptible = population;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateStats();
        UpdatePercents();
        UpdateFilters();
    }

    private void UpdateFilters()
    {
        // Adjust alpha of filter based on how many are infected or dead
        InfectedFilter.GetComponent<Image>().color = new Color(1, 0, 0, PercentInfected);
        DeadFilter.GetComponent<Image>().color = new Color(0, 0, 0, PercentDead);
    }

    private void UpdateStats()
    {
        // Calc amount that have died
        deadBuildUp += (infected * 1f) * severity;
        Debug.Log("deadBuildUp = " + deadBuildUp);
        if (deadBuildUp >= 1f)
        {
            dead += (int)deadBuildUp;
            infected -= (int)deadBuildUp;
            while (deadBuildUp > 1f)
            {
                deadBuildUp -= 1f;
            }
        }
        // Calc amount of new infected
        infectedBuildUp += (infected * 1f) * infectiousness;
        Debug.Log("infectedBuildUp = " + infectedBuildUp);
        if (infectedBuildUp >= 1f)
        {
            infected += (int)infectedBuildUp;
            while (infectedBuildUp > 1f)
            {
                infectedBuildUp -= 1f;
            }
        }
        // Calc amount that have recovered
        decayBuildUp += (infected * 1f) * decay;
        Debug.Log("decayBuildUp = " + decayBuildUp);
        if (decayBuildUp >= 1f)
        {
            infected -= (int)decayBuildUp;
            while (decayBuildUp > 1f)
            {
                decayBuildUp -= 1f;
            }
        }
        // Calc who is vulnerable
        susceptible = population - (infected + dead + cured);
        Debug.Log("infected = " + infected);
        Debug.Log("dead = " + dead);
        Debug.Log("susceptible = " + susceptible);
        Debug.Log("cured = " + cured);
    }
    private void UpdatePercents()
    {
        // Update the percents by dividing by the population multiplied by 1f
        PercentSusceptible = susceptible / (population * 1f);
        PercentInfected = infected / (population * 1f);
        PercentDead = dead / (population * 1f);
        PercentCured = cured / (population * 1f);
        // Make sure all values cap at 1f
        if (PercentSusceptible > 1f)
        {
            PercentSusceptible = 1f;
        }
        if (PercentInfected > 1f)
        {
            PercentInfected = 1f;
        }
        if (PercentDead > 1f)
        {
            PercentDead = 1f;
        }
        if (PercentCured > 1f)
        {
            PercentCured = 1f;
        }
    }
    internal void SetValues(int i)
    {
        // Set the infected value
        infected = i;
    }

    internal void StartValues(float i, float d, float s)
    {
        // Set the start values for the difficulty
        infectiousness = i;
        decay = d;
        severity = s;
    }

    internal int GetInfected()
    {
        return infected;
    }

    internal int GetHealthy()
    {
        return susceptible;
    }

    internal int GetDead()
    {
        return dead;
    }

    internal int GetCured()
    {
        return cured;
    }
}