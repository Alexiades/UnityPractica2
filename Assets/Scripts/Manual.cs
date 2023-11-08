using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manual : MonoBehaviour
{
public float horizontalIn;
public float verticalIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leo valores del teclado
        horizontalIn = Input.GetAxis("horizontalIn");
        verticalIn = Input.GetAxis("verticalIn");

        // Me muevo hacia el objetivo
        
    }
}
