using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
    public GameObject coin;
    public AudioClip coinSound;
    public Transform rotacion;
    public float angle;
    AudioSource FuentedeAudio;

    void Update()
    {
        transform.RotateAround(rotacion.position, Vector3.up, angle * Time.deltaTime);

        FuentedeAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Pinball Prefab")
        {

            FuentedeAudio.clip = coinSound;
            FuentedeAudio.Play();
            CoinCounter.countercoin++;
            Destroy(coin);

        }
    }
}
