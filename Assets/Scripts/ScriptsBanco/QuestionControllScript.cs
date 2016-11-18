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
	public AudioClip[] audioDasCuriosidadesRadio;

	private int perguntaInicial = 0;

	bool selecao = false;
	int randomNumber = 0;
	public int qtdPerguntasTentada = 0;

	int iterations = 0;

	void Start(){

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Quem foi o autor do quadro “Criança Morta”?",
				PerguntasClass.Temas.Arte,
				Materiais[6],
				audioDasPerguntas[5],
				audioDasAlternativas[5],
				"Candido Portinari",
				"Candido Portinari realizou cerca de 4.500 obras em 40 anos de trabalho , só cursou o primário. Quando ainda estava na escola, Portinari desenhou um leão em sala de aula. A obra foi tão adorada que ele foi obrigado a desenhar a capa de todas as provas que seriam expostas no final de ano. Aos 9 anos pintou o teto da igreja de sua cidade.",
				audioDasCuriosidadeArte[0],
				"Lasar Segall",
				"Lasar Segall nasceu na Lituânia. Em 1912 veio ao Brasil,deu aulas de desenho à jovem Jenny Klabin,com quem iria se casar doze anos mais tarde. No final daquele voltou à Europa   e conheceu Margarete Quack, com quem se casou no fim Primeira Guerra teve.Lasar e Margarete voltam ao Brasil. Um ano depois, em 1924, se separou e se casou com Jenny Klabin, sua ex-aluna.",
				audioDasCuriosidadeArte[1],
				"Tarsila do Amaral",
				"Foi considerada a pintora mais representativa da primeira fase do Modernismo no Brasil e recebeu o Prêmio de Pintura Nacional na I Bienal de São Paulo, em 1951. A pintora costumava levar cachaça brasileira em suas viagens ao exterior. Ela enganava os funcionários da alfândega dizendo que era álcool para “passar na pele”.",
				audioDasCuriosidadeArte[2],
				"Romero Britto",
				"Romero Britto é um artista plástico brasileiro de grande renome internacional, radicado nos Estados Unidos, Além das celebridades norte-americanas, Britto também produziu telas para Bill Clinton, o príncipe William, Kate Middleton, Pelé, Roberto Marinho e para a ex-Presidente do país, Dilma Rousseff.",
				audioDasCuriosidadeArte[3],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"A qual movimento artístico pertence a seguinte obra?",
				PerguntasClass.Temas.Arte,
				Materiais[7],
				audioDasPerguntas[6],
				audioDasAlternativas[6],
				"Arte conceitual",
				"A arte conceitual teve sua origem na obra de Duchamp, no episódio no qual enviou um mictório para um salão de arte,sob o título “A Fonte”, o artista inaugurou contra a sua própria vontade, um novo movimento artístico  na qual a idéia é o mais importante da obra.",
				audioDasCuriosidadeArte[4],
				"Expressionismo",
				"Expressionismo que teve seu auge no final do século XIX e início do século XX.Sem preocupação com a beleza ou com os padrões.O período em que se desenvolveu esse movimento artísticos foi muito conturbado. Cenário da primeira guerra mundial. A pintura “O Grito” é o melhor exemplo do estilo artístico denominado Expressionismo.",
				audioDasCuriosidadeArte[5],
				"Naturalismo",
				"Naturalismo é conhecido por ser a radicalização do Realismo, baseando-se na observação fiel da realidade e na experiência, mostrando que o indivíduo é determinado pelo ambiente e pela hereditariedade. O movimento esboçou o que se pode declarar como os primeiros passos do pensamento teórico evolucionista de Charles Darwin.",
				audioDasCuriosidadeArte[6],
				"Simbolismo",
				"Simbolismo é um movimento literário da poesia e das outras artes que surgiu na França, no final do século XIX, como oposição ao realismo, ao naturalismo e ao positivismo da época. Movido pelos ideais românticos, teve suas origens de “As Flores do Mal”, do poeta Charles Baudelaire.",
				audioDasCuriosidadeArte[7],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual marca de creme dental foi comprada e fundida para se tornar a atual Sorriso?",
				PerguntasClass.Temas.Propaganda,
				Materiais[8],
				audioDasPerguntas[7],
				audioDasAlternativas[7],
				"Kolynos",
				"Kolynos é uma marca de pasta-de-dente muito famosa no Brasil, que foi extinta e substituída na fusão, pela então recém-criada Sorriso.A força desta marca era tão grande que apenas recentemente, em 2003, quando indagados por uma pesquisa, que tinha o objetivo de tabular as marcas mais lembradas na cabeça do consumidor , a Kolynos perdeu a primeira posição para sua substituta, a Sorriso. Um fato incrível, já que desde 1997 a marca havia sido extinta.",
				audioDasCuriosidadePropaganda[4],
				"Colgate",
				" William Colgate, fundador da Colgate-Palmolive, lançou o tubo de creme dental, que revolucionou a maneira de vender tal produto e até o momento a venda era feita em pó ou em frascos.O Colgate Ribbon Dental Cream foi o primeiro creme dental em um tubo flexível, introduzido em 1896, quando tinha anteriormente sido vendido em frascos de vidro desde 1873.",
				audioDasCuriosidadePropaganda[5],
				"Close-up",
				"Close-Up é uma marca pertencente à multinacional Unilever referente a uma linha de produtos de higiene bucal. O gel dental desta linha foi o primeiro a ser lançado no mercado norte-americano. Foi lançado no Brasil em 1972. Na década de 60 foi o primeiro gel dental dos EUA, e no Brasil Close Up chegou pouco tempo depois, em 1971, construindo uma identidade própria, inovadora e que fala com o público jovem através de suas campanhas ousadas e produtos diferenciados.",
				audioDasCuriosidadePropaganda[6],
				"Gessy",
				"Desde 1946, a publicidade usava o fim de um romance com o mau hálito para promover o Creme Dental Gessy,utilizando a seguinte deixa: Porque, às vezes, todo o curso de um romance depende de um pormenor… da pureza e frescor de seu hálito. Esteja certa de que isto não lhe sucederá, protegendo seu hálito… protegendo seus dentes com o creme dental Gessy.",
				audioDasCuriosidadePropaganda[7],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false)); 

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
				"curiosidade6"));



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

	*/


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

		#region "Perguntas sem Material e Áudio"
		/*
		//PERGUNTAS DE ARTE -------------------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Em 1969 Chico Buarque de Holanda, já com 25 anos, buscou refúgio na Itália devido à crescente repressão do regime militar do Brasil os chamados “anos de chumbo”, contudo nessa época já havia produzido a música “A Banda” e com isso:",
				PerguntasClass.Temas.Arte,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Ganhou o festival de música popular brasileira",
				"Chico Buarque revelou-se ao público brasileiro quando ganhou o mesmo Festival, no ano seguinte (1966), transmitido pela TV Record, com A Banda, interpretada por Nara Leão (empatou em primeiro lugar com Disparada, de Geraldo Vandré, interpretada por Jair Rodrigues).No entanto, Zuza Homem de Mello, no livro A Era dos Festivais: Uma Parábola, revelou que “A Banda” venceu o festival.",
				audioDasCuriosidadeArte[0],
				"Teve suas canções “Apesar de você” e “Cálice” censuradas pelo regime militar",
				"A música “Apesar de você” foi vista pelo regime como uma alusão negativa ao presidente Médici, apesar de Chico Buarque afirmar que era sobre a situação atual 'na época', já “Cálice” foi censurada  devido ao cacófato que ocorre com a frase “Cale-se!”. Fato que incentivou o cantor a adotar o pseudônimo de Julinho da Adelaide para compositor",
				audioDasCuriosidadeArte[0],
				"Se tornou um dos artistas mais ativos na crítica política e na luta pela democratização no país",
				"De fato isso ocorreu mas foi depois 1970, após seu retorno da Itália e com as música “Cálice” e “Apesar de você”",
				audioDasCuriosidadeArte[0],
				"Artista foi homenageado no desfile das escolas de samba do Rio de Janeiro",
				"Em 1998, pela GRES Estação Primeira de Mangueira,o artista foi homenageado, no enredo “Chico Buarque da Mangueira”. A escola verde e rosa dividiu o título de campeã daquele carnaval com a Beija-Flor de Nilópolis.",
				audioDasCuriosidadeArte[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));





		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Quem foi o autor do quadro “A ventania”?",
				PerguntasClass.Temas.Arte,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Anita Malfatti",
				"Anita Malfatti é considerada a primeira representante do modernismo no Brasil. Aos 19 anos se formou como professora pela escola normal. Foi casada com Mário de Andrade, que participaram juntos do chamado  “Grupo dos Cinco” que era composto por, Tarsila do Amaral, Anita Malfatti, Mário de Andrade, Oswald de Andrade e Menotti Del Picchia.",
				audioDasCuriosidadeArte[0],
				"Van Gogh",
				"Um mês antes de sua morte,Van Gogh pintava uma tela por dia, foi quando pintou “Campo de Trigo com Corvo”, obra que expressava toda a tristeza e solidão. No dia 27 de julho de 1890, Vincent Wilen Van Gogh caminhou até o campo frente ao lugar em que morava e deu um tiro contra o próprio peito.Tendo vendido apenas uma única tela, morreu sem saber que seus quadros estariam, algum dia, entre os mais caros do mundo.",
				audioDasCuriosidadeArte[0],
				"Claude Monet",
				"O jovem Monet não gostava de ir à escola e tinha a mania de usar os cadernos para fazer desenhos,  já vendia seus desenhos e caricaturas nas ruas aos 15 anos de idade. Com a morte da mãe, Monet abandonou a escola. Na época, o pintor tinha apenas 16 anos.",
				audioDasCuriosidadeArte[0],
				"Edvard Munch",
				"Na obra “o Grito”, o personagem atormentado e disforme que emite este pedido de socorro agonizante é o próprio pintor. Ele se encontrava com uns amigos em uma colina perto de Oslo, de onde se vê toda a cidade, a Colina de Ekeberg, quando sofreu um ataque de pânico.",
				audioDasCuriosidadeArte[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		//PERGUNTAS DE CINEMA-------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual era o nome do gato da personagem interpretada pela Audrey Hepburn no filme “Bonequinha de Luxo”?",
				PerguntasClass.Temas.Cinema,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Gato",
				"Holly (Personagem interpretada por Audrey Hepburn) acredita que assim como ela seu gato não está realmente se sentindo em casa, por esse motivo ela não lhe deu um nome e o chama simplesmente de Gato.",
				audioDasCuriosidadeCinema[0],
				"Lassie",
				"Lassie é considerada “a cadela mais famosa do mundo” e realmente ela merece esse título, a cadelinha atuou em mais de oito filmes e cinco séries de TV, ela é tão famosa que é um dos três animais que foram homenageados na Calçada da Fama em Hollywood, ao lado de Rin Tin Tin e Strongheart.",
				audioDasCuriosidadeCinema[0],
				"Rinty",
				"Rinty ou como era mais conhecido Rin Tin Tin foi um famoso cachorro da década de 1920 e que continuou fazendo sucesso por muitos anos depois de seu lançamento, participou de vários programas de TV e de rádio, sempre fazendo o papel de um cachorro valente e destemido.",
				audioDasCuriosidadeCinema[0],
				"Orangey",
				"Orangey é o verdadeiro nome do gato fora das telonas, ele é literalmente considerado uma celebridade e tem uma página dedicada exclusivamente para ele na internet.",
				audioDasCuriosidadeCinema[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"“Três Homens em conflito” (1966), também conhecido como “O Bom, O Mau e O Feio” era o último filme da trilogia dos dólares de Sergio Leone, quais eram os outros dois filmes da trilogia?",
				PerguntasClass.Temas.Cinema,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"“Por um punhado de dólares” (1964) e “Por uns dólares a mais” (1965)",
				"A trilogia dos dólares era também conhecida por “Trilogia do Pistoleiro sem nome” pois fazia referência ao personagem de Clint Eastwood. Os Filmes de Leone ficaram extremamente conhecidos pela trilha sonora marcante, que até hoje é reconhecida como um ícone dos filmes de Bang Bang.",
				audioDasCuriosidadeCinema[0],
				"“Era uma vez no Oeste” (1968) e “Rastros de Odio” (1959)",
				"“Era uma vez no Oeste” também era um filme de Sergio Leone, aonde o mesmo pretendia apresentar os três protagonistas de “Três Homens em Conflito” logo no começo do filme, porém a ideia foi abandonada, já que o filme não faz parte da trilogia e por Clint Eastwood na época não estar disponível.  Já “Rastros de Ódio” era um filme de John Ford, que tinha como protagonista e ator principal John Wayne, que também foi um dos grandes ícones dos filmes de Faroeste.",
				audioDasCuriosidadeCinema[0],
				"“Sete homens e um destino” (1960) e “Um pistoleiro chamado Papaco” (1986)",
				"“Sete homens e um destino” dirigido por John Sturges, é um clássico dos filmes de Faroeste, inspirado em um filme japonês ele fez muito sucesso na época em que foi lançado, fazendo com que fossem criados vários seriados e filmes nos anos após seu lançamento. Mais atualmente um remake do filme foi feito. Já “Um pistoleiro chamado Papaco” era um filme brasileiro do gênero de “pornochanchada”, que chamou a atenção por ser um dos primeiros do gênero e ter um humor voltado para o erotismo, coisa que não era muito comum na época.",
				audioDasCuriosidadeCinema[0],
				"“El Dorado” (1966) e “Onde começa o Inferno” (1959)",
				"“El Dorado” e “Onde começa o Inferno” (Também conhecido como “Rio Bravo”) eram ambos filmes do diretor Howard Hawks e ambos interpretados por John Wayne com o papel principal. Além da música de “Rio Bravo” ser uma adaptação de um outro filme da dupla Howard e John, os dois filmes citados são extremamente semelhantes em seus roteiros, porém Howard nunca assumiu que houve qualquer tipo de inspiração.",
				audioDasCuriosidadeCinema[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual das seguintes informações sobre o filme “2001: Uma odisseia no espaço”, é falsa?",
				PerguntasClass.Temas.Cinema,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"A trilha sonora do filme foi feita pela banda “Pink Floyd”",
				"A banda faria a trilha sonora do filme, porém, essa colaboração acabou não acontecendo. Porém, assim como existe o rumor de que o álbum “Darkside of the Moon” da banda “Pink Floyd” sincroniza perfeitamente com o filme “Mágico de Oz”, também existe o rumor de que a música “Echoes”, que tem mais de 23 minutos, do álbum “Meddle” dessa mesma banda sincroniza perfeitamente com a sequência final do filme chamada, “Jupiter e além do infinito”.",
				audioDasCuriosidadeCinema[0],
				"O filme tem 88 minutos sem diálogo algum",
				"O filme tem 2 horas e 41 minutos de duração e nos primeiros 25 minutos e últimos 23 não possuem falas, ao somar essas duas grandes sequências mais algumas pequenas cenas, o filme tem um total de 88 minutos de silêncio dos personagens. A primeira personagem a falar no filme aos 23:38 minutos é a comissária de bordo.",
				audioDasCuriosidadeCinema[0],
				"As cenas na lua foram feitas com areia",
				"Para criar um efeito que parecesse que os personagens estavam na superfície da lua, o diretor, Stanley Kubrick, mandou importar, lavar e pintar centenas de toneladas de areia.",
				audioDasCuriosidadeCinema[0],
				"Originalmente os “Primeiros Homens” seriam homens nus",
				"A primeira ideia do diretor Stanley Kubrick foi que os primeiros homens fossem humanos, porém, a maquiagem que foi criada, exigia que os atores ficassem nus, o que levaria o filme a ter uma censura +18. Dessa maneira, Kubrick adotou pelo visual dos macacos. Com exceção dos filhotes de chimpanzé, todos os personagens foram interpretados por seres humanos fantasiados.",
				audioDasCuriosidadeCinema[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual dos seguintes filmes é baseado em um romance da vida real?",
				PerguntasClass.Temas.Cinema,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Bonnie e Clyde - Uma rajada de balas",
				"Esse filme de 1967, é baseado no casal de assaltantes e assassinos Bonnie Parker e Clyde Barrow. O filme é o 27° na lista de 100 maiores filmes de todos os tempos, e na lista de 100 frases mais famosas do cinema, está em 41° com a frase: “nós roubamos bancos”",
				audioDasCuriosidadeCinema[0],
				"Romeu e Julieta",
				"Esse filme de 1968 é baseado na peça teatral “Romeu e Julieta” de William Shakespeare. Venceu no Oscar de 1969 nas categorias de melhor fotografia e melhor figurino, também foi indicado para melhor filme e melhor diretor.",
				audioDasCuriosidadeCinema[0],
				"A primeira noite de um homem",
				"Esse filme de 1967 é baseado em um livro com o mesmo nome. Venceu o prêmio de melhor direção, no Oscar de 1968. O filme iniciou a carreira de Dustin Hoffman, ator de filmes como “Rain Man”, “Perfume: A História de um Assassino” e “Perdidos na Noite”.",
				audioDasCuriosidadeCinema[0],
				"Noivo neurótico, noiva nervosa",
				"Esse filme de 1977 teve um roteiro original, não foi baseado em nada que já tenha existido. Ganhou no Oscar de 1978, os prêmios de melhor filme, melhor diretor, melhor atriz e melhor roteiro original.",
				audioDasCuriosidadeCinema[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		// PERGUNTAS DE ESPORTES -------------------------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972 na Fórmula 1:",
				PerguntasClass.Temas.Esporte,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Campeão mundial mais jovem de F1 até então",
				"Em 1972, com 5 vitórias, Fittipaldi tornou-se o campeão mundial mais jovem da história da Fórmula 1, com 25 anos, oito meses e 29 dias, recorde que manteve por mais de três décadas e que só foi quebrado em 2005, pelo piloto espanhol Fernando Alonso.",
				audioDasCuriosidadeEsporte[0],
				"Primeiro e único campeão brasileiro de F1 da história",
				"Emerson Fittipaldi foi de fato o primeiro campeão brasileiro de F1 da história, entretanto não foi o único seguido por Nelson Piquet (81,83 e 87) e Ayrton Senna (88,90 e 91).",
				audioDasCuriosidadeEsporte[0],
				"Campeão das 500 milhas de Indianápolis",
				"Aos 38 anos, Emerson reafirmava seu talento e assinou com a Patrick Racing para disputar regularmente o campeonato da CART de Fórmula Indy. Em 5 anos ele obteve 6 vitórias. Em 1989, após 5 vitórias, ele se tornou o primeiro brasileiro campeão da categoria. Sua mais expressiva e histórica vitória foi a mítica 500 milhas de Indianapolis, quando liderou 158 das 200 voltas.",
				audioDasCuriosidadeEsporte[0],
				"Encerrou sua carreira após um acidente no michigan speedway",
				"Em 1993 ganhou a sua segunda 500 Milhas de Indianapolis superando o campeão da Fórmula 1 de 1992, Nigel Mansell. Emerson comemorou tomando suco de laranja em lugar do tradicional copo de leite, como forma de promover o produto de suas fazendas. Emerson encerrou sua participação na categoria em 1996, depois de um grave acidente no Michigan International Speedway",
				audioDasCuriosidadeEsporte[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual time foi vencedor do campeonato Paulista de 1973?",
				PerguntasClass.Temas.Esporte,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Nenhum dos anteriores",
				"Santos com 32 pontos e Portuguesa com 29, foram os dois times vencedores. O árbitro Armando Marquês, errou na contagem de pênaltis e acabou o jogo com 2x0 para o Santos porém, a Portuguesa ainda tinha suas duas cobranças mas o juiz só percebeu o erro quando os jogadores foram embora. Dessa maneira, a Federação Paulista de Futebol declarou os dois times vencedores. O melhor marcador do campeonato foi Pelé, do Santos, com 11 gols.",
				audioDasCuriosidadeEsporte[0],
				"Palmeiras",
				"O palmeiras ficou em 3° lugar no campeonato com 30 pontos ganhos. Em 1973, o time foi bicampeão do campeonato Brasileiro.",
				audioDasCuriosidadeEsporte[0],
				"Corinthians",
				"O Corinthians ficou em 4° lugar no campeonato com 28 pontos ganhos. No ano de 1973, o time foi campeão do 2° torneio “Laudo Natel”, esse torneio aconteceu em 1972, 73 e 75 e foi criado para que os clubes do interior pudessem jogar com os grandes times paulistas.",
				audioDasCuriosidadeEsporte[0],
				"São Paulo",
				"O time ficou em 8° lugar no campeonato Paulista com 21 pontos ganhos. O São Paulo foi o time vice campeão do campeonato Brasileiro de 1973.",
				audioDasCuriosidadeEsporte[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		// PERGUNTAS DE HISTORIA ----------------------------------------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"O que aconteceu no ano de 1961?",
				PerguntasClass.Temas.História,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Primeiro homem a entrar no espaço",
				"Em 12 de abril de 1961, o russo Yuri Gagarin se tornou o primeiro homem a entrar no espaço. O astronauta possuía apenas 27 anos e esteve a bordo da nave Vostok1, ele deu uma volta completamente em órbita ao redor do planeta, que durou 108 minutos. Nessa missão, Gagarin disse uma frase que ficou famosa, “A Terra é azul. Como é maravilhosa. Ela é incrível”. Em 2011, a viagem completou 50 anos e foi reconstruída no filme documentário “First Orbit” que possuo áudio original da missão é foi disponibilizado gratuitamente no YouTube.",
				audioDasCuriosidadesHistoria[0],
				"Chegada do homem à lua",
				"O homem chegou à lua em 20 de julho de 1969. A missão Apollo 11 foi a 5° missão tripulada do programa Apollo e foi a 1° a chegar à lua. O programa Apollo foi um conjunto de missões da NASA que tinha como objetivo, levar o homem à lua. Os tripulantes da Apollo 11 eram: Neil Armstrong, o comandante, Edwin Aldrin e Michael Collins.",
				audioDasCuriosidadesHistoria[0],
				"Primeiro transplante de coração",
				"Em 3 de dezembro de 1967 na África do Sul, aconteceu o primeiro transplante de coração na História. Apesar do transplante bem sucedido realizado pelo cirurgião Christiaan Barnard, o paciente só sobreviveu 18 dias após o procedimento, ele faleceu pois os esforços médicos para combater a rejeição do corpo ao coração, acabou prejudicando muito o sistema imunológico do paciente que contraiu uma infecção pulmonar que o levou à morte.",
				audioDasCuriosidadesHistoria[0],
				"Mudança da Capital do Brasil",
				"Em 21 de Abril de 1960, a capital do Brasil foi transferida do Rio de Janeiro para Brasília. A mudança aconteceu junto com a inauguração da cidade de Brasília que foi prometida pelo presidente Juscelino Kubitschek logo após sua posse em Janeiro de 1956. A cidade foi construída em apenas 3 anos e 10 meses e no dia de sua abertura oficial já tinha cerca de 142 mil habitantes.",
				audioDasCuriosidadesHistoria[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"A moda dos anos 70 foi muito influenciada pela música, qual dos seguintes estilos não pertence a essa época?",
				PerguntasClass.Temas.História,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Twiggy",
				"Twiggy foi uma modelo dos anos 60, ela ficou famosa por ser pequena, com cabelos curtos e ter cílios marcados. É considerada uma das primeiras super modelos do mundo, era o ícone de moda e estilo dos anos 60. O apelido “Twiggy” vem de “Twigs”, graveto em inglês, o nome era referência à magreza da modelo cujo nome real era Lesley Lawson.",
				audioDasCuriosidadesHistoria[0],
				"Hippie",
				"Esse estilo foi popularizado no festival de Woodstock em 69. Os jovens Hippies pregavam a paz e o amor é tinham calças boca de sino, estampas, batas, cabelos longos e barba, no caso dos homens. O estilo Hippie foi a primeira vez em que a moda foi unissex.",
				audioDasCuriosidadesHistoria[0],
				"Punk",
				"O estilo Punk foi difundido com grupos musicais nos anos 70. O visual transgressor era marcado por calças rasgadas, rebites, jaquetas de couro e cabelos coloridos e com cortes diferenciados.",
				audioDasCuriosidadesHistoria[0],
				"Glam",
				"Esse estilo foi influenciado pela música do gênero “Glam Rock”, a estética andrógina, com brilhos e exageros marcou uma quebra de gêneros. David Bowie com sapatos de plataforma e maquiagem, transmitiu a mensagem que, não importa se é feminino ou masculino mas sim, sua individualidade.",
				audioDasCuriosidadesHistoria[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		// PERGUNTAS DE PROPAGANDA -----------------------------------------------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual marca de cigarro foi resposável pela criação da “Lei de Gérson”?",
				PerguntasClass.Temas.Propaganda,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Cigarros Vila Rica",
				"A “Lei de Gerson” é um termo usado para pessoas que querem obter vantagem em tudo. A expressão foi criada em 1976 em uma propaganda para os “Cigarros Vila Rica”. Nessa propaganda, o meio armador da seleção brasileira de futebol, Gérson, diz a seguinte frase: “Por que pagar mais caro se o Vila me dá tudo aquilo que eu quero de um bom cigarro? Gosto de levar vantagem em tudo, certo? Leve vantagem você também, leve Vila Rica!”",
				audioDasCuriosidadePropaganda[0],
				"Cigarros Minister",
				"As propagandas dos Cigarros Minister carregavam o  slogan: “Sabor para quem sabe o que quer.",
				audioDasCuriosidadePropaganda[0],
				"Cigarros Hollywood",
				"O slogan das propagandas dos Cigarros Hollywood era: “Ao sucesso com Hollywood”.",
				audioDasCuriosidadePropaganda[0],
				"Cigarros Chanceller",
				"A propaganda dos Cigarros Chanceller era envolta de sua espessura de 100 milímetros, o slogan utilizado era: “O único fino que satisfaz”.",
				audioDasCuriosidadePropaganda[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));



		//PERGUNTAS DE RADIO/TV -------------------------------------------------------------------------------------------------------

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Durante os anos 70, o programa “Correspondente Musical” ficou famoso devido a qual locutor?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Hélio Ribeiro",
				"Correspondente Musical era um programa de músicas do mundo inteiro. Mas a maior atração era Hélio Ribeiro por apresentar o programa de uma maneira inteligente, por ter uma voz com um  timbre inconfundível e por suas memoráveis traduções simultâneas.",
				audioDasCuriosidadesRadio[0],
				"Samuel Correia",
				"Durante os anos 60 se popularizaram os programas policiais como Cidade contra o crime da Rádio Tupi, apresentado por Samuel Correia.",
				audioDasCuriosidadesRadio[0],
				"Edmo Zarife",
				"Edmo Zarife foi um famoso radialista e locutor brasileiro do sistema globo de rádio e responsável por gravar a famosa vinheta “Brasil-Sil-Sil!”, que é usada até hoje sempre que o brasil vence em algum esporte.",
				audioDasCuriosidadesRadio[0],
				"Eli Corrêa",
				"Eli Corrêa é um famoso radialista brasileiro conhecido como  “O homem sorriso do rádio” e, principalmente, pelo seu bordão “Oiiiii Gente!”, apresenta programas de rádio a mais de 46 anos e trabalhou em inúmeras rádios como  Rádio São Paulo, Tupi, Record, Globo, Capital (na qual está atualmente) e América.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"O bordão “Eu estou aqui para confundir, eu não estou aqui para explicar” era dito por qual apresentador?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Chacrinha",
				"“Alô, Terezinha!”, “Quem não se comunica se trumbica”, “Na TV nada se cria, tudo se copia” , “Eu vim para confundir e não para explicar”, permeado de bordões famosos, os programas do chacrinha fizeram um enorme sucesso e fez dele uma inspiração para muitos apresentadores que vieram depois dele. Porém por conta de seu comportamento teve problemas com a Censura Federal, em uma determinada ocasião ele chegou a ser abordado nos bastidores de seu programa e afirma ter sofrido maus-tratos.",
				audioDasCuriosidadesRadio[0],
				"Flávio Cavalcanti",
				"Flávio Calvacanti ficou muito conhecido por apresentar um dos programas mais polêmicos da televisão brasileira, seu estilo era muito marcante, tinha o costume de quebrar os discos de música que considerava medíocre e jogá-los no lixo. Em 1973 teve seu programa na rede Tupi suspenso por 60 dias pela Censura Federal, ao apresentar uma história em que um homem “emprestava” sua mulher ao vizinho.",
				audioDasCuriosidadesRadio[0],
				"Bolinha",
				"Édson Cabariti, mais conhecido como Bolinha iniciou a carreira como locutor esportivo veio a tornar-se célebre como o apresentador do programa Clube do Bolinha, o qual ficou no ar durante 20 anos na TV Bandeirantes entre 1974 e 1994. Uma das atrações do Clube era o quadro Eles e Elas, no qual transformistas e travestis apresentavam-se.",
				audioDasCuriosidadesRadio[0],
				"Ronald Golias",
				"\"Ô Cride, fala pra mãe...\" Golias dedicou-se a maior parte de sua carreira para a televisão. Trouxe consigo das telas o personagem Carlos Bronco Dinossauro, que acabaria tornando-se um dos destaques da Família Trapo, programa exibido pela TV Record entre 1967 e 1971.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual dos seguintes programas de televisão teve sua estreia no final dos anos 60?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Os trapalhões",
				"A série televisiva “Os trapalhões” teve seu primeiro episódio em 1969 e contava com Renato Aragão,conhecido como Didi Mocó, Mussum, Zacarias e Dedé Santana. Já o primeiro filme do grupo, aconteceu alguns anos antes, em 1966. A série acabou em 1994.",
				audioDasCuriosidadesRadio[0],
				"Programa Silvio Santos",
				"O “Programa Silvio Santos” começou em 1963, e continua no ar até hoje, comandado por Silvio Santos. O programa quase chegou a receber o recorde de programa mais antigo da televisão brasileira porém, perdeu o título para um programa que estreou em 1961.",
				audioDasCuriosidadesRadio[0],
				"Mosaico  na TV",
				"O programa “Mosaico na TV” teve sua estreia em 1961 e é exibido até hoje, tem o título no livro dos recordes de “O programa mais antigo da televisão brasileira ainda em exibição”. “Mosaico na TV” oferece várias atrações como entrevistas, documentários e música e é um programa voltado à comunidade judaica. O programa de televisão foi baseado no programa de rádio “Mosaico”.",
				audioDasCuriosidadesRadio[0],
				"Fantástico",
				"O programa “Fantástico” estreou em 1973 e originalmente se chamava “Fantástico: O Show Da vida”. O programa se destacava devido às suas aberturas coreografadas com música, com o tempo, as aberturas foram perdendo espaço e desde 2010, as aberturas passaram a ter somente 30 segundos de duração.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Quem era a personalidade da televisão que apresentava os resultados da Loteria Esportiva na Rede Globo nos anos 70?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Zebrinha",
				"Com o enorme sucesso da Loteria Esportiva no início dos anos 70, Borjalo criou a “Zebrinha” para a Rede Globo informar os resultados da loteria no Fantástico. Na gíria da época, “zebra” era um resultado inesperado no futebol, numa alusão ao Jogo do Bicho (zebra é um animal que não existe naquele jogo, portanto, é um resultado impossível de acontecer). O ator Pedro Braga, muito contribuiu com a personagem, ao criar o bordão “Olha eu aí! Zêêêbra!!!”. ",
				audioDasCuriosidadesRadio[0],
				"Borjalo",
				"Caricaturista internacionalmente famoso, Borjalo começou seu trabalho em TV no início dos anos 60. Com a intenção de integrar a caricatura à televisão, passou a ilustrar os programas que dirigia com cartões-truca (caricaturas em papel-cartão com olhos e boca móveis, para dar a impressão de que “falavam”). Borjalo apelidou aquelas caricaturas de Bonecos Falantes.",
				audioDasCuriosidadesRadio[0],
				"Cid Moreira",
				"Hilton Gomes e Cid Moreira abriram a primeira edição do Jornal Nacional anunciando: “O Jornal Nacional, da Rede Globo, um serviço de notícias integrando o Brasil novo, inaugura-se neste momento: imagem e som de todo o país”. Cid Moreira encerrou: “É o Brasil ao vivo aí na sua casa. Boa noite”. Dentre suas informações existia a Loteria Esportiva de Domingo.",
				audioDasCuriosidadesRadio[0],
				"William Bonner",
				"William Bonner Júnior, é um jornalista, publicitário, apresentador e escritor brasileiro. É editor-chefe e apresentador do Jornal Nacional, da Rede Globo, posto que lhe garantiu a posição de jornalista de maior credibilidade do país. Em sua carreira trabalhou no SPTV, Fantástico, Jornal da Globo, Jornal Hoje e Jornal Nacional.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Qual das seguintes afirmações sobre a novela “Selva de Pedra” está errada?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Foi a 2° maior novela da Rede Globo",
				"A segunda maior novela da Globo foi “Irmãos Coragem”, da mesma autora de “Selva de Pedra”. “Irmãos Coragem” possui 328 capítulos, já “Selva de Pedra”, possui 243. A maior novela da Rede Globo foi “A Grande Mentira” de 1968, com 341 capítulos.",
				audioDasCuriosidadesRadio[0],
				"Chegou a ter 100% de audiência",
				"Na exibição do capítulo 152, em 4 de outubro de 1972, durante a cena em que a personagem Simone Marques, interpretada por Regina Duarte é desmascarada, a novela conseguiu 100% de audiência.",
				audioDasCuriosidadesRadio[0],
				"Foi a última de uma série de novelas de Janete Clair",
				"Entre 1969 e 1973, Janete Clair escreveu uma série de novelas de sucesso para o horário nobre da Globo: “Véu de Noiva”, “Irmãos Coragem”, “O Homem que Deve Morrer” e por último, “Selva de Pedra”.",
				audioDasCuriosidadesRadio[0],
				"Alguns capítulos foram exibidos em horários diferentes",
				"Os capítulos 150 a 158 foram exibidos às 23 horas devido à censura. O horário normal da novela era às 20 horas.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass(
				"Segundo boatos, a banda americana “KISS” inspirou sua maquiagem em quais artistas do movimento “Glam Rock”?",
				PerguntasClass.Temas.Radio,
				Materiais[0],
				audioDasPerguntas[0],
				audioDasAlternativas[0],
				"Secos & Molhados",
				"Em 1972, a banda “Secos & Molhados” fez seu primeiro show com maquiagem. Somente no ano seguinte, a banda “KISS” fez seu primeiro show com as maquiagens. Além disso, em 1974, a banda brasileira fez um grande show no México, esse evento deu maior visibilidade à banda que chegou a ter contato com alguns empresários americanos.",
				audioDasCuriosidadesRadio[0],
				"David Bowie",
				"Apesar do artista também usar maquiagem, ele não foi inspiração para a banda “KISS”, além disso, David Bowie tinha uma maquiagem mais glamourosa, ao contrário da maquiagem do “KISS” que era mais teatral.",
				audioDasCuriosidadesRadio[0],
				"Elton John",
				"Apesar do cantor fazer parte do movimento Glam Rock, ele não utilizava maquiagem em suas apresentações. Em 2013, Elton John foi considerado o artista solo masculino mais bem-sucedido de todos os tempos.",
				audioDasCuriosidadesRadio[0],
				"Queen",
				"A banda “Queen” também fez parte do movimento “Glam Rock”, porém, não utilizava maquiagens, o foco da banda era as roupas extravagantes.",
				audioDasCuriosidadesRadio[0],
				"Resposta5",
				"Curiosidade5",
				"Resposta6",
				"Curiosidade6",
				false));
		*/
		#endregion

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
			//UnityEditor.EditorApplication.isPlaying = false;
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
