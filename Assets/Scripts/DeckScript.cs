using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public List<string> deck = new List<string>();

    void Start()
    {
        // Definir los valores de las cartas y cuántas se deben generar
        var values = new List<string>() { "Ace's", "Queen's", "King's", "Joker's" };

        // Generar el mazo de cartas, cada carta con un identificador único (por ejemplo, "Queen's 1", "Queen's 2", ...)
        foreach (var value in values)
        {
            int repeatCount = value == "Joker's" ? 2 : 6;

            for (int i = 1; i <= repeatCount; i++)
            {
                deck.Add($"{value} {i}");
            }
        }

        // Inicializar la semilla para la generación aleatoria
        Random.InitState(123);

        // Definir el número de jugadores y la cantidad de cartas en mano
        int numPlayers = Random.Range(2, 5); // Minimo 2 jugadores, máximo 4 jugadores
        const int CARDS_IN_HAND = 5;

        // Crear las manos para cada jugador
        List<List<string>> playersHands = new List<List<string>>();

        for (int player = 0; player < numPlayers; player++)
        {
            List<string> hand = new List<string>();

            for (int card = 0; card < CARDS_IN_HAND; card++)
            {
                int randomIndex = Random.Range(0, deck.Count);
                var currentCard = deck[randomIndex];
                hand.Add(currentCard);
                deck.RemoveAt(randomIndex);  // Eliminar la carta seleccionada del mazo
            }

            playersHands.Add(hand);
        }

        // Mostrar las cartas en la mano de cada jugador
        for (int player = 0; player < numPlayers; player++)
        {
            string cardsInHand = "";
            foreach (var card in playersHands[player])
            {
                cardsInHand += $"{card} ";
            }

            Debug.Log($"Mano del Jugador {player + 1}: {cardsInHand}");
        }

        // Mostrar cuántas cartas quedan en el mazo
        Debug.Log($"Cartas restantes en el mazo: {deck.Count}");
    }
}
