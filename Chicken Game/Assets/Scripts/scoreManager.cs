using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour {
	
public static int score;
public Text winText;
public int winScore;
public Text text;

void Awake(){
    Time.timeScale = 1;
}
void Start () {
winText.GetComponent<Text>().enabled = false;
text = GetComponent<Text>();
score = 0;

}
void Update () {
if(score < 0)
score = 0;

text.text =" " + score;

if(score >= winScore){
winText.GetComponent<Text>().enabled = true;
print("win score reached" + score);
Time.timeScale = 0;
}

if(Input.GetKeyDown(KeyCode.Escape)){
    SceneManager.LoadScene(0);
}
}
public static void Addpoints(int pointsToAdd){
score += pointsToAdd;
}
public void Reset(){
score=0;
}

}
	

