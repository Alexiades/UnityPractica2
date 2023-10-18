using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

   // public float y = 0.50f;
    public int x,y,z = 0;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,1, 0);
        //direction.normalized 
        
    }

    // Update is called once per frame
    void Update()
    {


    foreach (Transform child in transform)
        {
            child.position += Vector3.up * 10.0f;
        }


      // Duplicar el movimineto. 
      //transform.position = new Vector3(0,1,2) * 2; 

      // Elevar el cubo
      //transform.Translate(Vector3.up  * speed * Time.deltaTime); 
  
    }
}
