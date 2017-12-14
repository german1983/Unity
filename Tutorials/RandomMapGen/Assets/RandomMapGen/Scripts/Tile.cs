using System.Collections;
using UnityEngine;
using System;
using System.Text;

public enum Sides {
	Bottom,
	Right,
	Left,
	Top
}


public class Tile  {
	public int id = 0;
	public Tile[] neighbors = new Tile[4];
	public int autotileID;

	public void addNeighbor(Sides side, Tile tile){
		neighbors [(int)side] = tile;
		CalculateAutotileID ();
	}

	public void removeNeighbor(Tile tile) {
		var total = neighbors.Length;
		for (var i = 0; i < total; i++) {
			if (neighbors[i] != null) {
				if (neighbors [i].id == tile.id) {
					neighbors [i] = null;
				}
			}
		}
		CalculateAutotileID ();
	}

	public void clearNeighbors(){
		var total = neighbors.Length;
		for (var i = 0; i < total; i++) {
			var tile = neighbors [i];
			if (tile != null) {
				tile.removeNeighbor (this);
				neighbors [i] = null;
			}
		}
		CalculateAutotileID ();
	}

	private void CalculateAutotileID(){
		var sideValue = new StringBuilder ();
		foreach (Tile tile in neighbors) {
			sideValue.Append (tile == null ? "0" : "1");
		}

		autotileID = Convert.ToInt32 (sideValue.ToString (), 2);

	}
}
