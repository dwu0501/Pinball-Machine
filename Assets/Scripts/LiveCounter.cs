using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LiveCounter : MonoBehaviour
{
    public static int lives=3;
    public Text vidas;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vidas.text = ("Vidas: " + lives.ToString());

    }
}
