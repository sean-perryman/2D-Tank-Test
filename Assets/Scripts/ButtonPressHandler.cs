using UnityEngine;
//using UnityEditor;
using System.Collections;

public class ButtonPressHandler : MonoBehaviour {

    public void btn_QuitGame() {
        Application.Quit();
    }

    public void btn_RestartGame() {
        //EditorUtility.DisplayDialog("Clicked", "Restart Game", "Ok");
    }

    public void btn_Credits() {
        //EditorUtility.DisplayDialog("Clicked", "Credits", "Ok");
    }

    public void btn_Instructions() {
        //EditorUtility.DisplayDialog("Clicked", "Instructions", "Ok");
    }

    public void btn_StartGame() {
        //EditorUtility.DisplayDialog("Clicked", "Start Game", "Ok");
    }
}
