using UnityEngine;

public class exercicio03 : MonoBehaviour
{
    [SerializeField] bool VivoPlayer;

    [SerializeField] bool PowerUp;
    double VidaPlayer = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (VivoPlayer == false && PowerUp == true)
        {
            VidaPlayer = VidaPlayer * 0.5;
            print ("ainda nao, vida atual" + VidaPlayer);

        }

        else
        {
            print("nao pego");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
