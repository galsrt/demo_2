using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupun_kodu2 : MonoBehaviour
{
    public GameObject kure;
    private void Start()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        #region
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�una bas�ld�");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�undan �ekildi");
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�una bas�l�yor");
        //}


        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�una bas�ld�");
        //}

        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�undan �ekildi");
        //}

        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�una bas�l�yor");
        //}
        #endregion

        #region transform �zellikler
        //transform.Translate(0, 1 * Time.deltaTime, 0,Space.World);

        //transform.Rotate(150*Time.deltaTime, 80*Time.deltaTime, 50*Time.deltaTime,Space.World);

        //GetComponent<Rigidbody>().velocity = Vector3.right * 50 * Time.deltaTime;
        #region
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�una bas�ld�");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�undan �ekildi");
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Debug.Log("sa� ok tu�una bas�l�yor");
        //}


        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�una bas�ld�");
        //}

        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�undan �ekildi");
        //}

        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sa� mouse tu�una bas�l�yor");
        //}
        #endregion

        #region transform �zellikler
        //transform.Translate(0, 1 * Time.deltaTime, 0,Space.World);

        //transform.Rotate(150*Time.deltaTime, 80*Time.deltaTime, 50*Time.deltaTime,Space.World);

        //GetComponent<Rigidbody>().velocity = transform.right * 50 * Time.deltaTime;
        //GetComponent<Rigidbody>().velocity = transform.up * 50 * Time.deltaTime;
        //GetComponent<Rigidbody>().AddForce ( transform.up * 50 * Time.deltaTime);
        #endregion
        #endregion
        //}

        //gameObject.SetActive(false);
        //Debug.Log("pasif hale geldi");

        //gameObject.SetActive(true);
        //Debug.Log("aktif hale geldi");

        #region destroy nesneyi sil
        //Destroy(gameObject,3.0f);


        #endregion

        for (int i = 0; i <5;i++) 
        {
            GameObject yeni_kure= Instantiate(kure,transform.position,Quaternion.identity);

            Destroy(yeni_kure,5.0f);
        }

    }
}
