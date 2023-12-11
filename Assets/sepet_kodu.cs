using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sepet_kodu : MonoBehaviour
{

    public float hiz;
    int skor = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma")
        {
            skor += 10;
            Debug.Log(skor.ToString());

            float rast = Random.Range( 0.5f, 11.5f);
            collision.gameObject.transform.position = new Vector3(rast, 2, -7);
        }
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz*Time.deltaTime,0,0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);

        }
    }
}
