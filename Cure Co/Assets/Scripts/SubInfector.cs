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
        InfectedFilter.GetComponent<Image>().color = new Color (1, 0, 0, PercentInfected);
        DeadFilter.GetComponent<Image>().color = new Color (0, 0, 0, PercentDead);
    }
    private void UpdateStats()
    {
        deadBuildUp += infected * severity;
        if (deadBuildUp >= 1f)
        {
            dead += (int)deadBuildUp;
            while (deadBuildUp > 1f)
            {
                deadBuildUp -= 1f;
            }
        }
        infectedBuildUp += infected * infectiousness;
        if (infectedBuildUp >= 1f)
        {
            infected += (int)infectedBuildUp;
            while (infectedBuildUp > 1f)
            {
                infectedBuildUp -= 1f;
            }
        }
        decayBuildUp += infected * decay;
        if (decayBuildUp >= 1f)
        {
            infected -= (int)decayBuildUp;
            while (decayBuildUp > 1f)
            {
                decayBuildUp -= 1f;
            }
        }
        susceptible = population - (infected + dead + cured);
    }
    private void UpdatePercents()
    {
        PercentSusceptible = susceptible / population;
        PercentInfected = infected / population;
        PercentDead = dead / population;
        PercentCured = cured / population;
    }
    internal void SetValues(int i)
    {
        infected = i;
    }

    internal void StartValues(float i, float d, float s)
    {
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
