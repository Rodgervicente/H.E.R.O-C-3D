using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int maxLives = 3; // quantidade máxima de vidas
    public int currentLives; // quantidade atual de vidas
    public Text livesText; // objeto de texto que mostra as vidas na tela
    public GameObject gameOverPanel; // painel de Game Over que será exibido ao perder todas as vidas

    private void Start()
    {
        currentLives = maxLives; // define as vidas iniciais como a quantidade máxima
        UpdateLivesText(); // atualiza o texto de vidas na tela
    }

    public void LoseLife()
    {
        currentLives--; // decrementa uma vida
        UpdateLivesText(); // atualiza o texto de vidas na tela

        if (currentLives <= 0)
        {
            GameOver(); // se acabar as vidas, chama o método de Game Over
        }
    }

    private void UpdateLivesText()
    {
        livesText.text = "Lives: " + currentLives.ToString(); // atualiza o texto de vidas na tela
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true); // exibe o painel de Game Over
        // Aqui você pode definir outras ações que serão tomadas quando o jogo acabar, como reiniciar o jogo, por exemplo
    }
}

