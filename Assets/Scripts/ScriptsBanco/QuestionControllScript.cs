using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionControllScript : MonoBehaviour {

	public static QuestionControllScript Instance;

	public GameObject perguntaImagem;
	public GameObject perguntaImagem2;
	public GameObject pergunta;
	public GameObject resposta0;
	public GameObject resposta1;
	public GameObject resposta2;
	public GameObject resposta3;
	public GameObject curiosidade0;
	public GameObject curiosidade1;
	public GameObject curiosidade2;
	public GameObject curiosidade3;

	public GameObject[] vaziosRot;
	public GameObject respawnPosition;

	public bool GrupoVSGrupoGame = false;
	public GameObject HUDGrupoVSGrupo;
	private int randomGroup = 0;
	private int groupChoosed = 0;
	public bool groupSelected = false;
	public bool vezVermelho = false;
	public bool vezAzul = false;
	public GameObject canvasPontuacaoGrupo;
	public GameObject canvasPerguntaCuriosidade;
	public GameObject canvasRating;

	public Text pontuacaoVermelha;
	public Text pontuacaoAzul;

	public int contaPerguntas = 0;

	public int PontosVermelho = 0;
	public int PontosAzul = 0;

	public GameObject grupoV;
	public GameObject grupoA;

	public Text[] pontuacaoText;

	public int PointsArte = 0;
	public int PointsEsporte = 0;
	public int PointsCinema = 0;
	public int PointsRadio = 0;
	public int PointsHistoria = 0;
	public int PointsPropaganda = 0;


	public PerguntasClass.Temas TemaEscolhido;

	private int[] randomControll = {0,1,2,3};

	public Material[] Materiais;

	public AudioClip[] audioDasPerguntas;
	public AudioClip[] audioDasAlternativas;

	public AudioClip[] audioDasCuriosidadeArte;
	public AudioClip[] audioDasCuriosidadeEsporte;
	public AudioClip[] audioDasCuriosidadeCinema;
	public AudioClip[] audioDasCuriosidadePropaganda;
	public AudioClip[] audioDasCuriosidadesHistoria;
	private int perguntaInicial = 0;

	bool selecao = false;
	int randomNumber = 0;
	public int qtdPerguntasTentada = 0;

	int iterations = 0;

	void Start(){



		/*GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972:",
				PerguntasClass.Temas.Esporte,
				Materiais [0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Campeão mundial mais jovem de F1 até então.",
				"Curiosidade1",
				audioDasCuriosidadeEsporte[0],
				"Primeiro e único campeão brasileiro de F1 da história.",
				"Curiosidade2",
				audioDasCuriosidadeEsporte[1],
				"Campeão das 500 milhas de Indianápolis.",
				"Curiosidade3",
				audioDasCuriosidadeEsporte[2],
				"Que encerrou sua carreira após um acidente no michigan speedway.",
				"Curiosidade4",
				audioDasCuriosidadeEsporte[3],
				"resposta5",
				"curiosidade5",
				"resposta6",
				"curiosidade6"));*/

	

		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"De qual marca de refrigerante é o seguinte slogan:  “Quem bebe, repete”?",
				PerguntasClass.Temas.Propaganda,
				Materiais[2],
				audioDasPerguntas[1],
				audioDasAlternativas[1],
				"Grapette",
				"O slogan “Quem bebe Grapette, repete” apareceu em 1963. O refrigerante Grapette apareceu em território brasileiro em 1948 e foi o primeiro refrigerante com sabor uva no país. O refrigerante Grapette também faz uma aparição na música “Betty Frígida” da banda “Blitz” de 1983, na música havia o seguinte verso: “Hey Betty, vamos tomar um Grapette?”.",
				audioDasCuriosidadePropaganda[0],
				"Coca-Cola",
				"O refrigerante Coca Cola teve mais de 50 slogans de sucesso durante toda a sua história, porém nenhum deles é “quem bebe, repete”. A bebida chegou no Brasil em 1942. Na década de 60 seus slogans eram: “Tudo vai melhor com Coca-Cola” e “Isso é que é”. Na década de 70: “Coca-Cola dá mais vida”. A bebida tem muito impacto na cultura do mundo todo e é a bebida mais vendida na maioria dos paíse, já foi referenciada em inúmeras músicas nacionais e internacionais, uma das brasileiras mais famosas é a música “Geração Coca-Cola” da banda “Legião Urbana” de 1985.",
				audioDasCuriosidadePropaganda[1],
				"Sukita",
				"O primeiro slogan do refrigerante Sukita era: “Essa laranja é da boa”, de 1988. Sukita veio para o Brasil em 1976 e a propaganda mais famosa do refrigerante é, sem dúvidas, o “Tio Sukita” de 1999, com essa propaganda o refrigerante queria se promover entre o público jovem e moderno, o slogan dessa época era: “Quem bebe Sukita não engole qualquer coisa”.",
				audioDasCuriosidadePropaganda[2],
				"Fanta",
				"O slogan da Fanta antigamente era “Quanto mais Fanta melhor”. O refrigerante Fanta chegou no Brasil em 1964 com o sabor laranja. Segundo a própria Coca-Cola, o maior mercado de Fanta Laranja no mundo, é o Brasil. A marca Fanta é conhecida por sua variedade de sabores, existem 92 sabores oficiais. No Brasil, as versões padrão são “Laranja” e “Uva” porém, às vezes são disponibilizadas sabores especiais como “Maracujá” e “Morango”. Porém, ao redor do mundo existem alguns sabores exóticos como por exemplo, “Banana com Leite” no Japão e “Laranja com Chocolate” na Austrália.",
				audioDasCuriosidadePropaganda[3],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"O ano de 1969, segundo historiadores, foi a ano em que tudo aconteceu exceto:",
				PerguntasClass.Temas.História,
				Materiais [3],
				audioDasPerguntas [2],
				audioDasAlternativas [2],
				"Bill Gates e Paul Allen fundam a Microsoft.",
				"A Microsoft foi fundada em 1975 por Bill Gates e Paul Allen. Em 1985 a Microsoft e a IBM assinam acordo para desenvolvimento conjunto de um futuro sistema operacional, no mesmo ano lança o Microsoft Windows 1.0 por 99 dólares.Em 1988 a Apple acusa a Microsoft de plágio sobre o seu Macintosh OS (contudo este se baseia no sistema gráfico do Xerox Alto) com o Windows 2.0, mas no ano seguinte formam uma aliança para desenvolver o padrão de fontes TrueType.",
				audioDasCuriosidadesHistoria [0],
				"Festival de Woodstock",
				"A expressão “sexo, drogas e rock n’ roll” nunca teve tanto sentido como nos 3 dias do Woodstock. Um dos maiores eventos populares da história da música, contou com 32 dos principais nomes da música da época e embora tenha sido projetado para reunir no máximo 20.000 pessoas o evento acabou reunindo mais de 500.000 e isso em 1969 era muita gente.",
				audioDasCuriosidadesHistoria [1],
				"Primeiro Homem na Lua",
				"Chegada do homem a Lua. Embora tenha sido uma conquista que foi resultado da guerra fria, produto da corrida espacial foi bem como Neil Armstrong disse “Este é um pequeno passo para um homem, mas um grande salto para a humanidade”. Acima de toda aquela supremacia entre as nações havia as pessoas que estavam comprometidas com aquele projeto de que o impossível só era impossível se não fosse tentado.",
				audioDasCuriosidadesHistoria [2],
				"Milésimo gol de Pelé",
				"Em 1969 Pelé entra mais uma vez para a história do futebol por realizar o seu gol número 1000 numa partida contra o Vasco da Gama no Maracanã, um gol de pênalti aos 33 minutos do primeiro tempo. Isso acabou se tornando uma meta a ser batida para muitos jogadores e esse feito só foi alcançado novamente em 2007 pelo Romário , ou seja 38 anos depois.",
				audioDasCuriosidadesHistoria [3],
				"resposta5",
				"curiosidade5",
				"resposta6",
				"curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"A matéria Educação moral e cívica foi instituída no Ensino Médio por qual governo?",
				PerguntasClass.Temas.História,
				Materiais [4],
				audioDasPerguntas [3],
				audioDasAlternativas [3],
				"Getulho Vargas",
				"O ensino de Educação Moral, Cívica e, em alguns casos, física, já vinha sendo praticado no Brasil, mas a critério dos estabelecimentos. A adoção da disciplina na curricularidade escolar nacional ganhou efetividade com o Decreto-lei nº 2.072, de 8 de março de 1940, de Getúlio Vargas, que estabeleceu a obrigatoriedade da Educação Cívica, Moral e Física da infância e da juventude.",
				audioDasCuriosidadesHistoria [4],
				"Médici",
				"O governo Médici foi responsável pela eliminação das guerrilhas comunistas rurais e urbanas. Ancorada pelo Ato Institucional nº 5, de dezembro de 1968, a repressão às manifestações populares e às guerrilhas foi bastante pesada. A resistência passou a ser armada, com assaltos aos bancos para obter esse artifício; atentados contra militares; sequestros de pessoas beneficiadas pelo regime e treinamento de guerrilhas.",
				audioDasCuriosidadesHistoria [5],
				"FHC",
				"Fernando Henrique Cardoso foi presidente por dois mandatos consecutivos. Suas principais marcas foram a consolidação do Plano Real, a reforma do Estado brasileiro, com a privatização de empresas estatais, a criação das agências regulatórias e a mudança da legislação que rege o funcionalismo público, bem como a introdução de programas de transferência de renda como o Bolsa Escola.",
				audioDasCuriosidadesHistoria [6],
				"Collor",
				"Um dos pontos importantes do plano Collor previa o confisco dos depósitos bancários superiores a Cr$ 50.000,00 (cinquenta mil cruzeiros) por um prazo de dezoito meses. Mesmo sendo o confisco bancário um flagrante desrespeito ao direito constitucional de propriedade o plano econômico conduzido pela Ministra da Economia Zélia Cardoso de Mello foi aprovado pelo Congresso Nacional em questão de poucos dias.",
				audioDasCuriosidadesHistoria [7],
				"resposta5",
				"curiosidade5",
				"reposta6",
				"curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"As olímpiadas do México em 1968, foram marcadas por grandes polêmicas. Qual é considerada a maior delas?",
				PerguntasClass.Temas.Esporte,
				Materiais[5],
				audioDasPerguntas[4],
				audioDasAlternativas[4],
				"Três atletas do pódio, fizeram um ato contra o racismo.",
				" Os atletas do 1º e 3º lugar da prova, eram atletas afro-americanos, ao receberem as medalhas, os dois levantaram os punhos com luvas pretas, esse gesto, é a saudação e o maior símbolo do movimento revolucionário negro “Panteras Negras”. Ambos os atletas foram expulsos da vila olímpica e da delegação esportista americana. O 2º lugar da prova, um australiano, apoiou o movimento de seus colegas de pódio e carregou uma insígnia das “Olímpiadas pelos Direitos Humanos”, o atleta foi muito criticado em seu país pois, na Austrália, havia legalmente segregação do povo aborígene.",
				audioDasCuriosidadeEsporte[4],
				"As olímpiadas mostraram ao mundo dois tipos de dopping",
				" Não foi a maior polêmica dos jogos porém, nos jogos mexicanos, aconteceu o primeiro teste antidoping positivo e, além do dopping artificial, o mundo descobriu um novo “método de dopping”, o dopping natural, devido a latitude da Cidade do México, a resistência do ar é menor e devido a isso, os jogos tiveram 68 recordes mundiais e 301 recordes olímpicos foram quebrados.",
				audioDasCuriosidadeEsporte[5],
				"Teste de comprovação de sexo para provas femininas",
				" Esse assunto gerou polêmica, porém, não foi a mais impactante. O comitê olímpico suspeitou do porte físico de algumas atletas do bloco socialista e inseriu esse teste. Nenhuma atleta reprovou no teste porém, várias atletas importantes não se inscreveram para os jogos",
				audioDasCuriosidadeEsporte[6],
				"Primeira mulher a acender a pira",
				" Apesar de não ter sido o fato mais marcante dos jogos olímpicos, no ano de 1968, foi a primeira vez que uma atleta teve a honra de acender a pira na cerimônia de abertura, a atleta foi a velocista Enriqueta Basilio.",
				audioDasCuriosidadeEsporte[7],
				"resposta5",
				"curiosidade5",
				"resposta6",
				"curiosidade6",
				false));


			

		/*
		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"Quem Protagonizou o filme Três Homens em Conflito?",
				PerguntasClass.Temas.Cinema,
				Materiais[1],
				"Clint Eastwood",
				"Curiosidade1",
				"Lee Van Cleef",
				"Curiosidade2",
				"Willian Holder",
				"Curiosidades3",
				"Marlon Brando",
				"Curiosidade4",
				"Alpatino",
				"Curiosidade5",
				"Sean Coorney",
				"Curiosidade6"));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"Na 13º Bienal de Arte de São Paulo, conhecida como “Bienal dos Videomakers”, que ocorreu em 1975, um dos grandes artistas que participaram do evento foi Andy Warhol, ele foi o maior artista de um movimento. Qual movimento é esse?\n",
				PerguntasClass.Temas.Arte,
				Materiais [2],
				"PopArt",
				"Pop Art é um movimento artístico nascido na Inglaterra na década de 50. Esse movimento tinha como proposta, mostrar a crise que arte estava sofrendo no Século XX e criticar a cultura capitalista e consumista da sociedade. No Brasil, esse movimento foi utilizado para criticar a ditadura e a censura do regime militar. Esse movimento é considerado o marco de passagem da modernidade para a pós-modernidade no ocidente.\n",
				"Abstracionismo",
				"Abstracionismo é um movimento que não representa objetos de forma concreta, os artistas se utilizam de cores e linhas para mostrar algo de maneira “não representacional”, subjetiva. Na Bienal de 75, a artista representante desse movimento, foi a brasileira Tomie Ohtake.",
				"Video Art",
				"VideoArte foi um movimento que se utilizava de sons e imagens gravadas em uma câmera para criar obras artísticas. O representante desse movimento na Bienal de 75, foi o sul-coreano Nam June Paik.",
				"Realismo Capitalista",
				"Movimento artístico alemão, foi influenciado pela Pop Art, tinha como foco a representação da crescente cultura consumista alemã e a sociedade saturada de mídia. O representante desse movimento na Bienal de 75, foi Sigmar Polke, ele foi um dos quatro grandes nomes desse movimento.",
				"Neo-Expressionismo",
				"Movimento influenciado pelo Expressionismo, Simbolismo, e Surrealismo.  O representante desse movimento na Bienal de 75, foi o saxão Georg Baselitz.\n",
				"Conceitualismo",
				"A arte conceitual utiliza fotos, textos, objetos e vídeos de maneira minimalista, também é chamada de arte pobre. A arte conceitual tinha como objetivo desmaterializar os processos artísticos. Um dos principais nome do movimento foi o brasileiro Cildo Meireles.\n"));

			*/

		//GameControl.gControl.perguntasList [1].respostasBd [2].correta = true;

		//vaziosRot [0].transform.position = new Vector3 (vaziosRot [0].transform.position.x, vaziosRot [0].transform.position.y, vaziosRot [0].transform.position.z);

	}
	// Use this for initialization
	void Awake () {
		Instance = this;
	}
		
	
	// Update is called once per frame
	void Update () {


			
	}

	public void VoltaRotacaoVazio(){
		vaziosRot [0].transform.position = respawnPosition.transform.position;
		vaziosRot [0].transform.localRotation = Quaternion.identity;//Quaternion.Euler (0, 0, 0);

		/*vaziosRot [1].transform.rotation = Quaternion.Euler (0, 0, 0);
		vaziosRot [1].transform.localPosition = new Vector3 (-2.56f, 1.15f, -3.27f);
		vaziosRot [2].transform.rotation = Quaternion.Euler (0, 0, 0);
		vaziosRot [2].transform.localPosition = new Vector3 (-2.59f, 0, -3.27f);
		vaziosRot [3].transform.rotation = Quaternion.Euler (0, 0, 0);
		vaziosRot [3].transform.localPosition = new Vector3 (-5.42f, 1.15f, -3.27f);*/
	}

	public void ContaSmile(){
		if (vezVermelho) {
			PontosVermelho += 10;
			pontuacaoVermelha.text = PontosVermelho.ToString ();
		}

		if (vezAzul) {
			PontosAzul += 10;
			pontuacaoAzul.text = PontosAzul.ToString ();

		}

		if (contaPerguntas == 2) {
			canvasPontuacaoGrupo.SetActive (true);
			canvasPerguntaCuriosidade.SetActive (false);
			canvasRating.SetActive (false);
			iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
				"x", 0.27f,
				"y", -0.06f,
				"z", -10.1f,
				"time", 2,
				"speed", 2,
				"looptype", iTween.LoopType.none,
				"easetype", iTween.EaseType.linear));
		} else {
			canvasRating.SetActive (false);
			VerificaCuriosidadeScript.Instance.VoltarAosTemas ();
		}

	}

	public void ContaTriste(){
		if (vezVermelho) {
			PontosVermelho -= 10;
			pontuacaoVermelha.text = PontosVermelho.ToString ();
		}

		if (vezAzul) {
			PontosAzul -= 10;
			pontuacaoAzul.text = PontosAzul.ToString ();
		}


		if (contaPerguntas == 2) {
			canvasPontuacaoGrupo.SetActive (true);
			canvasPerguntaCuriosidade.SetActive (false);
			canvasRating.SetActive (false);
			iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
				"x", 0.27f,
				"y", -0.06f,
				"z", -10.1f,
				"time", 2,
				"speed", 2,
				"looptype", iTween.LoopType.none,
				"easetype", iTween.EaseType.linear));

		} else {
			canvasRating.SetActive (false);
			VerificaCuriosidadeScript.Instance.VoltarAosTemas ();
		}

	}

	public void ContaPontuacaoGrupoVSGrupo(){
		
		if (GrupoVSGrupoGame == true) {
			if (vezVermelho) {
				PontosVermelho -= 10;
				//Debug.Log (PontosVermelho);
			}

			if (vezAzul) {
				PontosAzul -= 10;
				//Debug.Log (PontosAzul);
			}
		}
	}

	public void ContaPontuacao(){

		if (GrupoVSGrupoGame == false) {
		
			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.Arte) {
				PointsArte += 10;
				pontuacaoText [0].text = PointsArte.ToString ();
			}

			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.Esporte) {
				PointsEsporte += 10;
				pontuacaoText [1].text = PointsEsporte.ToString ();
			}

			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.Cinema) {
				PointsCinema += 10;
				pontuacaoText [2].text = PointsCinema.ToString ();
			}

			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.Radio) {
				PointsRadio += 10;
				pontuacaoText [3].text = PointsRadio.ToString ();
			}

			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.História) {
				PointsHistoria += 10;
				pontuacaoText [4].text = PointsHistoria.ToString ();
			}

			if (QuestionControllScript.Instance.TemaEscolhido == PerguntasClass.Temas.Propaganda) {
				PointsPropaganda += 10;
				pontuacaoText [5].text = PointsPropaganda.ToString ();
			}
		} else {
			return;
		}
		}




	public void FunctionGrupoVSGrupo(){

		groupChoosed = randomGroup;

		if (!groupSelected) {

			do {
				randomGroup = Random.Range (0, 2);
			} while (randomGroup == groupChoosed);

			groupSelected = true;
		}
			
			
		if (randomGroup == 0) {
			HUDGrupoVSGrupo.SetActive (true);
			grupoV.SetActive (false);
			vezVermelho = true;
			vezAzul = false;
			grupoA.SetActive (true);
		}

		if (randomGroup == 1) {
			HUDGrupoVSGrupo.SetActive (true);
			grupoA.SetActive (false);
			vezAzul = true;
			vezVermelho = false;
			grupoV.SetActive (true);
		}
	}

	public void SelecionaQuestao(){
		

		int qtdPerguntaTema = 0;
	



		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			if (GameControl.gControl.perguntasList [i].tema == TemaEscolhido) {
				qtdPerguntaTema++; 
			}
		}


		randomNumber = UnityEngine.Random.Range (perguntaInicial, GameControl.gControl.perguntasList.Count);

		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			if (GameControl.gControl.perguntasList [i].tentada && GameControl.gControl.perguntasList[randomNumber].tema == TemaEscolhido) {
				qtdPerguntasTentada++;

			}
		}

		if(qtdPerguntasTentada >= qtdPerguntaTema ){

			for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
				if (GameControl.gControl.perguntasList [i].tema == TemaEscolhido) {
					GameControl.gControl.perguntasList[i].tentada = false;
				}
			}
			//Debug.Log ("correcao");

		}
	

		iterations++;

		if ((int)GameControl.gControl.perguntasList [randomNumber].tema == (int)TemaEscolhido) {

			//Debug.Log("Quantidade de perguntas do tema:" + qtdPerguntaTema);


			if (!GameControl.gControl.perguntasList [randomNumber].tentada) {
				//Debug.Log ("OK");
				selecao = true;
			}
		}
		if (iterations > 1000) {
			//Debug.Log ("Bug Splash");
		
			//Debug.Log("Tema Escolhido pelo jogador:" + TemaEscolhido);
			//Debug.Log("Tema da Pergunta" + GameControl.gControl.perguntasList[randomNumber].tema);
			//Debug.Log("Quantidade de perguntas do tema:" + qtdPerguntaTema);
			//Debug.Log("Quantidade em que ela foi tentada:" + qtdPerguntasTentada);
			selecao = true;
			UnityEditor.EditorApplication.isPlaying = false;
		}
		//Debug.Log(GameControl.gControl.perguntasList[randomNumber].tentada);
	}

	public void SetQuestion(){




	

		int qtdPerguntaTema = 0;
		int qtdPerguntasTentada = 0;
		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			if (GameControl.gControl.perguntasList [i].tema == TemaEscolhido) {
				qtdPerguntaTema++; 
			}
		}
		//for(PerguntasClass.Temas i = null; i != TemaEscolhido; i = GameControl.gControl.perguntasList[Random.Range(perguntaInicial,GameControl.gControl.perguntasList.Count)].tema)
		/*do {
			
			
			randomNumber = UnityEngine.Random.Range (perguntaInicial, GameControl.gControl.perguntasList.Count);
	
			if(GameControl.gControl.perguntasList[randomNumber].tentada == true && GameControl.gControl.perguntasList[randomNumber].tema == TemaEscolhido){
				qtdPerguntasTentada++;
					
			}

			if(qtdPerguntaTema == qtdPerguntasTentada){
				
				for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
					if (GameControl.gControl.perguntasList [i].tema == TemaEscolhido) {
						GameControl.gControl.perguntasList[i].tentada = false;
					}
				}
			}
				
			Debug.Log("Quantidade de perguntas do tema:" + qtdPerguntaTema);
			Debug.Log("Quantidade em que ela foi tentada:" + qtdPerguntasTentada);
			Debug.Log("Tema Escolhido pelo jogador:" + TemaEscolhido);
			Debug.Log("Tema da Pergunta" + GameControl.gControl.perguntasList[randomNumber].tema);
			Debug.Log(GameControl.gControl.perguntasList[randomNumber].textoDaPerguntaBd);
			Debug.Log("Tentada:" + GameControl.gControl.perguntasList[randomNumber].tentada);

		} while((int)GameControl.gControl.perguntasList [randomNumber].tema != (int)TemaEscolhido && GameControl.gControl.perguntasList[randomNumber].tentada == true);*/


		for (bool ok = false; ok != true; ok = selecao) {
			SelecionaQuestao ();
			
		}





			pergunta.GetComponent<ButtonScript> ().QuestionText.text = GameControl.gControl.perguntasList [randomNumber].textoDaPerguntaBd; 
			
			perguntaImagem.GetComponent<MeshRenderer> ().material = GameControl.gControl.perguntasList [randomNumber].materialImagem;
			perguntaImagem2.GetComponent<ButtonScript> ().audioDaPergunta = GameControl.gControl.perguntasList [randomNumber].audioDaQuestao;
			pergunta.GetComponent<ButtonScript> ().audioDasAlternativas = GameControl.gControl.perguntasList [randomNumber].alternativas;
			
				

		for (int i = 0; i < 4; i++) {
			randomControll [i] = i;
		}

		resposta0.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta1.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta2.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta3.GetComponent<ButtonScript> ().AnswerText.text = null;

		int randomAnswer;


		if (resposta0.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);
					
			resposta0.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade0.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				curiosidade0.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades1;
			} else if (randomAnswer == 1) {
				curiosidade0.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades2;
			} else if (randomAnswer == 2) {
				curiosidade0.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades3;
			} else if (randomAnswer == 3) {
				curiosidade0.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades4;
			}

			if (randomAnswer == 0) {
				resposta0.GetComponent<ButtonScript> ().isCorrect = true;
			}else {
				resposta0.GetComponent<ButtonScript> ().isCorrect = false;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}


		if (resposta1.GetComponent<ButtonScript> ().AnswerText.text == "") {

			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta1.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade1.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				curiosidade1.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades1;
			} else if (randomAnswer == 1) {
				curiosidade1.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades2;
			} else if (randomAnswer == 2) {
				curiosidade1.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades3;
			} else if (randomAnswer == 3) {
				curiosidade1.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades4;
			}

			if (randomAnswer == 0) {
				resposta1.GetComponent<ButtonScript> ().isCorrect = true;
			}
			else {
				resposta1.GetComponent<ButtonScript> ().isCorrect = false;
			} 
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}
		if (resposta2.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta2.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade2.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				curiosidade2.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades1;
			} else if (randomAnswer == 1) {
				curiosidade2.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades2;
			} else if (randomAnswer == 2) {
				curiosidade2.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades3;
			} else if (randomAnswer == 3) {
				curiosidade2.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades4;
			}
			if (randomAnswer == 0) {
				resposta2.GetComponent<ButtonScript> ().isCorrect = true;
			} else {
				resposta2.GetComponent<ButtonScript> ().isCorrect = false;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}

		if (resposta3.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta3.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade3.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				curiosidade3.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades1;
			} else if (randomAnswer == 1) {
				curiosidade3.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades2;
			} else if (randomAnswer == 2) {
				curiosidade3.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades3;
			} else if (randomAnswer == 3) {
				curiosidade3.GetComponent<ButtonScript> ().audioCuriosisidade = GameControl.gControl.perguntasList [randomNumber].audiosCuriosidades4;
			}
			if (randomAnswer == 0) {
				resposta3.GetComponent<ButtonScript> ().isCorrect = true;
			} else {
				resposta3.GetComponent<ButtonScript> ().isCorrect = false;
			}

			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}

		GameControl.gControl.perguntasList [randomNumber].tentada = true;
		selecao = false;
		qtdPerguntasTentada = 0;


		/*int qtdPerguntaTema = 0;
		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			if (GameControl.gControl.perguntasList [i].tema == TemaEscolhido) {
				qtdPerguntaTema++; 
			}
		}

		int qtdTentada = 0;
		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			if (GameControl.gControl.perguntasList[i].tema == TemaEscolhido && GameControl.gControl.perguntasList[i].tentada == true) {
				qtdTentada++;
			}
		}

		Debug.Log (qtdTentada);
		Debug.Log (qtdPerguntaTema);

		if (qtdPerguntaTema == qtdTentada) {
			for(int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
				if (GameControl.gControl.perguntasList[i].tema == TemaEscolhido && GameControl.gControl.perguntasList[i].tentada == true) {
					GameControl.gControl.perguntasList [i].tentada = false;
				}
			}

			qtdPerguntaTema = 0;
			qtdTentada = 0;
		}*/


			
			/*resposta1.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].textoDaResposta;
			resposta2.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].textoDaResposta;
			resposta3.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].textoDaResposta;

			
			curiosidade1.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].curiosidade;
			curiosidade2.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].curiosidade;
			curiosidade3.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].curiosidade;*/

	}



}
		


