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
    private int susceptible = 0;
    private int infected = 0;
    private float infectedBuildUp = 0f;
    private int dead = 0;
    private int cured = 0;
    private float infectiousness;
    private float decay;
    private float severity;

    // Update is called once per frame
    void Update()
    {
        infectedBuildUp += infected * infectiousness;
        infected = (int)infectedBuildUp;
        UpdatePercents();
        InfectedFilter.GetComponent<Image>().color = new Color (1, 0, 0, PercentInfected);
        DeadFilter.GetComponent<Image>().color = new Color (0, 0, 0, PercentDead);
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
