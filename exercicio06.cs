using UnityEditor;
using UnityEngine;
//(Escolha de personagem) O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.
public class exercicio06 : MonoBehaviour
{
    [SerializeField] int EstadoJogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (EstadoJogador)
        {
            case 01:
            print("guerreiro escolhido");
                break;

            case 02:
                    print("Mago escolhido");
                break;
    }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
