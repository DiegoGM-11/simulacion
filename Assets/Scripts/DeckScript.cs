using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public List<string> deck = new List<string>();

    void Start()
    {
        Debug.Log("Tu carta es: ");

        var suits = new string[] { "S" };
        var values = new List<string>() { "Ace's", "Queen's", "King's", "Joker's" };

        foreach (var suit in suits)
        {
            foreach (var value in values)
            {
                int repeatCount = value == "Joker's" ? 2 : 6;

                for (int i = 0; i < repeatCount; i++)
                {
                    deck.Add($"{value} {suit}");
                }
            }
        }

        // Mostrar el mazo completo para confirmar que se agregaron las cartas
        foreach (var card in deck)
        {
            Debug.Log(card);
        }
    }
}
