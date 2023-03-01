using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    public GameObject player;
    public GameObject Input;
    

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
            player.SetActive(true);
            Input.SetActive(false);

        }
    }
}
