using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin_kod : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            

            float rast = Random.Range(0.5f, 11.5f);
            collision.gameObject.transform.position = new Vector3(rast, 2, -7);
        }

    }
}
