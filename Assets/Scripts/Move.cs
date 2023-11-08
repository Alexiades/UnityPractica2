using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  //Definicion de Variables
   public float y = 2.50f;
   public float z = 1;
   public float x = 1;
   public float speed = 2.5f;
   

    // Start is called before the first frame update
    void Start()
    {
        

    }
              
    // Update is called once per frame
    void Update()
    { 

      // Dirección del vector3 en el espacio
      //Vector3 direction = new Vector3(0,y, 0);

      // Elevar el cubo
      //this.transform.Translate(direction * speed); 

      //Multiplico por 2 las variables de diereccion
      //this.transform.Translate(2*x,2*y,2*z);     
  
      //direction.normalized
      //transform.Translate(direction.normalized);

      // Aumentar velocidad 
      //this.transform.Translate(direction.normalized*speed);

      // Corregir inconsistencia de la velocidad
      //this.transform.Translate(goal.normalized * speed*Time.deltaTime);


    }
}
