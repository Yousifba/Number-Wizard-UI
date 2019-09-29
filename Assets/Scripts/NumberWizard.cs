using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        if(max >= min)
        {
            guess = Random.Range(min, max + 1);
        }
        guessText.text = guess.ToString();
    }
}
