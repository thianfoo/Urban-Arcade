using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBar : MonoBehaviour
{
	[SerializeField] private Color newestMat = new Color(0,2,255);
	[SerializeField] private Color newerMat = new Color(0,1,255);
	[SerializeField] private Color newMat = new Color(0,0,255);
	[SerializeField] private Color oldMat = new Color(0,0,0);
	[SerializeField] private List<Material> bar;
	[SerializeField] private Animator anim;
	[SerializeField] private GameObject hang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
		for (int i = 0; i < bar.Count; i++)
		{
			bar[i].color = newMat;
		}
	}

	void LightOff()
	{
		for (int i = 0; i < bar.Count; i++)
		{
			bar[i].color = oldMat;
		}
	}

	void LightChange()
	{
		for (int i = 0; i < bar.Count; i++)
		{
			newerMat = new Color(Mathf.Lerp(255,0,1),1,255);
			bar[i].color = newerMat;
		}
	}

	void EnableHang()
	{
		hang.SetActive(true);
	}

	void DisableHang()
	{
		hang.SetActive(false);
	}
}
