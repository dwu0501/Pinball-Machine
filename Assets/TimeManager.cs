using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    GameObject clon;
    public GameObject moneda;
    public GameObject camera;
    bool CameraActive = false;
    public Text txtTimeFloored;
    bool spawned = false;
    public int delay = 2;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTimeFloored.text = "Tiempo: " + Mathf.Floor(elapsedTime).ToString();

        int _time = (int)Time.time;
        if (_time==0)
        {

        }
        else if (_time%30 == 0 && !spawned)
        {
            for (int i = 0; i < 5; i++)
            {
                clon = Instantiate(moneda);
                clon.transform.position = new Vector3(Random.Range(-2.9f, 2.9f), 0.5f, Random.Range(-3f, 6f));
            }
            spawned = true;
        }
        else if (_time % 10 == 0 && !spawned)
        {
            spawned = true;
            GameObject clon;
            clon = Instantiate(moneda);
            clon.transform.position = new Vector3(Random.Range(-2.9f, 2.9f), 0.5f, Random.Range(-3f, 6f));
        }
        else if (_time % 10  == 1)
        {
            spawned = false;
        }

        if (_time % 5==0)
        {
            if (CameraActive)
            {
                camera.SetActive(false);
                CameraActive = false;
            }
            else if (!CameraActive)
            {
                camera.SetActive(false);
                CameraActive = false;
                
            }
        }
        while(CameraActive)
        {
            Flipper.hitStrenght = 20000;
        }

    }
}