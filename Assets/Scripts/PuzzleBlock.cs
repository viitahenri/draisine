﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Left, Right }

public class PuzzleBlock : MonoBehaviour
{
	public SpriteRenderer Renderer;
	public List<Sprite> SymbolSprites;

	public Sprite CurrentSprite
	{
		get { return SymbolSprites[_currentSpriteIndex]; }
	}

	private int _currentSpriteIndex;
	
	private void Start()
	{
		_currentSpriteIndex = Random.Range(0, SymbolSprites.Count);
		UpdateSprite();
	}

	private void UpdateSprite()
	{
		Renderer.sprite = SymbolSprites[_currentSpriteIndex];
	}
	
	public void ChangeSprite(Direction direction)
	{
		switch (direction)
		{
			case Direction.Left:
				if (_currentSpriteIndex != 0)
				{
					_currentSpriteIndex--;
					UpdateSprite();
				}
				else
				{
					// TODO: Fail effect
				}
				break;
			case Direction.Right:
				if (_currentSpriteIndex < SymbolSprites.Count - 1)
				{
					_currentSpriteIndex++;
					UpdateSprite();
				}
				else
				{
					// TODO: Fail effect
				}
				break;
		}
	}
}
