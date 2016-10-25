using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class RespostasClass : MonoBehaviour {

	public Button clicavel;
	public enum Estados{Normal,Tentado,Curioso,CuriosoPronto,CertoPronto,Certo};
	public Estados estado;

	public string textoDaResposta;
	public string curiosidade;
	public bool correta = false;


	public RespostasClass(Estados Estado, string TextoDaResposta, string Curiosidade, Button botao = null)
	{
		estado = Estado;
		textoDaResposta = TextoDaResposta;
		curiosidade = Curiosidade;
		clicavel = botao;
	}
	public RespostasClass(Estados Estado, string TextoDaResposta, string Curiosidade,bool Correta, Button botao = null)
	{
		estado = Estado;
		textoDaResposta = TextoDaResposta;
		curiosidade = Curiosidade;
		correta = Correta;
		clicavel = botao;
	}
}

