using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{
	public Material GoalMaterial;
	public GameObject Hole;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter() {
    	Hole.GetComponent<MeshRenderer>().material = GoalMaterial;
    }
}
