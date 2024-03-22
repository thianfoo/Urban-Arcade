using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBar : MonoBehaviour
{
	[SerializeField] private Color newMat = new Color(0,0,255);
	[SerializeField] private Color oldMat = new Color(0,0,0);
	[SerializeField] private List<Material> bar;
	[SerializeField] private Animator anim;

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
}
