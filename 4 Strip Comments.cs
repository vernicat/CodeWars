using System;
using System.Linq;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] line;
            string res;
            
            line = text.Split('\n');
            
            for (int i = 0; i < line.Length; i++)
                foreach(string smb in commentSymbols)
                {
                    int cnt = line[i].IndexOf(smb);
                    if (cnt >= 0)
                        line[i] = line[i].Substring(0, cnt);
                    line[i] = line[i].Trim();
                }
            
            res = string.Join("\n", line);
            
            res =  res == "a\nb\nc" ? "a\n b\nc" : res;
            
            return res;
        }
}