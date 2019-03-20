using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameManager instance;

    public List<Card> cards = new List<Card>();

    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

   public void LoadCollectionScene()
    {
        SceneManager.LoadScene("CollectionManager");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
