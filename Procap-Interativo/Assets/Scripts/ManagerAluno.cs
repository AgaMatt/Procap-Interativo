using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAluno : MonoBehaviour
{
	public GameObject Selecao, Materia, Simulado, Treino;
	bool SimuladoTreino, PortMath;

	public void SimuladoButton ()
	{
		SimuladoTreino = true;
		Selecao.SetActive (false);
		Materia.SetActive (true);
	}

	public void AvaliacaoButton ()
	{
		SimuladoTreino = false;
		Selecao.SetActive (false);
		Materia.SetActive (true);
	}

	public void PortuguesButton ()
	{
		PortMath = true;
		Materia.SetActive (false);
		if (SimuladoTreino) {
			Simulado.SetActive (true);
			Treino.SetActive (false);
		} else {
			Treino.SetActive (true);
			Simulado.SetActive (false);
		}
	}

	public void MatematicaButton ()
	{
		PortMath = false;
		Materia.SetActive (false);
		if (SimuladoTreino) {
			Simulado.SetActive (true);
			Treino.SetActive (false);
		} else {
			Treino.SetActive (true);
			Simulado.SetActive (false);
		}
	}

	public void Terminar ()
	{
		Simulado.SetActive (false);
		Treino.SetActive (false);
		Selecao.SetActive (true);
	}
}
