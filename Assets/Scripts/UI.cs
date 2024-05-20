using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text uiText;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            uiText.text = "æ∆¿Ã≈€ »πµÊ : øœ∑·!";

        }
    }
}