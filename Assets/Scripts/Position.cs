using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movimento hacia una posicion
public class Position : MonoBehaviour
{

 public float speed = 1.0f;
 public Transform goal;


    // Start is called before the first frame update
    void Start()
    {
      //Girar el objetivo
      this.transform.LookAt(goal.position);
    }

    // Update is called once per frame
    void Update()
    {
       //movimiento hacia una posicion
        Vector3 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);

      //oviento en referencia al mundo
      this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
 
      //Debug para comprobar la direccion esta correcta
      Debug.DrawRay(this.transform.position,direction,Color.red);

    }
}
