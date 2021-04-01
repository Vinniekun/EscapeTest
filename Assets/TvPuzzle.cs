using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TvPuzzle : MonoBehaviour {

    [SerializeField] public List<float> pipeRotations;
    [SerializeField] public List<float> linePipe;
    [SerializeField] public List<float> curvePipe;
    public GameObject complete;
    public GameObject solveButton;
    public GameObject exitButton;

    private void Start()
    {
        pipeRotations = new List<float>();
        linePipe = new List<float>();
        curvePipe = new List<float>();

    }

    public void RotatePipe(RectTransform rect)
    {
        rect.Rotate(new Vector3(0f, 0f, 90f));
    }

    public void ExitScene()
    {
        pipeRotations.Clear();
        linePipe.Clear();
        curvePipe.Clear();
        Cursor.lockState = CursorLockMode.Locked;
        Inventory.Instance.ChangeScene(true);
        Inventory.Instance.player.SetActive(true);
        SceneManager.UnloadSceneAsync("TVPuzzle");
    }

    private void GetAllPipesRotations()
    {
        foreach (var item in gameObject.GetComponentsInChildren<RectTransform>())
        {
            pipeRotations.Add(item.rotation.eulerAngles.z);
        }
    }

    public void SolvePuzzle()
    {
        GetAllPipesRotations();

        linePipe.Add(pipeRotations[1]);
        linePipe.Add(pipeRotations[2]);
        curvePipe.Add(pipeRotations[3]);
        linePipe.Add(pipeRotations[4]);
        curvePipe.Add(pipeRotations[5]);
        linePipe.Add(pipeRotations[6]);
        linePipe.Add(pipeRotations[7]);
        curvePipe.Add(pipeRotations[8]);
        linePipe.Add(pipeRotations[9]);
        linePipe.Add(pipeRotations[10]);
        curvePipe.Add(pipeRotations[11]);
        curvePipe.Add(pipeRotations[12]);
        curvePipe.Add(pipeRotations[13]);
        curvePipe.Add(pipeRotations[14]);
        linePipe.Add(pipeRotations[15]);
        linePipe.Add(pipeRotations[16]);
        curvePipe.Add(pipeRotations[17]);
        linePipe.Add(pipeRotations[18]);
        curvePipe.Add(pipeRotations[19]);
        linePipe.Add(pipeRotations[20]);
        linePipe.Add(pipeRotations[21]);
        curvePipe.Add(pipeRotations[22]);
        curvePipe.Add(pipeRotations[23]);
        curvePipe.Add(pipeRotations[24]);
        linePipe.Add(pipeRotations[25]);

        for (int i = 0; i < linePipe.Count; i++)
        {
            if (linePipe[i] == 270)
            {
                linePipe[i] = 90;
            }
            if (linePipe[i] == 180)
            {
                linePipe[i] = 0;
            }
            
        }

        //Check Correct ones
        if (linePipe[0] == 90 && linePipe[0] == linePipe[2] && linePipe[2] == linePipe[4] && linePipe[4] == linePipe[5]
            && linePipe[5] == linePipe[6] && linePipe[6] == linePipe[8] && linePipe[9] == linePipe[10]
            && linePipe[10] == linePipe[11] && linePipe[11] == linePipe[12] && linePipe[11] == linePipe[7])
        {
            if (linePipe[1] == 0 && linePipe[1] == linePipe[3])
            {
                if ((curvePipe[0] == 0 && curvePipe[0] == curvePipe[3] && curvePipe[3] == curvePipe[11])
                    && (curvePipe[1] == 180 && curvePipe[1] == curvePipe[4] && curvePipe[4] == curvePipe[8])
                    && (curvePipe[2] == 270 && curvePipe[2] == curvePipe[7] && curvePipe[7] == curvePipe[10]) 
                    && (curvePipe[5] == 90 && curvePipe[5] == curvePipe[6] && curvePipe[6] == curvePipe[9]) )
                {
                    exitButton.SetActive(false);
                    solveButton.SetActive(false);
                    complete.SetActive(true);
                    StartCoroutine(ExitingCompleteScene());
                    
                }
            }
        }
        pipeRotations.Clear();
        linePipe.Clear();
        curvePipe.Clear();
    }

    private IEnumerator ExitingCompleteScene()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Inventory.Instance.tvPuzzle = true;
        yield return new WaitForSecondsRealtime(3f);
        Inventory.Instance.ChangeScene(true);
        Inventory.Instance.player.SetActive(true);
        SceneManager.UnloadSceneAsync("TVPuzzle");
    }
}
