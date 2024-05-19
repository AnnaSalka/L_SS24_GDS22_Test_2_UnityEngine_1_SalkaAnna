using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private DoneScreenScript _doneScreenScript;
    private void Start()
    {
        _doneScreenScript = gameObject.GetComponent<DoneScreenScript>();
    }
    public void Scene_ApplePuzzle()
    {
        _doneScreenScript.isDoneScreen = false;
        SceneManager.LoadSceneAsync(0);
    }

    public void Scene_Trump()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
