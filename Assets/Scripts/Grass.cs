using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Grass"))
		{
			other.gameObject.SetActive(false);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag.Equals("Grass"))
		{
			other.gameObject.SetActive(true);
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
