using StuMS.Entity;
using System.Text;

namespace StuMSGUI.Util
{
    public static class ScoreUtil
    {
        public static string GenerateScoreString(List<Score> scores)
        {
            if (scores.Count == 0)
            {
                return "No score found";
            }

            StringBuilder sb = new StringBuilder();
            foreach (Score score in scores)
            {
                sb.Append($"{score.Course.Name} : {score.CourseScore}\n");
            }
            return sb.ToString();
        }
    }
}
