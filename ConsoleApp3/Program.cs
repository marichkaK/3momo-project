using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp3
{
    class Program
    {
        static List<Triangle> ReadData(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                JObject jsonData = JObject.Parse(sr.ReadToEnd());
                JArray trianglesData = (JArray)jsonData["Triangles"];
                Triangle[] triangles = new Triangle[trianglesData.Count];
                for (int i = 0; i < trianglesData.Count; i++)
                {
                    triangles[i] = new Triangle(new ColorSide[] {
                                                new ColorSide(new Color(trianglesData[i]["1sideColor"].ToString()), Int32.Parse(trianglesData[i]["1sideLength"].ToString())),
                                                new ColorSide(new Color(trianglesData[i]["2sideColor"].ToString()), Int32.Parse(trianglesData[i]["2sideLength"].ToString())),
                                                new ColorSide(new Color(trianglesData[i]["3sideColor"].ToString()), Int32.Parse(trianglesData[i]["3sideLength"].ToString()))});
                }
                return triangles.ToList();
            }
        }
        static List<Triangle> SortByPerimeter(List<Triangle> _triangles)
        {
            List<Triangle> triangles = _triangles;
            triangles = triangles.OrderBy(x => x.GetPeritemer()).ToList();
            return triangles;
        }
        static void WriteSortedData(List<Triangle> _triangles, string path)
        {
            string blockToWrite = "{\"Triangles\":[";
            foreach (var el in _triangles)
            {
                blockToWrite += el.GetJsonBlock();
            }
            blockToWrite += "]}";
            blockToWrite = blockToWrite.Remove(blockToWrite.LastIndexOf(","), 1);
            blockToWrite = JObject.Parse(blockToWrite).ToString();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(blockToWrite);
            }
        }
        static Dictionary<string, int> GetTrianglesDictionary(List<Triangle> _triangles)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var el in _triangles)
            {
                if (el.triangle[0].getColor().getColor() == el.triangle[1].getColor().getColor() && el.triangle[0].getColor().getColor() == el.triangle[2].getColor().getColor())
                {
                    if (dictionary.ContainsKey(el.triangle[0].getColor().getColor()))
                    {
                        dictionary[el.triangle[0].getColor().getColor()] += 1;
                    }
                    else
                    {
                        dictionary.Add(el.triangle[0].getColor().getColor(), 1);
                    }
                }
            }
            return dictionary;
        }
        static List<Triangle> RePaintTriagles(List<Triangle> _triangles)
        {
            List<Triangle> triangles = _triangles.Where(x => x.triangle[0].getColor().getColor() == x.triangle[1].getColor().getColor() && x.triangle[0].getColor().getColor() != x.triangle[2].getColor().getColor() ||
                                                             x.triangle[0].getColor().getColor() == x.triangle[2].getColor().getColor() && x.triangle[0].getColor().getColor() != x.triangle[1].getColor().getColor() ||
                                                             x.triangle[1].getColor().getColor() == x.triangle[2].getColor().getColor() && x.triangle[1].getColor().getColor() != x.triangle[0].getColor().getColor()).ToList();
            foreach (var x in triangles)
            {
                if (x.triangle[0].getColor().getColor() == x.triangle[1].getColor().getColor())
                {
                    x.triangle[2].getColor().color = x.triangle[0].getColor().getColor();
                }
                else if (x.triangle[0].getColor().getColor() == x.triangle[2].getColor().getColor())
                {
                    x.triangle[1].getColor().color = x.triangle[0].getColor().getColor();
                }
                else
                {
                    x.triangle[0].getColor().color = x.triangle[1].getColor().getColor();
                }
            }
            return triangles;
        }
        static void Main(string[] args)
        {
         
            
           
          
            Console.Read();

        }
    }
}
