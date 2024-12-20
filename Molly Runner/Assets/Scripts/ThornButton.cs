using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornButton : MonoBehaviour
{
    private Animation myAnim;
    void Start()
    {
        myAnim = transform.GetChild(0).GetComponent<Animation>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.GetChild(0).GetComponent<Animation>().Play();
            transform.parent.GetChild(0).GetComponent<Animation>().Play();

        }
    }
}
