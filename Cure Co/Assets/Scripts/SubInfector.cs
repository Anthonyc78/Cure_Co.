using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInfector : MonoBehaviour
{
    [SerializeField] int population = 200000;
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

    // Update is called once per frame
    void Update()
    {
        infectedBuildUp += infected * infectiousness;
        infected = (int)infectedBuildUp;
    }

    internal void SetValues(float percentInfected)
    {
        PercentInfected = percentInfected;
        infected = (int)(population * (PercentInfected/100));
    }

    internal void StartValues(float infectiousness, float severity)
    {
        throw new NotImplementedException();
    }
}
