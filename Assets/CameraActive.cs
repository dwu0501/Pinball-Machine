using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{
    public GameObject camara;
    public string activo = CameraSet.TF;

    // Start is called before the first frame update
    void Start()
    {
        camara.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        while(CameraSet.TF=="false")
        {
            Flipper.hitStrenght = 20000;
        }


    }
}
