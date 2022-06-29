using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LiveCounter : MonoBehaviour
{
    public static int lives=3;
    public Text vidas;
    public GameObject camara;
    public GameObject botoon;

    void Start()
    {
        botoon.SetActive(false);
        camara.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        vidas.text = ("Vidas: " + lives.ToString());
        if (lives<=0)
        {
            camara.SetActive(true);
            vidas.enabled = false;
            botoon.SetActive(true);
        }
    }

    public void boton()
    {
        SceneManager.LoadScene(1);
        lives = 3;
        CoinCounter.countercoin = 0;
    }
}
