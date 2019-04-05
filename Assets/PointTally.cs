using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTally : MonoBehaviour
{

    public Button button;
    public Text text;

    public int currentPoints = 0;

    public void ClickButt()
    {

        if (button != null)
        {
            currentPoints++;
            if (text != null)
            {

                text.text = " " + currentPoints.ToString();
            }

            {
                if (currentPoints > 11)
                    //break;
                {
                    text.text = " You Lose! ";
                }
            }

        }

    }
};