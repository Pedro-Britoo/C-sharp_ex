using UnityEngine;
//(Pontuação de missão) Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
//incompleta".
public class exercicio05 : MonoBehaviour
{
    [SerializeField] int missaoPontos = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (missaoPontos >= 50) 
        {
            print("missão sucedida");     
        }
        
        else
        {
            print("missao incompleto");
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
