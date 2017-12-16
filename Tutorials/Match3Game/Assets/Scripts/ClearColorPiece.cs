using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearColorPiece : ClearablePiece {

	private ColorPiece.ColorType color;

	public ColorPiece.ColorType Color {
		get { return color; }
		set { color = value; }
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void clear ()
	{
		base.clear ();

		piece.GridRef.ClearColor (color);
	}
}
