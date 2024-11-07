using UnityEngine;
//(Placar final) Crie um script que lê o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos três
//resultados possíveis aconteceu: vitória do time A, vitória do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi “um empate emocionante”.

public class exercicio09 : MonoBehaviour
{
    int timeA ;
    int timeB;
    bool empate;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (timeA > timeB )
        {
            print("VITORIA DO TIME A ");
        }

        if (timeA < timeB) {
            print("VITORIA DO TIME B");
        }

        if (timeA == timeB)
        {
            print("EMPATE");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
