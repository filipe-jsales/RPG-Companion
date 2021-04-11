using UnityEngine;

public class SmoothCamera : MonoBehaviour {

    public Transform target; /*personagem a ser seguido*/

    public float smoothSpeed = 0.125f; /*velocidade da camera*/
    public Vector3 offset; /*variavel vetorial da camera x,y,z*/

    private void FixedUpdate() /*update feito logo após update normal*/
    {
        Vector3 desiredPosition = target.position + offset; /*soma vetorial xyz camera + distancia vetorial desejada*/
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition; 
    }
}
