using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
	private float timer;
	private bool stepped;
	[SerializeField] private float threshold = 1;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Feet"))
		{
			Vanish();
			stepped = true;
		}
	}

	private void Vanish()
	{
		GetComponentInChildren<MeshRenderer>().enabled = false;
	}

	private void Appear()
	{
		GetComponentInChildren<MeshRenderer>().enabled = true;
	}

	private void Update()
	{
		if (stepped)
			timer += Time.deltaTime;
		else timer = 0;

		if (timer >= threshold)
		{
			Appear();
			stepped = false;
		}
	}
}
