using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class GamaManager : MonoBehaviour
{
    public GameObject layout1;
    public GameObject layout2;
    int brickCount;
    int levelNum;
    public TMP_Text guiLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelLayout();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level01");
    }
    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScreen");
    }
    public void levelLayout()
    {
        GameObject currentLayout;
        int spawnNum = Random.Range(0, 2);      

        if (spawnNum == 0)
        {
            currentLayout = layout1;
            brickCount = 16;
        }
        else
        {
            currentLayout = layout2;
            brickCount = 15;
        }


        Instantiate(currentLayout);

        levelNum++;
        setGUIlevel();
    }

    public void setGUIlevel()
    {
        guiLevel.text = "Level ";
        guiLevel.text += levelNum.ToString();
    }

    public void updateBrickCount()
    {
        brickCount--;
    }

    public int getBrickCount()
    {
        return brickCount;
    }
}
