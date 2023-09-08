using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FailPanelControl : MonoBehaviour
{
    Button FailButton;
    private void Start()
    {
        FailButton= GetComponent<Button>();
        FailButton.onClick.AddListener(FailButtonOnClick);
    }
    void FailButtonOnClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void Enable()
    {
        gameObject.SetActive(true);
    }
}
