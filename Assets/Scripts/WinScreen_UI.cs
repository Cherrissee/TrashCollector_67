using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class WinScreen_UI : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button button_retry = root.Q<Button>("button_retry");
        button_retry.clicked += on_retry_clicked;
        
        Button button_menu = root.Q<Button>("button_menu");
        button_menu.clicked += on_menu_clicked;
        
    }

    public void on_retry_clicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void on_menu_clicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
