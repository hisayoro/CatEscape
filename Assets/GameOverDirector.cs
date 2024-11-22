using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GameOverToTitleScene", 4.5f);
    }

    public void GameOverToTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
