using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBar : MonoBehaviour
{
	[SerializeField] private Color defaultMat;
	[SerializeField] private Color[] colorList;
	[SerializeField] private List<Material> bar;
	[SerializeField] private Animator anim;
	[SerializeField] private GameObject hang;
	private bool grabbed;

	private void Update()
	{
		if (!grabbed) bar[1].color = defaultMat;
	}

	void SwingBar()
	{
		anim.SetTrigger("Swing");
	}

	void ReturnBar()
	{
		anim.SetTrigger("Return");
	}

	void LightUp()
	{
		bar[0].color = colorList[0];
	}

	void LightOff()
	{
		bar[0].color = defaultMat;
	}

	void LightChange1()
	{
		bar[1].color = colorList[0];
		grabbed = true;
	}

	void LightChange2()
	{
		bar[1].color = colorList[1];
	}

	void LightChange3()
	{
		bar[1].color = colorList[2];
	}

	void LightChange4()
	{
		bar[1].color = colorList[3];
	}

	void LightChange5()
	{
		bar[1].color = colorList[4];
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
