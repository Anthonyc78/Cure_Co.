using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    public float Midwest = 68800000; // 68.8 mil
    public float Northeast = 56000000; // 56 mil
    public float Southeast = 92900000; // 92.9 mil
    public float Southwest = 43000000; // 43 mil
    public float West = 67700000; // 67.7 mil
    public float Total = 328400000; // 328.4 mil
    [SerializeField] float score;
    public float timer;
    public int counter = 1;

    private void Update()
    {
        score += Total/counter;

        timer += Time.deltaTime;
        if (timer > 5f)
        {
            //counter is going to be used to divide the score
            counter += 1;
            // reset the timer
            timer = 0;
            
        }
        
    }
}
// all numbers are rounded to the nearest 100,000
// https://worldpopulationreview.com/states/

// Midwest - 68.8 mil
// North Dakota - 800,000
// South Dakota - 900,000
// Nebraska - 2 mil
// Kansas - 2.9 mil
// Minnesota - 5.7 mil
// Iowa - 3.2 mil
// Missouri - 6.2 mil
// Wisconsin 5.9
// Illinois - 12.7 mil
// Indiana - 6.7
// Michigan -10 mil
// Ohio - 11.8 mil

// Northeast - 56 mil
// Pennsylvania - 12.8 mil
// New Jersey - 8.9 mil
// New York - 19.4 mil
// Connecticut - 3.6 mil
// Rhode Island - 1 mil
// Massachusetts - 7 mil
// Vermont - 600,000
// New Hampshire - 1.4 mil
// Maine - 1.3 mil

// Southeast - 92.9 mil
// Delaware - 1 mil
// Maryland - 6.1 mil
// West Virginia - 1.8 mil
// Virginia - 8.6 mil
// Kentucky - 4.5 mil
// North Carolina - 10.6 mil
// South Carolina - 5.2 mil
// Tennessee - 6.9 mil
// Arkansas - 3 mil
// Louisiana - 4.6 mil
// Mississippi - 3 mil
// Alabama - 4.9 mil
// Georgia - 10.7 mil
// Florida - 22 mil

// Southwest - 43 mil
// Texas - 29.5 mil
// Oklahoma - 4 mil
// New Mexico - 2.1 mil
// Arizona - 7.4 mil

// West - 67.7 mil
// California - 39.9 mil
// Nevada - 3.1 mil
// Utah - 3.3 mil
// Colorado 5.8 mil
// Wyoming - 600,000
// Montana - 1.1 mil
// Idaho - 1.8 mil
// Oregon - 4.3 mil
// Washington - 7.8 mil
