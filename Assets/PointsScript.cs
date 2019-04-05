using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsScript : MonoBehaviour
{

    public float scoreValue = 0;
    public Text score;

    void Start()
    {
        score = GetComponent<Text>();
        if (scoreValue >= 0)
        {
            scoreValue = + 1;
            score.text = scoreValue.ToString("F");
        }

    }

    void Update()
    {
       
    }

        public void ResetScene()
    {
        if (scoreValue >= 0)
        {
            scoreValue = + 1;
            score.text = scoreValue.ToString("F");
        }

    }
}


