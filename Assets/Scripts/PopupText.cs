using UnityEngine;
using UnityEngine.UI;

public class PopupText : MonoBehaviour
{
    public TMPro.TextMeshProUGUI popupText;

    void Start()
    {
        // Скрываем окно при запуске
        //HidePopup();
    }

    public void ShowPopup(string message)
    {
        // Показываем окно и устанавливаем текст
        popupText.text = message;
        gameObject.SetActive(true);
    }

    public void HidePopup()
    {
        // Скрываем окно
        gameObject.SetActive(false);
    }
}