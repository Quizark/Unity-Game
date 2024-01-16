using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    public Text textHints;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision theObject)
    {
        if (theObject.gameObject.name == "coconut")
        {
            GetComponent<Animator>().SetTrigger("hit");
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        // SprawdŸ, czy obiekt zderzaj¹cy siê ma tag "Player" (lub u¿yj innej metody identyfikacji gracza)
        if (other.CompareTag("Player"))
        {

            // Tutaj mo¿esz dodaæ logikê zakoñczenia gry
            EndGame();
        }
    }
    void EndGame()
    {
        // Wypisz komunikat na konsoli (mo¿esz tak¿e u¿yæ UI, aby wyœwietliæ komunikat na ekranie)
        Debug.Log("Wilk zjad³ gracza!");
        //Komunikat
        //textHints.SendMessage("ShowHint", "YOU HAVE DIED!");
        // Przywróæ do sceny "Menu" po pewnym opóŸnieniu (mo¿esz dostosowaæ czas)
        Invoke("LoadMenuScene", 2.0f);
    }

    // Metoda do za³adowania sceny "Menu"
    void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
