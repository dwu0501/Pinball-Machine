using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusTime : MonoBehaviour
{
    public GameObject Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pinball Prefab")
        {

            
            CoinCounter.countercoin++;
            Destroy(Timer);
            ShowTime.timeRemaining += 10;

        }
    }
}
