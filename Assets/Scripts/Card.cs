using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;
    public int cardValue;

    // Método para asignar valores a la carta
    public void InitializeCard(string name, int value)
    {
        cardName = name;
        cardValue = value;
    }

    // Método para mostrar el nombre de la carta en consola
    public void ShowCardInfo()
    {
        Debug.Log("Carta: " + cardName + " Valor: " + cardValue);
    }
}
