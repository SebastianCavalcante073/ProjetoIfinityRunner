using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject LoadingPanel;
    [SerializeField] GameObject SettingsPanel;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Inicia a corrotina que irá Chamar a nova cena é ativa a tela de loading
    public void StartGame()
    {
        StartCoroutine("LoadingSceneTimer");
        LoadingPanel.SetActive(true);

    }

    // Corrotina de Carregamento de cena, desativa a tela de loading de de 0.5 segundos.
    IEnumerator LoadingSceneTimer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(0.5f);
        LoadingPanel.SetActive(false);
    }

    public void OpenOrClosePanelSettings()
    {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
    }
}
