using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class BallMove : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse clicke");
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot(Force: mouseReleasePos-mousePressDownPos);
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        if(isShoot)
            return;
        
        rb.AddForce(new Vector3(Force.x,-Force.y,Force.y) * forceMultiplier);
        isShoot = false;
    }
    
}