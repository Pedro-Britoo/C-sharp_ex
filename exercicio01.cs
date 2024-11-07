using UnityEngine;

public class exercicio01 : MonoBehaviour
{
     [SerializeField] int VidaPlayer = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        if  (VidaPlayer > 0 )

        {
            print("personagem-vivo");
                }
        else
        { print("jogador-morto");
        }
            


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
