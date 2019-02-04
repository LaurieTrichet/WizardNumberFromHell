using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessEngine : MonoBehaviour
{

    [SerializeField] TMPro.TMP_Text GuessText;
    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;

    int guess;

    // Use this for initialization
    void Start()
    {
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        GuessText.text = guess.ToString();
    }

    public void OnLower()
    {
        max = guess + 1;
        NextGuess();
    }

    public void OnHigher()
    {
        min = guess - 1;
        NextGuess();
    }
}
