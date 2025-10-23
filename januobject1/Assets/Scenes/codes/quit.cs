using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button ResumeBtn;
    [SerializeField] private Button SkipLevelBtn;
    [SerializeField] private Button ExitBtn;
    [SerializeField] private MonoBehaviour playerController;
    [SerializeField] private GameObject settingsMenuCard;

    void Start()
    {
        // Initially hide settings menu
        settingsMenuCard.SetActive(false);

        // Add button listeners
        ResumeBtn.onClick.AddListener(CloseSettingsFun);
        SkipLevelBtn.onClick.AddListener(SkipLevelFun);
        ExitBtn.onClick.AddListener(ExitFun);
    }

    void Update()
    {
        // Open settings menu when Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openSettingsFun();
        }
    }

    void openSettingsFun()
    {
        settingsMenuCard.SetActive(true);
        playerController.enabled = false;
    }

    void CloseSettingsFun()
    {
        settingsMenuCard.SetActive(false);
        playerController.enabled = true;
    }

    void ExitFun()
    {
        SceneManager.LoadScene(0); // Loads Main Menu or first scene
    }

    void SkipLevelFun()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
