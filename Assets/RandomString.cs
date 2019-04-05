using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RandomString : MonoBehaviour {

    public Text myText;


    public string[] randomWord =
    {

        "Funny",
        "Clumsy",
        "Biggest Lightweight",
        "Worst driver",
        "Unfaithful",
        "Strong",
        "Generous",
        "Adventerous",
        "Rude",
        "Vain",
        "Selfish",
        "Enthusiastic",
        "Childish",
        "Talkative",
        "Rowdy",
        "Shy",
        "Impatient",
        "Immoral",
        "Feirce",
        "Campest",
        "Maniacal",
        "Lazy",
        "Party Animal",
        "Dumbest",
        "Talkative",
        "Big Spender",

    };


    // Use this for initialization
    void Start () {

        string myString = randomWord [Random.Range(0, randomWord.Length)];
        myText.text = myString;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetBut()
    {
        string myString = randomWord[Random.Range(0, randomWord.Length)];
        myText.text = myString;

    }

}

