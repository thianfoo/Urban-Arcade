using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{
	[SerializeField] private GameObject ilpCanvas;
	[SerializeField] private GameObject mbCanvas;
	[SerializeField] private GameObject cbCanvas;
	[SerializeField] private GameObject mistCanvas;

	private void OnTriggerEnter(Collider other)
	{
		switch (other.tag)
		{
			case "ILP":
				ilpCanvas.SetActive(true);
				break;
			case "MB":
				mbCanvas.SetActive(true);
				break;
			case "CB":
				cbCanvas.SetActive(true);
				break;
			case "Mist":
				mistCanvas.SetActive(true);
				break;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		switch (other.tag)
		{
			case "ILP":
				ilpCanvas.SetActive(false);
				break;
			case "MB":
				mbCanvas.SetActive(false);
				break;
			case "CB":
				cbCanvas.SetActive(false);
				break;
			case "Mist":
				mistCanvas.SetActive(false);
				break;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
		mbCanvas.SetActive(false);
		cbCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
