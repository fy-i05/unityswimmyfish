using UnityEngine;
using UnityEngine.UI; 
public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public Player player;

    private void Awake(){
        Application.targetFrameRate=60;
        gameOver.SetActive(false);
        Pause();
    }

    public void Play(){
        score=0;
        scoreText.text= score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled=true;
        Pipes[] pipes=FindObjectsOfType<Pipes>();
        for (int i=0; i<pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause(){
        Time.timeScale = 0f; //all things multiplied by time so can just set to 0
        player.enabled=false; //player cant move
    }


    private int score;
    public void GameOver(){
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore(){
        score++;
        scoreText.text = score.ToString();
    }
}