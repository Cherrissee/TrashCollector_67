using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MainMenu_UI : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button button_play = root.Q<Button>("button_play");
        button_play.clicked += on_play_clicked;


        Button button_exit = root.Q<Button>("button_exit");
        button_exit.clicked += on_exit_clicked;
    }

    public void on_exit_clicked()
    {
        Application.Quit();
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #endif
    }

    public void on_play_clicked()
    {
        SceneManager.LoadScene("GameScene");
    }

}