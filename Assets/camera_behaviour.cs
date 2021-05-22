using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_behaviour : MonoBehaviour
{
	public GameObject target;
	private Vector3 offset;
	public float smooth = 5f;
	public float xRotation, yRotation = 0f;
	public float rotationSpeed = 5f;

	void Start() {
		offset = transform.position - target.transform.position;
	}
    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;

        if (Input.GetMouseButton(1)) {
        	xRotation += Input.GetAxis("Mouse X") * rotationSpeed;
        	yRotation += -Input.GetAxis("Mouse Y") * rotationSpeed;
        	if (yRotation < -35f) {
        		yRotation = -35f;
        	}
        	transform.rotation = Quaternion.Euler(yRotation, xRotation, 0f);
        }
    }
}
