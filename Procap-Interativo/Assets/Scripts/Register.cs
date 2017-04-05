using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Register : MonoBehaviour {

	Text t_Question, t_Alternatives;
	public InputField question_Input, alt_Input;
//	public List<QuestioAndAlternative> list_QAndA = new List<QuestioAndAlternative>();
	public Dictionary<int, string> D_Alt = new Dictionary<int, string>();
	public int int_Question;

	// Use this for initialization
	void Start () {
		int_Question = 0;
	}
	
	// Update is called once per frame
	void Update () {
		t_Question = question_Input.GetComponent<Text> ();
		if (Input.GetKeyDown (KeyCode.P)) {
			//list_QAndA.Sort ();
			aloalo ();
		}
	}
	/*public void MeuOvo()
	{
		string value = alt_Input.text;
		for (int i = 0; i < 6; i++) {
			char delimiter = ',';
			dst [i] = value.Split (delimiter, 1);
		}
	}
*/



	public void aloalo() {

		string words = alt_Input.text;

		string [] split = words.Split(new Char [] {','});

		foreach (string s in split) {

			if (s.Trim() != "")
				print(s);
			D_Alt.Add (int_Question, s);
			int_Question++;	
		}
	}

	public void ConfirmQuestion()
	{
		
		/*	print (question_Input.text);
		print (alt_Input.text);*/
	//	list_QAndA.Add (new QuestioAndAlternative (question_Input.text, alt_Input.text));
			
		/*		for(int i = 0; i < alt_Input.text.Length; i++){
			if(alt_Input.text[i] == ","){
				
			}
				
			}*/
		question_Input.text = "";
		alt_Input.text = "";


	}


}
