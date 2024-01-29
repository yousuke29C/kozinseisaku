using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;

    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameClear != true)
        {
            if (DestroyAllBlocks())
            {
                //ゲームクリア
                Debug.Log("ゲームクリア");
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }
    }

    private bool DestroyAllBlocks()
    {
        foreach ( Block b in blocks)
        {
            if( b != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
