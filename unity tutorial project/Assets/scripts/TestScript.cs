using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yo Satoru!");
        Debug.Log("Yo Suguru!");
        Debug.Log("Lets Go Bro!");
        transform.Translate(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Satoru Gojo Arrives!");
        transform.Translate(-2, 4, 0);
    }
}
