﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const int MaxScore = 100;

        int score = 56;

        float percent = (float)score / MaxScore;

        float percentConvert = percent * 100;

        print("Score percent is: " + percentConvert + "%");
    }
}
