using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TapSound : MonoBehaviour {

	public AudioSource source;
	public Image image;

	public Color col1;
	public Color col2;

	public void Update()
	{
		Touch t = Input.GetTouch(0);
		if(t.phase == TouchPhase.Began)
		{
			ColorChange();
			Sound();
		}
		if(t.phase == TouchPhase.Ended)
		{
			ColorChangeBack();
		}
	}

	public void Sound()
	{
		source.Play();
	}

	public void ColorChange()
	{
		image.color = col1;
	}

	public void ColorChangeBack()
	{
		image.color = col2;
	}

}
