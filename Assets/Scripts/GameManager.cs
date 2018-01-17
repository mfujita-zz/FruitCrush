using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour 
{
	int gridSizeX = 6, gridSizeY = 6;

	private GameObject[] _fruits;
	private GridItem[,] _items;

	void Start () 
	{
		GetFruits ();
		CreateGrid ();
	}	

	void CreateGrid () 
	{
		_items = new GridItem[gridSizeX, gridSizeY];

		for (int x = 0; x < gridSizeX; x++) 
		{
			for (int y = 0; y < gridSizeY; y++) 
			{
				_items [x, y] = InstantiateFruit (x,y);

			}	
		}
	}

	GridItem InstantiateFruit(int xPos, int yPos)
	{
		print (xPos + " " + yPos);
		GameObject ramdomFruit = _fruits [UnityEngine.Random.Range (0, _fruits.Length)];
		GridItem newFruit = ((GameObject)Instantiate (ramdomFruit, new Vector3 (xPos * 1.6f-2, yPos*1.6f-4), Quaternion.identity)).GetComponent<GridItem> ();

		newFruit.OnItemPositionChanged (xPos, yPos);

		return newFruit;
	}

	void GetFruits()
	{
		_fruits = Resources.LoadAll<GameObject> ("Frutas");
	}
}
