using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlushScript : MonoBehaviour
{
    public GameObject Bow1;
    public GameObject Bow2;
    public GameObject Bow3;
    public int score;
    public float gameTimer;
    public int Bow;
    public GameObject gameManager;
    public bool hasGameWon;
    public bool isGameOver;
    public Button GameButton;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       gameTimer += Time.deltaTime;
    }
    public void spawn()
    {
        Bow = Random.Range(0, 3);
        if(Bow == 1)
        {
            Instantiate(Bow1);
        }
        if(Bow == 2)
        {
            Instantiate(Bow2);
        }
        if(Bow == 3)
        {
            Instantiate(Bow3);
        }
    }
    public void win()
    {
        if(score >= 40)
        {
            hasGameWon = true;
            isGameOver = true;
        }
    }
    public void lose()
    {
        if(gameTimer >= 90 && score <= 40)
        {
            isGameOver = true;
            hasGameWon = false;
        }
    }
    public void gamebutton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    
}
