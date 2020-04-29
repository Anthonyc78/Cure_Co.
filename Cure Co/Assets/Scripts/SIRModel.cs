using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIRModel : MonoBehaviour
{
    [SerializeField] int population = 100;
    [Range(0f, 100f)] private float PercentSusceptible = 0f;
    [Range(0f, 100f)] private float PercentInfected = 0;
    [Range(0f, 100f)] private float PercentDead = 0;
    [Range(0f, 100f)] private float PercentImmune = 0;
    private int susceptible = 0;
    private int infected = 0;
    private int dead = 0;
    private int immune = 0;
    // Start is called before the first frame update
    void Start()
    {
        PercentImmune = Random.Range(0f, 10f);
        PercentInfected = Random.Range(1f, 2f);
        PercentSusceptible = 100 - (PercentImmune + PercentInfected);
        immune = (int)(population * (PercentImmune / 100));
        infected = (int)(population * (PercentInfected / 100));
        susceptible = (int)(population * (PercentSusceptible / 100));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
