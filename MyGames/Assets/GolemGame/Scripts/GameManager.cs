using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GolemGame.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance; //instância estática do GM para ser acessada por qualquer script a qualquer momento

        private void Awake()
        {
            //padrão singleton, existe apenas 1 game manager no jogo inteiro
            //ele mantem salva todas as variáveis da sessão de jogo
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject); //se não há nenhuma instância ainda, defina esse objeto como tal
            }
            else
            {
                Destroy(gameObject); //se já há uma instância não precisamos de outra, destrua essa.
            }
                
        }

        public void LoadSceneByName(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
