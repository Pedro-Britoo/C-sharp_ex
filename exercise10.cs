using UnityEngine;
//(Itens do inventário) Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, poções, ou power-ups)
//que têm efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.
public class exercise10 : MonoBehaviour
{
    [SerializeField] int powerUP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (powerUP)
        {
            case 01:
                print("poçao de fogo, de o dobro de dano");
                break;

            case 02:

                print("poção de agua, atordoe seus inimigos");
                break;

            case 03:
                print("poção de forças, tiro mais rapido");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
