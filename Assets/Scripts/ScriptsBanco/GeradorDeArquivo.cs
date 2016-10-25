using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;



public enum Temas {Musica,Futebol,Radio,Arte,Outro};
public enum Estados{Normal,Tentado,Curioso,CuriosoPronto,CertoPronto,Certo};
//public List<RespostasClass> respostasBd = new List<RespostasClass>();

struct Resposta
{
	public int estadoAr;
	public string textoDaRespostaAr;
	public string curiosidadeAr;
	public bool corretaAr;
};

 struct Pergunta
{
	public string textoDaPerguntaAr;
	public int frequenciaAr;
	public int ratingAr;
	public int temaAr; 
	public Resposta[] respostasAr;

};

/*struct PerguntaString
{
	public string pergunta;
	public string[] respostas;
};*/
	
public class GeradorDeArquivo : MonoBehaviour {

	private Pergunta[] perguntasArray;
	//private PerguntaString[] perguntasString;

	public void CarregarPerguntas()
	{
		if (File.Exists(Application.dataPath + "/questionData.json")){
			//Pergunta data = JsonUtility.FromJson<Pergunta> (File.ReadAllText (Application.dataPath + "/questionData.json", Encoding.UTF8));
			string data;
			data = File.ReadAllText (Application.dataPath + "/questionData.json", Encoding.UTF8);
			int pos = data.IndexOf("textoDaPerguntaAr");
			string[] sep = {"]\r\n}"};
			string[] stringArray = data.Split (sep,StringSplitOptions.None);
			sep [0] = "\"respostasAr\":";
			string[] arrayPergunta = stringArray[0].Split (sep,StringSplitOptions.None);
			for (int i = 0; i < arrayPergunta.Length; i++) {
				Debug.Log (arrayPergunta [i]);
			}
			Debug.Log (data);
		}
		else {
			Debug.Log ("LoadQestionData FAIL");
		}
		/*int count = listaPerguntas.Count;
		perguntasArray = new Pergunta[count]; // Alocando Memória
		perguntasString = new PerguntaString[count];

		for (int i =0; i < count; i++)// Populando Pergunta
			{
			perguntasArray [i].textoDaPerguntaAr = listaPerguntas [i].textoDaPerguntaBd;
			perguntasArray [i].frequenciaAr = listaPerguntas [i].frequencia;
			perguntasArray [i].ratingAr = listaPerguntas [i].rating;
			perguntasArray [i].temaAr = (int)listaPerguntas [i].tema;



			int respCount = listaPerguntas [i].respostasBd.Count;
			perguntasArray[i].respostasAr = new Resposta[respCount]; //Alocando Memória
			perguntasString[i].respostas = new string[respCount];
			for(int j=0;j<respCount;j++)//Populando Resposta
			{
				perguntasArray [i].respostasAr [j].estadoAr = (int)listaPerguntas [i].respostasBd [j].estado;
				perguntasArray [i].respostasAr [j].textoDaRespostaAr = listaPerguntas [i].respostasBd [j].textoDaResposta;
				perguntasArray [i].respostasAr [j].curiosidadeAr = listaPerguntas [i].respostasBd [j].curiosidade;
				perguntasArray [i].respostasAr [j].corretaAr = listaPerguntas [i].respostasBd [j].correta;

				perguntasString [i].respostas[j] = JsonUtility.ToJson (perguntasArray [i].respostasAr [j]);
			}
			perguntasString [i].pergunta = JsonUtility.ToJson (perguntasArray [i]);


		}
		Debug.Log(JsonUtility.ToJson(perguntasString[0],true));

		//BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.dataPath + "/questionData.json");


		//parte tensa

		// writing data in string
		//your data
		byte[] info = new UTF8Encoding(true).GetBytes(JsonUtility.ToJson(perguntasString[0],true));
		file.Write(info, 0, info.Length);
	
		//fim da parte tensa

		file.Close ();



			if (File.Exists(Application.dataPath + "/questionData.json")){
			PerguntaString data = JsonUtility.FromJson<PerguntaString> (File.ReadAllText (Application.dataPath + "/questionData.json", Encoding.UTF8));
			Debug.Log (data.pergunta);
				
			}
			else {
				Debug.Log ("LoadQestionData FAIL");
			}*/



	}

	public void SalvaPerguntas(List<PerguntasClass> listaPerguntas)
	{
		int count = listaPerguntas.Count;
		perguntasArray = new Pergunta[count]; // Alocando Memória
	
		FileStream file = File.Create (Application.dataPath + "/questionData.json");
		byte[] info;

		info = new UTF8Encoding(true).GetBytes("[\r\n");
		file.Write(info, 0, info.Length);


		for (int i =0; i < count; i++)// Populando Pergunta
		{
			info = new UTF8Encoding(true).GetBytes("    {\r\n");
			file.Write(info, 0, info.Length);
			info = new UTF8Encoding(true).GetBytes("        \"textoDaPerguntaAr\":\""+listaPerguntas [i].textoDaPerguntaBd+"\",\r\n");
			file.Write(info, 0, info.Length);
			info = new UTF8Encoding(true).GetBytes("        \"frequenciaAr\":"+listaPerguntas [i].frequencia+",\r\n");
			file.Write(info, 0, info.Length);
			info = new UTF8Encoding(true).GetBytes("        \"ratingAr\":"+listaPerguntas [i].rating+",\r\n");
			file.Write(info, 0, info.Length);
			info = new UTF8Encoding(true).GetBytes("        \"temaAr\":"+(int)listaPerguntas [i].tema+",\r\n");
			file.Write(info, 0, info.Length);


			int respCount = listaPerguntas [i].respostasBd.Count;
			//perguntasArray[i].respostasAr = new Resposta[respCount]; //Alocando Memória
			//perguntasString[i].respostas = new string[respCount];

			info = new UTF8Encoding(true).GetBytes("        \"respostasAr\":[\r\n");
			file.Write(info, 0, info.Length);

			for(int j=0;j<respCount;j++)//Populando Resposta
			{
				info = new UTF8Encoding(true).GetBytes("            {\r\n");
				file.Write(info, 0, info.Length);
				info = new UTF8Encoding(true).GetBytes("                \"estadoAr\":"+(int)listaPerguntas [i].respostasBd [j].estado+",\r\n");
				file.Write(info, 0, info.Length);
				info = new UTF8Encoding(true).GetBytes("                \"textoDaPerguntaAr\":\""+listaPerguntas [i].respostasBd [j].textoDaResposta+"\",\r\n");
				file.Write(info, 0, info.Length);
				info = new UTF8Encoding(true).GetBytes("                \"curiosidadeAr\":\""+listaPerguntas [i].respostasBd [j].curiosidade+"\",\r\n");
				file.Write(info, 0, info.Length);

				if (listaPerguntas [i].respostasBd [j].correta) {
					info = new UTF8Encoding (true).GetBytes ("                \"corretaAr\":true\r\n");

				}
				else info = new UTF8Encoding (true).GetBytes ("                \"corretaAr\":false\r\n");
				file.Write (info, 0, info.Length);

				if (j < respCount - 1) {
					info = new UTF8Encoding (true).GetBytes ("            },\r\n");
				}
				else 	info = new UTF8Encoding (true).GetBytes ("            }\r\n");
				file.Write(info, 0, info.Length);
			}

			info = new UTF8Encoding(true).GetBytes("        ]\r\n");
			file.Write(info, 0, info.Length);

			if (i < count - 1) {
				info = new UTF8Encoding (true).GetBytes ("    },\r\n");
			}
			else 	info = new UTF8Encoding (true).GetBytes ("    }\r\n");
			file.Write(info, 0, info.Length);

		}

		info = new UTF8Encoding(true).GetBytes("]\r\n");
		file.Write(info, 0, info.Length);

		file.Close ();

	}
		

}
