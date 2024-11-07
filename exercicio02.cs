using UnityEngine;

public class exercicio02 : MonoBehaviour

    
{
    [SerializeField] bool powerup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerup == true)
        {
            print("power_up Coletador");
        }
        else
        {
            print("não coletado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
