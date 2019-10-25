using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;
    [SerializeField] Text guessText;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //guess = (max + min) / 2;

        //guessText.text = "Is it " + guess.ToString() + "?";
        NextGuess();
    }

    public void OnPressLower()
    {
        min = guess - 1;
        NextGuess();
    }

    public void OnPressHigher()
    {
        max = guess + 1;
        NextGuess();
    }
    
    void NextGuess()
    {
        //        guess = (max + min) / 2;
        guess = Random.Range(min, max);
        guessText.text = "Is it " + guess.ToString() + "?";
    }
}
