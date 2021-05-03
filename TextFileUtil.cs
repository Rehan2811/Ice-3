using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDoApp
{
    class TextFileUtil
    {
        public static List<ToDo> readFromFile()
        {
            List<ToDo> todoListTemp = new List<ToDo>();
            try
            {
                //Pass the file name to the StreamReader constructor
                using (StreamReader reader = new StreamReader("ToDoList.txt"))
                {
                    //Read the first line of text
                    string line;
                    //Continue to read until you reach end of file
                    while ((line = reader.ReadLine()) != null)
                    {
                        //each line: description#date#priority
                        string[] lineParts = line.Split('#');
                        string description = lineParts[0];

                        //date: year/month/day
                        string[] longDate = lineParts[1].Split('/');
                        int year = Convert.ToInt32(longDate[0]);
                        int month = Convert.ToInt32(longDate[1]);
                        int day = Convert.ToInt32(longDate[2].Substring(0, 2));
                        DateTime date = new DateTime(year, month, day);

                        ToDo.Levels level;
                        switch (lineParts[2])
                        {
                            case "Low":
                                level = ToDo.Levels.Low;
                                break;
                            case "Medium":
                                level = ToDo.Levels.Medium;
                                break;
                            default:
                                level = ToDo.Levels.High;
                                break;
                        }

                        ToDo item = new ToDo(description, date, level);
                        todoListTemp.Add(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return todoListTemp;
        }
    }
}