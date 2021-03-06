﻿using UnityEngine;

public class MultiCompile : MonoBehaviour
{
    private void OnGUI()
    {
        KeywordToggleGUI("RED");
        KeywordToggleGUI("GREEN");
        KeywordToggleGUI("BLUE");
    }

    private void KeywordToggleGUI(string keyword)
    {
        bool enabled = GUILayout.Toggle(Shader.IsKeywordEnabled(keyword), keyword);

        if (enabled)
        {
            Shader.EnableKeyword(keyword);
        }
        else
        {
            Shader.DisableKeyword(keyword);
        }
    }
}