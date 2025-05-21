using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button startGameButton;
    public Button settingButton;
    public Button quitButton;

    void Start()
    {
        startGameButton = GameObject.Find("GameStartButton").GetComponent<Button>();
        settingButton = GameObject.Find("SettingButton").GetComponent<Button>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
       
        startGameButton.onClick.AddListener(OnClickStartGame);
        settingButton.onClick.AddListener(OnClickSetting); 
        quitButton.onClick.AddListener(OnClickQuit);
    }

    public void OnClickStartGame()
    {
        SceneManager.LoadScene("Game"); // 실제 게임 씬 이름
    }

    public void OnClickSetting()
    {
        // 설정 UI 오픈 (활성화 등)
        Debug.Log("Setting button clicked");
    }

    public void OnClickQuit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}