using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int _playerScore;
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _scoreToAdd;
    [SerializeField] private GameObject _gameOverScreen;



    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        _playerScore = _playerScore + _scoreToAdd;
        _scoreText.text = _playerScore.ToString();
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        _gameOverScreen.SetActive(true);
    }
}
