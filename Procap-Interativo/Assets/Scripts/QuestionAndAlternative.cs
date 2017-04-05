using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuestioAndAlternative : MonoBehaviour {

	public string question;
	public string alternatives;

	public QuestioAndAlternative(string newQuestion, string newAlt)
	{
		question = newQuestion.Trim ();
		alternatives = newAlt.Trim ();
	}

	/*public string CompareTo(QuestioAndAlternative other)
	{
		if(other == null){
			return "1";
		}
		return other.question;
	}*/
}
