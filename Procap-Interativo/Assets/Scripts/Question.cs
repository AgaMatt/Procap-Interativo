using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
	public string[] pergunta;
	public int[] resposta;
	int numPergunta;
	public GameObject g_pergunta;
	public GameObject g_resposta;
	GameObject g_Canvas;
	Text t_resposta;
	Text t_pergunta, acertosT, errosT;
	string resp;
	int tentativa, acertos, erros;
	public GameObject acerto, acertosGO;
	public GameObject erro, errosGO;

	void Start ()
	{
		acertos = 0;
		erros = 0;
		numPergunta = 0;
		print (numPergunta);
		//pergunta = "ASDADWESDIEFDORDOFOASDIWQE";
		//g_pergunta = new GameObject ("Text_Pergunta");
		//g_pergunta.transform.SetParent (GameObject.Find ("Text").transform);
		t_pergunta = g_pergunta.GetComponent<Text> ();
		Font ArialFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Arial.ttf");
		t_pergunta.font = ArialFont;
		t_pergunta.material = ArialFont.material;
		t_pergunta.color = new Color (0, 0, 0);
		t_pergunta.text = pergunta [numPergunta];
	}

	void Update ()
	{
		acertosT = acertosGO.GetComponent<Text> ();
		acertosT.text = "Acertos:" + acertos;
		errosT = errosGO.GetComponent<Text> ();
		errosT.text = "Erros:" + erros;
	}

	public void Confirmar ()
	{
		
		print (numPergunta);
		t_resposta = g_resposta.GetComponent<Text> ();
		resp = t_resposta.text;
		int.TryParse (resp, out tentativa);
		if (tentativa == resposta [numPergunta]) {
			print ("acertou");
			acerto.SetActive (true);
			erro.SetActive (false);
			//numPergunta = Random.Range (0, 3);
			numPergunta++;
			acertos++;
			t_pergunta = g_pergunta.GetComponent<Text> ();
			Font ArialFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Arial.ttf");
			t_pergunta.font = ArialFont;
			t_pergunta.material = ArialFont.material;
			t_pergunta.color = new Color (0, 0, 0);
			t_pergunta.text = pergunta [numPergunta];

		} else {
			print ("Errou burro");
			acerto.SetActive (false);
			erro.SetActive (true);
			numPergunta++;
			erros++;
			t_pergunta = g_pergunta.GetComponent<Text> ();
			Font ArialFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Arial.ttf");
			t_pergunta.font = ArialFont;
			t_pergunta.material = ArialFont.material;
			t_pergunta.color = new Color (0, 0, 0);
			t_pergunta.text = pergunta [numPergunta];

		}


	}
}
