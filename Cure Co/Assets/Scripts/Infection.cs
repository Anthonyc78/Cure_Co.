using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infection : MonoBehaviour
{
    [SerializeField] [Range(1, 3)] int difficulty = 1;
    [SerializeField] int population = 328400000;
    [SerializeField] private SubInfector[] Regions;
    [SerializeField] [Range(0f, 1f)] private float PercentSusceptible = 0f;
    [SerializeField] RectTransform HealthyBar;
    [SerializeField] [Range(0f, 1f)] private float PercentInfected = 0f;
    [SerializeField] RectTransform InfectedBar;
    [SerializeField] [Range(0f, 1f)] private float PercentDead = 0f;
    [SerializeField] RectTransform DeadBar;
    [SerializeField] [Range(0f, 1f)] private float PercentCured = 0f;
    [SerializeField] RectTransform CuredBar;
    [SerializeField] private int susceptible = 0;
    [SerializeField] private int infected = 0;
    private float infectedBuildUp = 0f;
    [SerializeField] private int dead = 0;
    [SerializeField] private int cured = 0;
    private float infectiousness;
    private float decay;
    private float severity;
    // Start is called before the first frame update
    void Start()
    {
        int startRegion = UnityEngine.Random.Range(0, 4);
        if (difficulty == 1)
        {
            // Starting stats of normal
            PercentInfected = UnityEngine.Random.Range(0.01f, 0.02f);
            infected = (int)(population * PercentInfected);
            infectiousness = 0.025f;
            decay = 0.0125f;
            severity = 0.01f;
        }
        else if (difficulty == 2)
        {
            // Starting stats of hard
            PercentInfected = UnityEngine.Random.Range(0.02f, 0.05f);
            infected = (int)(population * PercentInfected);
            infectiousness = 0.05f;
            decay = 0.0125f;
            severity = 0.02f;
        }
        else if (difficulty == 3)
        {
            // Starting stats of epidemic
            PercentInfected = UnityEngine.Random.Range(0.05f, 0.1f);
            infected = (int)(population * PercentInfected);
            infectiousness = 0.1f;
            decay = 0.0125f;
            severity = 0.04f;
            for (int i = 0; i < Regions.Length; i++)
            {
                Regions[i].StartValues(infectiousness, decay, severity);
            }
        }
        Regions[startRegion].SetValues(infected);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateValues();
        UpdatePercents();
        UpdateStatusBar();
    }

    private void UpdatePercents()
    {
        PercentSusceptible = susceptible / population;
        PercentInfected = infected / population;
        PercentDead = dead / population;
        PercentCured = cured / population;
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

    private void UpdateValues()
    {
        // Collecting values for status
        int R1Infctd = Regions[0].GetInfected();
        int R1Hlthy = Regions[0].GetHealthy();
        int R1Ded = Regions[0].GetDead();
        int R1Crd = Regions[0].GetCured();

        int R2Infctd = Regions[1].GetInfected();
        int R2Hlthy = Regions[1].GetHealthy();
        int R2Ded = Regions[1].GetDead();
        int R2Crd = Regions[1].GetCured();

        int R3Infctd = Regions[2].GetInfected();
        int R3Hlthy = Regions[2].GetHealthy();
        int R3Ded = Regions[2].GetDead();
        int R3Crd = Regions[2].GetCured();

        int R4Infctd = Regions[3].GetInfected();
        int R4Hlthy = Regions[3].GetHealthy();
        int R4Ded = Regions[3].GetDead();
        int R4Crd = Regions[3].GetCured();

        int R5Infctd = Regions[4].GetInfected();
        int R5Hlthy = Regions[4].GetHealthy();
        int R5Ded = Regions[4].GetDead();
        int R5Crd = Regions[4].GetCured();

        int infctd = R1Infctd+ R2Infctd+ R3Infctd+ R4Infctd+ R5Infctd;
        int hlthy = R1Hlthy + R2Hlthy + R3Hlthy + R4Hlthy + R5Hlthy;
        int ded = R1Ded + R2Ded + R3Ded + R4Ded + R5Ded;
        int crd = R1Crd + R2Crd + R3Crd + R4Crd + R5Crd;

        infected = infctd;
        susceptible = hlthy;
        dead = ded;
        cured = crd;
    }

    private void UpdateStatusBar()
    {
        // Adjusting the scales for the status bar
        HealthyBar.localScale = new Vector3(PercentCured + PercentSusceptible, 1, 1);
        InfectedBar.localScale = new Vector3(PercentDead + PercentInfected, 1, 1);
        DeadBar.localScale = new Vector3(PercentDead, 1, 1);
        CuredBar.localScale = new Vector3(PercentCured, 1, 1);
    }
}
