using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillIn : MonoBehaviour
{
	string pergunta;
	//int numPergunta;
	GameObject g_pergunta;
	GameObject g_Canvas;
	Text t_pergunta;

	// Use this for initialization
	void Start ()
	{
		g_pergunta = GameObject.Find ("Text");
		t_pergunta = g_pergunta.GetComponent<Text> ();
		//numPergunta = Random.Range (0, 9);
	//	print (numPergunta);
		pergunta = "ASDADWESDIEFDORDOFOASDIWQE";
	//	t_pergunta.material = ArialFont.material;
		t_pergunta.text = pergunta;
		//print (g_pergunta.transform.position);
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	/*public void Confirmar ()
	{
		numPergunta = Random.Range (0, 9);
		print (numPergunta);
		t_pergunta = g_pergunta.GetComponent<Text> ();
		Font ArialFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Arial.ttf");
		t_pergunta.font = ArialFont;
		t_pergunta.material = ArialFont.material;
		t_pergunta.color = new Color (0, 0, 0);
		t_pergunta.text = pergunta [numPergunta];

	}*/
}
