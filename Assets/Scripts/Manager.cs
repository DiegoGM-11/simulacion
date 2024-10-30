using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cardPrefab;      // Referencia al Prefab de la carta
    public Transform cardSpawnArea;    // Área donde aparecerán las cartas

    void Start()
    {
        // Instanciar varias cartas y asignarles un nombre y valor
        for (int i = 0; i < 5; i++)
        {
            // Crear una instancia del prefab
            GameObject cardInstance = Instantiate(cardPrefab, cardSpawnArea);
            
            // Obtener el componente "Card" del objeto instanciado
            Card cardScript = cardInstance.GetComponent<Card>();

            // Inicializar la carta con un nombre y valor aleatorio
            cardScript.InitializeCard("Carta " + (i + 1), Random.Range(1, 10));

            // Mostrar la información de la carta en la consola
            cardScript.ShowCardInfo();
        }
    }
}
