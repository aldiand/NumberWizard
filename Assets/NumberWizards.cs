using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
    int guess;
    int maxGuess = 5;
    public Text text;
   
	// Use this for initialization
	void Start ()
    {
		StartGame ();
	}

	void StartGame()
    {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
	}

	void NextGuess()
    {
		guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuess--;
        if(maxGuess < 0)
        {
            SceneManager.LoadScene("Win");
        }
	}

    public void GuestHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuestLower()
    {
        max = guess;
        NextGuess();
    }
}
