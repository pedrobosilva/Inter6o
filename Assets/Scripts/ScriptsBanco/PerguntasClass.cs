using UnityEngine;
using System.Collections.Generic;

public class PerguntasClass : MonoBehaviour {



	public string textoDaPerguntaBd;
	public Sprite dica;
	public AudioClip audioDaQuestao;
	public AudioClip alternativas;
	public AudioClip audiosCuriosidades1;
	public AudioClip audiosCuriosidades2;
	public AudioClip audiosCuriosidades3;
	public AudioClip audiosCuriosidades4;
	public AudioClip audiosCuriosidades5;
	public AudioClip audiosCuriosidades6;
	public List<RespostasClass> respostasBd = new List<RespostasClass>();
	public int frequencia;
	public int rating;
	public enum Temas {Cinema,Esporte,Radio,Arte,História,Propaganda,Outro};
	public Temas tema; 
	public Material materialImagem;
	public bool tentada = false;


	public PerguntasClass(
		string TextoDaPergunta,
		Temas TemaDaQuestao,
		Material imagemDaPergunta,
		AudioClip AudioDaQuestao,
		AudioClip AudioAlternativas,
		string Resposta1Certa,
		string Curiosidade1,
		AudioClip AudioCuriosidade1,
		string Resposta2,
		string Curiosidade2,
		AudioClip AudioCuriosidade2,
		string Resposta3,
		string Curiosidade3,
		AudioClip AudioCuriosidade3,
		string Resposta4,
		string Curiosidade4,
		AudioClip AudioCuriosidade4,
		string Resposta5,
		string Curiosidade5,
		string Resposta6,
		string Curiosidade6,
		bool PerguntaRespondida = false,
		AudioClip AudioCuriosidade5 = null,
		AudioClip AudioCuriosidade6 = null,
		Sprite Dica = null)
	{
		textoDaPerguntaBd = TextoDaPergunta;
		materialImagem = imagemDaPergunta;
		tema = TemaDaQuestao;
		audiosCuriosidades1 = AudioCuriosidade1;
		audiosCuriosidades2 = AudioCuriosidade2;
		audiosCuriosidades3 = AudioCuriosidade3;
		audiosCuriosidades4 = AudioCuriosidade4;
		tentada = PerguntaRespondida;
		audioDaQuestao = AudioDaQuestao;
		alternativas = AudioAlternativas;
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta1Certa,Curiosidade1,true));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta2,Curiosidade2));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta3,Curiosidade3));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta4,Curiosidade4));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta5,Curiosidade5));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta6,Curiosidade6));

		dica = Dica;

	}

}