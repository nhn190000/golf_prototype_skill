using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trajectory_logic : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    private Rigidbody rb;

    private bool isShoot;
    public int shotCount = 0;

    void Start() {
    	rb = GetComponent<Rigidbody>();
    	isShoot = false;
    }

    private void OnMouseDown() {
    	mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp() {
    	mouseReleasePos = Input.mousePosition;
    	Shoot(Force: mousePressDownPos-mouseReleasePos);
    }

    private float forceMultiplier = 5;

    void Update() {
    	if(rb.IsSleeping()) {
    		isShoot = false;
    	}
    }
    // Update is called once per frame
    void Shoot(Vector3 Force) {
    	if(isShoot) {
    		return;
    	}

    	rb.AddForce(new Vector3(Force.x, Force.y, z:Force.y) * forceMultiplier);
    	isShoot = true;
    	shotCount += 1;
    }

	void OnCollisionEnter() {
		if (isShoot) {
			rb.drag += 10f;
		}
    }

    void OnCollisionExit() {
       rb.drag = 0.1f;
    }

}
