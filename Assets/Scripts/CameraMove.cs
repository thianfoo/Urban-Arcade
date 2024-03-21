using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-2 * Time.deltaTime, 0, 0));
		}

		if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(2 * Time.deltaTime, 0, 0));
		}
	}
}
