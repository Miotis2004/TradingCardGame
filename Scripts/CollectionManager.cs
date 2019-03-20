using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollectionManager : MonoBehaviour
{
    public GameManager instance;
    public GameObject cardPrefab;
    
    private int cardDisplayPosition = 0;

    private void Awake()
    {
        instance = FindObjectOfType<GameManager>();

        instance.cards.Sort();
    }

    private void Start()
    {

        int currentSpawn = 0;
        float xPos = 0f;
        float yPos = 2f;

        for (int i = 0; i < 11; i++)
        {
            foreach (Card card in instance.cards)
            {
                if (card.manaCost == i)
                {
                    switch (cardDisplayPosition)
                    {
                        case 0:
                            xPos = -4.5f;
                            break;
                        case 1:
                            xPos = -1.5f;
                            break;
                        case 2:
                            xPos = 1.5f;
                            break;
                        case 3:
                            xPos = 4.5f;
                            break;

                        default:
                            break;
                    }

                    cardDisplayPosition++;

                    if (cardDisplayPosition > 3)
                    {
                        cardDisplayPosition = 0;
                    }

                    GameObject go = Instantiate(cardPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                    CardDisplay display = go.GetComponent<CardDisplay>();
                    display.CardSetup(card);

                    currentSpawn++;

                    if (currentSpawn > 3)
                    {
                        yPos -= 4f;
                        currentSpawn = 0;
                    }
                }
            }
        }

       
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
   
}


