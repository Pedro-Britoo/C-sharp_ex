using UnityEngine;
//Implemente um sistema de diálogos onde o jogador
//pode interagir com um NPC (personagem não jogável), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.
public class exercicio11 : MonoBehaviour
{
    [SerializeField] int fraseJ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (fraseJ)
        {
            case 01:
                print("ola");
                break;

            case 02:

                print("tudo bem");
                break;

            case 03:
                print("ei");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
