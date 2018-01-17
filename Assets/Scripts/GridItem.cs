using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridItem : MonoBehaviour 
{
	public int x {
		get;
		private set;
	}

	public int y {
		get;
		private set;
	}

	public void OnItemPositionChanged(int newX, int newY)
	{
		x = newX;
		y = newY;

		gameObject.name = string.Format ("Sprite " + x + y);
	}

	private void OnMouseDow()
	{
		if (OnMouseOverItemEventHandler != null) 
		{
			OnMouseOverItemEventHandler (this);
		}
	}

	public delegate void OnMouseOverItem(GridItem item);
	public static event OnMouseOverItem OnMouseOverItemEventHandler;
}
