using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {


	// Update is called once per frame
	void Update () {

        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        /*moving character*/
        Vector3 direction = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direction);
        transform.Translate(direction);
	}
}
