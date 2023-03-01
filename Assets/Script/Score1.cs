using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public static Score1 instance;

    public Text scoreText;

    public GameObject player1;
    public GameObject player2;


    int score = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        
        score += 1;
        scoreText.text = score.ToString();
        if (score > 10)
        {
            player1.SetActive(true);
            player2.SetActive(false);

        }
    }
}
