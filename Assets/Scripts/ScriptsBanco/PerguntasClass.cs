using UnityEngine;
using System.Collections.Generic;

public class PerguntasClass : MonoBehaviour {

	public string textoDaPerguntaBd;
	public Sprite dica;
	public AudioSource audioDaQuestao;
	public List<RespostasClass> respostasBd = new List<RespostasClass>();
	public int frequencia;
	public int rating;
	public enum Temas {Musica,Futebol,Radio,Arte,Outro};
	public Temas tema; 
	public bool minhaMae = false;


	public PerguntasClass(
		string TextoDaPergunta,
		Temas TemaDaQuestao,
		string Resposta1Certa,
		string Curiosidade1,
		string Resposta2,
		string Curiosidade2,
		string Resposta3,
		string Curiosidade3,
		string Resposta4,
		string Curiosidade4,
		string Resposta5,
		string Curiosidade5,
		string Resposta6,
		string Curiosidade6,
		Sprite Dica = null,
		AudioSource AudioDaQuestao = null)
	{
		textoDaPerguntaBd = TextoDaPergunta;
		tema = TemaDaQuestao;
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta1Certa,Curiosidade1,true));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta2,Curiosidade2));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta3,Curiosidade3));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta4,Curiosidade4));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta5,Curiosidade5));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta6,Curiosidade6));
		audioDaQuestao = AudioDaQuestao;
		dica = Dica;

	}
}