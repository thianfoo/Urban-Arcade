using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBar : MonoBehaviour
{
	[SerializeField] private Color defaultMat;
	[SerializeField] private Color[] colorList;
	[SerializeField] private List<Material> barMat;
	[SerializeField] private List<GameObject> bar;
	[SerializeField] private Animator anim;
	[SerializeField] private GameObject hang;
	private bool grabbed;

	private void Update()
	{
		if (!grabbed) barMat[1].color = defaultMat;
	}

	void SwingBar()
	{
		anim.SetTrigger("Swing");
	}

	void ReturnBar()
	{
		anim.SetTrigger("Return");
	}

	void DisplayBar1()
	{
		bar[0].SetActive(true);
		bar[1].SetActive(false);
	}

	void DisplayBar2()
	{
		bar[0].SetActive(false);
		bar[1].SetActive(true);
	}

	void LightUp()
	{
		barMat[0].color = colorList[0];
	}

	void LightOff()
	{
		barMat[0].color = defaultMat;
	}

	void LightChange1()
	{
		barMat[1].color = colorList[0];
		grabbed = true;
	}

	void LightChange2()
	{
		barMat[1].color = colorList[1];
	}

	void LightChange3()
	{
		barMat[1].color = colorList[2];
	}

	void LightChange4()
	{
		barMat[1].color = colorList[3];
	}

	void LightChange5()
	{
		barMat[1].color = colorList[4];
	}

	void EnableHang()
	{
		hang.SetActive(true);
	}

	void DisableHang()
	{
		hang.SetActive(false);
		grabbed = false;
	}
}
