using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public TMP_InputField inputName;
    public TextMeshProUGUI bestScoreText;

    private void Start()
    {
        bestScoreText.SetText("Best Score: " + DataManager.Instance.bestUser + ": " + DataManager.Instance.score);
    }

    public void SetName()
    {
        DataManager.Instance.username = inputName.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        DataManager.Instance.SaveGameData();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
