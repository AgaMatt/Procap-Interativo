using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
	public void SouAluno ()
	{
		SceneManager.LoadScene ("Aluno");
	}

	public void SouProfessor ()
	{
		SceneManager.LoadScene ("Professor");
	}

	public void Return ()
	{
		SceneManager.LoadScene ("SelecaoAlunoProfessor");
	}
}
