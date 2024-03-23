using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
	public GameObject Model;
	public GameObject Destination;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Model.transform.position = Vector3.MoveTowards(Model.transform.position, Destination.transform.position, speed);
    }
}
