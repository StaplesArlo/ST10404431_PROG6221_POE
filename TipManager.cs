using System;
using System.Collections.Generic;
using System.IO;

public class TipManager
{
    private List<string> tips;
    private readonly string path = "C:/Users/Arlo/OneDrive - ADvTECH Ltd/Documents/PROG_6221/Practice_PROG/files/";


    public TipManager(string file)
    {
        string filePath = Path.Combine(path, file);
        tips = new List<string>();
        LoadTips(filePath);
    }
   
    private void LoadTips(string filePath)
    {
        if (File.Exists(filePath))
        {
            tips = new List<string>(File.ReadAllLines(filePath));
        }
        else
        {
            Console.WriteLine("Tip file not found.");
        }
    }

    public string GetRandomTip()
    {
        if (tips.Count == 0) return "No tips available.";
        Random rand = new Random();
        return tips[rand.Next(tips.Count)];
    }
}