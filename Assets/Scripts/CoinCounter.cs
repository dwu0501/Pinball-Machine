using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static int countercoin;
    public Text contador;
        
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = ("Monedas: " + countercoin.ToString());
        
    }
}
