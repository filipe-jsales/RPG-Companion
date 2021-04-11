using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float Velocidade = 5;
    Vector3 direction;

	// Update is called once per frame
	void Update () {

        
	}

    void FixedUpdate()
    {
        float eixoX = Input.GetAxis("Horizontal"); /*input from keyboard*/
        float eixoZ = Input.GetAxis("Vertical"); /*input from keyboard*/

        /*moving character*/
        Vector3 direction = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direction * Velocidade * Time.deltaTime); /*setting characters speed*/

        GetComponent<Rigidbody>().MovePosition /*moving by rigidbody*/
            (GetComponent<Rigidbody>().position +
            (direction * Velocidade * Time.deltaTime));    
    }
}
