using System;

namespace BlazorWASM.Models
{
    public class LanguageModel
    {
        public LanguageModel(string language, int stargazersCount)
        {
            this.language = language;
            this.currentCount = 1;
            this.stargazersCount = stargazersCount;
        }

        public string language { get; set; }
        public int currentCount { get; set; }
        public int stargazersCount { get; set; }

        public void AddOneToCount()
        {
            currentCount++;
        }

        public void AddStarCount(int num)
        {
            stargazersCount = stargazersCount + num;
        }
    }
}