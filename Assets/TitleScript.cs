using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public Button StartButton;
    public Button CreditButton;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startbutton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);

    }
    public void creditbutton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
