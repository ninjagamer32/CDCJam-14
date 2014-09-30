﻿using UnityEngine;
using System.Collections;

public class Balance : MonoBehaviour {
	TextMesh texts;
	private int total;
	public GameObject noteno;
	// Use this for initialization
	void Start () {
		total = 2500;
		texts = gameObject.GetComponent<TextMesh>();
		Font Arial = (Font)Resources.GetBuiltinResource (typeof(Font), "Arial.ttf");
		float pixelRatio = (Camera.main.orthographicSize * 2.0f) / Camera.main.pixelHeight;
		texts.transform.localScale = new Vector3(pixelRatio * 10.0f, pixelRatio * 10.0f, pixelRatio * 0.1f);
		texts.text = "Balance: "+total;
		texts.font = Arial;
		texts.fontStyle = FontStyle.Normal;
		texts.fontSize = 17;
	
	}

	void BuyEmtric(int cost){
		if (total > cost)
			total -= cost;
		else
			noteno.SendMessage ("tomuch", SendMessageOptions.DontRequireReceiver);
	}
	void BuyEfavir(int cost){
		if (total > cost)
			total -= cost;
		else
			noteno.SendMessage ("tomuch", SendMessageOptions.DontRequireReceiver);
	}
	void BuyTenofiv(int cost){
		if (total > cost)
			total -= cost;
		else
			noteno.SendMessage ("tomuch", SendMessageOptions.DontRequireReceiver);
	}
	void BuyAtrip(int cost){
		if (total > cost)
			total -= cost;
		else
			Debug.Log("to");
			noteno.SendMessage ("tomuch", SendMessageOptions.DontRequireReceiver);
	}
		// Update is called once per frame
	void Update () {
		texts.text = "Balance: "+total;
	}


}
